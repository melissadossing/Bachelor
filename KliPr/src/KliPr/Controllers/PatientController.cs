using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index()
        {
            var questionnaires = objds.GetAll();
            return View(questionnaires);
        }
    }
}
