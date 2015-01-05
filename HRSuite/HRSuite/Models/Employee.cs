using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRSuite.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public virtual EmployeeInfo EmployeeInfo { get; set; }
        public virtual ICollection<Role> Roles { get; set; }

        public Employee()
        {
            Roles = new HashSet<Role>();
        }
    }
}