using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography;
using System.Configuration;

namespace Portfel.Class
{
    public class ClassLogin
    {

        ClassPassword classPassword = new ClassPassword(); // Utworzenie globalnej zmiennej klasy do późniejszych odwołań
        string answare = "Error"; // Przypisanie domyślnej odpowiedzi

        public string LoginUser(string username, string password)
        {
            //Weryfikacja czy podane dane logowania są prawidłowe
            var appSettings = ConfigurationManager.AppSettings; // Zmienna w której zapisuje się konfiguracja aplikaji
            string myConnectionString = appSettings["ConnectionStringDatabaseMySql"]; // Zapisanie ConnectionString do zmiennej lokalnej
            try
            {
                //Rozpoczęcie próby
                using (MySqlConnection connection = new MySqlConnection(myConnectionString)) // Używając Using w łatwy sposób możemy pominąć zamknięcie połączenia z bazą
                {
                    connection.Open(); // Otwarcie połączenia
                    string sql = "SELECT ID,Username FROM users WHERE Username='" + username + "' and Password='" + Convert.ToString(classPassword.HashPassword(password)) + "'"; // Utworzenie zapytania
                    MySqlCommand command = new MySqlCommand(sql, connection); // Utworzenie komendy
                    command.CommandTimeout = 60; // Przypisanie Timeout dla nie udanego wykonania komendy
                    MySqlDataReader reader = command.ExecuteReader(); // Zapisanie do readera wyniku zapytania
                    if (reader.HasRows)
                    {
                        //Jeżeli zwrócona wartość to będzie wypisana
                        while (reader.Read())
                        {
                            string[] row = { reader.GetString(0), reader.GetString(1)}; // Zapisanie wyniku zapytania do tablicy
                            answare = "git;" + row[0] + ";" + row[1]; // Zapisanie wyniku jeżeli jest poprawne hasło
                        }
                    }
                    else
                    {
                        answare = "No user"; // Udzielenie odpowiedzi że użytkownik nie istnieje
                    }
                }
            }
            catch
            {
                answare = "No Connection"; // Zapisanie odpowiedzi o braku połączenia
            }
            return answare; // Zwrócenie odpowiedzi
        }
    }
}