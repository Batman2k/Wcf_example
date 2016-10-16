using System;
using WcfExample.Enums;

namespace WcfExample.Models
{
    public class User
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public AccountType AccountType { get; set; }

        public ContactInformation ContactInformation { get; set; }

        public string ContactInformationId { get; set; }

        public bool IsDeleted { get; set; }

        public void DeleteUser()
        {
            IsDeleted = true;
        }
    }
}