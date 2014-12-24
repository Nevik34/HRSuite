﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRSuite.Models
{
    public class Role
    {
        public int RoleID { get; set; }
        public int Name { get; set; }
        public bool Manager { get; set; }
        public string Level { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}