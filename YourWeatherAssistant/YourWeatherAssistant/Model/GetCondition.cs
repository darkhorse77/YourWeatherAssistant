namespace YourWeatherAssistant.Model
{
    class GetCondition
    {
        public static ConditionResponse GetCurrentCondition(string cityCode)
        {
            try
            { 
                return ApiRequest<ConditionResponse>.MakeRequest($"http://apidev.accuweather.com/currentconditions/v1/{cityCode}.json?language=ru&apikey=hoArfRosT1215");
            }
            catch 
            {
                return null;
            }
        }
    }
}
