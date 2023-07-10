using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Portfel.Class
{
    public class ClassCheckAccountSaldo
    {
        public string CheckAccountSaldo(string id)
        {
            //Weryfikacja stanu konta
            var appSettings = ConfigurationManager.AppSettings; // Zmienna w której zapisuje się konfiguracja aplikaji
            string myConnectionString = appSettings["ConnectionStringDatabaseMySql"]; // Zapisanie ConnectionString do zmiennej lokalnej
            string answare = "Error"; // Ustawienie domyślnej odpowiedzi w przypadku problemu z komponentem
            string sql = "SELECT IFNULL(ROUND(Sum(Amount),2),0) FROM usersdata WHERE UserID='" + id + "'"; // Zapytanie obliczające aktualny stan konta zwracające 0 jeeli brak transakcji
            try
            {
                // Rozpoczęcie próby
                using (MySqlConnection Connection = new MySqlConnection(myConnectionString)) // Używając Using w łatwy sposób możemy pominąć zamknięcie połączenia z bazą
                {
                    Connection.Open(); // Otwarcie połączenia z bazą
                    MySqlCommand commandDatabase = new MySqlCommand(sql, Connection) // Utworzenie komendy
                    {
                        CommandTimeout = 60 // Ustawienie Timeouta dla komendy w razie problemów z wykonaniem
                    };
                    MySqlDataReader reader = commandDatabase.ExecuteReader(); // Wykonanie zapytania na bazie
                    if (reader.HasRows) // Jeżeli zapytanie coś zwróciło to zostanie to wypisane
                    {
                        while (reader.Read()) // rozpoczęcie pętli czytającej wiersz który został nam zwrócony
                        {
                            answare = reader.GetString(0) + " zł"; // Zapisanie wyniku do zmiennej
                        }
                    }
                }
            }
            catch // Złapanie błędu w razie problemów
            {
                answare = "No Connection"; // Ustawienie odpowiedzi jako brak połączenia
            }
            return answare; // Zwrócenie odpowiedzi do pola tekstowego
        }

        public string CheckUserName(string id)
        {
            //Weryfikacja Username
            var appSettings = ConfigurationManager.AppSettings; // Zmienna w której zapisuje się konfiguracja aplikaji
            string myConnectionString = appSettings["ConnectionStringDatabaseMySql"]; // Zapisanie ConnectionString do zmiennej lokalnej
            string resoult = "Error"; // Ustawienie domyślnej odpowiedzi w przypadku problemu z komponentem
            string sql = "SELECT Username FROM users WHERE ID='" + id + "'"; // Utworzenie zapytania do wypisania Username Dla danego ID urzytkownika
            try
            {
                //Rozpoczęcie próby
                using (MySqlConnection Connection = new MySqlConnection(myConnectionString)) // Używając Using w łatwy sposób możemy pominąć zamknięcie połączenia z bazą
                {
                    Connection.Open(); // Otwarcie połączenia
                    MySqlCommand commandDatabase = new MySqlCommand(sql, Connection) // Utworzenie komendy
                    {
                        CommandTimeout = 60 // Ustawienie Timeout dla komendy w razie jej nie wykonania
                    };
                    MySqlDataReader reader = commandDatabase.ExecuteReader(); // Wykonanie zapytania i zczytanie odpowiedzi
                    if (reader.HasRows) // Jeżeli są wiersze zwrócony zostanie username
                    {
                        while (reader.Read()) // Wypisanie Username dla ID urzytkownika
                        {
                            resoult = reader.GetString(0); // Zapisanie do zmiennej
                        }
                    }
                }
            }
            catch
            {
                // W razie błędu połączenia zostanie zwrócony błąd
                resoult = "No Connection"; // Ustawienie odpowiedzi jako brak połączenia
            }
            return resoult; // Zwrócenie odpowiedzi do pola tekstowego
        }
    }
}
