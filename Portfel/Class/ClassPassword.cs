using System;
using System.Security.Cryptography;
using System.Text;

namespace Portfel.Class
{
    public class ClassPassword
    {
        public string HashPassword(string password)
        {
            // Szyfrowanie hasła
            byte[] toEncodeAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(password); // Zaszyfrowanie hasła w Base64
            password = Convert.ToBase64String(toEncodeAsBytes); // Przepisanie zaszyfrowanego hasła do textu
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider(); // Zainicjowanie sposobu szyfrowania SHA1
            byte[] password_bytes = Encoding.ASCII.GetBytes(password); // Przepisanie hasła do postaci bitowej
            byte[] encrypted_bytes = sha1.ComputeHash(password_bytes); // Zaszyfrowanie hasła
            return Convert.ToBase64String(encrypted_bytes); // Zwrócenie wartości zaszyfrowanego hasła
        }
    }
}
