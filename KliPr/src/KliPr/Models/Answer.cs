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
        public ObjectId textanswer;
        public int amountanswer;
        public string singletext;
        public int participanttype;
        public string elaboration;
    }
}
