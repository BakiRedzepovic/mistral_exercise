using Atata;

namespace Mistal.FixtureReusingDriver
{
    using _ = RegisterPage;

    [Url(GlobalConstants.Links.RegisterPage)]
    [VerifyH1(GlobalConstants.Titles.Register)]
    public class RegisterPage : Page<_>
    {

        [FindById("FirstName")]
        public TextInput<_> FirstName { get; private set; }

        [FindById("LastName")]
        public TextInput<_> LastName { get; private set; }

        [FindByName("DateOfBirthDay")]
        public Content<System.DateTime?, _> Day { get; private set; }

        [FindByName("DateOfBirthDay")]
        public Content<System.DateTime?, _> Month { get; private set; }

        [FindByName("DateOfBirthDay")]
        public Content<System.DateTime?, _> Year{ get; private set; }

        [FindById("Email")]
        public EmailInput<_> Email { get; private set; }

        [FindById("Company")]
        public TextInput<_> Commpany_Name { get; private set; }

        [FindById("Newsletter")]
        public CheckBox<_> Newsletter { get; private set; }

        [FindById("Password")]
        public PasswordInput<_> Password { get; private set; }

        [FindById("ConfirmPassword")]
        public PasswordInput<_> Confirm_Password { get; private set; }

        [FindById("register-button")]
        public Button<_> Registration { get; private set; }

        [FindById("FirstName-error")]
        public TextArea<_> FirstNameError { get; private set; }

        [FindById("LastName-error")]
        public TextArea<_> LastNameError { get; private set; }

        [FindById("Email-error")]
        public TextArea<_> EmailError { get; private set; }

        [FindById("Password-error")]
        public TextArea<_> PasswordError { get; private set; }

        [FindById("ConfirmPassword-error")]
        public TextArea<_> ConfirmPasswordError { get; private set; }
        
        [FindById("ConfirmPassword-error")]
        public TextArea<_> PasswordsMatch { get; private set; }

    }
}
