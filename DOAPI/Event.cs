using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalOcean;
using DigitalOcean.Structs;
using RestSharp;

namespace DigitalOcean
{
    public partial class DOClient
    {
        public virtual EventInfo GetEvent(int event_id)
        {
            var request = new RestRequest();
            request.Resource = "events/" + event_id + "/";
            return Execute<EventInfo>(request);
        }
    }
}
