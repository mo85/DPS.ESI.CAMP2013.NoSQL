using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Zuehlke.Camp2013.NoSQL.DAL.Entities
{
    public class SearchIndexEntry
    {
        [BsonId]
        public string Word { get; set; }

        public ICollection<SearchIndexRanking> WebPages { get; set; } 
    }
}