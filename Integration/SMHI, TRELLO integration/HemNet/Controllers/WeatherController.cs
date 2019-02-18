using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HemNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace HemNet.Controllers
{
    public class WeatherController : Controller
    {
        public IActionResult Index(WeatherVm w)
        {
            return View(w);
        }

        public IActionResult ShowWeather(WeatherVm w)
        {
            var service = new SmhiService();
            var result = service.GetMeterologicalForecast(w.Longitude, w.Latitude).Result;

            List<TimeTemp> timetemps = service.FilterTemperature(result, DateTime.Now);

            w.TimeTemps = timetemps;

            return View("Index", w);
        }
    }
}
