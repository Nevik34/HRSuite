using System;
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
            var employeesInfo = new List<EmployeeInfo>
            {
            new EmployeeInfo{FirstName="Carson",LastName="Alexander",Dob=DateTime.Parse("2005-09-01"), Address = "", Gender = Gender.M, MiddleName = "", PhoneNumber = "888-800-8135", SSN = "123-45-6789"},
            new EmployeeInfo{FirstName="Meredith",LastName="Alonso",Dob=DateTime.Parse("2002-09-01"), Address = "", Gender = Gender.M, MiddleName = "", PhoneNumber = "888-800-8135", SSN = "123-45-6789"},
            new EmployeeInfo{FirstName="Arturo",LastName="Anand",Dob=DateTime.Parse("2003-09-01"), Address = "", Gender = Gender.M, MiddleName = "", PhoneNumber = "888-800-8135", SSN = "123-45-6789"},
            new EmployeeInfo{FirstName="Gytis",LastName="Barzdukas",Dob=DateTime.Parse("2002-09-01"), Address = "", Gender = Gender.M, MiddleName = "", PhoneNumber = "888-800-8135", SSN = "123-45-6789"},
            new EmployeeInfo{FirstName="Yan",LastName="Li",Dob=DateTime.Parse("2002-09-01"), Address = "", Gender = Gender.M, MiddleName = "", PhoneNumber = "888-800-8135", SSN = "123-45-6789"},
            new EmployeeInfo{FirstName="Peggy",LastName="Justice",Dob=DateTime.Parse("2001-09-01"), Address = "", Gender = Gender.M, MiddleName = "", PhoneNumber = "888-800-8135", SSN = "123-45-6789"},
            new EmployeeInfo{FirstName="Laura",LastName="Norman",Dob=DateTime.Parse("2003-09-01"), Address = "", Gender = Gender.M, MiddleName = "", PhoneNumber = "888-800-8135", SSN = "123-45-6789"},
            new EmployeeInfo{FirstName="Nino",LastName="Olivetto",Dob=DateTime.Parse("2005-09-01"), Address = "", Gender = Gender.M, MiddleName = "", PhoneNumber = "888-800-8135", SSN = "123-45-6789"}
            };

            employeesInfo.ForEach(ei => context.EmployeeInfo.Add(ei));
            context.SaveChanges();

            var role = new List<Role>
            {
                new Role{Name = "Software Engineer", Level = 2, Manager = false},
                new Role{Name = "Software Engineer", Level = 1, Manager = false},
                new Role{Name = "Software Engineer", Level = 3, Manager = true},
                new Role{Name = "Accountant", Level = 1, Manager = false}
            };

            role.ForEach(r => context.Roles.Add(r));
            context.SaveChanges();

            //This seems backwards, which is why I'm questioning my approach overall to how we're creating these things
            //Is is backward. 
            //var employees = new List<Employee>
            //{
            //    new Employee{EmployeeID= 1},
            //    new Employee{EmployeeID=2},
            //    new Employee{EmployeeID=3},
            //    new Employee{EmployeeID=4},
            //    new Employee{EmployeeID=5},
            //    new Employee{EmployeeID=6},
            //    new Employee{EmployeeID=7},
            //    new Employee{EmployeeID=8}
            //};

            //employees.ForEach(e => context.Employees.Add(e));
            //context.SaveChanges();
        }
    }
}