using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Library.Tasks;
using Library.Actions;
using Library.Factories;
using NLog;

namespace UITests
{
    [Binding]
    public class BasicTestsSteps
    {
        private readonly  WebDrivers driver;
        private static readonly Logger _Logger = LogManager.GetCurrentClassLogger();

        public BasicTestsSteps(WebDrivers driver)
        {
            this.driver = driver;
        }

        [BeforeScenario]
        public void beginScenario()
        {
            // IWebDriver driver = new ChromeDriver();
            WebDriverFactory factory = new WebDriverFactory();
            IWebDriver driver = factory.Create(BrowserType.Chrome);
            driver.Manage().Window.Maximize();
            this.driver.driver = driver;
        }
        [AfterScenario]
        public void endScenario()
        {
            this.driver.driver.Close();
            this.driver.driver.Quit();
        }

        [Given(@"basic test step 1")]
        public void GivenTheUserIsOnTheLoginPage()
        {
            _Logger.Info("The user is on the log in page");
            //IWebDriver driver = new ChromeDriver();
            this.driver.driver.Navigate().GoToUrl("https://dmiqa3.calastonetest.com/dmi");
            // _Logger.Info(driver.Manage().Logs.GetLog(LogType.Browser).ToString());
            this.driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        [When(@"basic test step 2")]
        public void WhenTheUserAttemptsToLogIn()
        {
            _Logger.Info("Logging in to the DMI now");
           // IWebDriver driver = new ChromeDriver();
            LoginTo.DMI(driver.driver);
            GoTo.OrdersPage(driver.driver);
            GoTo.SettlementsPage(driver.driver);
            GoTo.RegisterPage(driver.driver);
            GoTo.BalancesPage(driver.driver);
        }

        [Then(@"basic test step 3")]
        public void ThenTheUserIsLRedirectedToTheDMI()
        {
            _Logger.Info("The user is logged into the DMI");
        }
    }
}
