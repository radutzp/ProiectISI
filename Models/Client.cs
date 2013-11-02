using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProiectISI.Models
{
    public class Client
    {
        public int ClientID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}
