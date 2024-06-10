using Microsoft.AspNetCore.Mvc;

namespace İntProgOdev.Controllers
{
    public class OgretmenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult OgretmenListe()
        {
            return View();
        }
    }
}
