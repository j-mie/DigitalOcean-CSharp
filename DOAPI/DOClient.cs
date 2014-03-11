using System;
using System.Text;
using RestSharp;
using RestSharp.Extensions;

namespace DigitalOcean
{
    public partial class DOClient
    {
        public string BaseUrl { get; private set; }
        public string ApiVersion { get; private set; }

        private string ClientID { get; set; }
        private string APIKey { get; set; }

        private RestClient _client;

        public DOClient(string clientID, string apiKey)
        {
            ApiVersion = "03-2014";
            BaseUrl = "https://api.digitalocean.com/";
            ClientID = clientID;
            APIKey = apiKey;
            _client = new RestClient(BaseUrl);
            _client.UserAgent = "do-csharp";
            _client.Timeout = 30000;
            _client.AddDefaultParameter("client_id", clientID);
            _client.AddDefaultParameter("api_key", apiKey);
        }

        /// <summary>
        /// Execute a manual REST request
        /// </summary>
        /// <typeparam name="T">The type of object to create and populate with the returned data.</typeparam>
        /// <param name="request">The RestRequest to execute (will use client credentials)</param>
        public virtual T Execute<T>(RestRequest request) where T : new()
        {
            request.OnBeforeDeserialization = (resp) =>
            {
                // for individual resources when there's an error to make
                // sure that RestException props are populated
                if (((int)resp.StatusCode) >= 400)
                {
                    // have to read the bytes so .Content doesn't get populated
                    string restException = "{{ \"RestException\" : {0} }}";
                    var content = resp.RawBytes.AsString(); //get the response content
                    var newJson = string.Format(restException, content);

                    resp.Content = null;
                    resp.RawBytes = Encoding.UTF8.GetBytes(newJson.ToString());
                }
            };

            request.DateFormat = "ddd, dd MMM yyyy HH:mm:ss '+0000'";

            var response = _client.Execute<T>(request);
            return response.Data;
        }
    }
}
