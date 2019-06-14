using System.Collections.Generic;
using System.Linq;
using EFFunzies.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFFunzies.Controllers
{
    [Route("dashboard")]
    public class DashboardController : UserAccessController
    {
        private MyContext dbContext;
        public DashboardController(MyContext context)
        {
            dbContext = context;
        }
        // localhost:5000/dashboard
        [HttpGet("")]
        public ViewResult Index()
        {
            List<Message>messages = dbContext.Messages
                .Include(m => m.Creator)
                .Include(m => m.VotesRecieved).ToList();

            return View(messages);
        }
    }
}