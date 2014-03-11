﻿using System;
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
        /// Gets a list of regions from the API
        /// </summary>
        /// <returns></returns>
        public virtual Regions GetRegions()
        {
            var request = new RestRequest();
            request.Resource = "regions/";
            return Execute<Regions>(request);
        }
    }
}
