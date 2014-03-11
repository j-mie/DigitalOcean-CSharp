using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalOcean.Structs
{
    public class Region
    {
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
    }

    public class Regions
    {
        public string status { get; set; }
        public List<Region> regions { get; set; }
    }
}
