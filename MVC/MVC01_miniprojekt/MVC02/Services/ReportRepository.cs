using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using MVC02.Models;

namespace MVC02.Services
{
    public class ReportRepository : IReportRepository
    {
        private IHostingEnvironment _env;

        public ReportRepository(IHostingEnvironment env)
        {
            _env = env;
        }

        public IEnumerable<Report> GetAll()
        {
            string root = _env.ContentRootPath;
            string filename = Path.Combine(root, "Data", "Reports.txt");

            string[] txt = File.ReadAllLines(filename);
            IEnumerable<Report> allReports = txt.Select(x => new Report
            {
                Id = int.Parse(x.Split(',')[0]),
                Title = x.Split(',')[1],
                Restaurant = x.Split(',')[2],
                Description = x.Split(',')[3],
                Rating = int.Parse(x.Split(',')[4])
            }); ;
            return allReports;
        }

        public Report GetById(int id)
        {
            return GetAll().Single(x => x.Id == id);
        }

        public void AddReport(Report r)
        {
            r.Id = GetAll().Max(x => x.Id) + 1;

            string root = _env.ContentRootPath;
            string filename = Path.Combine(root, "Data", "Reports.txt");

            File.AppendAllText(filename, $"{r.Id},{r.Title},{r.Restaurant},{r.Description},{r.Rating}\n");
        }

        public void DeleteReport(int id)
        {

            string root = _env.ContentRootPath;
            string filename = Path.Combine(root, "Data", "Reports.txt");


            Report r = GetAll().Single(x => x.Id == id);




            List<string> txt = File.ReadAllLines(filename).ToList();
            txt.RemoveAt(id);
            File.WriteAllLines(filename, txt.ToArray());











            


        }
    }
}
