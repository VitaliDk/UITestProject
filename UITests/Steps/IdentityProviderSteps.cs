using System;
using TechTalk.SpecFlow;
using Library.Tasks;
using Library.Actions;
using Library.Screens;
using Library.Factories;
using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace UITests.Steps
{
    [Binding]
    public class IdentityProviderSteps
    {

        private readonly WebDrivers driver;
        private static readonly Logger _Logger = LogManager.GetCurrentClassLogger();

        public IdentityProviderSteps(WebDrivers driver)
        {
            this.driver = driver;
        }

        [Given(@"the user is on the login page")]
        public void GivenTheUserIsOnTheLoginPage()
        {
            // this.driver.driver.Navigate().GoToUrl("https://dmiqa3.calastonetest.com/dmi");
            GoTo.DMILoginPage(driver.driver);
            driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        
        [When(@"the user attempts to log in")]
        public void WhenTheUserAttemptsToLogIn()
        {
            LoginTo.DMI(driver.driver);
        }

        [When(@"the user attempts to log in with an invalid username")]
        public void WhenTheUserAttemptsToLogInWithAnInvalidUsername()
        {
            LoginTo.DMIWithInvalidUsername(driver.driver);
        }

        [When(@"the user attempts to log out")]
        public void WhenTheUserAttemptsToLogOut()
        {
            Logout.DMI(driver.driver);
        }

        [Then(@"the user is redirected to the DMI")]
        public void ThenTheUserIsRedirectedToTheDMI()
        {
            VerifyExistsOnPage.Element(driver.driver, DMIDashboardPage.dashboard);

        }

        [Then(@"the user is redirected to the DMI login page")]
        public void ThenTheUserIsRedirectedToTheDMILoginPage()
        {
            VerifyExistsOnPage.Element(driver.driver, DMILoginPage.usernameField);

        }

        [Given(@"the user is logged into the DMI")]
        public void GivenTheUserIsLoggedIntoTheDMI()
        {
            GivenTheUserIsOnTheLoginPage();
            WhenTheUserAttemptsToLogIn();
            ThenTheUserIsRedirectedToTheDMI();
        }

       
        [Then(@"the user is shown a validation message explaining that their login attempt was unsuccessful")]
        public void ThenTheUserIsUnsuccessfulInLoggingIntoTheDMI()
        {
            VerifyExistsOnPage.Element(driver.driver, DMILoginPage.invalidLoginAttemptMessage);
        }
    }
}
