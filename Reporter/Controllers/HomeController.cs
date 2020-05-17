using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Reporter.BL.Services.Departmens;
using Reporter.BL.Services.Faculties;
using Reporter.BL.Services.Reports;
using Reporter.Common.DTOs;
using Reporter.UI.Models;

namespace Reporter.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDepartmentService _departmentService;
        private readonly IFacultiesService _facultiesService;
        private readonly IReportService _reportService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IDepartmentService departmentService, IFacultiesService facultiesService, IReportService reportService, ILogger<HomeController> logger)
        {
            _departmentService = departmentService;
            _facultiesService = facultiesService;
            _reportService = reportService;
            _logger = logger;
        }

        [Authorize]
        public IActionResult Index()
        {
            ReportsListViewModel reportsListViewModel = new ReportsListViewModel();
            reportsListViewModel.Reports = _reportService.GetAllReports();
            reportsListViewModel.CurrentFacultie = "AMI";
            reportsListViewModel.CurrentDepartment = "Programming";
            return View(reportsListViewModel);
        }

        public FileStreamResult GetFile(ReportDTO reportModel)
        {
            var reportTest = _reportService.GetAllReports().First();

            var byteArray = Encoding.ASCII.GetBytes(reportTest.Report);
            var stream = new MemoryStream(byteArray);

            return File(stream, "text/plain", "your_file_name.txt");
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
