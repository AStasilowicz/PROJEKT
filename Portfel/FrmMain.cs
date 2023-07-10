using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Portfel.Class;
using Portfel.UserControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Portfel
{
    public partial class FrmMain : Form
    {
        string username, id; // Utworzenie zmiennych UserID i UserName

        ClassCheckAccountSaldo classCheckAccountSaldo = new ClassCheckAccountSaldo(); // Wygenerowanie klasy sprawdzającej stan konta Globalnie żeby nie powtarzać lokalnie wiele razy

        public FrmMain(string ID, string USERNAME)
        {
            InitializeComponent(); // Inicjalizacja Okna
            InitializeColors(); // Wykonanie Designe
            id = ID; // Przypisanie zmiennej z poprzedniego Forma do obecnej zmiennej globalnej
            username = USERNAME;// Przypisanie zmiennej z poprzedniego Forma do obecnej zmiennej globalnej
            LabelUsername.Text = username; // Wpisanie Username do pola tekstowego
            if (id.Length == 1) ID = "000" + ID; // Wyrównanie ID wizualnie zeby wyglądało lepiej
            if (id.Length == 2) ID = "00" + ID; // Wyrównanie ID wizualnie zeby wyglądało lepiej
            if (id.Length == 3) ID = "0" + ID; // Wyrównanie ID wizualnie zeby wyglądało lepiej
            LabelUserID.Text = "#" + ID; // Zapisanie ID do pola tekstowego

            /*
             * Wywołanie UserControl w którym znajduje się Lista wszystkich transakcji
             * Przekazanie zmiennych typu UserID oraz Username do wykożystania w polu kontroli
             * Nadanie UserControl parametru Dock  Fill czyli wypełnienie całego obszaru
             */
            UserControlTransactionList ControlTransactionList = new UserControlTransactionList(id, USERNAME) { Dock = DockStyle.Fill };
            PanelContainer.Controls.Clear(); // Wyczyszczenie kontenera z UserControl
            PanelContainer.Controls.Add(ControlTransactionList); // Dodanie Pola kontroli do kontenera
            PanelContainer.Controls["UserControlTransactionList"].BringToFront(); // Wyciągnięcie UserControl na wierzch

            ButtonTransactionList.Focus(); // Skupienie uwagi aplikacji na 1 przycisku

            LabelSaldo.Text = classCheckAccountSaldo.CheckAccountSaldo(id); // Wywołanie sprawdzenia stanu konta 
            LabelUsername.Text = classCheckAccountSaldo.CheckUserName(id); // Wywołanie Aktualnej nazwy urzytkownika
        }

        public void InitializeColors() // Ustawienie kolorystyki aplikacji
        {
            PanelUser.BackColor = Color.FromArgb(22, 27, 34);
            PanelProfil.BackColor = Color.FromArgb(45, 51, 59);
            PanelContainer.BackColor = Color.FromArgb(54, 57, 63);

            LabelUsername.ForeColor = Color.FromArgb(201, 209, 217);
            LabelUserID.ForeColor = Color.FromArgb(201, 209, 217);

            LabelSaldo.ForeColor = Color.FromArgb(201, 209, 217);

            ButtonTransactionList.FlatAppearance.BorderColor = Color.FromArgb(201, 209, 217);
            ButtonProceedsList.FlatAppearance.BorderColor = Color.FromArgb(201, 209, 217);
            ButtonExpensesList.FlatAppearance.BorderColor = Color.FromArgb(201, 209, 217);

            ButtonTransactionList.BackColor = Color.Orange;
            ButtonProceedsList.BackColor = Color.FromArgb(45, 51, 59);
            ButtonExpensesList.BackColor = Color.FromArgb(45, 51, 59);

            ButtonTransactionList.ForeColor = Color.Black;
            ButtonProceedsList.ForeColor = Color.FromArgb(201, 209, 217);
            ButtonExpensesList.ForeColor = Color.FromArgb(201, 209, 217);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No; // Zwrócenie dialogResoult NO
            this.Close(); // Wyłączenie okna
        }

        private void ButtonTransactionList_Click(object sender, EventArgs e)
        {
            ButtonTransactionList.BackColor = Color.Orange;
            ButtonTransactionList.ForeColor = Color.Black;
            ButtonProceedsList.BackColor = Color.FromArgb(45, 51, 59);
            ButtonExpensesList.BackColor = Color.FromArgb(45, 51, 59);

            UserControlTransactionList ControlTransactionList = new UserControlTransactionList(id, username) { Dock = DockStyle.Fill }; // WYygenerowanie usercontrol i dodanie stylu dock na fill czyli wypełnienie okna panelcatalog
            // Wygenerowanie UserControl do wyświetlenia TABELI Z TRANSAKCJAMI
            PanelContainer.Controls.Clear(); // Wyczyszczenie Panelu kontenera
            PanelContainer.Controls.Add(ControlTransactionList); // dodanie kontroli do panelu
            PanelContainer.Controls["UserControlTransactionList"].BringToFront(); // Wyciągnięcie okna na przód aplikacji
        }

        private void ButtonProceedsList_Click(object sender, EventArgs e)
        {
            ButtonTransactionList.BackColor = Color.FromArgb(45, 51, 59);
            ButtonProceedsList.BackColor = Color.Orange;
            ButtonProceedsList.ForeColor = Color.Black;
            ButtonExpensesList.BackColor = Color.FromArgb(45, 51, 59);
            UserControlProceedsList ControlProceedsList = new UserControlProceedsList(id, username) { Dock = DockStyle.Fill };

            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(ControlProceedsList);
            PanelContainer.Controls["UserControlProceedsList"].BringToFront();
        }

        private void ButtonExpensesList_Click(object sender, EventArgs e)
        {
            ButtonTransactionList.BackColor = Color.FromArgb(45, 51, 59);
            ButtonProceedsList.BackColor = Color.FromArgb(45, 51, 59);
            ButtonExpensesList.BackColor = Color.Orange;
            ButtonExpensesList.ForeColor = Color.Black;
            UserControlExpensesList UserControlExpensesList = new UserControlExpensesList(id, username) { Dock = DockStyle.Fill };

            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(UserControlExpensesList);
            PanelContainer.Controls["UserControlExpensesList"].BringToFront();
        }

        private void PictureBoxSettings_Click(object sender, EventArgs e)
        {
            ButtonTransactionList.BackColor = Color.FromArgb(45, 51, 59);
            ButtonProceedsList.BackColor = Color.FromArgb(45, 51, 59);
            ButtonExpensesList.BackColor = Color.FromArgb(45, 51, 59);
            ButtonTransactionList.ForeColor = Color.FromArgb(201, 209, 217);
            ButtonProceedsList.ForeColor = Color.FromArgb(201, 209, 217);
            ButtonExpensesList.ForeColor = Color.FromArgb(201, 209, 217);

            UserControlSettings Settings = new UserControlSettings(id, username) { Dock = DockStyle.Fill };

            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(Settings);
            PanelContainer.Controls["UserControlSettings"].BringToFront();
        }

        private void TimerAccountName_Tick(object sender, EventArgs e)
        {
            LabelUsername.Text = classCheckAccountSaldo.CheckUserName(id);
        }

        private void ButtonTransactionList_Enter(object sender, EventArgs e)
        {
            ButtonTransactionList.FlatAppearance.BorderColor = Color.Orange;
        }

        private void ButtonProceedsList_Enter(object sender, EventArgs e)
        {
            ButtonProceedsList.FlatAppearance.BorderColor = Color.Orange;
        }

        private void ButtonExpensesList_Enter(object sender, EventArgs e)
        {
            ButtonExpensesList.FlatAppearance.BorderColor = Color.Orange;
        }

        private void ButtonTransactionList_Leave(object sender, EventArgs e)
        {
            ButtonTransactionList.FlatAppearance.BorderColor = Color.FromArgb(201, 209, 217);
            ButtonTransactionList.ForeColor = Color.FromArgb(201, 209, 217);
            if (ButtonTransactionList.BackColor == Color.Orange)
            {
                ButtonTransactionList.FlatAppearance.BorderColor = Color.Orange;
                ButtonTransactionList.ForeColor = Color.Black;
            }
        }

        private void ButtonProceedsList_Leave(object sender, EventArgs e)
        {
            ButtonProceedsList.FlatAppearance.BorderColor = Color.FromArgb(201, 209, 217);
            ButtonProceedsList.ForeColor = Color.FromArgb(201, 209, 217); 
            if (ButtonProceedsList.BackColor == Color.Orange)
            {
                ButtonProceedsList.FlatAppearance.BorderColor = Color.Orange;
                ButtonProceedsList.ForeColor = Color.Black;
            }
        }

        private void ButtonExpensesList_Leave(object sender, EventArgs e)
        {
            ButtonExpensesList.FlatAppearance.BorderColor = Color.FromArgb(201, 209, 217);
            ButtonExpensesList.ForeColor = Color.FromArgb(201, 209, 217); 
            if (ButtonExpensesList.BackColor == Color.Orange)
            {
                ButtonExpensesList.FlatAppearance.BorderColor = Color.Orange;
                ButtonExpensesList.ForeColor = Color.Black;
            }
        }

        private void TimmerRefreshAccountSaldo_Tick(object sender, EventArgs e)
        {
            LabelSaldo.Text = classCheckAccountSaldo.CheckAccountSaldo(id);
        }
    }
}
