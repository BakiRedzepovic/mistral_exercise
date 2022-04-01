using Atata;

namespace Mistal.FixtureReusingDriver
{
    using _ = ShoppingCartPage;

    [Url(GlobalConstants.Links.CartPage)]
    [VerifyH1(GlobalConstants.Titles.ShoppingCart)]
    public class ShoppingCartPage : Page<_>
    {
        [FindById("shopping-cart-form")]
        public Button<_> ShoppingCartConent { get; private set; }
        
        [FindByClass("totals")]
        public Button<_> TotalsContent { get; private set; }
        
        [FindById("updatecart")]
        public Button<_> UpdateCart { get; private set; }

        [FindByClass("qty-input")]
        public TextInput<_> Qty { get; private set; }

        [FindById("termsofservice")]
        public CheckBox<_> TermOfService { get; private set; }
        
        [FindById("checkout")]
        public Button<CheckOutPage,_> CheckOut { get; private set; }
        
        [FindById("ui-id-2")]
        public Text<_> RequiredPopup { get; private set; }
    }
}
