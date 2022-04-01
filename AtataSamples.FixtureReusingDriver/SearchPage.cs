using Atata;

namespace Mistal.FixtureReusingDriver
{
    using _ = SearchPage;

    [Url(GlobalConstants.Links.SearchPage)]
    [VerifyH1("Search")]
    [VerifyH2("HTC One Mini Blue")]
    public class SearchPage : Page<_>
    {
        [FindByClass("product-title")]
        public Button<_> ProductItem { get; private set; } 
        
        [FindByTitle("Show details for HTC One Mini Blue")]
        public Link<ItemDetailsPage,_> ItemLink { get; private set; }

        [FindByClass("button-2 product-box-add-to-cart-button")]
        public Button<ItemDetailsPage, _> CartButton { get; private set; }
        
        [FindById("bar-notification")]
        public Text<_> SuccessPopup { get; private set; }
    }
}
