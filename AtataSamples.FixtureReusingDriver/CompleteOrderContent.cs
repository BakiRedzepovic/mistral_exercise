using Atata;

namespace Mistal.FixtureReusingDriver
{
    using _ = CompleteOrderPage;

    [Url(GlobalConstants.Links.CompleteOrderPage)]
    [VerifyH1("Thank you")]
    public class CompleteOrderPage : Page<_>
    {

    }
}
