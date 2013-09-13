namespace Zuehlke.Camp2013.NoSQL.DAL.Entities
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class SearchIndexRanking
    {
        public ObjectId WebPageId { get; set; }

        public int Ranking { get; set; }
    }
}
