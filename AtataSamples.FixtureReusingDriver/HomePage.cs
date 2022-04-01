using Atata;

namespace Mistal.FixtureReusingDriver
{
    using _ = HomePage;

    [Url(GlobalConstants.Links.HomePage)]
    [VerifyH2(GlobalConstants.Titles.Home)]
    public class HomePage : Page<_>
    {
        [FindById("small-searchterms")]
        public TextInput<_> Search { get; private set; }

        [FindByClass("button-1 search-box-button")]
        public Button<SearchPage,_> SearchButton { get; private set; }
        
        [FindById("topcartlink")]
        public Link<ShoppingCartPage,_> ShoppingCart { get; private set; }
    }
}
