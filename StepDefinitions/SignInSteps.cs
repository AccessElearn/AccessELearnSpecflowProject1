using AccessELearnSpecflowProject.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessELearnSpecflowProject.StepDefinitions
{
    [Binding]
    public class SignInSteps
    {

        SignInPage signInPage;

        public SignInSteps()
        {
            signInPage = new SignInPage();
        }


        [Given(@"I navigate to the website ""([^""]*)""")]
        public void GivenINavigateToTheWebsite(string url)
        {
            signInPage.LaunchUrl(url);
        }

        [When(@"I click on the SignIn button")]
        public void WhenIClickOnTheSignInButton()
        {
            signInPage.ClickSignInButton();
        }

        [When(@"I enter my email adddress as ""([^""]*)""")]
        public void WhenIEnterMyEmailAdddressAs(string email)
        {
            signInPage.EnterEmailForSignIn(email);
        }

        [When(@"I click on the create an account button")]
        public void WhenIClickOnTheCreateAnAccountButton()
        {
            signInPage.ClickCreateAccountButton();
        }

        [Then(@"Your personal information page should be displayed")]
        public void ThenYourPersonalInformationPageShouldBeDisplayed()
        {
            
            signInPage.ValidateInformationPage();
        }

        [Given(@"I click on the title button")]
        public void GivenIClickOnTheTitleButton()
        {
            signInPage.ClickTitleButton();
        }

        [Given(@"I enter my firstName and LastName")]
        public void GivenIEnterMyFirstNameAndLastName()
        {
            signInPage.EnterFirstNameAndLastName();
        }

        [When(@"I enter my password")]
        public void WhenIEnterMyPassword()
        {
            signInPage.EnterPassword();
        }

        [When(@"I select my date of birth")]
        public void WhenISelectMyDateOfBirth()
        {
            signInPage.SelectDOBDate();
            signInPage.SelectDOBMonth();
            signInPage.SelectDOBYear();
        }

        [Given(@"I enter my address fields and values as below")]
        public void GivenIEnterMyAddressFieldsAndValuesAsBelow(Table table)
        {
          signInPage.EnterAddressDetails(table);
        }

        [Given(@"I click on the register button")]
        public void GivenIClickOnTheRegisterButton()
        {
            signInPage.ClickRegisterButton();
        }

        [Then(@"I should be registered")]
        public void ThenIShouldBeRegistered()
        {
            
        }


    }
}
