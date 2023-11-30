// using System;
// using System.Collections.Generic;

// namespace WeatherAPI
// {
//     public class OpenWeatherForecastResponse
//     {
//         public string? Cod { get; set; }
//         public int Message { get; set; }
//         public int Cnt { get; set; }
//         public List<OpenWeatherForecastEntry>? List { get; set; }
//         public OpenWeatherCity? City { get; set; }
//     }

//     public class OpenWeatherForecastEntry
//     {
//         public long Dt { get; set; }
//         public OpenWeatherMain? Main { get; set; }
//         public List<OpenWeatherWeather>? Weather { get; set; }
//         public OpenWeatherClouds? Clouds { get; set; }
//         public OpenWeatherWind? Wind { get; set; }
//         public int Visibility { get; set; }
//         public double Pop { get; set; }
//         public OpenWeatherRain? Rain { get; set; }
//         public OpenWeatherSys? Sys { get; set; }
//         public string? DtTxt { get; set; }
//     }

//     public class OpenWeatherMain
//     {
//         public double Temp { get; set; }
//         public int Humidity { get; set; }
//     }

//     public class OpenWeatherWeather
//     {
//         public int Id { get; set; }
//         public string? Main { get; set; }
//         public string? Description { get; set; }
//         public string? Icon { get; set; }
//     }

//     public class OpenWeatherClouds
//     {
//         public int All { get; set; }
//     }

//     public class OpenWeatherWind
//     {
//         public double Speed { get; set; }
//         public int Deg { get; set; }
//         public double Gust { get; set; }
//     }

//     public class OpenWeatherRain
//     {
//         public double? ThreeH { get; set; }
//     }

//     public class OpenWeatherSys
//     {
//         public string? Pod { get; set; }
//     }

//     public class OpenWeatherCity
//     {
//         public int Id { get; set; }
//         public string? Name { get; set; }
//         public OpenWeatherCoord? Coord { get; set; }
//         public string? Country { get; set; }
//         public int Population { get; set; }
//         public int Timezone { get; set; }
//         public long Sunrise { get; set; }
//         public long Sunset { get; set; }
//     }

//     public class OpenWeatherCoord
//     {
//         public double Lat { get; set; }
//         public double Lon { get; set; }
//     }
// }

using System.Collections.Generic;

namespace WeatherAPI
{
    public class OpenWeatherForecastResponse
    {
        public List<OpenWeatherForecastEntry>? List { get; set; }
        public OpenWeatherCity? City { get; set; }
    }

    public class OpenWeatherForecastEntry
    {
        public string? Dt_Txt { get; set; }
        public OpenWeatherMain? Main { get; set; }
        public List<OpenWeatherWeather>? Weather { get; set; }
        public OpenWeatherCity? City { get; set; }
    }

    public class OpenWeatherMain
    {
        public double Temp { get; set; }
        public int Humidity { get; set; }
    }

    public class OpenWeatherWeather
    {
        public string? Description { get; set; }
    }

    public class OpenWeatherCity
    {
        public string? Name { get; set; }
    }
}
