using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace Training.E2E
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public bool IsVisible => _wait.Until(ExpectedConditions.ElementIsVisible(By.Id("slider"))).Displayed;

        public string LoggedInAs => _driver.FindElement(By.XPath("//i[@class='fa fa-user']/following-sibling::b")).Text;

        public void GoTo()
        {
            _driver.Navigate().GoToUrl("https://automationexercise.com/");
        }

        public LoginPage GoToLoginPage()
        {
            _driver.FindElement(By.XPath("//a[@href='/login']")).Click();

            return new LoginPage(_driver);
        }
    }
}