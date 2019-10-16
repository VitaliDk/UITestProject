using System;
using OpenQA.Selenium;
using Library.Actions;
using Library.Screens;

namespace Library.Tasks
{
    public class Logout
    {
        public static void DMI(IWebDriver driver)
        {
            Click.button(driver, DMIDashboardPage.accountDropDownToggle);
            Click.lastButtonByCSS(driver);
            WaitFor.element(driver, DMILoginPage.usernameField);
        }
    }
}
