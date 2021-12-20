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
    public class DataProccessing
    {
        public int MaxAsteroidNumber { get; set; }
        public async Task<AsteroidModel> GetProductAsync(string sdt = "", string fdt = "")
        { 
            string url = "";
            if (sdt == "")
            {
                throw new Exception("Chybí start datum");
            }
            else if (fdt == "")
            {
                throw new Exception("Chybí end datum");
            }
            else
            {
                url = @"https://api.nasa.gov/neo/rest/v1/feed?start_date={ sdt }&end_date={ fdt }&api_key=UBk1mGTXSFblOfH005BBNET7P470yYWptrHNqSxt";
            }
            using (HttpResponseMessage response = await CallingAPI.AppClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    AsteroidModel asteroid = await response.Content.ReadAsAsync<AsteroidModel>();

                    return asteroid;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
            //Asteroid asteroid = null;
            //HttpResponseMessage response = await AppClient.GetAsync(path);
            //if (response.IsSuccessStatusCode)
            //{
            //    asteroid = await response.Content.ReadAsAsync<Asteroid>();
            //}
            //return asteroid;
        }
    }
}
