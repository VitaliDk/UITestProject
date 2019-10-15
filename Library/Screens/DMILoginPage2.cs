using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace Library.Screens
{
    public class DMILoginPage2
    {
        [FindsBy(How = How.Name, Using = "button")]
        public static IWebElement loginButton { get; set; }

        [FindsBy(How = How.Id, Using = "Username")]
        public static IWebElement usernameField { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public static IWebElement passwordField { get; set; }

    }
}
