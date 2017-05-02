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
        public QuestionnaireListViewModel(ObjectId qid, string qname, bool qactive, int amt, int participnt)
        {
            Id = qid;
            name = qname;
            active = qactive;
            answeramount = amt;
            participant = participnt;
        }
        public ObjectId Id { get; set; }
        public string name { get; set; }
        public bool active { get; set; }
        public int answeramount { get; set; }

        public int participant { get; set; }
    }

}
