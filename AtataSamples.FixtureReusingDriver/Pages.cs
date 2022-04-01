using Atata;

namespace Mistal.FixtureReusingDriver
{
    public static partial class Pages 
    {
        public static SignInPage Login_Page() => Go.To<SignInPage>();
        public static HomePage HomePage() => Go.To<HomePage>();
        public static RegisterPage RegisterPage() => Go.To<RegisterPage>();
        public static SearchPage SearchPage() => Go.To<SearchPage>();
        public static ShoppingCartPage ShoppingCartPage() => Go.To<ShoppingCartPage>();
        public static CheckOutPage CheckOutPage() => Go.To<CheckOutPage>();
        public static ShippingMethod ShippingMethod() => Go.To<ShippingMethod>();
        public static CompleteOrderPage CompleteOrderPage() => Go.To<CompleteOrderPage>();
    }
}
