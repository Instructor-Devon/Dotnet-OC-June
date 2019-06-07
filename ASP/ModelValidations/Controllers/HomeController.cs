using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelValidations.Models;

namespace ModelValidations.Controllers
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
        public IActionResult ProcessForm(IndexViewModel model)
        {
            var form = model.NewUser;
            if((DateTime.Now - form.DOB).Days / 365.25 <= 13)
            {
               ModelState.AddModelError("DOB", "Must be 13 years or older");   
            }
            if(ModelState.IsValid)
            {
                // add stuff to DB (later)
                
                return RedirectToAction("Index");
            }
            else {
                return View("Index", TheModel);
            }
        }
    }
}
