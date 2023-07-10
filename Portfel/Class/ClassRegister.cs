using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Collections;
using System.Configuration;

namespace Portfel.Class
{
    public class ClassRegister
    {
        public string Register(string USERNAME, string PASSWORD)
        {
            // Rejestracja użytkownika
            var appSettings = ConfigurationManager.AppSettings; // Zmienna w której zapisuje się konfiguracja aplikaji
            string myConnectionString = appSettings["ConnectionStringDatabaseMySql"]; // Zapisanie ConnectionString do zmiennej lokalnej
            ClassPassword classPassword = new ClassPassword(); // Wygenerowanie zmiennej ClassPassword
            string answare = "Error"; // Ustawienie domyślnej odpowiedzi w przypadku problemu z komponentem
            try
            {
                // Rozpoczęcie próby
                using (MySqlConnection connection = new MySqlConnection(myConnectionString)) // Używając Using w łatwy sposób możemy pominąć zamknięcie połączenia z bazą
                {
                    connection.Open(); // Otwarcie połączenia
                    string sql = "SELECT Username,Password FROM users WHERE Username='" + USERNAME + "' and Password='" + Convert.ToString(classPassword.HashPassword(PASSWORD)) + "'"; // Generowanie zapytania
                    MySqlCommand command = new MySqlCommand(sql, connection); // Denerowanie komendy
                    command.CommandTimeout = 60; // Ustawienie Timeout 60 s
                    MySqlDataReader reader1 = command.ExecuteReader(); // Ekzekucja komendy i zapisanie jej do czytnika
                    if (reader1.HasRows)
                    {
                        //Wypisanie wartości jeżeli zwrócone
                        while (reader1.Read())
                        {
                            string[] row = { reader1.GetString(0), reader1.GetString(1) }; // Zapisanie wyniku do tablicy
                            if ((row[0] == USERNAME) && (row[1] == Convert.ToString(classPassword.HashPassword(PASSWORD)))) // Jeżeli istnieje już taki urzytkownik
                            {
                                answare = "Exist"; // Zwrócenie informacji że taki urzytkownik istnieje
                            }
                        }
                    }
                }
                if (answare != "Exist")
                {
                    // Jeżeli użytkownik nie istnieje to go wprowadzamy
                    using (MySqlConnection connection = new MySqlConnection(myConnectionString)) // Używając Using w łatwy sposób możemy pominąć zamknięcie połączenia z bazą
                    {
                        connection.Open(); // Otwarcie połaćżenia
                        string sql = "INSERT INTO users(`Username`, `Password`) VALUES ('" + USERNAME + "', '" + Convert.ToString(classPassword.HashPassword(PASSWORD)) + "')"; // Generowanie Inserta
                        MySqlCommand command = new MySqlCommand(sql, connection); // Generowanie komendy
                        command.CommandTimeout = 60; // Ustawienie Timeout 60 s
                        int AffectsRow = command.ExecuteNonQuery();
                        if (AffectsRow > 0)
                        {
                            answare = "Create"; // zwrócenie odpowiedzi o utworzeniu urzytkownika
                        }
                        else answare = "Not Created"; // zwrócenie informacji że urzytkownik nie został utworzony
                    }
                }
            }
            catch 
            {
                answare = "Conection error"; // Zwrócenie informacji o braku połączenia
            }
            return answare; // zwrócenie odpoweidzi
        }
    }
}

