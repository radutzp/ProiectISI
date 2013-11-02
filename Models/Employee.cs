using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ProiectISI.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int DepartmentID { get; set; }

        public virtual Department Department { get; set; }

        public int JobID { get; set; }

        public virtual Job Job { get; set; } 
    }
}