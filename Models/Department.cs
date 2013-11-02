using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProiectISI.Models
{
    public class Department
    {
        public int DepartamentID { get; set; }

        public string Name { get; set; }

        public int DivisionID { get; set; }

        public virtual Division Division { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}