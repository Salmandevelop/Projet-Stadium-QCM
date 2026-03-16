using System;
using System.Windows.Forms;
using GestionQuestionnaires;

namespace GestionQuestionnaire.Views
{
    public partial class FormInscription : Form
    {
        public FormInscription()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtIdentifiant_Click(object sender, EventArgs e)
        {


        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string pseudo = txtIdentifiant.Text;
            string email = txtEmail.Text;
            string mdpClair = txtMdp.Text;

            if (string.IsNullOrWhiteSpace(pseudo) || string.IsNullOrWhiteSpace(mdpClair))
            {
                MessageBox.Show("Merci de remplir l'identifiant et le mot de passe.");
                return;
            }

            string mdpHache = GestionQuestionnaires.Models.Securite.Hacher(mdpClair);

            var cnx = Connexion.getInstance();
            try
            {
                string sql = "INSERT INTO Utilisateur (pseudo, email, mdp) VALUES (@pseudo, @email, @mdp)";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, cnx);

                cmd.Parameters.AddWithValue("@pseudo", pseudo);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@mdp", mdpHache);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Inscription réussie !");
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }


        private void seconnecter_Click(object sender, EventArgs e)
        {

            Views.FormLogin pageLogin = new Views.FormLogin();
            pageLogin.Show();
            this.Hide();


        }
    }
}
