using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Ligne ultra importante pour la base de données !

namespace GestionQuestionnaire.Views
{
    public partial class FormGererQCM : Form
    {
        // Ta chaîne de connexion à la base de données
        string cnxStr = "Server=localhost;Database=stadium_questionnaire;Uid=root;Pwd=toto;";
        public FormGererQCM()
        {
            InitializeComponent();
        }

        private void FormGererQCM_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(cnxStr))
                {
                    conn.Open();
                    // On charge les QCM depuis la table 'questionnaire'
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM questionnaire", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvQCM.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur au chargement des QCM : " + ex.Message);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // On vérifie si l'utilisateur a bien sélectionné une ligne
            if (dgvQCM.SelectedRows.Count > 0)
            {
                // On récupère l'ID de la ligne cliquée
                int idQCM = Convert.ToInt32(dgvQCM.SelectedRows[0].Cells["id"].Value);

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(cnxStr))
                    {
                        conn.Open();

                        // 1. On supprime d'abord les questions liées (pour éviter l'erreur de clé étrangère)
                        MySqlCommand cmdQuestions = new MySqlCommand("DELETE FROM question WHERE id_questionnaire = " + idQCM, conn);
                        cmdQuestions.ExecuteNonQuery();

                        // 2. Ensuite on supprime le QCM
                        MySqlCommand cmdQCM = new MySqlCommand("DELETE FROM questionnaire WHERE id = " + idQCM, conn);
                        cmdQCM.ExecuteNonQuery();
                    }

                    MessageBox.Show("QCM et ses questions supprimés avec succès !");

                    // On recharge la liste direct 
                    using (MySqlConnection conn = new MySqlConnection(cnxStr))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM questionnaire", conn);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvQCM.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Veuillez d'abord cliquer sur la marge gauche d'une ligne pour sélectionner le QCM entier.");
            }
        }
    }
}