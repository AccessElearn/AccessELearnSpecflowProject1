using AccessELearnSpecflowProject.Utility;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AccessELearnSpecflowProject.Pages
{
    public class SignInPage
    {
        IWebDriver driver;
        Waits waits;
        IWebElement SigninButton => driver.FindElement(By.XPath("//*[@id=\"header\"]/div[2]/div/div/nav/div[1]/a"));
        IWebElement EnterSignInEmail => driver.FindElement(By.Id("email_create"));
        IWebElement CreateAccountButton => driver.FindElement(By.XPath("//*[@id=\"SubmitCreate\"]/span"));
        IWebElement TitleButton => driver.FindElement(By.Id("id_gender1"));
        IWebElement FirstName => driver.FindElement(By.Id("customer_firstname"));
        IWebElement LastName => driver.FindElement(By.Id("customer_lastname"));
        IWebElement Password => driver.FindElement(By.Id("passwd"));
        IWebElement SelectDate => driver.FindElement(By.Id("days"));
        IWebElement SelectMonth => driver.FindElement(By.Id("months"));
        IWebElement SelectYear => driver.FindElement(By.Id("years"));
        IWebElement AddressFirstName => driver.FindElement(By.Id("firstname"));
        IWebElement AddressLastName => driver.FindElement(By.Id("lastname"));
        IWebElement Address => driver.FindElement(By.Id("address1"));
        IWebElement City => driver.FindElement(By.Id("city"));
        IWebElement State => driver.FindElement(By.Id("id_state"));
        IWebElement ZipCode => driver.FindElement(By.Id("postcode"));
        IWebElement AdditionalInfo => driver.FindElement(By.Id("other"));
        IWebElement HomePhoneNo => driver.FindElement(By.Id("phone"));
        IWebElement MobileNO => driver.FindElement(By.Id("phone_mobile"));
        IWebElement AssignAlias => driver.FindElement(By.Id("alias"));
        IWebElement RegisterButton => driver.FindElement(By.XPath("//*[@id=\"submitAccount\"]/span"));
        IWebElement SignOutButton => driver.FindElement(By.XPath("//*[@id=\"header\"]/div[2]/div/div/nav/div[2]/a"));







        public SignInPage()
        {
            driver =Hooks.driver;
            waits =new Waits(); 
        }

        public void LaunchUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void ClickSignInButton()
        {
            waits.WaitForElement(driver, SigninButton);
            SigninButton.Click();
        }

        public void EnterEmailForSignIn(string email)
        {
            
            EnterSignInEmail.SendKeys(email);
        }

        public void ClickCreateAccountButton()
        {
            CreateAccountButton.Click();
           
        }

        public void ValidateInformationPage()
        {
            string actualTitle = "Login - My Store";
            string expectedTitle = driver.Title;
            Assert.AreEqual(expectedTitle, actualTitle);
            Console.WriteLine("The page title is :" + driver.Title);

            // string actualtext = driver.FindElement(By.XPath("xpath")).Text;
            //string expectedText = "Dresses"
            //Assert.AreEqual(expectedText, actualText);
        }

        public void ClickTitleButton()
        {
            //new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(driver => TitleButton);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(driver => TitleButton).Click();

            //TitleButton.Click();

        }

        public void EnterFirstNameAndLastName()
        {
            FirstName.SendKeys("Access");
            LastName.SendKeys("Tester");
        }

        public void EnterPassword()
        {
            Password.SendKeys("AugBatch2022");
        }

        public void SelectDOBDate()
        {
            SelectElement select = new SelectElement(SelectDate);
            select.SelectByIndex(6);
        }

        public void SelectDOBMonth()
        {
            SelectElement select = new SelectElement(SelectMonth);
            select.SelectByIndex(4);
        }

        public void SelectDOBYear()
        {
         
            SelectElement select = new SelectElement(SelectYear);
            select.SelectByValue("2006");
        }

        public void EnterAddressDetails(Table table)
        {
            var dictionary = TableExtension.ToDictionary(table);
            var test = dictionary["AddressFirstName"];

            waits.WaitForElement(driver, AddressFirstName);
            AddressFirstName.Clear();   
            AddressFirstName.SendKeys(dictionary["AddressFirstName"]);

            AddressLastName.Clear();
            AddressLastName.SendKeys(dictionary["AddressLastName"]);

            Address.SendKeys(dictionary["Address"]);

            City.SendKeys(dictionary["City"]);

            SelectElement select = new SelectElement(State);
            select.SelectByText(dictionary["State"]);          

            ZipCode.SendKeys(dictionary["Zip/PostalCode"]);

            AdditionalInfo.SendKeys(dictionary["AdditionalInformation"]);

            HomePhoneNo.SendKeys(dictionary["HomePhoneNumber"]);

            MobileNO.SendKeys(dictionary["MobilePhoneNumber"]);

            AssignAlias.SendKeys(dictionary["AddressAlias"]);         
        }

        public void ClickRegisterButton()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(driver => RegisterButton);

            RegisterButton.Click(); 
        }

        public void ValidateSuccesfullRegistration()
        {
            bool status = SignOutButton.Displayed;
            if(status)
                Console.WriteLine(SignOutButton.Text, " + is displayed");
            else
                Console.WriteLine("Login Failed");

            Thread.Sleep(3000);

        }
    }
}
