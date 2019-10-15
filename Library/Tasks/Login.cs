using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Library.Tasks;
using Library.Actions;
using NLog;

namespace Library.Tasks
{
    public class LoginTo
    {
        public static void DMI(IWebDriver driver)
        {
            Library.Actions.Enter.into(driver, Library.Screens.DMILoginPage.usernameField, "qa1");
            Library.Actions.Enter.into(driver, Library.Screens.DMILoginPage.passwordField, "Password123.");
            Library.Actions.Click.button(driver, Library.Screens.DMILoginPage.loginButton);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            
            // Library.Actions.Click.linkByStringValue(driver, "73");
        }
    }
}
