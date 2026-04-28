using System.Data;
using System.Data.SqlClient;
using welcomeCanada;
using welcomeCanada.Database;
using welcomeCanada.Models;
using welcomeCanada.Services;
using System.Configuration;


namespace UnitTestApp
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        // =========================
        // AUTHENTIFICATION
        // =========================

        [Test]
        public void Connect_ValidUser()
        {
            string email = "marc@gmail.com";
            string mdp = "marc";

            AuthService authService = new AuthService();

            bool connexion = authService.Connexion(email, mdp);

            Assert.AreEqual(true, connexion);
        }

        [Test]
        public void Connect_InvalidUser()
        {
            string email = "fake@gmail.com";
            string mdp = "wrong";

            AuthService authService = new AuthService();

            bool connexion = authService.Connexion(email, mdp);

            Assert.AreEqual(false, connexion);
        }

        [Test]
        public void GetTypeUtilisateur_ValidEmail()
        {
            string email = "marc@gmail.com";

            AuthService authService = new AuthService();

            TypeUtilisateur? type = authService.GetTypeUtilisateurByEmail(email);

            Assert.IsNotNull(type);
        }

        [Test]
        public void GetNom_ValidEmail()
        {
            string email = "marc@gmail.com";

            AuthService authService = new AuthService();

            string nom = authService.GetNomByEmail(email);

            Assert.IsNotNull(nom);
            Assert.AreNotEqual("", nom);
        }

        [Test]
        public void GetPrenom_ValidEmail()
        {
            string email = "marc@gmail.com";

            AuthService authService = new AuthService();

            string prenom = authService.GetPrenomByEmail(email);

            Assert.IsNotNull(prenom);
            Assert.AreNotEqual("", prenom);
        }

        // =========================
        // GUIDES
        // =========================

        [Test]
        public void GetGuides_ReturnsData()
        {
            GuideService guideService = new GuideService();

            DataTable guides = guideService.GetGuides();

            Assert.IsNotNull(guides);
            Assert.GreaterOrEqual(guides.Rows.Count, 0);
        }

        [Test]
        public void GetAllGuidesForObserver_ReturnsColumns()
        {
            GuideService guideService = new GuideService();

            DataTable guides = guideService.GetAllGuidesForObserver();

            Assert.IsTrue(guides.Columns.Contains("Titre"));
            Assert.IsTrue(guides.Columns.Contains("Description"));
            Assert.IsTrue(guides.Columns.Contains("Categorie"));
            Assert.IsTrue(guides.Columns.Contains("TypeUtilisateur"));
        }

        [Test]
        public void AjouterGuide_ValidGuide()
        {
            GuideService guideService = new GuideService();

            guideService.AjouterGuide(
                "Test Guide NUnit",
                "Description de test pour NUnit",
                GuideCategorie.Banque,
                TypeUtilisateur.Etudiant
            );

            DataTable guides = guideService.GetGuides();

            bool found = false;

            foreach (DataRow row in guides.Rows)
            {
                if (row["Titre"].ToString() == "Test Guide NUnit")
                {
                    found = true;
                    break;
                }
            }

            Assert.AreEqual(true, found);
        }

        [Test]
        public void AjouterGuide_EmptyTitle_ShouldThrowException()
        {
            GuideService guideService = new GuideService();

            Assert.Throws<System.Exception>(() =>
            {
                guideService.AjouterGuide(
                    "",
                    "Description valide",
                    GuideCategorie.NAS,
                    TypeUtilisateur.Travailleur
                );
            });
        }

        [Test]
        public void AjouterGuide_EmptyDescription_ShouldThrowException()
        {
            GuideService guideService = new GuideService();

            Assert.Throws<System.Exception>(() =>
            {
                guideService.AjouterGuide(
                    "Titre valide",
                    "",
                    GuideCategorie.OPUS,
                    TypeUtilisateur.Etudiant
                );
            });
        }

        // =========================
        // ADMIN / UTILISATEURS
        // =========================

        [Test]
        public void GetUtilisateurs_ReturnsData()
        {
            AdminService adminService = new AdminService();

            DataTable users = adminService.GetUtilisateurs();

            Assert.IsNotNull(users);
            Assert.GreaterOrEqual(users.Rows.Count, 0);
        }

        [Test]
        public void GetUtilisateurs_FilterByNom()
        {
            AdminService adminService = new AdminService();

            DataTable users = adminService.GetUtilisateurs("marc", "");

            Assert.IsNotNull(users);
        }

        [Test]
        public void GetUtilisateurs_FilterByTypeEtudiant()
        {
            AdminService adminService = new AdminService();

            DataTable users = adminService.GetUtilisateurs("", "Etudiant");

            Assert.IsNotNull(users);

            foreach (DataRow row in users.Rows)
            {
                Assert.AreEqual("Etudiant", row["TypeUtilisateur"].ToString());
            }
        }

        [Test]
        public void GetUtilisateurs_FilterByTypeTravailleur()
        {
            AdminService adminService = new AdminService();

            DataTable users = adminService.GetUtilisateurs("", "Travailleur");

            Assert.IsNotNull(users);

            foreach (DataRow row in users.Rows)
            {
                Assert.AreEqual("Travailleur", row["TypeUtilisateur"].ToString());
            }
        }

        // =========================
        // TEST SIMPLE EXISTANT
        // =========================

        [Test]
        public void Multiply_NormalCase()
        {
            int a = 5;
            int b = 10;
            int result = 50;

            TestCalculation calculation = new TestCalculation();

            int testResult = calculation.multiply(a, b);

            Assert.AreEqual(result, testResult);
        }

        [Test]
        public void Multiply_NormalCase2()
        {
            int a = 87;
            int b = -10;
            int result = -870;

            TestCalculation calculation = new TestCalculation();

            int testResult = calculation.multiply(a, b);

            Assert.AreEqual(result, testResult);
        }
    }
}