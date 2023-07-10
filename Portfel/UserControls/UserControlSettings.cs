using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
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
    public partial class UserControlSettings : UserControl
    {
        string userId = "";
        string userName = "";
        int Flags = 0;
        List<ClassCategory> classCategories = new List<ClassCategory>();

        public UserControlSettings(string id, string username)
        {
            // InicjalizacjaUser controlsa
            InitializeComponent();

            userId = id;
            userName = username;

            LabelAddTransaction.ForeColor = Color.FromArgb(201, 209, 217);

            PanelAddCategory.BackColor = Color.FromArgb(54, 57, 63);
            listView.BackColor = Color.FromArgb(54, 57, 63);
            listView.ForeColor = Color.FromArgb(201, 209, 217);

            ButtonAddType.BackColor = Color.FromArgb(46, 160, 67);
            ButtonAccept.BackColor = Color.FromArgb(46, 160, 67);
            ButtonAddType.ForeColor = Color.FromArgb(201, 209, 217);

            PanelChangeUserdata.BackColor = Color.FromArgb(45, 51, 59);
            PanelAddCategory.BackColor = Color.FromArgb(45, 51, 59);

            listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            FileCategoryList();
            RadioButtonPassword_CheckedChanged(null, null);
        }

        public void FileCategoryList()
        {
            // Wypisanie kategorii
            var appSettings = ConfigurationManager.AppSettings;
            string myConnectionString = appSettings["ConnectionStringDatabaseMySql"];
            listView.Items.Clear();
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
                    listView.Items.Add(item.Type);
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonAddType_Click(object sender, EventArgs e)
        {
            // Dodanie kategorii do listy dla konkretnego urzytkownika
            var appSettings = ConfigurationManager.AppSettings;
            string myConnectionString = appSettings["ConnectionStringDatabaseMySql"];
            if (String.IsNullOrEmpty(TextBoxTyp.Text))
            {
                Timmer.Enabled = true;
                LabelWrongData.Visible = true;
                LabelWrongData.Text = "Missing type";
                LabelWrongData.ForeColor = Color.FromArgb(187, 64, 60);
            }
            else if (TextBoxTyp.Text.Length > 32)
            {
                Timmer.Enabled = true;
                LabelWrongData.Visible = true;
                LabelWrongData.Text = "Type is too long";
                LabelWrongData.ForeColor = Color.FromArgb(187, 64, 60);
            }
            else if ((TextBoxTyp.Text.Contains("Delete")) || (TextBoxTyp.Text.Contains("Insert")) || (TextBoxTyp.Text.Contains("Drop")))
            {
                Timmer.Enabled = true;
                LabelWrongData.Visible = true;
                LabelWrongData.Text = "Bad words in text";
                LabelWrongData.ForeColor = Color.FromArgb(187, 64, 60);
            }
            else
            {
                foreach (var item in classCategories)
                {
                    if (item.Type == TextBoxTyp.Text)
                    {
                        Flags = 1;
                        Timmer.Enabled = true;
                        LabelWrongData.Visible = true;
                        LabelWrongData.Text = "Alredy exists";
                        LabelWrongData.ForeColor = Color.FromArgb(187, 64, 60);
                    }
                }
                if (Flags == 0)
                {
                    string query = "INSERT INTO `category` (`UserID`, `Type`) VALUES ('" + userId + "', '" + TextBoxTyp.Text + "')";
                    try
                    {
                        using (MySqlConnection databaseConnection = new MySqlConnection(myConnectionString))
                        {
                            databaseConnection.Open(); 
                            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                            commandDatabase.CommandTimeout = 60;
                            int AffectsRow = commandDatabase.ExecuteNonQuery();
                            if (AffectsRow > 0)
                            {
                                Timmer.Enabled = true;
                                LabelWrongData.Visible = true;
                                LabelWrongData.Text = "Category succesfuly added";
                                LabelWrongData.ForeColor = Color.FromArgb(46, 160, 67);
                            }
                            else
                            {
                                Timmer.Enabled = true;
                                LabelError.Visible = true;
                                LabelError.Text = "No changes were made";
                                LabelError.ForeColor = Color.Red;
                            }
                        }
                    }
                    catch
                    {
                        Timmer.Enabled = true;
                        LabelWrongData.Visible = true;
                        LabelWrongData.Text = "No Connection";
                        LabelWrongData.ForeColor = Color.Red;
                    }
                }
                FileCategoryList();
                Flags = 0;
                TextBoxTyp.Clear();
            }

        }

        private void Timmer_Tick_1(object sender, EventArgs e)
        {
            // Wyłączenie wyświetlania napisu
            LabelWrongData.Visible = false;
        }

        private void ButtonAccept_Click(object sender, EventArgs e)
        {
            // Zmiana hasła lub loginu
            ClassPassword classPassword = new ClassPassword();
            ClassUpdateUser classUpdateUser = new ClassUpdateUser();
            string CurrentPassword = classUpdateUser.GetPasswordFromDatabase(userId);
            var appSettings = ConfigurationManager.AppSettings;
            string myConnectionString = appSettings["ConnectionStringDatabaseMySql"];
            string sql = "";
            if (RadioButtonPassword.Checked)
            {
                if (!String.IsNullOrEmpty(TextBoxPassword.Text))
                {
                    if (!String.IsNullOrEmpty(TextBoxNewPassword.Text))
                    {
                        if (!String.IsNullOrEmpty(TextBoxNewPassword2.Text))
                        {
                            if (TextBoxNewPassword2.Text == TextBoxNewPassword.Text)
                            {
                                if (CurrentPassword == classPassword.HashPassword(TextBoxPassword.Text))
                                    sql = "UPDATE users SET Password='" + classPassword.HashPassword(TextBoxNewPassword.Text) + "' WHERE ID='" + userId + "' and Username='" + userName + "' and Password='" + classPassword.HashPassword(TextBoxPassword.Text) + "'";
                            }
                            else
                            {
                                timer1.Enabled = true;
                                LabelError.Visible = true;
                                LabelError.Text = "New Password No Mach";
                                LabelError.ForeColor = Color.Red;
                            }
                        }
                        else
                        {
                            timer1.Enabled = true;
                            LabelError.Visible = true;
                            LabelError.Text = "Mising New Password";
                            LabelError.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        timer1.Enabled = true;
                        LabelError.Visible = true;
                        LabelError.Text = "Mising New Password";
                        LabelError.ForeColor = Color.Red;
                    }
                }
                else
                {
                    timer1.Enabled = true;
                    LabelError.Visible = true;
                    LabelError.Text = "Mising Password";
                    LabelError.ForeColor = Color.Red;
                }
            }
            if (RadioButtonUsername.Checked)
            {
                if (!String.IsNullOrEmpty(TextBoxPassword.Text))
                {
                    if (!String.IsNullOrEmpty(TextBoxNewName.Text))
                    {
                        if((CurrentPassword == classPassword.HashPassword(TextBoxPassword.Text)))
                        sql = "UPDATE users SET Username='" + TextBoxNewName.Text + "' WHERE ID='" + userId + "' and Username='" + userName + "' and Password='" + classPassword.HashPassword(TextBoxPassword.Text) + "'";
                    }
                    else
                    {
                        timer1.Enabled = true;
                        LabelError.Visible = true;
                        LabelError.Text = "New Password No Mach";
                        LabelError.ForeColor = Color.Red;
                    }
                }
                else
                {
                    timer1.Enabled = true;
                    LabelError.Visible = true;
                    LabelError.Text = "Mising Password";
                    LabelError.ForeColor = Color.Red;
                }
            }
            try
            {
                using (MySqlConnection databaseConnection = new MySqlConnection(myConnectionString))
                {
                    databaseConnection.Open();
                    MySqlCommand command = new MySqlCommand(sql, databaseConnection);
                    command.CommandTimeout = 60;
                    int AffectsRow = command.ExecuteNonQuery();
                    if (AffectsRow > 0)
                    {
                        TextBoxNewName.Text = "";
                        TextBoxPassword.Text = "";
                        TextBoxNewPassword.Text = "";
                        TextBoxNewPassword2.Text = "";
                        timer1.Enabled = true;
                        LabelError.Visible = true;
                        LabelError.Text = "Succesfuly changed";
                        LabelError.ForeColor = Color.FromArgb(46, 160, 67);
                    }
                    else
                    {
                        timer1.Enabled = true;
                        LabelError.Visible = true;
                        LabelError.Text = "No changes were made";
                        LabelError.ForeColor = Color.Red;
                    }
                }
            }
            catch
            {
                timer1.Enabled = true;
                LabelError.Visible = true;
                LabelError.Text = "Error Connection";
                LabelError.ForeColor = Color.Red;
            }
        }

        private void RadioButtonPassword_CheckedChanged(object sender, EventArgs e)
        {
            //przełączenie kontroli w odpowiedni tryb dla odpowiedniego zadania
            if (RadioButtonPassword.Checked)
            {
                TextBoxNewName.Visible = false;
                LabelNewUsername.Visible = false;
                TextBoxNewPassword.Visible = true;
                LabelNewPassword.Visible = true;
                LabelNewPassword2.Visible = true;
                TextBoxNewPassword2.Visible = true;
            }
            if (RadioButtonUsername.Checked)
            {
                TextBoxNewName.Visible = true;
                LabelNewUsername.Visible = true;
                TextBoxNewPassword.Visible = false;
                LabelNewPassword.Visible = false;
                LabelNewPassword2.Visible = false;
                TextBoxNewPassword2.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Wykonywane kiedy timer wybije swój czas
            timer1.Enabled = false;
            LabelError.Visible = false;

            ClassUpdateUser classUpdateUser = new ClassUpdateUser();
            userName = classUpdateUser.GetUsernameFromDatabase(userId);
        }
    }
}
