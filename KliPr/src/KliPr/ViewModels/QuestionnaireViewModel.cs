using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KliPr.ViewModels
{
    public class QuestionnaireViewModel
    {
        public ObjectId Id { get; set; }
        public string name { get; set; }
        public bool active { get; set; }


        public string q0name { get; set; }
        public string q0t0a0 { get; set; }
        public string q0t0a1 { get; set; }
        public string q0t0a2 { get; set; }
        public string q0t0a3 { get; set; }
        public int q0t1a0 { get; set; }
        public int q0t1a1 { get; set; }
        public bool needanswer0 { get; set; }
        public int q0type { get; set; }


        public string q1name { get; set; }
        public string q1t0a0 { get; set; }
        public string q1t0a1 { get; set; }
        public string q1t0a2 { get; set; }
        public string q1t0a3 { get; set; }
        public int q1t1a0 { get; set; }
        public int q1t1a1 { get; set; }
        public bool needanswer1 { get; set; }
        public int q1type { get; set; }



        public string q2name { get; set; }
        public string q2t0a0 { get; set; }
        public string q2t0a1 { get; set; }
        public string q2t0a2 { get; set; }
        public string q2t0a3 { get; set; }
        public int q2t1a0 { get; set; }
        public int q2t1a1 { get; set; }
        public bool needanswer2 { get; set; }
        public int q2type { get; set; }


        public string q3name { get; set; }
        public string q3t0a0 { get; set; }
        public string q3t0a1 { get; set; }
        public string q3t0a2 { get; set; }
        public string q3t0a3 { get; set; }
        public int q3t1a0 { get; set; }
        public int q3t1a1 { get; set; }
        public bool needanswer3 { get; set; }
        public int q3type { get; set; }


        public string q4name { get; set; }
        public string q4t0a0 { get; set; }
        public string q4t0a1 { get; set; }
        public string q4t0a2 { get; set; }
        public string q4t0a3 { get; set; }
        public int q4t1a0 { get; set; }
        public int q4t1a1 { get; set; }
        public bool needanswer4 { get; set; }
        public int q4type { get; set; }
    }
}
