namespace YourWeatherAssistant.Model
{
    class CityResponse
    {
        public string Key { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
        public Country Country { get; set; }
        public AdministrativeArea AdministrativeArea { get; set; }
    }

    class Country
    {
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
    }

    class AdministrativeArea
    {
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
        public string LocalizedType { get; set; }
        public string EnglishType { get; set; }
        public string CountryID { get; set; }
    }

}
