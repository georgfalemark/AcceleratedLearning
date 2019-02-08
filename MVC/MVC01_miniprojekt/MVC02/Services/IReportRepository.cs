using MVC02.Models;
using System.Collections.Generic;

namespace MVC02.Services
{
    public interface IReportRepository
    {
        IEnumerable<Report> GetAll();
        Report GetById(int id);
        void AddReport(Report r);
        void DeleteReport(int id);
    }
}