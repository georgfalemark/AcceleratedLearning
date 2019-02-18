using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HemNet.Models
{
    public class WeatherVm
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public List<TimeTemp> TimeTemps { get; set; }
    }
}
