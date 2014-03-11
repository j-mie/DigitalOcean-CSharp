using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalOcean.Structs
{
    public class Size
    {
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
    }

    public class Sizes
    {
        public string status { get; set; }
        public List<Size> sizes { get; set; }
    }
}
