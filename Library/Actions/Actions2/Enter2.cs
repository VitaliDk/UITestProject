
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Library.Actions
{
    public class Enter2
    {
        public static void into(IWebElement webElement, string text)
        {
            webElement.SendKeys(text);
        }
    }
}
