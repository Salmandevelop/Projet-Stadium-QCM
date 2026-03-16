using System;
using System.Windows.Forms;
using GestionQuestionnaires;
using MySql.Data.MySqlClient;

namespace GestionQuestionnaire.Views
{
    public partial class FormCreerQCM : Form
    {
        public FormCreerQCM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Vérification que les cases ne sont pas vides
            if (txtNomTheme.Text == "" || txtNomQuestionnaire.Text == "")
            {
                MessageBox.Show("Veuillez remplir le Thème et le Questionnaire.");
                return;
            }

            try
            {
                // On appelle ta connexion
                MySqlConnection cnx = Connexion.getInstance();

                string queryTheme = "INSERT INTO theme (nom) VALUES (@nomTheme)";
                MySqlCommand cmdTheme = new MySqlCommand(queryTheme, cnx);
                cmdTheme.Parameters.AddWithValue("@nomTheme", txtNomTheme.Text);
                cmdTheme.ExecuteNonQuery();

                long idThemeCree = cmdTheme.LastInsertedId;

                string queryQcm = "INSERT INTO questionnaire (nom, id_theme, nb_question) VALUES (@nomQcm, @idTheme, @nbQuestion)";
                MySqlCommand cmdQcm = new MySqlCommand(queryQcm, cnx);
                cmdQcm.Parameters.AddWithValue("@nomQcm", txtNomQuestionnaire.Text);
                cmdQcm.Parameters.AddWithValue("@idTheme", idThemeCree);
                cmdQcm.Parameters.AddWithValue("@nbQuestion", txtNbQuestion.Text);
                cmdQcm.ExecuteNonQuery();

                int idQcmCree = (int)cmdQcm.LastInsertedId;

                MessageBox.Show("Succès ! Le QCM a été ajouté. Passons aux questions ! 🚀");

                FormAjouterQuestion pageQuestions = new FormAjouterQuestion(idQcmCree);
                pageQuestions.Show();

                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void txtNomQuestionnaire_TextChanged(object sender, EventArgs e) { }
        private void txtNbQuestion_TextChanged(object sender, EventArgs e) { }

        private void btnGererQCM_Click(object sender, EventArgs e)
        {
            Views.FormGererQCM formGerer = new Views.FormGererQCM();
            formGerer.ShowDialog();
        }

        private void FormCreerQCM_Load(object sender, EventArgs e)
        {

        }
    }
}