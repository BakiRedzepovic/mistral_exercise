using Atata;
using NUnit.Framework;

namespace Mistal.FixtureReusingDriver
{
    public class SmokeTestLogin : UITestFixture
    {
        [Test]
        public void Login_Page_Success_Login_in()
        {
            Pages.Login_Page()
                .Email.Set("basic_user@mail.com")
                .Password.Set("user123!")
                .Login.Click();

        }

        [Test]
        public void Login_Page_Email_Should_Alert_If_Invalid()
        {
            Pages.Login_Page()
                .Email.SetRandom()
                .Password.SetRandom()
                .Login.Click()
                .EmailError.Should.Equals("Wrong email");
        }


        [Test]
        public void Login_Page_Password_Should_Alert_If_Invalid()
        {
            Pages.Login_Page()
                .Email.Set("bakir@mail.com")
                .Password.SetRandom()
                .Login.Click()
                .GeneralError.Should.Equals("Login was unsuccessful. Please correct the errors and try again.");
        }

        [Test]
        public void Login_Page_Required_Fields_Validation()
        {
            Pages.Login_Page()
                .Login.Click()
                .EmailError.Should.Equals("Please enter your email");
        }

        //[Test]
        //public void LoginPage_Should_Validate_Properly()
        //{
        //    Pages.LoginPage()
        //        .SignIn.Click()
        //        .Email.ValidationMessage.Should.BeRequired()
        //        .Password.ValidationMessage.Should.BeRequired()
        //        .Email.Set("!")
        //        .Email.ValidationMessage.Should.HaveMinLength(5);
        //}



        //[Test]
        //public void LoginPage_Logout_Should_Work()
        //{
        //    LoginHelpers.LoginAsTenantManagementAdministrator();
        //    Pages.Home()
        //        .Menu.Account.SignOut();
        //}



        //[Test]
        //public void Login_As_Registred_User()
        //{
        //    Pages.LoginPage()
        //        .Email.Set(AtataConfig.Current?.Account.Email)
        //        .Password.Set(AtataConfig.Current?.Account.Password)
        //        .SignIn().Title.Should.BeVisible();
        //}






    }








}
