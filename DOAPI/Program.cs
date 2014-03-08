using RestSharp;

namespace DigitalOcean
{
    class DOClient
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

            _client.AddDefaultUrlSegment("client_id", clientID);
            _client.AddDefaultUrlSegment("api_key", apiKey); 
        }
    }
}
