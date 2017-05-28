using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace KliPrTests.Mocks
{
    public class MongoDB
    {
        public interface IMongoDBRepository
        {
            Collection<T> GetCollection<T>(string name) where T :BsonDocument;
        }

        public class MongoDbRepository : IMongoDBRepository
        {
            public Collection<T> GetCollection<T>(string name)
              where T : BsonDocument
            {
                return MongoDatabase.GetCollection<BsonDocument>(name);
            }
        }
    }
}
