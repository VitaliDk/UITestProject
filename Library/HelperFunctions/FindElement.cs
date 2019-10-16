using System;
using OpenQA.Selenium;
using NLog;

namespace Library.HelperFunctions
{
    public class Find
    {
       
        public static IWebElement Element(IWebDriver driver, By selector)
        {
            // Return null by default
            IWebElement elementToReturn = null;

            try
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                elementToReturn = driver.FindElement(selector);
            }
            catch (NoSuchElementException e)
            {
                //_Logger.Info($"No such element: {selector} could be found.");
                String format = "dd-mm-yyyy.hh.mm.tt";
                TakeScreenshot.SaveAs(driver, "C:\\CSharpUITestProject\\UITestProject\\UITests\\Screenshots", DateTime.Now.ToString(format));
                throw new NoSuchElementException("exception thrown", e);
            }
            catch (Exception e)
            {
                throw e;
            }

            // return either the element or null
            return elementToReturn;
        }
    }
}
