using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using static UnitTestProject1.SmhiClasses;

namespace UnitTestProject1
{
    internal class SmhiService
    {


        public async Task<string> Get(string url)
        {
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(url))
            using (HttpContent content = response.Content)
            {
                if (!response.IsSuccessStatusCode)
                    throw new Exception(response.ReasonPhrase);

                return await content.ReadAsStringAsync();
            }
        }

        public async Task<Rootobject> GetMeterologicalForecast(decimal longitude, decimal latitude)
        {
            string sLongitude = Math.Round(longitude, 3).ToString(new CultureInfo("en"));
            string sLatitude = Math.Round(latitude, 3).ToString(new CultureInfo("en"));

            string page = "https://opendata-download-metfcst.smhi.se/api/category/pmp3g/version/2/geotype/point/lon/" + sLongitude + "/lat/" + sLatitude + "/data.json";

            string result = await Get(page);
            return JsonConvert.DeserializeObject<Rootobject>(result);
        }

        internal List<TimeTemp> FilterTemperature(Rootobject result, DateTime now)
        {
            List<TimeTemp> timeTemps = new List<TimeTemp>();

            for (int i = 0; i < 24; i++)
            {
                //Math.Abs(result.timeSeries[i] - now);

                Parameter param = result.timeSeries[i].parameters.Single(x => x.name == "t");
                decimal value = param.values[0];

                var tt = new TimeTemp { Temp = value, Time = now.AddHours(i) };
                timeTemps.Add(tt);
            }

            return timeTemps;



        }
    }
}