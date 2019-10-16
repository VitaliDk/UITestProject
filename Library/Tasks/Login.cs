using System;
using OpenQA.Selenium;
using Library.Actions;
using Library.Screens;

namespace Library.Tasks
{
    public class LoginTo
    {
        public static void DMI(IWebDriver driver)
        {
            Enter.into(driver, DMILoginPage.usernameField, "qa1");
            Enter.into(driver, DMILoginPage.passwordField, "Password123.");
            Click.button(driver, DMILoginPage.loginButton);
            WaitFor.element(driver, DMIDashboardPage.dashboard);
        }

        public static void DMIWithInvalidUsername(IWebDriver driver)
        {
            Enter.into(driver, DMILoginPage.usernameField, "invalidusernameTest");
            Enter.into(driver, DMILoginPage.passwordField, "Password123.");
            Click.button(driver, DMILoginPage.loginButton);
            WaitFor.element(driver, DMILoginPage.usernameField);
        }
    }
}
