using OpenQA.Selenium;
using Library.Actions;

namespace Library.Tasks
{
    public class LoginTo2
    {
        public static void DMI(IWebDriver driver)
        {
            Enter2.into(Screens.DMILoginPage2.usernameField, "qa1");
            Enter2.into(Screens.DMILoginPage2.passwordField, "Password123.");
            Click2.button(Screens.DMILoginPage2.loginButton);
        }
    }
}
