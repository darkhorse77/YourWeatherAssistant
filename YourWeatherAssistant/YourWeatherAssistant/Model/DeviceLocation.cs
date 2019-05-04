using Xamarin.Essentials;

namespace YourWeatherAssistant.Model
{
    static class DeviceLocation
    {
        public static string Latinude { get; set; }
        public static string Longitude { get; set; }

        static DeviceLocation()
        {
            InitCoords();
        }

        static async void InitCoords()
        {
            Location location = await Geolocation.GetLastKnownLocationAsync();
            Latinude = location.Latitude.ToString();
            Longitude = location.Longitude.ToString();
        }
    }
}
