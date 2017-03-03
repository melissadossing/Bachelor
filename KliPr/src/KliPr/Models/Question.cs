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
        public string t0a0 { get; set; }
        public string t0a1 { get; set; }
        public string t0a2 { get; set; }
        public string t0a3 { get; set; }
        public int t1a0 { get; set; }
        public int t1a1 { get; set; }
        public int type { get; set; }
        public bool needanswer { get; set; }
        public List <Answer> answers { get; set; }
    }
}
