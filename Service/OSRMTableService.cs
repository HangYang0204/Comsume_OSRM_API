using ComsumeOSRM_backend.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ComsumeOSRM_backend.Service
{
    internal class OSRMTableService
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public static async Task<OSRMTableResponse> GetDistanceMatrixAsync(List<OSRMCoordinate> coordinates)
        {
            // Format coordinates
            string coordinatesString = string.Join(";", coordinates);

            // GET: http://34.214.128.10:5000/table/v1/driving/-82.518771,27.324867 
            string json = File.ReadAllText("endpoints.json");
            OSRMApiConfig config = System.Text.Json.JsonSerializer.Deserialize<OSRMApiConfig>(json);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            config = System.Text.Json.JsonSerializer.Deserialize<OSRMApiConfig>(json, options);

            string requestUrl = $"{config.BaseUrl}{config.EndPoints["Table"]}{coordinatesString}?annotations=duration,distance";
            Console.WriteLine(requestUrl);
            HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"OSRM API Error: {response.StatusCode}");
            }

            string jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<OSRMTableResponse>(jsonResponse);
        }
    }
}
