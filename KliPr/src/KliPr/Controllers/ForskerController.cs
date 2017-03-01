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
            var activequestionnaire = objds.GetActive();

            QuestionnaireListViewModel vm;
            if (activequestionnaire != null) {
                vm = new QuestionnaireListViewModel(activequestionnaire.Id,activequestionnaire.name,activequestionnaire.active);
            }
            else
            {
                vm = new QuestionnaireListViewModel(new ObjectId(), "Intet spørgeskema er aktiveret", false);
            }

            return View(vm);
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
            return RedirectToAction("Dashboard", "Forsker");
        }

        [HttpGet]
        public IActionResult Delete()
        {
            var questionnaires = objds.GetAll();

            List<QuestionnaireListViewModel> vms = new List<QuestionnaireListViewModel>();
            foreach(var obj in questionnaires)
            {
                QuestionnaireListViewModel vm = new QuestionnaireListViewModel(obj.Id,obj.name,obj.active);
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

        [HttpGet]
        public IActionResult SetActive()
        {
            var questionnaires = objds.GetAll();

            List<QuestionnaireListViewModel> vms = new List<QuestionnaireListViewModel>();
            foreach (var obj in questionnaires)
            {
                QuestionnaireListViewModel vm = new QuestionnaireListViewModel(obj.Id, obj.name, obj.active);
                vms.Add(vm);
            }

            return View(vms);
        }

        [HttpPost]
        public IActionResult SetActive(FormCollection fc)
        {
            var toactive = Request.Form["ObjectID"];
            //foreach (var d in todelete)
            //{
            //    ObjectId delid = new ObjectId(d);
            //    objds.delete(delid);
            //}

            ObjectId activeid = new ObjectId(toactive);
            objds.SetActive(activeid);

            return RedirectToAction("Dashboard", "Forsker");
        }
        public IActionResult AddQuestion()
        {
            int x = 0;
            int y = x + 199;
            return View("Create");
        }
    }
}
