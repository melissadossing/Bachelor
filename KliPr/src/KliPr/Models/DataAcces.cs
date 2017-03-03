using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

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

        public void SetActive(ObjectId q)
        {
            var updatemany = Builders<BsonDocument>.Update.Set("active", false);
            var filtermany = Builders<BsonDocument>.Filter.Empty;
            _db.GetCollection<BsonDocument>("Questionnaires").UpdateMany(filtermany, updatemany);


            var update = Builders<BsonDocument>.Update.Set("active", true);
            var filter = Builders<BsonDocument>.Filter.Eq("_id",q);
            _db.GetCollection<BsonDocument>("Questionnaires").UpdateOne(filter,update);
        }

        public Questionnaire GetActive()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("active", true);
            var temp = _db.GetCollection<Questionnaire>("Questionnaires").Find(a => a.active == true).ToList();

            if(temp.Any())
            return temp.First();
            return null;
        }

    }
}
