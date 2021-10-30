using Microsoft.AspNetCore.Mvc;

namespace CodingInterview.AuthorizationServer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}