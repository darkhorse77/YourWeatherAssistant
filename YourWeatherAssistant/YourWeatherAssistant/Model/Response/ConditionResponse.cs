namespace YourWeatherAssistant.Model
{
    class ConditionResponse
    {
        public string WeatherText { get; set; }
        public bool HasPrecipitation { get; set; }
        public string PrecipitationType { get; set; }
        public bool IsDayTime { get; set; }
        public Temperature Temperature { get; set; }
    }

    class Temperature
    {
        public Metric Metric { get; set; }
    }

    class Metric
    {
        public double Value { get; set; }
    }
}
