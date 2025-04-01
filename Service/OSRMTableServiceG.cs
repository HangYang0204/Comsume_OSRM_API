using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using ComsumeOSRM_backend.Data;
using System.Text.Json;

namespace ComsumeOSRM_backend.Service
{
    internal class OSRMTableServiceG
    {
        public static string GetDistanceMatrix(List<OSRMCoordinate> coordinates)
        {
            // Format coordinates
            string coordinatesString = string.Join(";", coordinates);

            //System.Net.ServicePointManager.Expect100Continue = false;
            //WebClient MyWebClient = new WebClient();
            //MyWebClient.Headers.Set("Content-Type", "application/json");
            //MyWebClient.Headers.Set("Accept-Encoding", "gzip, deflate");
            //var responseStream = new System.IO.Compression.GZipStream
            //(
            //    new System.IO.MemoryStream(MyWebClient.UploadData("http://34.214.128.10:5000/table/v1/driving/", System.Text.Encoding.UTF8.GetBytes(coordinatesString)))
            //   , System.IO.Compression.CompressionMode.Decompress
            //);

            //var reader = new System.IO.StreamReader(responseStream);

            //return reader.ReadToEnd();
            string url = string.Format("http://34.214.128.10:5000/table/v1/driving/{0}", System.Web.HttpUtility.UrlEncode(coordinatesString));
            var request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);
            request.Accept = "application/json";
            var response = request.GetResponse();
            var stream = response.GetResponseStream();
            var reader = new System.IO.StreamReader(stream);
            return reader.ReadToEnd();
 
        }

    }
}
