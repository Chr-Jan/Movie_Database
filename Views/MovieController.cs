using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Views
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
