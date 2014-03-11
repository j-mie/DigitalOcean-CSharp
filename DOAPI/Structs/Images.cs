using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalOcean.Structs
{
    public class Image
    {
        public int id { get; set; }
        public string name { get; set; }
        public string distribution { get; set; }
        public string slug { get; set; }
        public bool @public { get; set; }
    }

    public class Images
    {
        public string status { get; set; }
        public List<Image> images { get; set; }
    }
}
