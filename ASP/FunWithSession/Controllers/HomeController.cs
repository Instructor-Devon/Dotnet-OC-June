using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using FunWithSession.Extensions;

namespace FunWithSession.Controllers
{
    public class HomeController : Controller
    {
        public int? SessionCount
        {
            get { return HttpContext.Session.GetInt32("count"); }
            set { HttpContext.Session.SetInt32("count", (int)value); }
        }
        [HttpGet("")]
        public IActionResult Index()
        {


            // First time user experiencce
            if(SessionCount == null)
            {
                SessionCount = 0;
            }

            ViewBag.Count = SessionCount;

            // HttpContext.Session.GetString("username");
            // HttpContext.Session.SetString("username", "Devon");



            return View();
        }
        [HttpGet("count")]
        public int? Count()
        {
            // increment count in session
            SessionCount++;
            return SessionCount;
        }
        
    }
}
