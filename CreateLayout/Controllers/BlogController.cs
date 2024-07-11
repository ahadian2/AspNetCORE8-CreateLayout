using Microsoft.AspNetCore.Mvc;

namespace CreateLayout.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
