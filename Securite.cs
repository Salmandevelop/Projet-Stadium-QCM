using System.Security.Cryptography;
using System.Text;

namespace GestionQuestionnaires.Models
{
    public static class Securite
    {
        // (Hash SHA256)
        public static string Hacher(string motDePasseClair)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(motDePasseClair));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}