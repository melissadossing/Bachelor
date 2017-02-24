using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Reflection;
using KliPr.ViewModels;
using MongoDB.Driver;
using MongoDB.Bson;

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
            var client = new MongoClient();
            var database = client.GetDatabase("foo");
            var collection = database.GetCollection<BsonDocument>("bar");

            var document = new BsonDocument{
                { "name", "MongoDB" },
                { "type", "Database" },
                { "count", 1 },
                { "info", new BsonDocument
                    {
                        { "x", 203 },
                        { "y", 102 }
                    }}
            };

            collection.InsertOne(document);



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
