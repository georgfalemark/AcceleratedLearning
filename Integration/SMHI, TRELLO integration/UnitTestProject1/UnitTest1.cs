using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static UnitTestProject1.SmhiClasses;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Get_SMHI_String()
        {
            SmhiService service = new SmhiService();
            string smhiString = "https://opendata-download-metfcst.smhi.se/api/category/pmp3g/version/2/geotype/point/lon/16.158/lat/58.5812/data.json";
            var x = service.Get(smhiString).Result;
        }

        [TestMethod]
        public void Get_SMHI_In_Classes()
        {
            decimal longitude = 16.158m;
            decimal latitude = 58.5812m;

            SmhiService service = new SmhiService();
            Rootobject x = service.GetMeterologicalForecast(longitude, latitude).Result;

            Timesery firstTimeSeries = x.timeSeries[0];

            DateTime time = x.timeSeries[0].validTime; // klockslag
            decimal value = x.timeSeries[0].parameters[11].values[0];  //värde(temperatur) (om temperaturen fortfarande är på position 11)
            string paramname = x.timeSeries[0].parameters[11].name; // namn ("t")
        }

        [TestMethod]
        public void get_temperature_for_first_timeserie_better()
        {
            var service = new SmhiService();
            var result = service.GetMeterologicalForecast(13.846M, 58.390M).Result;

            DateTime time = result.timeSeries[0].validTime;
            Parameter param = result.timeSeries[0].parameters.Single(p => p.name == "t");
            decimal temperature = param.values[0];
        }




        [TestMethod]
        public void get_all_temperature_for_a_position_a_given_day()
        {
            var service = new SmhiService();
            var result = service.GetMeterologicalForecast(13.846M, 58.390M).Result;

            List<TimeTemp> timetemps = service.FilterTemperature(result, DateTime.Now);
        }
    }
}
