using OpenQA.Selenium;
using System;

namespace Training.E2E
{
    public class CreateAccountPage : BasePage
    {
        private IWebDriver driver;

        public CreateAccountPage(IWebDriver driver) : base(driver)
        {
        }

        public bool IsVisible { get; set; } // implement 

        public HomePage Continue()
        {

            //implement me

            return new HomePage(_driver);
        }
    }
}