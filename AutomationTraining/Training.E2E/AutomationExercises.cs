using Bogus;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.IO;
using System.Reflection;

namespace Training.E2E
{
    [TestClass]
    public class AutomationExercises
    {
        private IWebDriver _driver;

        [TestInitialize]
        public void TestInitialize()
        {
            var driverPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            _driver = new ChromeDriver(driverPath, new ChromeOptions(), TimeSpan.FromMinutes(1));
            _driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            _driver.Quit();
            _driver.Close();
        }

        [TestMethod]
        public void TestCase1_RegisterUser()
        {
            var homePage = new HomePage(_driver);
            homePage.GoTo();

            Assert.IsTrue(homePage.IsVisible);

            var loginPage = homePage.GoToLoginPage();
            Assert.IsTrue(loginPage.IsVisible);

            var faker = new Faker();
            var name = faker.Person.FirstName;

            var signUpPage = loginPage.SignUp(name, faker.Person.Email);
            Assert.IsTrue(signUpPage.IsVisible);

            signUpPage.FillIn(new SignUpForm(faker));

            var createAccountPage = signUpPage.CreateAccount();

            Assert.IsTrue(createAccountPage.IsVisible);

            homePage = createAccountPage.Continue();
            Assert.IsTrue(homePage.IsVisible);
            Assert.AreEqual(name, homePage.LoggedInAs);
        }
    }
}