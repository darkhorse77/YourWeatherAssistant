namespace YourWeatherAssistant.Model
{
    class GetCity
    {
        public static CityResponse GetCurrentCity()
        {
            try
            {
                return ApiRequest<CityResponse>.MakeRequest($"http://apidev.accuweather.com/locations/v1/cities/search.json?q={DeviceLocation.Latinude},{DeviceLocation.Longitude}&apikey=hoArfRosT1215&language=ru");
            }
            catch
            {
                return null;
            }
        }
    }
}
