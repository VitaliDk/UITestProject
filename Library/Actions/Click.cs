using OpenQA.Selenium;
using Library.BaseClasses;
using NLog;

namespace Library.Actions
{
    public class Click : BaseAction
    { 
        
        public static void button(IWebDriver driver, By id)
        {
            _Logger.Info("Attempting to click on button with id: " + id);
            driver.FindElement(id).Click();
        }

        public static void linkByStringValue(IWebDriver driver, string text)
        {
            driver.FindElement(By.LinkText(text)).Click();
        }
    }
}
