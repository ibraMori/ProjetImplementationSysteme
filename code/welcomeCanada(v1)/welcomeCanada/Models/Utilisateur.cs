namespace welcomeCanada.Models
{
    

    public class Utilisateur
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string MotDePasse { get; set; }
        public TypeUtilisateur TypeUtilisateur { get; set; }
    }
}