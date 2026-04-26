using welcomeCanada;
using welcomeCanada.Services;
using System.Data.SqlClient;
using welcomeCanada.Database;
namespace UnitTestApp
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
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
       // [Test]
       /* public void Multiply_BoundaryCase()
        {
            int a = 8878787;
            int b = 9222788;
            int result = int.MaxValue;

            TestCalculation calculation = new TestCalculation();
            int testResult = calculation.multiply(a, b);
            Assert.AreEqual(result, testResult);

        }*/
    }
}