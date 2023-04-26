using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult StudentView()
        {
            StudentModel suman = new StudentModel();
            suman.FirstName = "Suman";
            suman.LastName = "Shrestha";
            suman.Age = 24;
            suman.Address = "Bafal";
            suman.CollegeName = "BMC";
            return View(suman);
        }
        public ActionResult StudentsView()
        {
            StudentModel suman = new StudentModel();
            suman.FirstName = "Suman";
            suman.LastName = "Heiseng";
            suman.Age = 20;
            suman.Address = "loas";
            suman.CollegeName = "BMC";
            StudentModel jesse = new StudentModel();
            jesse.FirstName = "jesse    ";
            jesse.LastName = "PinkMan";
            jesse.Age = 21;
            jesse.Address = "Us";
            jesse.CollegeName = "BMC";
            StudentModel chandler = new StudentModel();
            chandler.FirstName = "Chandler";
            chandler.LastName = "Bing";
            chandler.Age = 24;
            chandler.Address = "US";
            chandler.CollegeName = "BMC";
            List<StudentModel> Students = new List<StudentModel>();
            Students.Add(suman);
            Students.Add(jesse);
            Students.Add(chandler);
            return View(Students);
        }
    }
}
