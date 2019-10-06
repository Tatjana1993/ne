using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMExample.PageObjects
{
    public class HomePage 
    {
        private IWebDriver driver;
        By signInLink = By.ClassName("login");

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void NavigateToLoginPage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(signInLink));

            driver.FindElement(signInLink).Click();

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("center_column")));




        }

    }
    
}
   