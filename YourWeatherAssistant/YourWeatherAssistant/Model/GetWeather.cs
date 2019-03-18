using System;
using System.IO;
using System.Net;
using System.Text;

namespace YourWeatherAssistant
{
    class GetWeather
    {
        public string City { get; set; } = "Лабытанги";
        private double Lat { get; set; }
        private double Lon { get; set; }

        private ServerResponse response; // готовый json

        public GetWeather(double lat, double lon)
        {
            this.Lat = lat;
            this.Lon = lon;
            response = GetJson();
        }

        public ServerResponse GetJson()
        {
            string url =  @"https://api.weather.yandex.ru/v1/forecast?lat=" + Lat + "&lon=" + Lon + "&extra=true";
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Headers.Add("X-Yandex-API-Key: 75f2d8b2-7b19-4f1a-89ee-badecd60a37c");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            using (Stream stream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                String responseString = reader.ReadToEnd();

                ServerResponse weather = (ServerResponse)Newtonsoft.Json.JsonConvert.DeserializeObject(responseString, typeof(ServerResponse));

                return weather;
            }     
        }

        public int GetTemp() => int.Parse(response.Fact.Temp);

        public string GetCondition() => response.Fact.Condition;

        public int GetPrecType() => int.Parse(response.Fact.PrecType);
    } 

    class ServerResponse 
    {
        public Fact Fact { get; set; }
    }

    class Fact 
    {
        public string Temp { get; set; } // температура
        public string Condition { get; set; } // погода (снег, дождь и тд)
        public string PrecType { get; set; } // тип осадков 
    }


    //#pragma warning disable 0649
    //#pragma warning restore 0649
}
