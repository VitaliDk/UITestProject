using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Library.Tasks;
using Library.Actions;
using NLog;

namespace UITests
{
    [Binding]
    public class BasicTestsSteps
    {
        private IWebDriver _driver;
        private static readonly Logger _Logger = LogManager.GetCurrentClassLogger();

        public BasicTestsSteps(IWebDriver driver)
        {
            _driver = driver;
        }



        [Given(@"the user is on the login page")]
        public void GivenTheUserIsOnTheLoginPage()
        {
            _Logger.Info("The user is on the log in page");
            //IWebDriver driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://dmiqa3.calastonetest.com/dmi");
           // _Logger.Info(driver.Manage().Logs.GetLog(LogType.Browser).ToString());
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            
        }

        [When(@"the user attempts to log in")]
        public void WhenTheUserAttemptsToLogIn()
        {
            _Logger.Info("Logging in to the DMI now");
           // IWebDriver driver = new ChromeDriver();
            LoginTo.DMI(_driver);
            GoTo.OrdersPage(_driver);
            GoTo.SettlementsPage(_driver);
            GoTo.RegisterPage(_driver);
            GoTo.BalancesPage(_driver);
        }

        [Then(@"the user is redirected to the DMI")]
        public void ThenTheUserIsLRedirectedToTheDMI()
        {
            _Logger.Info("The user is logged into the DMI");

        }
    }
}
