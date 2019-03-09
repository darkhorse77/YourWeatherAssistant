using System;
using System.IO;
using System.Net;
using System.Text;

namespace YourWeatherAssistant
{
    class GetWeather
    {
        public string city = "Лабытанги";
        private ServerResponse response; // готовый json

        public GetWeather()
        {
            response = GetJson();
        }

        public ServerResponse GetJson()
        {
            string url = "https://api.weather.yandex.ru/v1/forecast?lat=66.39&lon=66.24&extra=true";
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

        public int GetTemp()
        {
            return int.Parse(response.fact.temp);
        }

        public string GetCondition()
        {
            return response.fact.condition;
        }

        public int GetPrecType()
        {
            return int.Parse(response.fact.prec_type);
        }
    }

    #pragma warning disable 0649

    class ServerResponse 
    {
        public Fact fact; 
    }

    class Fact 
    {
        public string temp; // температура
        public string condition; // погода (снег, дождь и тд)
        public string prec_type; // тип осадков 
    }

    #pragma warning restore 0649
}
