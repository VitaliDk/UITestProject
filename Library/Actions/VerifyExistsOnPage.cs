using OpenQA.Selenium;
namespace Library.Actions
{
    public class VerifyExistsOnPage
    {
        public static void Element(IWebDriver driver, By id)
        {
            driver.FindElement(id);
        }
    }
}
