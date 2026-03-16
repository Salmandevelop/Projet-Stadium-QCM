namespace GestionQuestionnaires.Models
{
    public class Questionnaire
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int IdTheme { get; set; }
        public int NbQuestion { get; set; }
        public bool Publier { get; set; }
        public string NomTheme { get; set; }
    }
}