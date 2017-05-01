using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using KliPr.Models;
using System.Text;

namespace KliPr.Helpers
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Export
    {
        public interface IExport
        {
            string Export(Questionnaire q);
        }

        public class ExportCSV : IExport
        {
            public string Export(Questionnaire q)
            {

                StringBuilder builder = new StringBuilder();
                builder.Append('"').Append(q.name).Append('"').AppendLine();

                foreach(var question in q.Questions)
                {
                    builder.Append('"').Append(question.text).Append('"').Append(",");
                    foreach(var ans in question.answers)
                    {
                        //radiotype
                        if(question.type == 0)
                            
                        {
                            foreach(var tas in question.textanswers)
                            {
                                if(ans.textanswer == tas.Id)
                                {
                                    builder.Append('"').Append(tas.text).Append('"').Append(",");
                                }
                            }
                            
                        }
                       
                        //textareatype
                        if(question.type == 2)
                        {
                            if (ans.singletext != "")
                                builder.Append('"').Append(ans.singletext).Append('"').Append(",");
                        }
                    }

                    builder.AppendLine();
                }
                
                return builder.ToString(); ;
            }
        }

        public class ExportJSON : IExport
        {
            public string Export(Questionnaire q)
            {
                return "N/A";
            }
        }

        public class ExportXML : IExport
        {
            public string Export(Questionnaire q)
            {
                return "N/A";
            }
        }

        public class ExportClient
        {
            public IExport Strategy { get; set; }

            public ExportClient(IExport strategy)
            {
                Strategy = strategy;
            }

            public string Export(Questionnaire q)
            {
                return Strategy.Export(q);
            }
        }
    }
}
