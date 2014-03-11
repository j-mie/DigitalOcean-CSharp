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
        /// <summary>
        /// Gets a list of system images from the API.
        /// </summary>
        /// <returns></returns>
        public virtual Images GetImages()
        {
            var request = new RestRequest();
            request.Resource = "images/";
            return Execute<Images>(request);

        }

        public virtual ImageInfo GetImage(int image_id)
        {
            var request = new RestRequest();
            request.Resource = "images/" + image_id + "/";
            return Execute<ImageInfo>(request);

        }

        public virtual InstantEvent DeleteImage(int image_id)
        {
            var request = new RestRequest();
            request.Resource = "images/" + image_id + "/destroy/";
            return Execute<InstantEvent>(request);
        }

        public virtual Event TransferImage(int image_id, int region_id )
        {
            var request = new RestRequest();
            request.Resource = "images/" + image_id + "/transfer/";
            request.AddParameter("region_id", region_id);
            return Execute<Event>(request);
        }
    }
}
