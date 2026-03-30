using System;
using System.Data;
using welcomeCanada.Models;
using welcomeCanada.Services;

class Program
{
    static void Main(string[] args)
    {
        AuthService auth = new AuthService();
        FindHousingService logementService = new FindHousingService();

        Console.WriteLine("=== INSCRIPTION ===");
        Console.WriteLine(auth.Inscrire(
            TypeUtilisateur.Etudiant,
            "Test",
            "User",
            "test@test.com",
            "1234"));

        Console.WriteLine("=== CONNEXION ===");
        Console.WriteLine(auth.Connexion("test@test.com", "1234") ? "OK" : "FAIL");

        Console.WriteLine("\n=== LOGEMENTS ===");

        DataTable logements = logementService.GetAllLogements();

        foreach (DataRow row in logements.Rows)
        {
            Console.WriteLine($"{row["Titre"]} - {row["Ville"]} - {row["Prix"]}$");
        }

        Console.ReadKey();
    }
}