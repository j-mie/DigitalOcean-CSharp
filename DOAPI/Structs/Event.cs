using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalOcean.Structs
{
    public class Event
    {
        public string status { get; private set; }
        public int event_id { get; private set; }
    }

    /// <summary>
    /// This is returned from most deletion events and only has one attribute: status
    /// </summary>
    public class InstantEvent
    {
        public string status { get; private set; }
    }
}
