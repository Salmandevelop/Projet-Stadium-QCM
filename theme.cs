namespace GestionQuestionnaires.Models
{
    public class Theme
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public override string ToString()
        {
            return Nom;
        }
    }
}