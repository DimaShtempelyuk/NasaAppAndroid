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
    public class Rootobject
    {
        public string links { get; set; }
        public int element_count { get; set; }
        public Near_Earth_Objects near_earth_objects { get; set; }
    }
    public class Near_Earth_Objects
    {
        [JsonProperty("date")]
        public Asteroid[] asteroids { get; set; }
    }
    public class AsteroidModel
    {
        [JsonProperty("NameAster")]
        public string Name { get; set; }

        [JsonProperty("KilometrAster")]
        public string Kilometers { get; set; }
    }
    public class Asteroid
    {
        public string id { get; set; }
        public string neo_reference_id { get; set; }
        public string name { get; set; }
        public bool is_potentially_hazardous_asteroid { get; set; }
        public Asteroid(int AstNum)
        {

        }
        public string _description;
        public string description
        {
            get
            {
                if (_description == null)
                {
                    Description();
                }
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        public void Description()
        {
            Rootobject x = new Rootobject();
            for (int i = 0; i < x.element_count; i++)
            {

            }

        }
    }

}
