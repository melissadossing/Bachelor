using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Reflection;
using KliPr.ViewModels;

namespace KliPr.Controllers
{
    public class ForskerController : Controller
    {
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
        public IActionResult Create(CreateQuestionnaireViewModel vm)
        {
            int x = 7;
            int y = x + 55;

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
