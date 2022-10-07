using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;

namespace Training.E2E
{
    public class SignUpPage : BasePage
    {
        public SignUpPage(IWebDriver driver) : base(driver)
        {
        }

        public bool IsVisible => _wait.Until(ExpectedConditions.ElementIsVisible(
            By.XPath("//b[text()='Enter Account Information']"))).Displayed;

        public void FillIn(SignUpForm form)
        {
            SetGender(form.Gender);
            //fill in the rest
        }

        private void SetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Mr:
                    _driver.FindElement(By.XPath("//label[@for='id_gender1']")).Click();
                    break;
                case Gender.Mrs:
                    _driver.FindElement(By.XPath("//label[@for='id_gender2']")).Click();
                    break;
            }
        }

        public CreateAccountPage CreateAccount()
        {
            /// create account here.
            /// 
            return new CreateAccountPage(_driver);
        }
    }
}