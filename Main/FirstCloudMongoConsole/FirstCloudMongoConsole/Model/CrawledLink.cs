using MongoDB.Bson;

namespace FirstCloudMongoConsole.Model
{
    public class CrawledLink
    {
        public ObjectId Id { get; set; }

        public string ReferencedURL { get; set; }

        public string Label { get; set; }

        public override string ToString()
        {
            return string.Format("Link #{0}, Named: {1}, Points to: {2}", Id, Label, ReferencedURL);
        }
    }
}
