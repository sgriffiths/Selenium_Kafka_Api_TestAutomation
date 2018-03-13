using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp;

namespace Web_Kafka_API_Automation.Clients
{
    public class ApiClient
    {
        private readonly IRestClient _restClient;
        private readonly JsonSerializerSettings _jsonSerializerSettings = new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            NullValueHandling = NullValueHandling.Ignore,
            Formatting = Formatting.Indented,
            TypeNameHandling = TypeNameHandling.Auto,
            //TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple,
            //SerializationBinder = new RenamingSerializationBinder()
        };
        private string _token;
        public ApiClient(string rootUrl)
        {
            try
            {
                _restClient = new RestClient(rootUrl);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
