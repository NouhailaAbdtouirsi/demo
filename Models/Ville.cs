using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class Ville
    {
        public Int32 VilleId { get; set; }
        public String VilleName { get; set; }
        public Int32 RegionId { get; set; }
        public int Population { get; set; }
    }
}