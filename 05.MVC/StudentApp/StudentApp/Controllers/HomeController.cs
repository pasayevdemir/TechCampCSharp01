using Microsoft.AspNetCore.Mvc;
using StudentApp.Models;
using System.Diagnostics;
using DataAccess;
using Helpers.Constants;

namespace StudentApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentDal _studentDal;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentDal = new StudentDal(new MyDbContext());
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Student student)
        {
            if (student != null)
            {
                if(!string.IsNullOrWhiteSpace(student.FirstName)&&
                    !string.IsNullOrWhiteSpace(student.LastName))
                {
                    if (student.FirstName.Length <= 3 || student.LastName.Length <= 3)
                    {
                        TempData["UIMessage"] = ConstantValues.HasMinLength("Ad və Soyad",3);
                    }
                    else if(student.FirstName.Length >= 50 || student.LastName.Length >= 50)
                    {
                        TempData["UIMessage"] = ConstantValues.HasMaxLength("Ad və Soyad", 50);
                    }
                    else
                    {
                        _studentDal.Add(student);
                        TempData["UIMessage"] = "Elave edildi!";
                    }
                }
                else
                {
                    TempData["UIMessage"] = ConstantValues.DO_NOT_EMPTY_FIELDS;
                }
            }
            else
            {
                TempData["UIMessage"] = ConstantValues.DO_NOT_EMPTY_FIELDS;
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
