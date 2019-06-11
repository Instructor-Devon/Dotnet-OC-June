using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySQLFun.Models;
using DbConnection;
using MySQLFun.Factories;

namespace MySQLFun.Controllers
{
    public class HomeController : Controller
    {
        private QuoteFactory qFactory;
        private UserFactory uFactory;
        public HomeController()
        {
            qFactory = new QuoteFactory();
            uFactory = new UserFactory();   
        }
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Quotes = qFactory.GetAll();
            ViewBag.Users = uFactory.GetAll();
            return View();
        }
        [HttpPost("create")]
        public IActionResult Create(Quote newQuote)
        {
            // if user is in session, for example, do this: newQuote.UserId = ...Session.GetInt32("userId")
            qFactory.Create(newQuote);

            return RedirectToAction("Index");
        }
        [HttpGet("user/{id}")]
        public IActionResult Show(int id)
        {
            return View(uFactory.GetOneById(id));
        }
        

    }
}
