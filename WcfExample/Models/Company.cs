using System;

namespace WcfExample.Models
{
    public class Company
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool HasRut { get; set; }

        public string Description { get; set; }

        public User Owner { get; set; }

        public string UserId { get; set; }

        public bool IsDeleted { get; private set; }

        public void DeleteCompany()
        {
            IsDeleted = true;
        }   
    }

}