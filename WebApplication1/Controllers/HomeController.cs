using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Data;
using WebApplication1.DBConnection;
using Dapper;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DBInterface _dbconnection;

        public HomeController(ILogger<HomeController> logger, DBInterface dbconnection)
        {
            _logger = logger;
            _dbconnection = dbconnection;
        }

        public IActionResult Index()
        {
            using (var connection = _dbconnection.Connection)
            {

                var data = connection.Query<>("select * from [AppUser]"); // fetch all data from the table
                return View();
            }
        }

        public IActionResult Privacy()
        {
            return View(new Partner());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
