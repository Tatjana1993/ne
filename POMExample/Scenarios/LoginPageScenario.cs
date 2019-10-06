using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using POMExample.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMExample
{


    public class LoginPageScenario : BaseScenario
    {

        [Test]

        public void LoginWithValidPasswordAndEmailField()
        {
            HomePage homePage = new HomePage(Driver);
            MyAccountPage myAccountPage = new MyAccountPage(Driver);
            LoginPage loginPage = new LoginPage(Driver);

            //arrange 
            string email = "carrot@webgmail.info";
            string password = "12345";

            // act
            homePage.NavigateToLoginPage();
            loginPage.TypeEmail(email);
            loginPage.TypePassword(password);
            loginPage.ClickOnSignInButton();
            
            // assert
            Assert.IsTrue(myAccountPage.IsPageDisplayed());
        }

        [Test]

        public void LoginWithEmptyEmailField()
        {
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);

            // arrange
            string password = "12345";

            // act
            homePage.NavigateToLoginPage();
            loginPage.TypePassword(password);
            loginPage.ClickOnSignInButton();
            
            // assert
            Assert.That(loginPage.IsWarningMsgDisplayed(), Is.True, "Error message is NOT displayed");



        }
    }
}
  
