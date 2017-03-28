using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KliPr.Models
{
    public class ChartPie
    {
        DataAccess objds;
        public List<ChartPreparer> cplist = new List<ChartPreparer>();

        public ChartPie(ObjectId questionnaireid)
        {
            objds = new DataAccess();
            var questionnaire = objds.GetById(questionnaireid);
            foreach(var q in questionnaire.Questions)
            {
               cplist.Add(new ChartPreparer(q));
            }
        }   
    }
}
