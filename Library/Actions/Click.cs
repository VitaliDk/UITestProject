using OpenQA.Selenium;
using Library.BaseClasses;
using Library.HelperFunctions;

namespace Library.Actions
{
    public class Click : BaseAction
    { 
        
        public static void button(IWebDriver driver, By id)
        {
            //_Logger.Info("Attempting to click on button with id: " + id);
            Find.Element(driver, id).Click();
        }

        public static void link(IWebDriver driver, By id)
        {
            Find.Element(driver, id).Click();
        }

        public static void lastButtonByCSS(IWebDriver driver)
        {
            _Logger.Info("Attempting to click the last button using a CSS Selector");
            Find.Element(driver, By.CssSelector("button:last-child")).Click();
        }

        public static void linkByStringValue(IWebDriver driver, string text)
        {
            Find.Element(driver, By.LinkText(text)).Click();
        }
    }
}
