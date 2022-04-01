using Atata;
using NUnit.Framework;

namespace Mistal.FixtureReusingDriver
{
    public class SmokeTestRegistration : UITestFixture
    {
        [Test]
        public void Register_Page_Required_First_Name_Field_Validation()
        {
            Pages.RegisterPage()
                .LastName.SetRandom()
                .Registration.Click()
                .FirstNameError.Should.Equals("First name is required.");                
        }

        [Test]
        public void Register_Page_Required_Last_Name_Field_Validation()
        {
            Pages.RegisterPage()
                .FirstName.SetRandom()
                .Registration.Click()
                .LastNameError.Should.Equals("Last name is required.");

        }

        [Test]
        public void Register_Page_Required_Email_Field_Validation()
        {
            Pages.RegisterPage()
                .FirstName.SetRandom()
                .LastName.SetRandom()
                .Registration.Click()
                .EmailError.Should.Equals("Email is required.");
        }

        [Test]
        public void Register_Page_Required_Password_Field_Validation()
        {
            Pages.RegisterPage()
                .FirstName.SetRandom()
                .LastName.SetRandom()
                .Email.Set("user@mail.com")
                .Registration.Click()
                .EmailError.Should.Equals("Password is required.");
        }

        [Test]
        public void Register_Page_Required_Confirm_Password_Field_Validation()
        {
            Pages.RegisterPage()
                .FirstName.SetRandom()
                .LastName.SetRandom()
                .Email.Set("user@mail.com")
                .Password.SetRandom()
                .Registration.Click()
                .EmailError.Should.Equals("Confirm password is required.");
        }

        [Test]
        public void Register_Page_Field_Passwords_Match_Validation()
        {
            Pages.RegisterPage()
                .FirstName.SetRandom()
                .LastName.SetRandom()
                .Email.Set("user@mail.com")
                .Password.SetRandom()
                .Confirm_Password.SetRandom()
                .Registration.Click()
                .PasswordsMatch.Should.Equals("The password and confirmation password do not match.");
        }

        [Test]
        public void Register_Page_Success_Registration()
        {
            Pages.RegisterPage()
                .FirstName.Set("Basic1")
                .LastName.Set("User")
                .Email.Set("basic1_user@mail.com")
                .Password.Set("user123!")
                .Confirm_Password.Set("user123!")
                .Registration.Click();
        }
    }
}
