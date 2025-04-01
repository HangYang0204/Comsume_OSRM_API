
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ComsumeOSRM_backend.Data
{
    internal class OSRMApiConfig
    {
        [JsonPropertyName("BaseUrl")]
        public string BaseUrl { get; set; }
        [JsonPropertyName("EndPoints")]
        public Dictionary<string, string> EndPoints { get; set; }

        public OSRMApiConfig()
        {
            EndPoints = new Dictionary<string, string>();
        }
    }
}
