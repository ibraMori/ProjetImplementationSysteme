namespace welcomeCanada.Models
{
    public enum TypeUtilisateur { Etudiant, Travailleur }

    public interface IUtilisateur
    {
        string Nom { get; set; }
        string Prenom { get; set; }
        string Email { get; set; }
        string MotDePasse { get; set; }
    }

    public class Etudiant : IUtilisateur
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string MotDePasse { get; set; }
    }

    public class Travailleur : IUtilisateur
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string MotDePasse { get; set; }
    }

    public class UtilisateurFactory
    {
        public static IUtilisateur CreerUtilisateur(TypeUtilisateur type)
        {
            switch (type)
            {
                case TypeUtilisateur.Etudiant:
                    return new Etudiant();
                case TypeUtilisateur.Travailleur:
                    return new Travailleur();
                default:
                    throw new System.Exception("Type utilisateur inconnu");
            }
        }
    }
}