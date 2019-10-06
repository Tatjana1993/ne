using NUnit.Framework;
using POMExample.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POMExample.Scenarios
{
    class CreateAccountScenario : BaseScenario
    {
        [Test]

        public void CreatAccountSuccessfully()
        {
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            CreateAccountPage createAccountPage = new CreateAccountPage(Driver);
            MyAccountPage myAccountPage = new MyAccountPage(Driver);

            //arrange 
            string firstName = "Miso";
            string lastName = "Pekic";
            string email = "lala@gmail.com";
            string password = "12345";
            string address = "bla";
            string city = "Paris";
            string stateValue = "1";
            string zipCode = "21000";
            string countryValue = "21";
            string phoneNumber = "065555555";

            //act 
            homePage.NavigateToLoginPage();
            loginPage.TypeEmailForCreateAccount(email);         
            loginPage.ClickOnCreateAccountButton();
            createAccountPage.TypeFirstName(firstName);
            createAccountPage.TypeLastName(lastName);
            createAccountPage.TypePassword(password);
            createAccountPage.TypeAddress(address);
            createAccountPage.TypeCity(city);
            createAccountPage.SelectStateFromDropDown(stateValue);
            createAccountPage.TypeZip(zipCode);
            createAccountPage.SelectCountryFromDropDown(countryValue);
            createAccountPage.TypePhone(phoneNumber);
            createAccountPage.ClickOnRegisterButton();

            //assert
            Assert.IsTrue(myAccountPage.IsPageDisplayed());


        }
    }
}
