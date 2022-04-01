using Atata;

namespace Mistal.FixtureReusingDriver
{
    using _ = ItemDetailsPage;

    [Url(GlobalConstants.Links.SpecificItem)]
    [VerifyH1("HTC One Mini Blue")]
    public class ItemDetailsPage : Page<_>
    {
        
        [FindByTitle("Show details for HTC One Mini Blue")]
        public Button<_> ItemLink { get; private set; }

        [FindById("add-to-cart-button-19")]
        public Button<_> CartButton { get; private set; }


    }
}
