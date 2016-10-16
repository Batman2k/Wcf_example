using System;

namespace WcfExample.Models
{
    public class ContactInformation
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public string PhoneNumber { get; set; }

        public string EmailAdress { get; set; }

        public string StreetName { get; set; }

        public string City { get; set; }

        public string ZipCode { get; set; }

        public string Country { get; set; }

    }
}