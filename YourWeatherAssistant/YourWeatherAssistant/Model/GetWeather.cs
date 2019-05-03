using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using YourWeatherAssistant.Model;

namespace YourWeatherAssistant
{
    class GetWeather
    {
        public static ServerResponse GetJson()
        {
            try
            {
                string url = @"http://apidev.accuweather.com/currentconditions/v1/291507.json?language=ru&apikey=hoArfRosT1215";
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                using (Stream stream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                    String responseString = reader.ReadToEnd();

                    List<ServerResponse> weather = JsonConvert.DeserializeObject<List<ServerResponse>>(responseString);

                    return weather.First();
                }
            }
            catch 
            {
                return null;
            }
        }
    }

    // API response sample:
    //[
    //    {
    //    "LocalObservationDateTime":"2019-05-02T16:10:00+05:00",
    //    "EpochTime":1556795400,
    //    "WeatherText":"Light snow",
    //    "WeatherIcon":19,
    //    "HasPrecipitation":true,
    //    "PrecipitationType":"Snow",
    //    "IsDayTime":true,
    //    "Temperature":
    //     {
    //         "Metric":
    //         {
    //             "Value":-3.0,
    //             "Unit":"C",
    //             "UnitType":17
    //         },
    //         "Imperial":
    //         {
    //              "Value":27.0,
    //              "Unit":"F",
    //              "UnitType":18
    //          }
    //      },
    //    "MobileLink":"http://m.accuweather.com/en/ru/labytnangi/291507/current-weather/291507?lang=en-us",
    //    "Link":"http://www.accuweather.com/en/ru/labytnangi/291507/current-weather/291507?lang=en-us"
    //    }
    //]
}
