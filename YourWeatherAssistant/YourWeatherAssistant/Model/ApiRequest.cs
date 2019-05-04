using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace YourWeatherAssistant.Model
{
    static class ApiRequest<T>
    {
        public static T MakeRequest(string path)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(path);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            using (Stream stream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                String responseString = reader.ReadToEnd();

                List<T> value = JsonConvert.DeserializeObject<List<T>>(responseString);

                return value.First();
            }
        }
    }
}