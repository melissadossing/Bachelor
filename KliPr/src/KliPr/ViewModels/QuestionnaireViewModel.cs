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
        public string q0t0a4 { get; set; }
        public int q0t1a0 { get; set; }
        public int q0t1a1 { get; set; }
        public bool needanswer0 { get; set; }
        public int q0type { get; set; }


        public string q1name { get; set; }
        public string q1t0a0 { get; set; }
        public string q1t0a1 { get; set; }
        public string q1t0a2 { get; set; }
        public string q1t0a3 { get; set; }
        public string q1t0a4 { get; set; }
        public int q1t1a0 { get; set; }
        public int q1t1a1 { get; set; }
        public bool needanswer1 { get; set; }
        public int q1type { get; set; }



        public string q2name { get; set; }
        public string q2t0a0 { get; set; }
        public string q2t0a1 { get; set; }
        public string q2t0a2 { get; set; }
        public string q2t0a3 { get; set; }
        public string q2t0a4 { get; set; }
        public int q2t1a0 { get; set; }
        public int q2t1a1 { get; set; }
        public bool needanswer2 { get; set; }
        public int q2type { get; set; }


        public string q3name { get; set; }
        public string q3t0a0 { get; set; }
        public string q3t0a1 { get; set; }
        public string q3t0a2 { get; set; }
        public string q3t0a3 { get; set; }
        public string q3t0a4 { get; set; }
        public int q3t1a0 { get; set; }
        public int q3t1a1 { get; set; }
        public bool needanswer3 { get; set; }
        public int q3type { get; set; }


        public string q4name { get; set; }
        public string q4t0a0 { get; set; }
        public string q4t0a1 { get; set; }
        public string q4t0a2 { get; set; }
        public string q4t0a3 { get; set; }
        public string q4t0a4 { get; set; }
        public int q4t1a0 { get; set; }
        public int q4t1a1 { get; set; }
        public bool needanswer4 { get; set; }
        public int q4type { get; set; }

        public string q5name { get; set; }
        public string q5t0a0 { get; set; }
        public string q5t0a1 { get; set; }
        public string q5t0a2 { get; set; }
        public string q5t0a3 { get; set; }
        public string q5t0a4 { get; set; }
        public int q5t1a0 { get; set; }
        public int q5t1a1 { get; set; }
        public bool needanswer5 { get; set; }
        public int q5type { get; set; }

        public string q6name { get; set; }
        public string q6t0a0 { get; set; }
        public string q6t0a1 { get; set; }
        public string q6t0a2 { get; set; }
        public string q6t0a3 { get; set; }
        public string q6t0a4 { get; set; }
        public int q6t1a0 { get; set; }
        public int q6t1a1 { get; set; }
        public bool needanswer6 { get; set; }
        public int q6type { get; set; }

        public string q7name { get; set; }
        public string q7t0a0 { get; set; }
        public string q7t0a1 { get; set; }
        public string q7t0a2 { get; set; }
        public string q7t0a3 { get; set; }
        public string q7t0a4 { get; set; }
        public int q7t1a0 { get; set; }
        public int q7t1a1 { get; set; }
        public bool needanswer7 { get; set; }
        public int q7type { get; set; }

        public string q8name { get; set; }
        public string q8t0a0 { get; set; }
        public string q8t0a1 { get; set; }
        public string q8t0a2 { get; set; }
        public string q8t0a3 { get; set; }
        public string q8t0a4 { get; set; }
        public int q8t1a0 { get; set; }
        public int q8t1a1 { get; set; }
        public bool needanswer8 { get; set; }
        public int q8type { get; set; }

        public string q9name { get; set; }
        public string q9t0a0 { get; set; }
        public string q9t0a1 { get; set; }
        public string q9t0a2 { get; set; }
        public string q9t0a3 { get; set; }
        public string q9t0a4 { get; set; }
        public int q9t1a0 { get; set; }
        public int q9t1a1 { get; set; }
        public bool needanswer9 { get; set; }
        public int q9type { get; set; }

        public string q10name { get; set; }
        public string q10t0a0 { get; set; }
        public string q10t0a1 { get; set; }
        public string q10t0a2 { get; set; }
        public string q10t0a3 { get; set; }
        public string q10t0a4 { get; set; }
        public int q10t1a0 { get; set; }
        public int q10t1a1 { get; set; }
        public bool needanswer10 { get; set; }
        public int q10type { get; set; }

        public string q11name { get; set; }
        public string q11t0a0 { get; set; }
        public string q11t0a1 { get; set; }
        public string q11t0a2 { get; set; }
        public string q11t0a3 { get; set; }
        public string q11t0a4 { get; set; }
        public int q11t1a0 { get; set; }
        public int q11t1a1 { get; set; }
        public bool needanswer11 { get; set; }
        public int q11type { get; set; }

        public string q12name { get; set; }
        public string q12t0a0 { get; set; }
        public string q12t0a1 { get; set; }
        public string q12t0a2 { get; set; }
        public string q12t0a3 { get; set; }
        public string q12t0a4 { get; set; }
        public int q12t1a0 { get; set; }
        public int q12t1a1 { get; set; }
        public bool needanswer12 { get; set; }
        public int q12type { get; set; }

        public string q13name { get; set; }
        public string q13t0a0 { get; set; }
        public string q13t0a1 { get; set; }
        public string q13t0a2 { get; set; }
        public string q13t0a3 { get; set; }
        public string q13t0a4 { get; set; }
        public int q13t1a0 { get; set; }
        public int q13t1a1 { get; set; }
        public bool needanswer13 { get; set; }
        public int q13type { get; set; }
    }
}
