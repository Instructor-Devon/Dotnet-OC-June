using Microsoft.AspNetCore.Mvc;
namespace HelloASP.Controllers
{
    public class HomeController : Controller
    {
        // Inputs (requests)
        // localhost:5000/
        [Route("")]
        public ViewResult Index()
        {
            // looking for a view...
            // Views/Home/Index.cshtml
            // Views/Shared/Index.cshtml
            return View("Hello");
        }
        [Route("party/{kind}")]
        public IActionResult Party(string kind)
        {
            if(kind == "birthday")
                return Redirect("/success");
            return View();
        }
        [Route("success")]
        public string Success()
        {
            return "yay success!";
        }
    }
}