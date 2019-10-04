using OpenQA.Selenium;

namespace Library.Tasks
{
    public class LoginTo
    {
        public static void DMI(IWebDriver driver)
        {
            Library.Actions.Enter. into(driver, Library.Screens.DMILoginPage.usernameField, "qa1");
            Library.Actions.Enter.into(driver, Library.Screens.DMILoginPage.passwordField, "Password123.");
            Library.Actions.Click.button(driver, Library.Screens.DMILoginPage.loginButton);
        }
    }
}
