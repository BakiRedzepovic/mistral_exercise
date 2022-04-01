using Atata;

namespace Mistal.FixtureReusingDriver
{
    using _ = SignInPage;

    [Url(GlobalConstants.Links.LoginPage)]
    [VerifyH1(GlobalConstants.Titles.SignIn)] 
    public class SignInPage : Page<_>
    {
        [FindById(Constants.LoginComponents.Email)]
        public EmailInput<_> Email { get; private set; }

        [FindById(Constants.LoginComponents.Pasword)]
        public PasswordInput<_> Password { get; private set; }

        [FindById(Constants.LoginComponents.RememberMe)]
        public CheckBox<_> RememberMe { get; private set; }

        [FindByClass(Constants.LoginComponents.LoginButton)]
        public Button<_> Login { get; private set; } 
        
        [FindById(Constants.LoginComponents.EmailError)]
        public Button<_> EmailError { get; private set; }

        [FindByClass(Constants.LoginComponents.GeneralError)]
        public Button<_> GeneralError { get; private set; }
    }
}
