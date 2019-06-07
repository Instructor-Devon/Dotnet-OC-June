using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PassingAroundData.Models;

namespace PassingAroundData.Controllers
{
    public class HomeController : Controller
    {
        private IndexViewModel TheModel
        {
            get
            {
                return new IndexViewModel()
                {
                    Users = new List<string>()
                    {"Jerry", "Sally", "Barbara"},
                    PresentTime = DateTime.Now
                };
            }
        }
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            // ViewBag.Users = Usernames;
            return View(TheModel);
        }
        [HttpPost("process")]
        public IActionResult ProcessForm(UserForm form)
        {
            var temp = TheModel;
            temp.Users.Add($"{form.Name} from {form.Location}");
            // ViewBag.Users = temp;
            return View("Index", temp);
        }
    }
}
