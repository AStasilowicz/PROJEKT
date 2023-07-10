using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Portfel.Class;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;

namespace Portfel.UserControls
{
    public partial class UserControlExpensesList : UserControl
    {
        string userId = "";
        string userName = "";
        double value = 0;
        string limitmaxrecord = "100";
        string sql = "";
        List<ClassCategory> classCategories = new List<ClassCategory>(); // Utworzenie listy dla klasy ClassCategory

        public UserControlExpensesList(string id, string username)
        {
            //Inicjalizacja usercontrol
            InitializeComponent();
            //Wstawienie dzisiejszej daty do pól daty
            DateTimePickerFrom.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            userId = id; // Zapisanie ID id userid
            userName = username; // zapisanie username do username
            // Ustawienie stylizacji aplikacji
            ListViewExpensesList.BackColor = Color.FromArgb(54, 57, 63); 
            PanelAdd.BackColor = Color.FromArgb(45, 51, 59);
            NumericValue.BackColor = Color.FromArgb(54, 57, 63);
            ButtonSerch.BackColor = Color.FromArgb(46, 160, 67);
            ButtonInsertTransaction.BackColor = Color.Red;
            // Wczytanie listy kategorii do pola combobox
            FileCategoryList();
            // Wczytanie danych z tabeli
            Viev();
        }

        public void Viev()
        {
            // Wczytywanie danych z bazy danych do tabeli
            var appSettings = ConfigurationManager.AppSettings; // pobranie ranych konfiguracyjnych
            string myConnectionString = appSettings["ConnectionStringDatabaseMySql"]; // pobranie konkretnego klucza konfiguracyjnego
            try
            {
                // Rozpoczęcie próby
                limitmaxrecord = NumericValue.Value.ToString(); // ustawienie maksymalnej ilości wierszy // Zabezpieczenie przed wczytywaniem niebotycznie wielkich danych
                ListViewExpensesList.Items.Clear(); // Wyczyszczenie tabeli
                SetSQL(); // Utworzenie zapytania SQL


                using (MySqlConnection connection = new MySqlConnection(myConnectionString)) // Wykożystując using generujemy Połączenie
                {
                    connection.Open(); // Otwarcie połączenia z bazą danych
                    MySqlCommand command = new MySqlCommand(sql, connection); // generowanie komendy
                    command.CommandTimeout = 60; // Zastosowanie timeouta
                    MySqlDataReader reader = command.ExecuteReader(); // Ekzekucja zapytania i zapisanie do czytnika
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string iduser = reader.GetString(0);
                            string[] row = { reader.GetString(1) + " zł", reader.GetString(2), reader.GetString(3), reader.GetString(4) };
                            ListViewExpensesList.Items.Add(iduser).SubItems.AddRange(row); // Zapisanie wyniku zapytania do zmiennej
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

            sql = "SELECT u.Id, u.Amount, c.Type, u.Comment, u.CreationTime " +
                "FROM usersdata u JOIN category c ON u.CategoryID = c.ID " +
                "WHERE (u.UserID='"+userId+"' or u.CategoryID='0') and u.Amount < '0' and u.CreationTime BETWEEN '"+ from + " 00:00:00' and '"+ to + " 23:59:59' " +
                "Order By u.CreationTime DESC Limit " + limitmaxrecord;
        }

        private void ButtonSerch_Click(object sender, EventArgs e)
        {
            Viev();
        }

        public void FileCategoryList()
        {
            var appSettings = ConfigurationManager.AppSettings;
            string myConnectionString = appSettings["ConnectionStringDatabaseMySql"];
            ComboBoxCategory.Items.Clear();
            classCategories.Clear();

            string query = "SELECT * FROM category WHERE UserID=" + userId + " OR UserID = 0 Group by Type";

            MySqlConnection databaseConnection = new MySqlConnection(myConnectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    classCategories.Add(new ClassCategory(reader.GetString(0), reader.GetString(1), reader.GetString(2)));
                }
                foreach (var item in classCategories)
                {
                    ComboBoxCategory.Items.Add(item.Type);
                    ComboBoxCategory.SelectedIndex = 0;
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonInsertTransaction_Click(object sender, EventArgs e)
        {
            var appSettings = ConfigurationManager.AppSettings;
            string myConnectionString = appSettings["ConnectionStringDatabaseMySql"];
            if ((!String.IsNullOrEmpty(TextBoxAmount.Text)) || (!String.IsNullOrEmpty(TextBoxComment.Text)))
            {


                string categoryID = "";
                string selected = ComboBoxCategory.Text;
                

                try
                {

                    try
                    {
                        string query = "SELECT ID FROM category WHERE (UserID=" + userId + " OR UserID = 0) and Type='" + selected + "' limit 1";

                        using (MySqlConnection connection = new MySqlConnection(myConnectionString))
                        {
                            connection.Open();
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.CommandTimeout = 60;
                                MySqlDataReader mySqlDataReader = command.ExecuteReader();
                                while (mySqlDataReader.Read())
                                {
                                    categoryID = mySqlDataReader.GetString(0);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    string sql = "INSERT INTO `usersdata` (`UserID`, `CategoryID`, `Amount`, `Comment`) " +
                            "VALUES ('" + userId + "', '" + categoryID + "', '-" + Math.Abs(value).ToString("F2").Replace(",", ".") + "', '" + TextBoxComment.Text + "')";
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
            if(e.KeyCode == Keys.Enter)
            {
                Viev();
            }
        }

        private void TextBoxComment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonInsertTransaction_Click(null,null);
            }
        }
    }
}
