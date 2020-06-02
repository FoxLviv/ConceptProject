using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reporter.BL.Services.Departmens;
using Reporter.BL.Services.Faculties;
using Reporter.BL.Services.Reports;
using Reporter.UI.Models;

namespace Reporter.UI.Controllers
{
    public class ReportController : Controller
    {
        private readonly IReportService _reportService;
        private readonly IDepartmentService _departmentService;
        private readonly IFacultiesService _facultiesService;

        public ReportController(IDepartmentService departmentService, IFacultiesService facultiesService, IReportService reportService)
        {
            _departmentService = departmentService;
            _facultiesService = facultiesService;
            _reportService = reportService;
        }

        public async Task<IActionResult> Index(int reportId)
        {
            ReportViewModel reportViewModel = new ReportViewModel();
            reportViewModel.Report = await _reportService.GetById(reportId);

            return View(reportViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(ReportViewModel reportViewModel) {
            var existingReport = await _reportService.GetById(reportViewModel.Report.ID);

            await _reportService.Update(reportViewModel.Report);

            return View(reportViewModel);
        }
    }
}