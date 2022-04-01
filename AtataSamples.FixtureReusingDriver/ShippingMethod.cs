using Atata;

namespace Mistal.FixtureReusingDriver
{
    using _ = ShippingMethod;

    [Url(GlobalConstants.Links.ShippingMethodPage)]
    [VerifyH2("Shipping method")]

    public class ShippingMethod : Page<_>
    {
        [FindByName("save")]
        public Button<_> Save { get; private set; } 
        
        [FindById("shippingoption_0")]
        public RadioButton<_> Ground { get; private set; } 
        
        [FindById("shippingoption_1")]
        public RadioButton<_> NextDayAir { get; private set; }  
        
        [FindById("shippingoption_2")]
        public RadioButton<_> TwoDayAir { get; private set; }

        [FindByClass("button-1 shipping-method-next-step-button")]
        public Button<_> Continue { get; private set; }

        [FindById("shopping-cart-form")]
        public Text<_> OrderContent { get; private set; }

        [FindByClass("button-1 payment-info-next-step-button")]
        public Button<CompleteOrderPage, _> CompleteOrder { get; private set; }

        [FindById("paymentmethod_0")]
        public RadioButton<_> CheckMoneyOrder { get; private set; }
        
        [FindById("paymentmethod_1")]
        public RadioButton<_> CreditCard { get; private set; }

        [FindById("CardholderName")]
        public TextInput<_> CreditName { get; private set; }

        [FindById("CardNumber")]
        public TextInput<_> CardNumber { get; private set; } 
        
        [FindById("CardCode")]
        public TextInput<_> CardCode { get; private set; }

        [FindById("ExpireMonth")]
        public Select<_> ExpirationDate { get; private set; }
        
        [FindByClass("button-1 confirm-order-next-step-button")]
        public Button<CompleteOrderPage,_> ConfirmOrder { get; private set; }

        
    }
}
