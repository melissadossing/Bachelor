using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using KliPr.Models;

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

        [HttpPost]
        public IActionResult Index(FormCollection fc)
        {
            var todelete = Request.Form["ObjectID"];


            //foreach (var d in todelete)
            //{
            //    ObjectId delid = new ObjectId(d);
            //    objds.delete(delid);
            //}

            foreach (var key in Request.Form)
            {
                var answer = new Answer();

                if (key.Key.StartsWith("textanswer_"))
                {
                    answer.textanswer = key.Value;
                    int x = 8;
                }
                if (key.Key.StartsWith("numberanswer_"))
                {
                    answer.amountanswer = Int32.Parse(key.Value);
                    int x = 8;
                }
            }

            return RedirectToAction("Delete", "Forsker");
        }
    }
}
