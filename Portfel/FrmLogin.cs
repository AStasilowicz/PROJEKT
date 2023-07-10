using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Portfel.Class;
using Org.BouncyCastle.Asn1.X509;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.Win32;
using System.Configuration;

namespace Portfel
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(13, 17, 23);
            PanelLogin.BackColor = Color.FromArgb(22, 27, 34);
            TextBoxLogin.BackColor = Color.FromArgb(13, 17, 23);
            TextBoxPassword.BackColor = Color.FromArgb(13, 17, 23);
            LabelLogin.ForeColor = Color.FromArgb(201, 209, 217);
            LabelPassword.ForeColor = Color.FromArgb(201, 209, 217);
            ButtonLogin.BackColor = Color.FromArgb(46, 160, 67);
            ButtonRegister.BackColor = Color.FromArgb(45, 51, 59);
            ButtonLogin.ForeColor = Color.FromArgb(201, 209, 217);
            ButtonRegister.ForeColor = Color.FromArgb(201, 209, 217);
            LabeltTitle.ForeColor = Color.FromArgb(201, 209, 217);
            ButtonRegister.FlatAppearance.BorderColor = Color.FromArgb(201, 209, 217);
            TextBoxLogin.ForeColor = Color.FromArgb(201, 209, 217);
            TextBoxPassword.ForeColor = Color.FromArgb(201, 209, 217);
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            // Weryfikacja logowania 
            if ((String.IsNullOrEmpty(TextBoxLogin.Text)) || (String.IsNullOrEmpty(TextBoxPassword.Text)))
            {
                Timmer.Enabled = true;
                Timmer.Start();
                LabelPassCorrect.Visible = true;
                LabelPassCorrect.Text = "Missing Username or Password";
                LabelPassCorrect.ForeColor = Color.FromArgb(187, 64, 60);
            }
            else if ((TextBoxLogin.Text.Length > 32) || (TextBoxPassword.Text.Length > 32))
            {
                Timmer.Enabled = true;
                Timmer.Start();
                LabelPassCorrect.Visible = true;
                LabelPassCorrect.Text = "Username or Password is too long\nThe maximum size is 32 characters";
                LabelPassCorrect.ForeColor = Color.FromArgb(187, 64, 60);
            }
            else
            {
                ClassLogin classLogin = new ClassLogin();
                string answare = classLogin.LoginUser(TextBoxLogin.Text, TextBoxPassword.Text);
                string[] resoult = answare.Split(';');
                if (resoult[0] == "git")
                {
                    this.Hide();
                    FrmMain loginwindow = new FrmMain(resoult[1], resoult[2]);
                    loginwindow.Closed += new EventHandler(ExitApp);
                    loginwindow.ShowDialog();
                }
                else
                {
                    Timmer.Enabled = true;
                    Timmer.Start();
                    LabelPassCorrect.Visible = true;
                    LabelPassCorrect.Text = "User not exsist";
                    LabelPassCorrect.ForeColor = Color.FromArgb(187, 64, 60);
                }
            }
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {

            // Weryfikacja Rejestracji
            if ((String.IsNullOrEmpty(TextBoxLogin.Text)) || (String.IsNullOrEmpty(TextBoxPassword.Text)))
            {
                Timmer.Enabled = true;
                Timmer.Start();
                LabelPassCorrect.Visible = true;
                LabelPassCorrect.Text = "Missing Username or Password";
                LabelPassCorrect.ForeColor = Color.FromArgb(187, 64, 60);
            }
            else if ((TextBoxLogin.Text.Length > 32) || (TextBoxPassword.Text.Length > 32))
            {
                Timmer.Enabled = true;
                Timmer.Start();
                LabelPassCorrect.Visible = true;
                LabelPassCorrect.Text = "Username or Password is too long\nThe maximum size is 32 characters";
                LabelPassCorrect.ForeColor = Color.FromArgb(187, 64, 60);
            }
            else
            {
                ClassRegister classRegister = new ClassRegister();
                string answare = classRegister.Register(TextBoxLogin.Text, TextBoxPassword.Text);
                if (answare == "Exsist")
                {
                    Timmer.Enabled = true;
                    Timmer.Start();
                    LabelPassCorrect.Visible = true;
                    LabelPassCorrect.Text = "User Exsist";
                    LabelPassCorrect.ForeColor = Color.FromArgb(187, 64, 60);
                }
                else
                {
                    Timmer.Enabled = true;
                    Timmer.Start();
                    LabelPassCorrect.Visible = true;
                    LabelPassCorrect.Text = "User succesfully registered";
                    LabelPassCorrect.ForeColor = Color.FromArgb(46, 160, 67);
                }
            }
        }

        private void ExitApp(object sender, EventArgs e)
        {
            // Wyłączenie aplikacji
            Application.Exit();
        }

        private void Timmer_Tick(object sender, EventArgs e)
        {
            // Zaprzestanie wyświetlania label
            LabelPassCorrect.Visible = false;
        }

        private void TextBoxLogin_KeyDown(object sender, KeyEventArgs e)
        {
            // utworzenie skrutu klawiszowego
            if(e.KeyCode == Keys.Enter)
            {
                ButtonLogin_Click(null,null);
            }
        }
    }
}
