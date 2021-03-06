using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace VeterinarskaStanica.Helper
{
    public class MD5Hash
    {
        public static String GetMD5Hash(String TextToHash)
        {
            if (TextToHash == null || TextToHash.Length == 0)
                return String.Empty;

            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] textToHash = Encoding.Default.GetBytes(TextToHash);
            byte[] result = md5.ComputeHash(textToHash);

            string hashedPassword = "";
            foreach (byte hexdigit in result)
            {
                hashedPassword += hexdigit.ToString("X2", CultureInfo.InvariantCulture.NumberFormat);
            }

            return hashedPassword;
        }
    }
}