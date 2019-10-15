using Library.Actions;
using Library.Screens;
using OpenQA.Selenium;

namespace Library.Tasks
{
    public class GoTo
    {
        public static void OrdersPage(IWebDriver driver)
        {
            driver.FindElement(DMIDashboardPage.ordersLink).Click();
        }
        public static void SettlementsPage(IWebDriver driver)
        {
            driver.FindElement(DMIDashboardPage.settlementsLink).Click();
        }
        public static void BalancesPage(IWebDriver driver)
        {
            driver.FindElement(DMIDashboardPage.balancesLink).Click();
        }
        public static void RegisterPage(IWebDriver driver)
        {
            driver.FindElement(DMIDashboardPage.registerLink).Click();
        }

    }
}
