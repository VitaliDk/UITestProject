
using OpenQA.Selenium;
using Library.HelperFunctions;

namespace Library.Actions
{
    public class Enter
    {
        public static void into(IWebDriver driver, By id, string text)
        {
            Find.Element(driver, id).SendKeys(text);
        }
    }
}
