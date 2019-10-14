using OpenQA.Selenium;

namespace Library.Screens
{
    class DMIDashboardPage
    {

        public static By ordersLink = DMINavBar.ordersWebLink;
        public static By settlementsLink = DMINavBar.settlementsWebLink;
        public static By balancesLink = DMINavBar.balancesWebLink;
        public static By registerLink = DMINavBar.registerWebLink;

        public static By dmiOrderIdSearchField = By.Id("dx-col-1");
        public static By sendingPartySearchField = By.Id("dx-col-2");
        public static By receivingPartySearchField = By.Id("dx-col-3");
        public static By tpaSearchField = By.Id("dx-col-4");
        public static By createdDateTimeSearchField = By.Id("dx-col-5");
        public static By modifiedDateTimeSearchField = By.Id("dx-col-6");
        public static By orderReferenceSearchField = By.Id("dx-col-7");
        public static By dealReferenceSearchField = By.Id("dx-col-8");
        public static By isinSearchField = By.Id("dx-col-9");
        public static By accountSearchField = By.Id("dx-col-10");
        public static By transactionTypeSearchField = By.Id("dx-col-11");
        public static By orderedAmountSearchField = By.Id("dx-col-12");
        public static By orderedUnitsSearchField = By.Id("dx-col-13");
        public static By confirmedUnitsSearchField = By.Id("dx-col-14");
        public static By settlementAmountSearchField = By.Id("dx-col-15");
        public static By settlementDateSearchField = By.Id("dx-col-16");
        public static By statusSearchField = By.Id("dx-col-17");

    }
}
