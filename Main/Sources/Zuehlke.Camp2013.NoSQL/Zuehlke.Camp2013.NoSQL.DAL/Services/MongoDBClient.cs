using System.Collections.Generic;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using Zuehlke.Camp2013.NoSQL.DAL.Entities;

namespace Zuehlke.Camp2013.NoSQL.DAL.Services
{
    public class MongoDBClient : ISearchContext
    {
        private readonly MongoDatabase database;

        public MongoDBClient()
        {
            var client = new MongoClient();
            var server = client.GetServer();

            database = server.GetDatabase("zuehlke-search");
        }

        public IEnumerable<WebPageEntity> Pages { get { return WebPagesCollection.FindAll(); } }

        public IEnumerable<SearchIndexEntryEntity> IndexEntries { get { return IndexEntriesCollection.FindAll(); } }
        
        public int SaveChanges()
        {
            // do nothing - not required for this implementation
            return 0;
        }

        public void Add(SearchIndexEntryEntity indexEntry)
        {
            IndexEntriesCollection.Save(indexEntry);
        }

        public void Add(WebPageEntity page)
        {
            WebPagesCollection.Save(page);
        }

        public void Remove(WebPageEntity page)
        {
            var query = Query<WebPageEntity>.EQ(x => x.Id, page.Id);
            WebPagesCollection.Remove(query);
        }
        
        private MongoCollection<WebPageEntity> WebPagesCollection
        {
            get { return database.GetCollection<WebPageEntity>("WebPages"); }
        }

        private MongoCollection<SearchIndexEntryEntity> IndexEntriesCollection
        {
            get { return database.GetCollection<SearchIndexEntryEntity>("SearchIndexEntries"); }
        }
    }
}
