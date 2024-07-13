using DevExpress.XtraReports.UI;
using Microsoft.AspNetCore.Mvc;
using ReportsApp.Models;
using System.Diagnostics;

namespace ReportsApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Viewer()
        {
            var rptPath = "ReportsApp.Report";

            XtraReport report = (XtraReport) Activator.CreateInstance(Type.GetType(rptPath));
            ViewBag.ReportName = report;
            ViewBag.ReportHeader = "Report";
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}