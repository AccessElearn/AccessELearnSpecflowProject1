using AccessELearnSpecflowProject.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessELearnSpecflowProject.Pages
{
    public class LoginPage
    {
        IWebDriver driver;
        IWebElement SigninButton => driver.FindElement(By.XPath("//*[@id=\"header\"]/div[2]/div/div/nav/div[1]/a"));
        IWebElement EnterEmail => driver.FindElement(By.Id("email"));
        IWebElement EnterPassword => driver.FindElement(By.Id("passwd"));
        IWebElement LoginSignInButton => driver.FindElement(By.Id("passwd"));



        public LoginPage()
        {
            driver = Hooks.driver;
        }

        public void LaunchUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void ClickSignInButton()
        {
            SigninButton.Click();
        }

        public void EnterEmailAndPassword(string userName, string password)
        {
            EnterEmail.SendKeys(userName);
            EnterPassword.SendKeys(password);
        }

        public void ClickLoginSignInButton()
        {
            LoginSignInButton.Click();
        }
    }
}
