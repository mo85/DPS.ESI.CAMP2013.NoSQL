using System.Collections.Generic;
using FirstCloudMongoConsole.Model;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace FirstCloudMongoConsole.Services
{
    public class LinkService
    {
        private readonly MongoCollection<CrawledLink> linkCollection;

        private const string LinkCollectionName = "Links";

        public LinkService(MongoDatabase database)
        {
            linkCollection = database.GetCollection<CrawledLink>(LinkCollectionName);
        }

        public IEnumerable<CrawledLink> AllLinks()
        {
            return linkCollection.FindAll();
        }

        public CrawledLink FindLink(ObjectId id)
        {
            var query = Query<CrawledLink>.EQ(x => x.Id, id);
            return linkCollection.FindOneAs<CrawledLink>(query);
        }

        public IEnumerable<CrawledLink> FindByQuery(IMongoQuery query)
        {
            return linkCollection.Find(query);
        } 

        public WriteConcernResult Save(CrawledLink link)
        {
            return linkCollection.Save(link);
        }

        public WriteConcernResult Delete(ObjectId id)
        {
            var query = Query<CrawledLink>.EQ(x => x.Id, id);
            return linkCollection.Remove(query);
        }

        public WriteConcernResult DeleteAll()
        {
            return linkCollection.RemoveAll();
        }
    }
}
