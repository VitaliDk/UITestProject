
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Library.Actions
{
    public class Enter
    {
        public static void into(IWebDriver driver, By id, string text)
        {
            driver.FindElement(id).SendKeys(text);
        }
    }
}
