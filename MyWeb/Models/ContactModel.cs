using System.Collections.Generic;

namespace MyWebApp.Models
{
    public class Contact
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }
        public IList<string> PhoneNumbers { get; set; }
    }

    public class ContactPageModel
    {
        public string TeamName { get; set; }
        public Contact Contact { get; set; }
        public IList<EmailAddress> EmailAddresses { get; set; }
    }

    public class EmailAddress
    {
        public string DepartmentName { get; set; }
        public string Email { get; set; }
    }
}
