﻿using Microsoft.AspNetCore.Mvc;
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

        public IActionResult ShowChart()
        {

            return View(objds.GetActive());
        }

        
        public IActionResult Dashboard()
        {
            var activequestionnaire = objds.GetActive();

            QuestionnaireListViewModel vm;
            if (activequestionnaire != null) {
                vm = new QuestionnaireListViewModel(activequestionnaire.Id,activequestionnaire.name,activequestionnaire.active,activequestionnaire.answeramount);
            }
            else
            {
                vm = new QuestionnaireListViewModel(new ObjectId(), "Intet spørgeskema er aktiveret", false, 0);
            }

            return View(vm);
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
    }
}
