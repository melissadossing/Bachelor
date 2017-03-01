using KliPr.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KliPr.ViewModels
{
    public class QuestionnaireListViewModel
    {
        public QuestionnaireListViewModel(ObjectId qid, string qname, bool qactive)
        {
            Id = qid;
            name = qname;
            active = qactive;
        }
        public ObjectId Id { get; set; }
        public string name { get; set; }
        public bool active { get; set; }
    }

}
