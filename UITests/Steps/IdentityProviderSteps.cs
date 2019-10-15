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
            this.driver.driver.Navigate().GoToUrl("https://dmiqa3.calastonetest.com/dmi");
            this.driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        
        [When(@"the user attempts to log in")]
        public void WhenTheUserAttemptsToLogIn()
        {

            LoginTo.DMI(driver.driver);
        }
        
        [Then(@"the user is redirected to the DMI")]
        public void ThenTheUserIsRedirectedToTheDMI()
        {
            VerifyExistsOnPage.Element(driver.driver, DMIDashboardPage.dashboard);

        }

        [Given(@"the user is logged into the DMI")]
        public void GivenTheUserIsLoggedIntoTheDMI()
        {
            GivenTheUserIsOnTheLoginPage();
            WhenTheUserAttemptsToLogIn();
            ThenTheUserIsRedirectedToTheDMI();
            driver.driver.FindElement(DMIDashboardPage.accountDropDownToggle).Click();
            driver.driver.FindElement(By.XPath("*/div/div/button[4]")).Click();
            // //*[@id="userDropdownContainer"]/div/div/button[4]
            driver.driver.FindElement(By.Id("tyranosaurus"));

        }
    }
}
