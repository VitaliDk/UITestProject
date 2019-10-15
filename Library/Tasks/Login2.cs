using OpenQA.Selenium;

namespace Library.Tasks
{
    public class LoginTo2
    {
        public static void DMI(IWebDriver driver)
        {
            Library.Actions.Enter2.into(Screens.DMILoginPage2.usernameField, "qa1");
            Library.Actions.Enter2.into(Screens.DMILoginPage2.passwordField, "Password123.");
            Library.Actions.Click2.button(Screens.DMILoginPage2.loginButton);
        }
    }
}
