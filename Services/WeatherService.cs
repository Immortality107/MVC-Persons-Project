using Models;
using ServiceContracts;

namespace Services
{
    public class WeatherService : IWeather
    {
        private List<CityWeather> _weatherList;

        public WeatherService () {
            List<CityWeather> cityWeather = new List<CityWeather> {
           new CityWeather {  CityUniqueCode = "LDN", CityName = "London", DateAndTime = Convert.ToDateTime( "2030-01-01 8:00"),  TemperatureFahrenheit = 33
              },new CityWeather {CityUniqueCode = "NYC", CityName = "New York", DateAndTime = Convert.ToDateTime("2030-01-01 3:00"),  TemperatureFahrenheit = 60
             }, new CityWeather{CityUniqueCode = "PAR", CityName = "Paris", DateAndTime =   Convert.ToDateTime("2030-01-01 9:00"),  TemperatureFahrenheit = 82
             } };
            _weatherList = cityWeather;

        }
        public List<CityWeather> CitiesWeather()
        {
           return _weatherList;
        }

        public CityWeather GetCityWeather(string CityUniCode)
        {
           CityWeather c = _weatherList.FirstOrDefault(c=> c.CityUniqueCode  == CityUniCode);
            return c;
        }
    }
}
