using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CraigslistClone.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StateId { get; set; }

        public virtual State State { get; set; }
    }
}