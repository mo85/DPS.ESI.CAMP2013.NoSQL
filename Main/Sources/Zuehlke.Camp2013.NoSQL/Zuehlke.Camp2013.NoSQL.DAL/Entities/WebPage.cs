using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Zuehlke.Camp2013.NoSQL.DAL.Entities
{
    [BsonIgnoreExtraElements]
    public class WebPage
    {
        public ObjectId Id { get; set; }

        public string Url { get; set; }

        //public string Content { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}