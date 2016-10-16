using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Build.Framework;

namespace WcfExample.Models
{
    public class Job
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public decimal Price { get; set; }

        public User CreatedByUser { get; set; }

        [Required]
        public string CreatedByUserId { get; set; }

        public string AssignedCompany { get; set; }

        public string AssignedCleaner { get; set; }

        public DateTime Created { get; set; }

        public DateTime ForDateTime { get; set; }

        public DateTime Confrimed { get; set; }

        public bool IsDeleted { get; private set; }

        public void DeleteJob()
        {
            this.IsDeleted = true;
        }
    }
}