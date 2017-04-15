using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using KliPr.Models;
using MongoDB.Bson;
using KliPr.Enum;
using KliPr.ViewModels;

namespace KliPr.Controllers
{
    public class PatientController : Controller
    {
        DataAccess objds;

        public PatientController(DataAccess d)
        {
            objds = d;
        }
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index(string id)
        {
            if (id != null) { 
                ObjectId selectedobjid = new ObjectId(id);
                var questionnaire = objds.GetById(selectedobjid);
                return View(questionnaire);
            }

            return View(null);
        }

        [HttpGet]
        public IActionResult Succes()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(FormCollection fc)
        {
            if (Request.Form.Count < 1) { return RedirectToAction("Index", "Patient"); }
            var todelete = Request.Form["ObjectID"];
            string questionnaireIDres = null;


            //foreach (var d in todelete)
            //{
            //    ObjectId delid = new ObjectId(d);
            //    objds.delete(delid);
            //}
            int partType = 0;

            foreach (var key in Request.Form)
            {
                var answer = new Answer();
                answer.participanttype = partType;

                if (key.Key.StartsWith("elaboration"))
                {
                    continue;
                }



                if (key.Key.StartsWith("participanttype_"))
                {

                    partType = (int)((Participant)System.Enum.Parse(typeof(Participant), key.Value));
                    continue;
                }

                var tempID = key.Key;
                var result = tempID.Substring(tempID.LastIndexOf('_') + 1);

                var questionnaireID = result.Substring(0, result.IndexOf(' '));
                var questionID = result.Substring(result.LastIndexOf(' ') + 1);


                if (key.Key.StartsWith("textanswer_"))
                {
                    answer.textanswer = new ObjectId(key.Value);
                    foreach (var key2 in Request.Form)
                    {
                        if (key2.Key.StartsWith("elaboration_" + questionnaireID + " " + questionID)){ 
                        answer.elaboration = key2.Value;
                        }
                    }
                }
                if (key.Key.StartsWith("numberanswer_"))
                {
                    answer.amountanswer = Int32.Parse(key.Value);
                    foreach (var key2 in Request.Form)
                    {
                        if (key2.Key.StartsWith("elaboration_" + questionnaireID + " " + questionID))
                        {
                            answer.elaboration = key2.Value;
                        }
                    }
                }
                if (key.Key.StartsWith("singletext_"))
                {
                    answer.singletext = key.Value;
                    foreach (var key2 in Request.Form)
                    {
                        if (key2.Key.StartsWith("elaboration_" + questionnaireID + " " + questionID))
                        {
                            answer.elaboration = key2.Value;
                        }
                    }
                }


                //insert answer to db


                questionnaireIDres = questionnaireID;

                if(answer.textanswer == null)
                {
                    answer.textanswer = ObjectId.GenerateNewId();
                }
                var succes = await objds.addAnswer(new ObjectId(questionID), new ObjectId(questionnaireID),answer);
                if (!succes)
                {
                    return RedirectToAction("Index", "Patient");
                }
            }

            var succes2 = await objds.incAnswerAmt(new ObjectId(questionnaireIDres));

            return RedirectToAction("Succes", "Patient");
        }


        [HttpGet]
        public IActionResult SelectQuestionnaire()
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
        public IActionResult SelectQuestionnaire(FormCollection fc)
        {
            string selected = Request.Form["ObjectID"];
            //ObjectId selectedobjid = new ObjectId(selected);

            return RedirectToAction("Index", "Patient", new { id = selected });
        }
    }
}
