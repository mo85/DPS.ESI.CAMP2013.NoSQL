using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Zuehlke.Camp2013.NoSQL.DAL.Entities
{
    public class WebPageEntity
    {
        public string Url { get; set; }

        public virtual ObjectId Id { get; private set; }

        [BsonIgnore]
        public string Content { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public IEnumerable<SearchIndexEntryEntity> SearchIndexEntities { get; set; }
    }
}