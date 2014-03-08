using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalOcean.Structs
{
        public class GetDropletReturn
        {
            public int id { get; set; }
            public string name { get; set; }
            public int image_id { get; set; }
            public int size_id { get; set; }
            public int region_id { get; set; }
            public bool backups_active { get; set; }
            public string ip_address { get; set; }
            public object private_ip_address { get; set; }
            public bool locked { get; set; }
            public string status { get; set; }
            public string created_at { get; set; }
        }

        public class GetDroplestReturn
        {
            public string status { get; set; }
            public List<DropletCreateReturn> droplets { get; set; }
        }
}
