using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class Region
    {
        public Int32 RegionId { get; set; }
        public String RegionName { get; set; }
        public IList<Ville> VillesListe { get; set; }
    }
}