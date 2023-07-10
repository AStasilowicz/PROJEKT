using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Portfel.Class;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Portfel.UserControls
{
    public partial class UserControlTransactionList : UserControl
    {
        string userId = "";
        string userName = "";

        public UserControlTransactionList(string id, string username)
        {
            InitializeComponent();
            userId = id;
            userName = username;
            ListViewTransaction.BackColor = Color.FromArgb(54, 57, 63);
            NumPanel.BackColor = Color.FromArgb(45, 51, 59);
            NumericValue.BackColor = Color.FromArgb(54, 57, 63);
            ButtonSerch.BackColor = Color.FromArgb(46, 160, 67);
            Viev();
        }

        public void Viev()
        {
            ListViewTransaction.Items.Clear();
            var appSettings = ConfigurationManager.AppSettings;
            string myConnectionString = appSettings["ConnectionStringDatabaseMySql"];
            try
            {
                using (MySqlConnection connection = new MySqlConnection(myConnectionString))
                {
                    connection.Open();
                    string sql = "SELECT u.Id, u.Amount, c.Type, u.Comment, u.CreationTime " +
                        "FROM usersdata u,category c  " +
                        "WHERE u.CategoryID=c.ID and u.UserID='" + userId + "' " +
                        "Order By u.CreationTime DESC Limit " + NumericValue.Value.ToString();
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.CommandTimeout = 60;
                    MySqlDataReader reader;
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        LabelNoData.Visible = false;
                        while (reader.Read())
                        {
                            string iduser = reader.GetString(0);
                            string[] row = { reader.GetString(1) + " zł", reader.GetString(2), reader.GetString(3), reader.GetString(4) };
                            ListViewTransaction.Items.Add(iduser).SubItems.AddRange(row);
                        }
                    }
                    else
                    {
                        LabelNoData.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonSerch_Click(object sender, EventArgs e)
        {
            Viev();
        }
    }
}
