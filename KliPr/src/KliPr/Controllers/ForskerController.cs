using Microsoft.AspNetCore.Mvc;
using KliPr.ViewModels;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using MongoDB.Bson;
using KliPr.Models;
using Microsoft.AspNetCore.Authorization;

namespace KliPr.Controllers
{
    [Authorize]
    public class ForskerController : Controller
    {
        DataAccess objds;

        public ForskerController(DataAccess d)
        {
            objds = d;
        }

        public IActionResult ShowChart(string id)
        {

            return View(objds.GetById(new ObjectId(id)));
        }

        
        public IActionResult Dashboard()
        {
            var questionnaires = objds.GetAll();

            List<QuestionnaireListViewModel> vms = new List<QuestionnaireListViewModel>();
            foreach (var obj in questionnaires)
            {
                QuestionnaireListViewModel vm = new QuestionnaireListViewModel(obj.Id, obj.name, obj.active, obj.answeramount);
                vms.Add(vm);
            }

            return View(vms);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(QuestionnaireViewModel q)
        {
            var mapper = new ViewModelMapper();
            var question = mapper.Map(q);
            objds.Create(question);
            return RedirectToAction("Dashboard", "Forsker");
        }

        [HttpGet]
        public IActionResult Delete()
        {
            var questionnaires = objds.GetAll();

            List<QuestionnaireListViewModel> vms = new List<QuestionnaireListViewModel>();
            foreach(var obj in questionnaires)
            {
                QuestionnaireListViewModel vm = new QuestionnaireListViewModel(obj.Id,obj.name,obj.active,obj.answeramount);
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
                QuestionnaireListViewModel vm = new QuestionnaireListViewModel(obj.Id, obj.name, obj.active,obj.answeramount);
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
            return View("Create");
        }

        [HttpGet]
        public IActionResult Chooseforchart()
        {
            var questionnaires = objds.GetAll();

            List<QuestionnaireListViewModel> vms = new List<QuestionnaireListViewModel>();
            foreach (var obj in questionnaires)
            {
                QuestionnaireListViewModel vm = new QuestionnaireListViewModel(obj.Id, obj.name, obj.active, obj.answeramount);
                vms.Add(vm);
            }

            return View(vms);
        }

        [HttpPost]
        public IActionResult Chooseforchart(FormCollection fc)
        {
            string selected = Request.Form["ObjectID"];
            //ObjectId selectedobjid = new ObjectId(selected);

            return RedirectToAction("ShowChart", "Forsker", new { id = selected });
        }
    }
}
