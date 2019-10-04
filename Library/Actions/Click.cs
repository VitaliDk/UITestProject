using OpenQA.Selenium;
using Library.BaseClasses;

namespace Library.Actions
{
    public class Click : BaseAction
    {
        public static void button(IWebDriver driver, By id)
        {
            _Logger.Info("Attempting to click on button with id: " + id);
            driver.FindElement(id).Click();
        }
    }
}
