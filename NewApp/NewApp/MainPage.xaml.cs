using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NewApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        public List<Weather> weathers { get => WeatherData(); }
        private List<Weather> WeatherData()
        {
            var tempList = new List<Weather>();
            tempList.Add(new Weather { Temp = "22", Date = "Sunday 14", Icon = "weather.png" });
            tempList.Add(new Weather { Temp = "15", Date = "Monday 15", Icon = "weather.png" });
            tempList.Add(new Weather { Temp = "17", Date = "Tuesday 16", Icon = "weather.png" });
            tempList.Add(new Weather { Temp = "21", Date = "Wednesday 17", Icon = "weather.png" });
            tempList.Add(new Weather { Temp = "22", Date = "Thursday 18", Icon = "weather.png" });
            tempList.Add(new Weather { Temp = "22", Date = "Friday 19", Icon = "weather.png" });

            return tempList;
        }
    }

    public class Weather
    {
        public string Temp { get; set; }
        public string Date { get; set; }
        public string IconImageSource { get; set; }

    }
}