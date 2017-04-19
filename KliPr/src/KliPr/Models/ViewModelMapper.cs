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
            q.participant = qvm.participant;

            if (qvm.q0name != null)
            {
                q.Questions.Add(new Question() {
                    text = qvm.q0name,
                    needanswer = qvm.needanswer0,
                    t1a0 = qvm.q0t1a0,
                    t1a1 = qvm.q0t1a1,
                    Id = ObjectId.GenerateNewId(),
                    answers = new List<Answer>(),
                    textanswers = TextAnswersToList(qvm.q0t0a0, qvm.q0t0a1, qvm.q0t0a2, qvm.q0t0a3, qvm.q0t0a4),
                    type = qvm.q0type

                });
            }

            if (qvm.q1name != null)
            {
                q.Questions.Add(new Question()
                {
                    text = qvm.q1name,
                    needanswer = qvm.needanswer1,
                    t1a0 = qvm.q1t1a0,
                    t1a1 = qvm.q1t1a1,
                    Id = ObjectId.GenerateNewId(),
                    answers = new List<Answer>(),
                    textanswers = TextAnswersToList(qvm.q1t0a0, qvm.q1t0a1, qvm.q1t0a2, qvm.q1t0a3, qvm.q1t0a4),
                    type = qvm.q1type
                });
            }
            if (qvm.q2name != null)
            {
                q.Questions.Add(new Question()
                {
                    text = qvm.q2name,
                    needanswer = qvm.needanswer2,
                    t1a0 = qvm.q2t1a0,
                    t1a1 = qvm.q2t1a1,
                    Id = ObjectId.GenerateNewId(),
                    answers = new List<Answer>(),
                    textanswers = TextAnswersToList(qvm.q2t0a0, qvm.q2t0a1, qvm.q2t0a2, qvm.q2t0a3, qvm.q2t0a4),
                    type = qvm.q2type
                });
            }
            if (qvm.q3name != null)
            {
                q.Questions.Add(new Question()
                {
                    text = qvm.q3name,
                    needanswer = qvm.needanswer3,
                    t1a0 = qvm.q3t1a0,
                    t1a1 = qvm.q3t1a1,
                    Id = ObjectId.GenerateNewId(),
                    answers = new List<Answer>(),
                    textanswers = TextAnswersToList(qvm.q3t0a0, qvm.q3t0a1, qvm.q3t0a2, qvm.q3t0a3, qvm.q3t0a4),
                    type = qvm.q3type
                });
            }
            if (qvm.q4name != null)
            {
                q.Questions.Add(new Question()
                {
                    text = qvm.q4name,
                    needanswer = qvm.needanswer4,
                    t1a0 = qvm.q4t1a0,
                    t1a1 = qvm.q4t1a1,
                    Id = ObjectId.GenerateNewId(),
                    answers = new List<Answer>(),
                    textanswers = TextAnswersToList(qvm.q4t0a0, qvm.q4t0a1, qvm.q4t0a2, qvm.q4t0a3, qvm.q4t0a4),
                    type = qvm.q4type
                });
            }
            if (qvm.q5name != null)
            {
                q.Questions.Add(new Question()
                {
                    text = qvm.q5name,
                    needanswer = qvm.needanswer5,
                    t1a0 = qvm.q5t1a0,
                    t1a1 = qvm.q5t1a1,
                    Id = ObjectId.GenerateNewId(),
                    answers = new List<Answer>(),
                    textanswers = TextAnswersToList(qvm.q5t0a0, qvm.q5t0a1, qvm.q5t0a2, qvm.q5t0a3, qvm.q5t0a4),
                    type = qvm.q5type
                });
            }
            if (qvm.q6name != null)
            {
                q.Questions.Add(new Question()
                {
                    text = qvm.q6name,
                    needanswer = qvm.needanswer6,
                    t1a0 = qvm.q6t1a0,
                    t1a1 = qvm.q6t1a1,
                    Id = ObjectId.GenerateNewId(),
                    answers = new List<Answer>(),
                    textanswers = TextAnswersToList(qvm.q6t0a0, qvm.q6t0a1, qvm.q6t0a2, qvm.q6t0a3, qvm.q6t0a4),
                    type = qvm.q6type
                });
            }
            if (qvm.q7name != null)
            {
                q.Questions.Add(new Question()
                {
                    text = qvm.q7name,
                    needanswer = qvm.needanswer7,
                    t1a0 = qvm.q7t1a0,
                    t1a1 = qvm.q7t1a1,
                    Id = ObjectId.GenerateNewId(),
                    answers = new List<Answer>(),
                    textanswers = TextAnswersToList(qvm.q7t0a0, qvm.q7t0a1, qvm.q7t0a2, qvm.q7t0a3, qvm.q7t0a4),
                    type = qvm.q7type
                });
            }
            if (qvm.q8name != null)
            {
                q.Questions.Add(new Question()
                {
                    text = qvm.q8name,
                    needanswer = qvm.needanswer8,
                    t1a0 = qvm.q8t1a0,
                    t1a1 = qvm.q8t1a1,
                    Id = ObjectId.GenerateNewId(),
                    answers = new List<Answer>(),
                    textanswers = TextAnswersToList(qvm.q8t0a0, qvm.q8t0a1, qvm.q8t0a2, qvm.q8t0a3, qvm.q8t0a4),
                    type = qvm.q3type
                });
            }
            if (qvm.q9name != null)
            {
                q.Questions.Add(new Question()
                {
                    text = qvm.q9name,
                    needanswer = qvm.needanswer9,
                    t1a0 = qvm.q9t1a0,
                    t1a1 = qvm.q9t1a1,
                    Id = ObjectId.GenerateNewId(),
                    answers = new List<Answer>(),
                    textanswers = TextAnswersToList(qvm.q9t0a0, qvm.q9t0a1, qvm.q9t0a2, qvm.q9t0a3, qvm.q9t0a4),
                    type = qvm.q9type
                });
            }
            if (qvm.q10name != null)
            {
                q.Questions.Add(new Question()
                {
                    text = qvm.q10name,
                    needanswer = qvm.needanswer10,
                    t1a0 = qvm.q10t1a0,
                    t1a1 = qvm.q10t1a1,
                    Id = ObjectId.GenerateNewId(),
                    answers = new List<Answer>(),
                    textanswers = TextAnswersToList(qvm.q10t0a0, qvm.q10t0a1, qvm.q10t0a2, qvm.q10t0a3, qvm.q10t0a4),
                    type = qvm.q10type
                });
            }
            if (qvm.q11name != null)
            {
                q.Questions.Add(new Question()
                {
                    text = qvm.q11name,
                    needanswer = qvm.needanswer11,
                    t1a0 = qvm.q11t1a0,
                    t1a1 = qvm.q11t1a1,
                    Id = ObjectId.GenerateNewId(),
                    answers = new List<Answer>(),
                    textanswers = TextAnswersToList(qvm.q11t0a0, qvm.q11t0a1, qvm.q11t0a2, qvm.q11t0a3, qvm.q11t0a4),
                    type = qvm.q11type
                });
            }
            if (qvm.q12name != null)
            {
                q.Questions.Add(new Question()
                {
                    text = qvm.q12name,
                    needanswer = qvm.needanswer12,
                    t1a0 = qvm.q12t1a0,
                    t1a1 = qvm.q12t1a1,
                    Id = ObjectId.GenerateNewId(),
                    answers = new List<Answer>(),
                    textanswers = TextAnswersToList(qvm.q12t0a0, qvm.q12t0a1, qvm.q12t0a2, qvm.q12t0a3, qvm.q12t0a4),
                    type = qvm.q12type
                });
            }
            if (qvm.q13name != null)
            {
                q.Questions.Add(new Question()
                {
                    text = qvm.q13name,
                    needanswer = qvm.needanswer13,
                    t1a0 = qvm.q13t1a0,
                    t1a1 = qvm.q13t1a1,
                    Id = ObjectId.GenerateNewId(),
                    answers = new List<Answer>(),
                    textanswers = TextAnswersToList(qvm.q13t0a0, qvm.q13t0a1, qvm.q13t0a2, qvm.q13t0a3, qvm.q13t0a4),
                    type = qvm.q13type
                });
            }
            if (qvm.q14name != null)
            {
                q.Questions.Add(new Question()
                {
                    text = qvm.q14name,
                    needanswer = qvm.needanswer14,
                    t1a0 = qvm.q14t1a0,
                    t1a1 = qvm.q14t1a1,
                    Id = ObjectId.GenerateNewId(),
                    answers = new List<Answer>(),
                    textanswers = TextAnswersToList(qvm.q14t0a0, qvm.q14t0a1, qvm.q14t0a2, qvm.q14t0a3, qvm.q14t0a4),
                    type = qvm.q14type
                });
            }
            if (qvm.q15name != null)
            {
                q.Questions.Add(new Question()
                {
                    text = qvm.q15name,
                    needanswer = qvm.needanswer15,
                    t1a0 = qvm.q15t1a0,
                    t1a1 = qvm.q15t1a1,
                    Id = ObjectId.GenerateNewId(),
                    answers = new List<Answer>(),
                    textanswers = TextAnswersToList(qvm.q15t0a0, qvm.q15t0a1, qvm.q15t0a2, qvm.q15t0a3, qvm.q15t0a4),
                    type = qvm.q15type
                });
            }
            if (qvm.q16name != null)
            {
                q.Questions.Add(new Question()
                {
                    text = qvm.q16name,
                    needanswer = qvm.needanswer16,
                    t1a0 = qvm.q16t1a0,
                    t1a1 = qvm.q16t1a1,
                    Id = ObjectId.GenerateNewId(),
                    answers = new List<Answer>(),
                    textanswers = TextAnswersToList(qvm.q16t0a0, qvm.q16t0a1, qvm.q16t0a2, qvm.q16t0a3, qvm.q16t0a4),
                    type = qvm.q16type
                });
            }
            if (qvm.q17name != null)
            {
                q.Questions.Add(new Question()
                {
                    text = qvm.q17name,
                    needanswer = qvm.needanswer17,
                    t1a0 = qvm.q17t1a0,
                    t1a1 = qvm.q17t1a1,
                    Id = ObjectId.GenerateNewId(),
                    answers = new List<Answer>(),
                    textanswers = TextAnswersToList(qvm.q17t0a0, qvm.q17t0a1, qvm.q17t0a2, qvm.q17t0a3, qvm.q17t0a4),
                    type = qvm.q17type
                });
            }
            if (qvm.q18name != null)
            {
                q.Questions.Add(new Question()
                {
                    text = qvm.q18name,
                    needanswer = qvm.needanswer18,
                    t1a0 = qvm.q18t1a0,
                    t1a1 = qvm.q18t1a1,
                    Id = ObjectId.GenerateNewId(),
                    answers = new List<Answer>(),
                    textanswers = TextAnswersToList(qvm.q18t0a0, qvm.q18t0a1, qvm.q18t0a2, qvm.q18t0a3, qvm.q18t0a4),
                    type = qvm.q18type
                });
            }
            if (qvm.q19name != null)
            {
                q.Questions.Add(new Question()
                {                   
                    text = qvm.q19name,
                    needanswer = qvm.needanswer19,
                    t1a0 = qvm.q19t1a0,
                    t1a1 = qvm.q19t1a1,
                    Id = ObjectId.GenerateNewId(),
                    answers = new List<Answer>(),
                    textanswers = TextAnswersToList(qvm.q19t0a0, qvm.q19t0a1, qvm.q19t0a2, qvm.q19t0a3, qvm.q19t0a4),
                    type = qvm.q19type
                });
            }

            return q;
        }

        public List<Textanswer> TextAnswersToList(params String[] textanswers)
        {
            if (textanswers != null)
            {
                var rettextanswers = new List<Textanswer>();
                
                for(int i = 0; i < textanswers.Length; i++)
                {
                    if(textanswers[i] != null)
                    rettextanswers.Add(new Textanswer(){ text = textanswers[i] });
                }

                return rettextanswers;
            }
            return null;
        }


    }
}
