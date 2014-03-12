using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DigitalOcean.Structs
{
    public class EventPointer
    {
        public string status { get; private set; }
        public int event_id { get; private set; }
    }

    public class EventInfo
    {
        public string status { get; set; }
        public Event @event { get; set; }
    }

    public class Event
    {
        public int id { get; set; }
        public string action_status { get; set; }
        public int droplet_id { get; set; }
        public int event_type_id { get; set; }
        public string percentage { get; set; }
        private DOClient _doClient;

        public void onComplete(object callback)
        {
            
        }

        public void updateEvent()
        {
            
        }
    }

    /// <summary>
    /// This is returned from most deletion events and only has one attribute: status
    /// </summary>
    public class InstantEvent
    {
        public string status { get; private set; }
    }
}
