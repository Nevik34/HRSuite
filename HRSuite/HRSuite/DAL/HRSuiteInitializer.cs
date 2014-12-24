﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HRSuite.Models;

namespace HRSuite.DAL
{
    public class EmployeeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
            var EmployeesInfo = new List<EmployeeInfo>
            {
            new EmployeeInfo{FirstName="Carson",LastName="Alexander",Dob=DateTime.Parse("2005-09-01"), Address = "", Gender = "M", MiddleName = "", PhoneNumber = "888-800-8135", SSN = "123-45-6789"},
            new EmployeeInfo{FirstName="Meredith",LastName="Alonso",Dob=DateTime.Parse("2002-09-01"), Address = "", Gender = "M", MiddleName = "", PhoneNumber = "888-800-8135", SSN = "123-45-6789"},
            new EmployeeInfo{FirstName="Arturo",LastName="Anand",Dob=DateTime.Parse("2003-09-01"), Address = "", Gender = "M", MiddleName = "", PhoneNumber = "888-800-8135", SSN = "123-45-6789"},
            new EmployeeInfo{FirstName="Gytis",LastName="Barzdukas",Dob=DateTime.Parse("2002-09-01"), Address = "", Gender = "M", MiddleName = "", PhoneNumber = "888-800-8135", SSN = "123-45-6789"},
            new EmployeeInfo{FirstName="Yan",LastName="Li",Dob=DateTime.Parse("2002-09-01"), Address = "", Gender = "M", MiddleName = "", PhoneNumber = "888-800-8135", SSN = "123-45-6789"},
            new EmployeeInfo{FirstName="Peggy",LastName="Justice",Dob=DateTime.Parse("2001-09-01"), Address = "", Gender = "M", MiddleName = "", PhoneNumber = "888-800-8135", SSN = "123-45-6789"},
            new EmployeeInfo{FirstName="Laura",LastName="Norman",Dob=DateTime.Parse("2003-09-01"), Address = "", Gender = "M", MiddleName = "", PhoneNumber = "888-800-8135", SSN = "123-45-6789"},
            new EmployeeInfo{FirstName="Nino",LastName="Olivetto",Dob=DateTime.Parse("2005-09-01"), Address = "", Gender = "M", MiddleName = "", PhoneNumber = "888-800-8135", SSN = "123-45-6789"}
            };

            EmployeesInfo.ForEach(ei => context.EmployeeInfo.Add(ei));
            context.SaveChanges();
        }
    }
}