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
        private static readonly Logger _Logger = LogManager.GetCurrentClassLogger();
        [Given(@"I am logged into the DMI")]
        public void GivenIAmLoggedIntoTheDMI()
        {
           // _Logger.Info("Logging in to the DMI now");
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://dmiqa1.calastonetest.com/dmi");
            _Logger.Info(driver.Manage().Logs.GetLog(LogType.Browser).ToString());
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            LoginTo.DMI(driver);
        }
    }
}
