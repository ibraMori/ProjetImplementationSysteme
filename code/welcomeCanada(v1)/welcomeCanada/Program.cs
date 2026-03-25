using System;
using welcomeCanada.Models;
using welcomeCanada.Services;

namespace welcomeCanada
{
    class Program
    {
        static void Main(string[] args)
        {
            AuthService auth = new AuthService();

            Console.WriteLine("=== Test Inscription ===");
            string result = auth.Inscrire(TypeUtilisateur.Etudiant, "Hajar", "Chonani", "hajar@test.com", "12345");
            Console.WriteLine(result);

            Console.WriteLine("=== Test Connexion ===");
            bool ok = auth.Connexion("hajar@test.com", "12345");
            Console.WriteLine(ok ? "Connexion réussie" : "Connexion échouée");

            auth.Fermer();

            Console.WriteLine("Appuyez sur une touche pour quitter...");
            Console.ReadKey();
        }
    }
}