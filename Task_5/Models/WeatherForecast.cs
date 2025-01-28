using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_5.Models
{
    public class WeatherForecast
    {
        public DateOnly Date {get;set;}
        public int TemperatureC {get;set;}
        public string Summary {get;set;}

        public WeatherForecast(DateOnly date, int temperatureC, string summary){

            Date = date;
            TemperatureC = temperatureC;
            Summary = summary;
        }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

}

