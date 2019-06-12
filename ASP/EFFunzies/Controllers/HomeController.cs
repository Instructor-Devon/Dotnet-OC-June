using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EFFunzies.Models;
using Microsoft.Extensions.Configuration;

namespace EFFunzies.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            var users = dbContext.Users;
            var hulk = dbContext.Users.FirstOrDefault(u => u.FirstName == "Hulk");

            var orderedByName = dbContext.Users.OrderBy(u => u.FirstName);

            if(dbContext.Users.Any(u => u.LastName.Contains("Warrior")))
            {
                Console.WriteLine("WARRIOR FOUND");
            }


            return View();
        }

    }
}
