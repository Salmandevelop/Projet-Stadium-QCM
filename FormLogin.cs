using System;
using System.Windows.Forms;
using GestionQuestionnaires;
using GestionQuestionnaires.Models;
using MySql.Data.MySqlClient;


namespace GestionQuestionnaire.Views
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {


            string identifiant = txtIdentifiant.Text;
            string mdp = txtMdp.Text;

            if (identifiant == "" || mdp == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            try
            {
                
                MySqlConnection cnx = Connexion.getInstance();

                string query = "SELECT * FROM Utilisateur WHERE (pseudo = @id OR email = @id) AND mdp = @mdp";
                MySqlCommand cmd = new MySqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@id", identifiant);
                cmd.Parameters.AddWithValue("@mdp", mdp);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) 
                {
                    Views.FormCreerQCM pageQcm = new Views.FormCreerQCM();
                    pageQcm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Identifiant ou mot de passe incorrect.");
                }
                reader.Close(); // Toujours fermer le lecteur
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }


        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnhassh_Click(object sender, EventArgs e)
        {
            if (txtMdp.Text == "")
            {
                MessageBox.Show("Veuillez taper un mot de passe d'abord.");
                return;
            }

            string mdpHash = GestionQuestionnaires.Models.Securite.Hacher(txtMdp.Text);
            MessageBox.Show("Voici l'empreinte de sécurité (Hash) :\n\n" + mdpHash, "Résultat du Hachage");
        }
    }
}


