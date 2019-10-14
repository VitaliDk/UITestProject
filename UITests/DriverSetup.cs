using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using BoDi;

namespace UITests
{
    public class DriverSetup
    {
        private IObjectContainer _objectContainer;
        public IWebDriver Driver;

        public DriverSetup(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void beginScenario()
        {
             Driver = new ChromeDriver();
            _objectContainer.RegisterInstanceAs(Driver);
        }

    }
}
