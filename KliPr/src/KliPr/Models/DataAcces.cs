using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KliPr.Models
{
    public class DataAccess
    {
        MongoClient _client;
        IMongoDatabase _db;

        public DataAccess()
        {
            _client = new MongoClient("mongodb://localhost:27017");
            _db = _client.GetDatabase("QuestionnaireDB");
        }

        public Questionnaire Create(Questionnaire q)
        {
            _db.GetCollection<Questionnaire>("Questionnaires").InsertOne(q);
            return q;
        }

        public List<Questionnaire> GetAll()
        {
            var documents = _db.GetCollection<Questionnaire>("Questionnaires").Find(new BsonDocument()).ToList();

            return documents;
        }

        public void delete(ObjectId q)
        {
            _db.GetCollection<Questionnaire>("Questionnaires").DeleteOne(a => a.Id == q);
        }

    }
}
