using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KliPr.Models
{
    public class Answer
    {
        ObjectId questionID;
        public string textanswer;
        public int amountanswer;
        public int participanttype;
    }
}
