using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Net.Http;

namespace YourWeatherAssistant
{
    class GetWeather
    {
        public void GetCurrentWeather()
        {
            string url = @"https://api.weather.yandex.ru/v1/informers?lat=55&lon=37 X-Yandex-API-Key:1c2989df-22f1-4359-a46d-c8f24f098d85";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        }
    }
}
