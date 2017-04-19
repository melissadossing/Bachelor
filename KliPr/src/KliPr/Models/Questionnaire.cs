using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KliPr.Models
{
    public class Questionnaire
    {
        public Questionnaire()
        {
            name = "";
            active = false;
            Questions = new List<Question>();
        }

        public ObjectId Id { get; set; }
        public string name { get; set; }
        public bool active { get; set; }
        public int answeramount { get; set; }    
        public int participant { get; set; }           
        public List<Question> Questions { get; set; }
    }
}
