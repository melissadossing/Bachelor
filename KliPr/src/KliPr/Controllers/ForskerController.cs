using Microsoft.AspNetCore.Mvc;
using KliPr.Models;

namespace KliPr.Controllers
{
    public class ForskerController : Controller
    {
        DataAccess objds;

        public ForskerController(DataAccess d)
        {
            objds = d;
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Questionnaire q)
        {
            objds.Create(q);
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult SetActive()
        {
            return View();
        }
        public IActionResult AddQuestion()
        {
            int x = 0;
            int y = x + 199;
            return View("Create");
        }
    }
}
