using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Portfel.Class;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Portfel.UserControls
{
    public partial class UserControlProceedsList : UserControl
    {
        string userId = "";
        string userName = ""; double value = 0;
        string limitmaxrecord = "100";
        string sql = "";
        List<ClassCategory> classCategories = new List<ClassCategory>();

        public UserControlProceedsList(string id, string username)
        {
            InitializeComponent();
            DateTimePickerFrom.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            userId = id;
            userName = username;
            ListViewExpensesList.BackColor = Color.FromArgb(54, 57, 63);
            PanelAdd.BackColor = Color.FromArgb(45, 51, 59);
            NumericValue.BackColor = Color.FromArgb(54, 57, 63);
            ButtonSerch.BackColor = Color.FromArgb(46, 160, 67);
            ButtonInsertTransaction.BackColor = Color.Red;
            Viev();
        }

        public void Viev()
        {
            var appSettings = ConfigurationManager.AppSettings;
            string myConnectionString = appSettings["ConnectionStringDatabaseMySql"];
            try
            {
                limitmaxrecord = NumericValue.Value.ToString();
                ListViewExpensesList.Items.Clear();
                SetSQL();


                using (MySqlConnection connection = new MySqlConnection(myConnectionString))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.CommandTimeout = 60;
                    MySqlDataReader reader;
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string iduser = reader.GetString(0);
                            string[] row = { reader.GetString(1) + " zł", reader.GetString(2), reader.GetString(3), reader.GetString(4) };
                            ListViewExpensesList.Items.Add(iduser).SubItems.AddRange(row);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SetSQL()
        {
            string yearfrom = DateTimePickerFrom.Value.Year.ToString();
            string monthfrom = DateTimePickerFrom.Value.Month.ToString();
            string dayfrom = DateTimePickerFrom.Value.Day.ToString();

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(yearfrom);
            stringBuilder.Append("-");
            stringBuilder.Append(monthfrom);
            stringBuilder.Append("-");
            stringBuilder.Append(dayfrom);
            string from = stringBuilder.ToString();

            stringBuilder.Clear();

            string yearto = dateTimePicker2.Value.Year.ToString();
            string monthto = dateTimePicker2.Value.Month.ToString();
            string dayto = dateTimePicker2.Value.Day.ToString();

            stringBuilder.Append(yearto);
            stringBuilder.Append("-");
            stringBuilder.Append(monthto);
            stringBuilder.Append("-");
            stringBuilder.Append(dayto);
            string to = stringBuilder.ToString();
            stringBuilder.Clear();

            sql = "SELECT u.Id, u.Amount, c.Type, u.Comment, u.CreationTime  " +
                "FROM usersdata u, category c " +
                "WHERE c.ID='-15' and u.UserID='" + userId + "' and u.Amount >= '0' and u.CreationTime BETWEEN  '" + from + " 00:00:00' and  '" + to + " 23:59:59'  " +
                "Order By u.CreationTime DESC Limit " + limitmaxrecord;
        }

        private void ButtonSerch_Click(object sender, EventArgs e)
        {
            Viev();
        }

        private void ButtonInsertTransaction_Click(object sender, EventArgs e)
        {
            var appSettings = ConfigurationManager.AppSettings;
            string myConnectionString = appSettings["ConnectionStringDatabaseMySql"];
            if ((!String.IsNullOrEmpty(TextBoxAmount.Text)) || (!String.IsNullOrEmpty(TextBoxComment.Text)))
            {
                try
                {
                    string sql = "INSERT INTO `usersdata` (`UserID`, `CategoryID`, `Amount`, `Comment`) " +
                            "VALUES ('" + userId + "', '-15', '" + Math.Abs(value).ToString("F2").Replace(",", ".") + "', '" + TextBoxComment.Text + "')";
                    using (MySqlConnection connection = new MySqlConnection(myConnectionString))
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(sql, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                    TextBoxComment.Text = "";
                    TextBoxAmount.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            Viev();
        }

        private void userTextChanged(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(TextBoxAmount.Text)) || (String.IsNullOrEmpty(TextBoxComment.Text)))
            {
                ButtonInsertTransaction.Enabled = false;
                ButtonInsertTransaction.BackColor = Color.Red;
            }
            else
            {
                ButtonInsertTransaction.Enabled = true;
                ButtonInsertTransaction.BackColor = Color.FromArgb(46, 160, 67);
            }
            double.TryParse(TextBoxAmount.Text.Replace(".", ","), out value);
        }

        private void DateTimePickerFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Viev();
        }

        private void TextBoxComment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ButtonInsertTransaction_Click(null, null);
        }
    }
}
