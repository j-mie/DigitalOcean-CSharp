using System;
using DigitalOcean;
using DigitalOcean.Structs;
using RestSharp;

namespace DigitalOcean
{
    public partial class DOClient
    {
        public virtual Droplets GetDroplets()
        {
            var request = new RestRequest();
            request.Resource = "droplets/";
            Console.WriteLine(request);
            return Execute<Droplets>(request);
        }

        public virtual DropletCreateReturn MakeDroplet()
        {
            return null;
        }

    }
}
