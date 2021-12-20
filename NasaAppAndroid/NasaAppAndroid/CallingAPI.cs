using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;


namespace NasaAppAndroid
{
    
   
    public class CallingAPI
    {
        //public string path = "https://api.nasa.gov/neo/rest/v1/feed?start_date=2015-09-07&end_date=2015-09-08&api_key=UBk1mGTXSFblOfH005BBNET7P470yYWptrHNqSxt";
        public static HttpClient AppClient { get; set; } = new HttpClient();
        public static async Task<API_Response> Get(string url, string authID = null)
        {
            AppClient = new HttpClient();
            AppClient.DefaultRequestHeaders.Accept.Clear();
            AppClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            if (!string.IsNullOrWhiteSpace(authID))
            AppClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Authorization", authID);

            var request = await AppClient.GetAsync(url);
            if (request.IsSuccessStatusCode)
            {
                return new API_Response { Response = await request.Content.ReadAsStringAsync() };
            }
            else
            {
                return new API_Response { ErrorMessage = request.ReasonPhrase };
            }
        }
        
    }
    public class API_Response
    {
        public bool Successuful => ErrorMessage == null;
        public string ErrorMessage { get; set; }
        public string Response { get; set; }
    }
}
