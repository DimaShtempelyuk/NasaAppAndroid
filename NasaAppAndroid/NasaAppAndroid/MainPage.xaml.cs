using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using Xamarin.Essentials;
using System.Text.RegularExpressions;

namespace NasaAppAndroid
{
    public partial class MainPage : ContentPage
    {

        public static ObservableCollection<Asteroid> AsteroidList { get; set; }
        public static Rootobject info;
        public MainPage()
        {
            InitializeComponent();
            GetData();
        }
        private async void GetData()
        {
            var InternerConnection = Connectivity.NetworkAccess;

            if (InternerConnection == NetworkAccess.Internet)
            {
                DateTime sdt = StartDatePicker.Date;
                DateTime fdt = FinishDatePicker.Date;
                string API_key = "UBk1mGTXSFblOfH005BBNET7P470yYWptrHNqSxt";
                string url = $"https://api.nasa.gov/neo/rest/v1/feed?start_date={sdt.Year}-{sdt.Month}-{sdt.Day}&end_date={fdt.Year}-{fdt.Month}-{fdt.Day}&api_key={API_key}";
                API_Response data = await CallingAPI.Get(url);

                if (data.Successuful)
                {
                    Regex reg = new Regex(@"\d{4}[-]\d{2}[-]\d{2}");
                    string database = reg.Replace(data.Response, "date", 1, 500);

                    info = JsonConvert.DeserializeObject<Rootobject>(database);
                }
            }
            else
            {
                
            }
            if (info != null)
            {
                AsteroidList = new ObservableCollection<Asteroid>(info.near_earth_objects.asteroids);
            }
        }
    }
}
