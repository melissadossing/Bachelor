using MongoDB.Bson;
using MongoDB.Driver;
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


        public Questionnaire GetById(ObjectId id)
        {
            var temp = _db.GetCollection<Questionnaire>("Questionnaires").Find(a => a.Id == id).ToList();
            if (temp.Any())
                
                return temp.First();
            return null;
        }

        public async Task<bool> addAnswer(ObjectId questionId, ObjectId questionnaireId, Answer a)
        {
            var filter = Builders<Questionnaire>.Filter.And(
            Builders<Questionnaire>.Filter.Where(x => x.Id == questionnaireId),
            Builders<Questionnaire>.Filter.Eq("Questions.Id", questionId));

            var update = Builders<Questionnaire>.Update.Push("Questions.$.answers", a);

            var ret = await _db.GetCollection<Questionnaire>("Questionnaires").FindOneAndUpdateAsync(filter, update);



            if (ret != null)
            {
                return true;
            }
            return false;
        }


        public async Task<bool> incAnswerAmt(ObjectId id)
        {

            var filter1 = Builders<Questionnaire>.Filter.Eq("Id", id);
            var update1 = Builders<Questionnaire>.Update.Inc("answeramount", 1);
            var ret1 = await _db.GetCollection<Questionnaire>("Questionnaires").UpdateOneAsync(filter1, update1);


            if (ret1 != null)
            {
                return true;
            }
            return false;
        }

    }
}
