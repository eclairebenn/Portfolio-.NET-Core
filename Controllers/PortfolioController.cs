using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Home()
        {
            return View("home");
        }

        [HttpGet]
        [Route("projects")]

        public IActionResult Project()
        {
            return View("projects");
        }

        [HttpGet]
        [Route("contact")]

        public IActionResult Contact()
        {
            return View("contact");
        }

        [HttpPost]
        [Route("contact/submit")]
        public IActionResult FormSubmit(string name, string email, string comment)
        {
            return View("contact");
        }

    }
}