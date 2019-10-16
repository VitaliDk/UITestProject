using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System;
using System.IO;
using System.Reflection;

namespace Library.Factories
{
    public class WebDriverFactory
    {
        public IWebDriver Create(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                     return getChromeDriver();
                case BrowserType.Firefox:
                    return getFirefoxDriver();
                case BrowserType.Edge:
                    return getEdgeDriver();
                default:
                    throw new ArgumentOutOfRangeException(browserType + " was not recognised as a valid browser type");

            }
        }

        public IWebDriver getChromeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            return driver;
        }

        public IWebDriver getFirefoxDriver()
        {
            // Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }
        public IWebDriver getEdgeDriver()
        {
            IWebDriver driver = new EdgeDriver();
            return driver;
        }
    }


}
