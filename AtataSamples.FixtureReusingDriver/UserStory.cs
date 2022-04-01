using Atata;
using NUnit.Framework;

namespace Mistal.FixtureReusingDriver
{
    public class UserStory : UITestFixture
    {
        protected override bool ReuseDriver => false;

        [SetUp]
        public void Login()
        {
            Pages.Login_Page()
                 .Email.Set("basic1_user@mail.com")
                 .Password.Set("user123!")
                 .Login.Click();
        }

        [Test]
        public void Home_Page_Search_Using_First_Characters_Of_Name()
        {
            Pages.HomePage()
            .Search.Set("htc")
            .SearchButton.ClickAndGo(); 

        }

        [Test]
        public void Home_Page_Search_Using_Last_Characters_Of_Name()
        {
            Pages.HomePage()
            .Search.Set("blue")
            .SearchButton.ClickAndGo();
            
        }

        [Test]
        public void Home_Page_Search_Using_Mean_Characters_Of_Name()
        {
            Pages.HomePage()
            .Search.Set("mini")
            .SearchButton.ClickAndGo();

        }

        [Test]
        public void Navigate_To_Item_Details_Page()
        {
            Pages.HomePage()
            .Search.Set("HTC One Mini Blue")
            .SearchButton.ClickAndGo()
            .ItemLink.ClickAndGo();

        }

        [Test]
        public void Add_Item_To_Cart_From_Search_Details_Page()
        {
            Pages.HomePage()
            .Search.Set("HTC One Mini Blue")
            .SearchButton.ClickAndGo()
            .CartButton.Click()
            .SuccessPopup.Should.BeVisible();

        }

        [Test]
        public void Navigate_To_Shopping_Chart()
        {
            Pages.HomePage()
             .ShoppingCart.ClickAndGo()
             .ShoppingCartConent.Should.BeVisible();

        }

        [Test]
        public void Verify_Quantity_Validation_From_Shopping_Chart()
        {
            Pages.ShoppingCartPage()
             .ShoppingCartConent.Should.BeVisible()
             .Qty.Set("20")
             .UpdateCart.Click()
             .Qty.SetRandom()
             .UpdateCart.Click()
             .Qty.Should.Equals("20");

        }

        [Test]
        public void Verify_Content_Totals_Is_Visible_From_Shopping_Chart()
        {
            Pages.ShoppingCartPage()
             .TotalsContent.Should.BeVisible();

        }

        [Test]
        public void Policy_Term_Should_Be_Checked()
        {
            Pages.ShoppingCartPage()
             .TermOfService.Should.BeVisible()
             .TermOfService.Click();

        }

        [Test]
        public void Policy_Term_Should_Be_Required()
        {
            Pages.ShoppingCartPage()
             .TermOfService.Should.BeVisible()
             .CheckOut.Click()
             .RequiredPopup.Should.BeVisible();

        }

        [Test]
        public void Billing_Field_Last_Name_Should_Be_Required()
        {
            Pages.CheckOutPage()
             .LastName.Set("")
             .Country.Set(CheckOutPage.Countries.Afghanistan)
             .Save.Click()
             .LastNameError.Should.Equals("Last name is required.");

        }
        // Before run this test, the User must have item on the Cart
        [Test]
        public void Billing_Fields_Success_Edited()
        {
            Pages.CheckOutPage()
             .Country.Set(CheckOutPage.Countries.Afghanistan)
             .City.SetRandom()
             .Address.SetRandom()
             .ZipCode.SetRandom()
             //.Phone.Set("000000"); I dont know whay it selector doesn't work
             .Save.ClickAndGo();
        }

        //Before run this test, the User must setup Billing informations
        [Test]
        public void Shipping_Methods_Should_Be_Clickable()
        {
            Pages.ShippingMethod()
              .Save.Click()
              .Ground.Click()
              .NextDayAir.Click()
              .TwoDayAir.Click();
        }

        [Test]
        public void Shipping_Method_NextDayAir_Should_Be_Selected()
        {
            Pages.ShippingMethod()
              .Save.Click()
              .NextDayAir.Click()
              .Continue.Click();
        }

        [Test]
        public void Payment_Methods_Should_Be_Clickable()
        {
            Pages.ShippingMethod()
              .Save.Click()
              .Continue.Click()
              .CheckMoneyOrder.Click()
              .CreditCard.Click()
              .Save.Click();
        }
        
        [Test]
        public void Payment_Information_Should_Be_Editable()
        {
            Pages.ShippingMethod()
              .Save.Click()
              .Continue.Click()
              .Save.Click()
              .CreditName.Set("Test Credit Card")
              .CardNumber.Set("4242424242424242")
              .ExpirationDate.Set("05")
              .CardCode.Set("123");
        }

        [Test]
        public void Order_Completed()
        {
            Pages.ShippingMethod()
              .Save.Click()
              .Continue.Click()
              .Save.Click()
              .CreditName.Set("Test Credit Card")
              .CardNumber.Set("4242424242424242")
              .ExpirationDate.Set("05")
              .CardCode.Set("123")
              .CompleteOrder.Click()
              .OrderContent.Should.BeVisible()
              .ConfirmOrder.ClickAndGo();
        }


    }
}
