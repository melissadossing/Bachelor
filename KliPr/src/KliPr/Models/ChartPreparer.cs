using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using MongoDB.Bson;

namespace KliPr.Models
{
    public class ChartPreparer
    {
        public ChartPreparer(Question q)
        {
            questionid = q.Id;
            text = q.text;
            type = q.type;
            answerlist = q.answers;
            textanswers = new List<textanswerwamount>();
            foreach(var qi in q.textanswers)
            {
                textanswers.Add(new textanswerwamount
                {
                    Id = qi.Id,
                    text = qi.text,
                
                });
            }

            foreach(var ta in textanswers)
            {
                foreach(var a in answerlist)
                {
                    if (ta.Id == a.textanswer)
                    {
                        ta.amount++;
                    }
                }
            }
        }
        public ObjectId questionid { get; set; }
        public string text { get; set; }
        public int type { get; set; }
        public List<Answer> answerlist { get; set; }
        public List<textanswerwamount> textanswers {get;set;}
    }

    public class textanswerwamount : Textanswer
    {
        public textanswerwamount()
        {
            amount = 0;
        }
        public int amount { get; set; }
    }
}
