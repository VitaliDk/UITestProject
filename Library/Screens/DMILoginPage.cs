using OpenQA.Selenium;


namespace Library.Screens
{
    public class DMILoginPage
    {
        public static By usernameField = By.Id("Username");
        public static By passwordField = By.Id("Password");

        public static By loginButton = By.Name("button");
        public static By submitButton = By.Name("button");

        public static By forgotPasswordLink = By.PartialLinkText("Forgot Password");

        public static By invalidLoginAttemptMessage = By.ClassName("validation-summary-errors");
    }
}
