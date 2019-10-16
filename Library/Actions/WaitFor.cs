using System;
using OpenQA.Selenium;
using Library.HelperFunctions;

namespace Library.Actions
{
    public class WaitFor
    {
        public static void element(IWebDriver driver, By id)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(id);
            TakeScreenshot.SaveAs(driver, "C:\\CSharpUITestProject\\UITestProject\\UITests", "testScreenshotMethod");
        }
    }
}
