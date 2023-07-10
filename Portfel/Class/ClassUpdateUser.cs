using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Portfel.Class
{
    public class ClassUpdateUser
    {

        public string GetPasswordFromDatabase(string userId)
        {
            // Pobranie zaszyfrowanego hasła z bazy danych
            var appSettings = ConfigurationManager.AppSettings; // Zapisanie konfiguracji do zmiennej
            string myConnectionString = appSettings["ConnectionStringDatabaseMySql"]; // Wypisanie klucza z connectionstring
            string password = "";
            using (MySqlConnection databaseConnection = new MySqlConnection(myConnectionString)) // Używając using łatwiej będzie zamknąć połączenie z bazą jeżeli coś by się stało złego w trakcie wykonywania polecenia
            {
                databaseConnection.Open(); // Otwarcie połączenia
                using (MySqlCommand commandDatabase = new MySqlCommand("SELECT Password FROM users WHERE ID='" + userId + "'", databaseConnection)) // Generowanie komendy
                {
                    commandDatabase.CommandTimeout = 60; // Ustawienie TimeOut
                    MySqlDataReader reader = commandDatabase.ExecuteReader(); // Zapisanie wyniku zapytania do czytnika
                    while (reader.Read())
                    {
                        password = reader.GetString(0); // Zapisanie wprowadzonego hasła do zmiennej
                    }
                }
            }
            return password; // Zwrócenie zaszyfrowanego hasła do wywołującego
        }

        public string GetUsernameFromDatabase(string userId)
        {
            // Pobranie loginu z bazy danych
            var appSettings = ConfigurationManager.AppSettings; // Zapisanie konfiguracji do zmiennej
            string myConnectionString = appSettings["ConnectionStringDatabaseMySql"]; // Wypisanie klucza z connectionstring
            string password = "";
            using (MySqlConnection databaseConnection = new MySqlConnection(myConnectionString)) // Użycie using pozwala na łatwiejsze zażądzanie połączeniem
            {
                databaseConnection.Open(); // Otwarcie połączenia z bazą danych
                using (MySqlCommand commandDatabase = new MySqlCommand("SELECT Username FROM users WHERE ID='" + userId + "'", databaseConnection)) // Generowanie komendy
                {
                    commandDatabase.CommandTimeout = 60; // Ustawienie TimeOut
                    MySqlDataReader reader = commandDatabase.ExecuteReader(); // Zapisanie wywołanego zapytania do czytnika
                    while (reader.Read())
                    {
                        password = reader.GetString(0); // Zapisanie wyniku zapytania do zmiennej
                    }
                }
            }
            return password; // Zwrócenie loginu do wywołującego
        }
    }
}
