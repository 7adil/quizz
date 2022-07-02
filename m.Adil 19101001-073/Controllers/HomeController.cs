using Microsoft.AspNetCore.Mvc;

namespace m.Adil_19101001_073.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
