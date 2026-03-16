using System;
using System.Windows.Forms;
using GestionQuestionnaires;
using MySql.Data.MySqlClient;

namespace GestionQuestionnaire.Views
{
    public partial class FormAjouterQuestion : Form
    {
        private int idQuestionnaireEnCours;

        public FormAjouterQuestion(int idQ)
        {
            InitializeComponent();
            this.idQuestionnaireEnCours = idQ;
        }

        private void btnAjouterQuestion_Click(object sender, EventArgs e)
        {
            if (txtIntituleQuestion.Text == "")
            {
                MessageBox.Show("Veuillez taper une question.");
                return;
            }

            try
            {
                MySqlConnection cnx = Connexion.getInstance();

                // ⚠️ AJOUT DE 'reponse_vrai' ET '@rep' DANS LA REQUÊTE
                string query = "INSERT INTO question (libelle, id_type, id_questionnaire, reponse_vrai) VALUES (@libelle, @idType, @idQ, @rep)";
                MySqlCommand cmd = new MySqlCommand(query, cnx);

                cmd.Parameters.AddWithValue("@libelle", txtIntituleQuestion.Text);
                cmd.Parameters.AddWithValue("@idType", 1);
                cmd.Parameters.AddWithValue("@idQ", idQuestionnaireEnCours);

                // ⚠️ ON LIT LE BOUTON RADIO ICI (1 si Vrai, 0 si Faux)
                cmd.Parameters.AddWithValue("@rep", rbVrai.Checked ? 1 : 0);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Question ajoutée avec succès ! Elle est maintenant liée à ce questionnaire. 🚀");
                txtIntituleQuestion.Text = "";
                rbVrai.Checked = true; // On remet le bouton sur VRAI pour la prochaine question
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur MySQL : " + ex.Message);
            }
        }

        private void btnTerminer_Click(object sender, EventArgs e)
        {
            Views.FormCreerQCM pageCreation = new Views.FormCreerQCM();
            pageCreation.Show();
            this.Close();
        }
    }
}