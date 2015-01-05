using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRSuite.Models
{
    public enum Gender
    {
        M, F
    }
    
    public class EmployeeInfo
    {
        public int EmployeeInfoId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Dob { get; set; }
        public Gender? Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string SSN { get; set; }

        public virtual ICollection<Role> Roles { get; set; }

        public EmployeeInfo()
        {
            Roles = new HashSet<Role>();
        }
    }
}