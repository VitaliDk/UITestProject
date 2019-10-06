using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace Library.Screens
{
    public class DMILoginPage
    {
        public static By usernameField = By.Id("Username");
        public static By passwordField = By.Id("Password");
        //public static By loginButton = By.Name("button");
        [FindsBy(How = How.Name, Using = "button")]
        public IWebElement loginButton { get; set;} 
    }
}
