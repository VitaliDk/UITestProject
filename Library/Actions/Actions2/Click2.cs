using OpenQA.Selenium;
using Library.BaseClasses;

namespace Library.Actions
{
    public class Click2 : BaseAction
    {

        public static void button(IWebElement webElement)
        {
            //_Logger.Info("Attempting to click on button " + webElement);
            webElement.Click();
        }

        public static void DynamicLinkText(string text)
        {
            
        }
    }
}
