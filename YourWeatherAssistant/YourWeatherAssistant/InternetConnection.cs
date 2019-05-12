using System.Net;

namespace YourWeatherAssistant
{
    class InternetConnection
    {
        public bool CheckConnection()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://apidev.accuweather.com/");
                request.Timeout = 5000;
                request.Credentials = CredentialCache.DefaultNetworkCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
