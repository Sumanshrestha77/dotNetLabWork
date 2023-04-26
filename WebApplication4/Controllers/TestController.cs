using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class TestController : Controller
    {
        public IActionResult heisen()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Content()
        {
            return Content("This is a content return test by action.");
        }
        public ContentResult Contents()
        {
            return Content("This is a content return test by ContentResult.");
        }
        public JsonResult json()
        {
            return Json(new { name = "HEISENG", college = "TUUNI" });
        }
        public IActionResult Partial()
        {
            return PartialView("heisen"); // layout is discarded
        }
        public IActionResult Download()
        {
            return File("myfile.txt", "text/plain", "myfile.txt");
        }
    }
}
