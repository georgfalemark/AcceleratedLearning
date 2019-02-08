using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC02.Models;
using MVC02.Services;
using MVC02.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC02.Controllers
{
    public class ReportController : Controller
    {
        private IReportRepository _repo;

        public ReportController(IReportRepository repo)
        {
            _repo = repo;
        }

        public IActionResult ViewAll()
        {
            IEnumerable<Report> allReport = _repo.GetAll();
            return View(allReport);
        }

        public IActionResult GetById(int Id)
        {
            Report r = _repo.GetById(Id);
            return View(r);
        }

        [HttpPost]
        public IActionResult AddReport(Report r)
        {
            _repo.AddReport(r);
            return View();
        }

        public IActionResult AddReportPage()
        {
            return View();
        }

        public IActionResult DeleteReport()
        {
            IEnumerable<Report> allReport = _repo.GetAll();
            
            var vm = new ReportListVM
            {
                AllReports = _repo.GetAll().Select(x => new SelectListItem
                {
                    Text = x.Title,
                    Value = x.Id.ToString()
                })
            };

            return View(vm);
        }

        [HttpDelete]
        public IActionResult DeleteById(int id)
        {
            _repo.DeleteReport(id);
            return View();
        }




    }
}
