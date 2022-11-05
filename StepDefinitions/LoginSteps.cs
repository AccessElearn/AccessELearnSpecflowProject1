using AccessELearnSpecflowProject.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessELearnSpecflowProject.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        LoginPage loginPage;
        public LoginSteps()
        {
            loginPage = new LoginPage();
        }

        [Given(@"I navigate to ""([^""]*)""")]
        public void GivenINavigateTo(string url)
        {
           loginPage.LaunchUrl(url); 
        }

        [When(@"I click on the SignInButton")]
        public void WhenIClickOnTheSignInButton()
        {
            loginPage.ClickSignInButton();
        }

        [When(@"I eneter my ""([^""]*)"" and ""([^""]*)""")]
        public void WhenIEneterMyAnd(string userName, string password)
        {
            loginPage.EnterEmailAndPassword(userName, password);
        }

        [When(@"I click on the LoginSignIn button")]
        public void WhenIClickOnTheLoginSignInButton()
        {
            loginPage.ClickLoginSignInButton();
        }

        [Then(@"I should be looged into the application")]
        public void ThenIShouldBeLoogedIntoTheApplication()
        {
            
        }

    }
}
