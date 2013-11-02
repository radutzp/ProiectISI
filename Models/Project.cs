using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProiectISI.Models
{
    public class Project
    {
        public int ProjectID { get; set; }

        public string Name { get; set; }

        public int ClientID { get; set; }

        public virtual Client Client { get; set; }

        public virtual ICollection<Activity> Activities { get; set; }
    }
}