using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using coreapp2._0.Models;
using coreapp2._0.DataAccess;

namespace coreapp2._0.Controllers
{
    public class HomeController : Controller
    {
        protected DataBaseContext dbContext;
        public HomeController(DataBaseContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult About()
        {

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
