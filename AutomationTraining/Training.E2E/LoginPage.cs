using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;

namespace Training.E2E
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public bool IsVisible => _wait.Until(ExpectedConditions.ElementIsVisible(
            By.XPath("//h2[text()='New User Signup!']"))).Displayed;

        public SignUpPage SignUp(string name, string email)
        {
            _driver.FindElement(By.XPath("//input[@data-qa='signup-name']")).SendKeys(name);
            _driver.FindElement(By.XPath("//input[@data-qa='signup-email']")).SendKeys(email);
            _driver.FindElement(By.XPath("//input[@data-qa='signup-button']")).Click();

            return new SignUpPage(_driver);
        }
    }

}