using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Training.E2E
{
    public abstract class BasePage
    {
        protected IWebDriver _driver;
        protected WebDriverWait _wait;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }
    }

}