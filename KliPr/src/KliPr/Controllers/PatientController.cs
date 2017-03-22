using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using KliPr.Models;
using MongoDB.Bson;
using KliPr.Enum;

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
        public IActionResult Index()
        {
            


            var questionnaires = objds.GetAll();
            return View(questionnaires);
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

                if (key.Key.StartsWith("participanttype_"))
                {

                    partType = (int)((Participant)System.Enum.Parse(typeof(Participant), key.Value));
                    continue;
                }

                if (key.Key.StartsWith("textanswer_"))
                {
                    answer.textanswer = key.Value;
                }
                if (key.Key.StartsWith("numberanswer_"))
                {
                    answer.amountanswer = Int32.Parse(key.Value);
                }

                //insert answer to db
                var tempID = key.Key;
                var result = tempID.Substring(tempID.LastIndexOf('_') + 1);

                var questionnaireID = result.Substring(0, result.IndexOf(' '));
                var questionID = result.Substring(result.LastIndexOf(' ') + 1);

                var succes = await objds.addAnswer(new ObjectId(questionID), new ObjectId(questionnaireID),answer);
                if (!succes)
                {
                    return RedirectToAction("Index", "Patient");
                }
            }

            var succes2 = await objds.incAnswerAmt();

            return RedirectToAction("Succes", "Patient");
        }
    }
}
