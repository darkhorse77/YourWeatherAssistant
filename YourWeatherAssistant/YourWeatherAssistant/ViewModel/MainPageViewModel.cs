using YourWeatherAssistant.Model;

namespace YourWeatherAssistant.ViewModel
{
    class MainPageViewModel : BaseViewModel
    {
        private ConditionResponse weather;
        private CityResponse city;

        public string CurrentCity { get; set; }
        public string Region { get; set; }

        public string Temperature { get; set; }
        public string WeatherText { get; set; }
        public string PrecipitationType { get; set; }
        public bool IsDayTime { get; set; }

        public MainPageViewModel()
        {
            city = GetCity.GetCurrentCity();
            CurrentCity = city.LocalizedName;
            Region = city.AdministrativeArea.LocalizedName;

            weather = GetCondition.GetCurrentCondition(city.Key);
            Temperature = weather.Temperature.Metric.Value + "°";
            WeatherText = weather.WeatherText;
            if (weather.HasPrecipitation)
                PrecipitationType = weather.PrecipitationType;
            else
                PrecipitationType = "Без осадков";
        }
    }
}
