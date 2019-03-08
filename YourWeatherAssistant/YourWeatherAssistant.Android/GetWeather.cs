using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

//namespace YourWeatherAssistant.Droid
//{
//    class GetWeather : HttpClient
//    {
//        public GetWeather()
//        {
//            var client = new HttpClient();
//            client.BaseAddress = new Uri("localhost:8080");

//            string jsonData = @"{""username"" : ""myusername"", ""password"" : ""mypassword""}"

//            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
//            HttpResponseMessage response = await client.PostAsync("/foo/login", content);

//            // this result string should be something like: "{"token":"rgh2ghgdsfds"}"
//            var result = await response.Content.ReadAsStringAsync();
//        }
//    }
//}