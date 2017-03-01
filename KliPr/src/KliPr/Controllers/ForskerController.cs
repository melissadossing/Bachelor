using Microsoft.AspNetCore.Mvc;
using KliPr.Models;
using KliPr.ViewModels;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using MongoDB.Bson;

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

        [HttpGet]
        public IActionResult Delete()
        {
            var questionnaires = objds.GetAll();

            List<DeleteViewModel> vms = new List<DeleteViewModel>();
            foreach(var obj in questionnaires)
            {
                DeleteViewModel vm = new DeleteViewModel(obj.Id,obj.name,obj.active);
                vms.Add(vm);
            }

            return View(vms);
        }
        [HttpPost]
        public IActionResult Delete(FormCollection fc)
        {
            var todelete = Request.Form["ObjectID"];
            foreach(var d in todelete)
            {
                ObjectId delid = new ObjectId(d);
                objds.delete(delid);
            }

            return RedirectToAction("Delete", "Forsker");
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
