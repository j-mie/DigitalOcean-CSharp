using DigitalOcean;
using DigitalOcean.Structs;
using RestSharp;

namespace DigitalOcean
{
    public partial class DOClient
    {
        public virtual GetDropletReturn GetDroplets()
        {
            var request = new RestRequest();
            request.Resource = "droplets/";
			return Execute<GetDropletReturn>(request);
        }

        public virtual DropletCreateReturn MakeDroplet()
        {
            return null;
        }

    }
}
