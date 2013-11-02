using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProiectISI.Models
{
    public class Division
    {
        public int DivisionID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Department> Departaments { get; set; }
    }
}
