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

                var data = connection.Query<>("select * from [Partner]"); // fetch all data from the table
                return View();
            }
        }

        public IActionResult Privacy()
        {
            return View(new Partner());
        }

        public IActionResult Add(Partner model)
        {
            using (var connection = _dbconnection.Connection)
            {

                _ = connection.Execute(@"insert into [AppUser](FirstName, LastName, Address, PartnerNumber, CroatianPIN, PartnerTypeId, CreatedAtUtc, CreateByUser, IsForeign, ExternalCode, Gender) values (@FirstName, @LastName, @Address, @PartnerNumber, @CroatianPIN, @PartnerTypeId, @CreatedAtUtc, @CreateByUser, @IsForeign, @ExternalCode, @Gender)", model);
                return RedirectToAction("Index");
            }
        }

        public IActionResult Details(int id)
        {
            using (var connection = _dbconnection.Connection)
            {
                //***
                //***  Get user info from the table based on ID
                //***
                var data = connection.QueryFirstOrDefault<Partner>("select * from [Partner] where Id = @id", new { id = id });
                return View(data);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
