using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KliPr.Models
{
    public class Textanswer
    {
        public Textanswer()
        {
            Id = ObjectId.GenerateNewId();
        }
        public ObjectId Id { get; set; }
        public string text { get; set; }
    }
}
