using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubSpotApi
{
    public class HubSpotClient
    {
        private readonly string _apiKey;
        private readonly IRestClient _client;
        
        public HubSpotClient(string apiKey)
        {
            _apiKey = apiKey;
            _client = new RestClient
            {
                BaseUrl = new Uri("https://api.hubapi.com")
            };
        }
    }
}
