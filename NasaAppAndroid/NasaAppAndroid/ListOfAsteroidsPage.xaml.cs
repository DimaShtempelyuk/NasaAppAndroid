using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NasaAppAndroid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListOfAsteroidsPage : ContentPage
    {
        public ListOfAsteroidsPage(Asteroid x)
        {
            InitializeComponent();

        }
    }
}