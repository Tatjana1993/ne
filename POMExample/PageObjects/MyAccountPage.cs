using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMExample.PageObjects
{
   public class MyAccountPage
    {
        private IWebDriver driver;

        public MyAccountPage(IWebDriver driver)
        {
            this.driver = driver;
        }

       

        public bool IsPageDisplayed()
        {
           By myAccount = By.ClassName("myaccount-link-list");
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
           return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(myAccount)).Displayed;           
        }
    }

}
