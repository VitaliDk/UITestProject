using OpenQA.Selenium;

namespace Library.Screens
{
    public class DMINavBar
    {
        public static By ordersLink = DMINavBar.ordersWebLink;
        public static By settlementsLink = DMINavBar.settlementsWebLink;
        public static By balancesLink = DMINavBar.balancesWebLink;
        public static By registerLink = DMINavBar.registerWebLink;

        public static By ordersWebLink = By.LinkText("Orders");
        public static By settlementsWebLink = By.LinkText("Settlements");
        public static By balancesWebLink = By.LinkText("Balances");
        public static By registerWebLink = By.LinkText("Register");
    }
}
