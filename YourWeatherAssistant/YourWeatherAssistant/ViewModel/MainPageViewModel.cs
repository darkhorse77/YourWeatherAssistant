using System;
using System.Collections.Generic;
using System.Text;
using YourWeatherAssistant.Model;

namespace YourWeatherAssistant.ViewModel
{
    class MainPageViewModel : BaseViewModel
    {
        public string Temperature { get; set; }
        private ServerResponse weather;

        public MainPageViewModel()
        {
            weather = GetWeather.GetJson();
            Temperature = weather.Temperature.Metric.Value.ToString();
        }
    }
}
