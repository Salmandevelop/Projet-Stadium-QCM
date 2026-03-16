using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace GestionQuestionnaires
{
    public class Connexion
    {

        private static string connectionString = "Server=localhost;Database=Stadium_Questionnaire;Uid=root;Pwd=toto;"; private static MySqlConnection cnx = null;

        public static MySqlConnection getInstance()
        {
            if (cnx == null)
            {
                try
                {
                    cnx = new MySqlConnection(connectionString);
                    cnx.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur Connexion : " + ex.Message);
                }
            }
            else if (cnx.State == ConnectionState.Closed)
            {
                cnx.Open();
            }
            return cnx;
        }

        public static void Close()
        {
            if (cnx != null && cnx.State == ConnectionState.Open)
                cnx.Close();
        }
    }
}
