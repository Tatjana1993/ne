using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMExample.PageObjects
{
    class CreateAccountPage
    {
        IWebDriver driver;
        By firstNameField = By.Id("firstname");
        By lastNameField = By.Id("lastname");
        By emailField = By.Id("email");
        By passField = By.Id("passwd");
        By addressField = By.Id("address1");
        By cityField = By.Id("city");
        By phoneField = By.Id("phone_mobile");
        By zipField = By.Id("postcode");
        By registerButton = By.Id("submitAccount");

        public CreateAccountPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void TypeFirstName(string firstName)
        {
            driver.FindElement(firstNameField).SendKeys(firstName);
        }

        public void TypeLastName(string lastName)
        {
            driver.FindElement(lastNameField).SendKeys(lastName);
        }

        public void TypeEmail(string email)
        {
            driver.FindElement(emailField).SendKeys(email);
        }

        public void TypePassword(string password)
        {
            driver.FindElement(passField).SendKeys(password);
        }

        public void TypeAddress(string address)
        {
            driver.FindElement(addressField).SendKeys(address);
        }

        public void TypeCity(string city)
        {
            driver.FindElement(cityField).SendKeys(city);
        }


        public void TypePhone(string phone)
        {
            driver.FindElement(phoneField).SendKeys(phone);
        }

        public void TypeZip(string zipCode)
        {
            driver.FindElement(zipField).SendKeys(zipCode);
        }

        public void ClickOnRegisterButton()
        {
            driver.FindElement(registerButton).Click();
        }

        public void SelectStateFromDropDown(string stateValue)
        {
            SelectElement oSelect = new SelectElement(driver.FindElement(By.Id("id_state")));
            oSelect.SelectByValue(stateValue);
        }

        public void SelectCountryFromDropDown(string countryValue)
        {
            SelectElement oSelect = new SelectElement(driver.FindElement(By.Id("id_country)")));
            oSelect.SelectByValue(countryValue);
        }
    }

}
