using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMExample.PageObjects
{
    public class LoginPage 
    {
        IWebDriver driver;

        
        By emailLoginField = By.Id("email");
        By passwordLoginField = By.Id("passwd");
        By emailCreateAccountField = By.Id("email_create");
        By createAccountButton = By.Id("SubmitCreate");
        By forgotYourPasswordLink = By.LinkText("Recover your forgotten password");
        // By forgotYourPasswordLink = By.Xpath("//*[@id='login_form']/div/p[1]/a");
        By signInButton = By.Id("SubmitLogin");
        By emptyEmailWarningMsg = By.XPath("//*[@id='center_column']//li");
        
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;

        }

        public  void TypeEmail(string email)
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(emailLoginField));
            driver.FindElement(emailLoginField).SendKeys(email);
        }
       
           
        public void TypePassword(string password)
        {
            driver.FindElement(passwordLoginField).SendKeys(password);
        }
            

        public void ClickOnSignInButton()
        {
            driver.FindElement(signInButton).Click();
        }
           
        public void ClickOnForgottenYourPassword()
        {
            driver.FindElement(forgotYourPasswordLink).Click();
        }

        public void TypeEmailForCreateAccount(string emailCreateAccount)
        {
            driver.FindElement(emailCreateAccountField).SendKeys(emailCreateAccount);
        }

        public void ClickOnCreateAccountButton()
        {
            driver.FindElement(createAccountButton).Click();
        }

        public bool IsWarningMsgDisplayed()
        {
        
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(emptyEmailWarningMsg)).Displayed;
        }



    }
}

