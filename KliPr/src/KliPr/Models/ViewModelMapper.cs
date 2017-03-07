using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KliPr.ViewModels;
using MongoDB.Bson;

namespace KliPr.Models
{
    public class ViewModelMapper
    {
        public Questionnaire Map(QuestionnaireViewModel qvm)
        {
            var q = new Questionnaire();
            q.name = qvm.name;
            q.active = false;

            if (qvm.q0name != null)
            {
                q.Questions.Add(new Question() {
                    text = qvm.q0name,
                    needanswer = qvm.needanswer0,
                    t0a0 = qvm.q0t0a0,
                    t0a1 = qvm.q0t0a1,
                    t0a2 = qvm.q0t0a2,
                    t0a3 = qvm.q0t0a3,
                    t1a0 = qvm.q0t1a0,
                    t1a1 = qvm.q0t1a1,
                    Id = ObjectId.GenerateNewId(),
                    answers = new List<Answer>(),
                    type = qvm.q0type

                });
            }

            if (qvm.q1name != null)
            {
                q.Questions.Add(new Question()
                {
                    text = qvm.q1name,
                    needanswer = qvm.needanswer1,
                    t0a0 = qvm.q1t0a0,
                    t0a1 = qvm.q1t0a1,
                    t0a2 = qvm.q1t0a2,
                    t0a3 = qvm.q1t0a3,
                    t1a0 = qvm.q1t1a0,
                    t1a1 = qvm.q1t1a1,
                    Id = ObjectId.GenerateNewId(),
                    answers = new List<Answer>(),
                    type = qvm.q1type
                });
            }
            if (qvm.q2name != null)
            {
                q.Questions.Add(new Question()
                {
                    text = qvm.q2name,
                    needanswer = qvm.needanswer2,
                    t0a0 = qvm.q2t0a0,
                    t0a1 = qvm.q2t0a1,
                    t0a2 = qvm.q2t0a2,
                    t0a3 = qvm.q2t0a3,
                    t1a0 = qvm.q2t1a0,
                    t1a1 = qvm.q2t1a1,
                    Id = ObjectId.GenerateNewId(),
                    answers = new List<Answer>(),
                    type = qvm.q2type
                });
            }
            if (qvm.q3name != null)
            {
                q.Questions.Add(new Question()
                {
                    text = qvm.q3name,
                    needanswer = qvm.needanswer3,
                    t0a0 = qvm.q3t0a0,
                    t0a1 = qvm.q3t0a1,
                    t0a2 = qvm.q3t0a2,
                    t0a3 = qvm.q3t0a3,
                    t1a0 = qvm.q3t1a0,
                    t1a1 = qvm.q3t1a1,
                    Id = ObjectId.GenerateNewId(),
                    answers = new List<Answer>(),
                    type = qvm.q2type
                });
            }
            if (qvm.q4name != null)
            {
                q.Questions.Add(new Question()
                {
                    text = qvm.q4name,
                    needanswer = qvm.needanswer4,
                    t0a0 = qvm.q4t0a0,
                    t0a1 = qvm.q4t0a1,
                    t0a2 = qvm.q4t0a2,
                    t0a3 = qvm.q4t0a3,
                    t1a0 = qvm.q4t1a0,
                    t1a1 = qvm.q4t1a1,
                    Id = ObjectId.GenerateNewId(),
                    answers = new List<Answer>(),
                    type = qvm.q3type
                });
            }

            return q;
        }


    }
}
