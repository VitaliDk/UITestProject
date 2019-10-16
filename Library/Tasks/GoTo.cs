using Library.Actions;
using Library.Screens;
using OpenQA.Selenium;

namespace Library.Tasks
{
    public class GoTo
    {
        public static void DMILoginPage(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://dmiqa3.calastonetest.com/dmi");
        }

        public static void OrdersPage(IWebDriver driver)
        {
            Click.link(driver, DMIDashboardPage.ordersLink);
        }

        public static void SettlementsPage(IWebDriver driver)
        {
            Click.link(driver, DMIDashboardPage.settlementsLink);
        }

        public static void BalancesPage(IWebDriver driver)
        {
            Click.link(driver, DMIDashboardPage.balancesLink);
        }

        public static void RegisterPage(IWebDriver driver)
        {
            Click.link(driver, DMIDashboardPage.registerLink);
        }

    }
}
