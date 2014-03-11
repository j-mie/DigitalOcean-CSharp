using System.Collections.Generic;

namespace DigitalOcean.Structs
{
    public class Droplet
    {
        public int id { get; set; }
        public int image_id { get; set; }
        public string name { get; set; }
        public int region_id { get; set; }
        public int size_id { get; set; }
        public bool backups_active { get; set; } 
        public List<object> backups { get; set; } //extended
        public List<object> snapshots { get; set; } //extended
        public string ip_address { get; set; }
        public object private_ip_address { get; set; }
        public bool locked { get; set; }
        public string status { get; set; }
        public string created_at { get; set; }
    }

    public class Droplets
    {
        public string status { get; set; }
        public List<Droplet> droplets { get; set; }
    }
}