using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KliPr.Models
{
    public class Question
    {
        public ObjectId Id { get; set; }
        public string text { get; set; }
        public int t1a0 { get; set; }
        public int t1a1 { get; set; }
        public int type { get; set; }
        public bool needanswer { get; set; }
        public List <Answer> answers { get; set; }
        public List<Textanswer> textanswers { get; set; }
    }
}
