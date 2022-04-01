using Atata;

namespace Mistal.FixtureReusingDriver
{
    using _ = CheckOutPage;

    [Url(GlobalConstants.Links.CheckOutPageBilling)]

    public class CheckOutPage : Page<_>
    {
       
        [FindById("BillingNewAddress_FirstName")]
        public TextInput<_> FirstName { get; private set; } 
        
        [FindById("BillingNewAddress_LastName")]
        public TextInput<_> LastName { get; private set; }  
        
        [FindByClass("field-validation-error")]
        public TextArea<_> LastNameError { get; private set; } 
        
        [FindById("BillingNewAddress_Email")]
        public EmailInput<_> Email { get; private set; } 
        
        [FindById("BillingNewAddress_Email-error")]
        public Text<_> EmailError { get; private set; } 
        
        [FindById("BillingNewAddress_CountryId")]
        public Select<Countries,_> Country { get; private set; }

        [FindByClass("field-validation-error")]
        public Select<int,_> CountryError { get; private set; }

        [FindById("BillingNewAddress_City")]
        public TextInput<_> City { get; private set; }
        
        [FindById("BillingNewAddress_Address1")]
        public TextInput<_> Address { get; private set; }
        

        [FindById("BillingNewAddress_ZipPostalCode")]
        public TextInput<_> ZipCode { get; private set; }

        [FindById("BillingNewAddress_PhoneNumber")]
        public TextInput<_> Phone { get; private set; }

        [FindById("billing-buttons-container")]
        public Button<ShippingMethod,_> Save { get; private set; }

        public enum Countries
        {
            [Term("Select country")]
            Angola,
            Afghanistan,
            Albania,
            Algeria,
            Belgium
        }
    }
}
