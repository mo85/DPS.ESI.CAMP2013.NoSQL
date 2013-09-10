using MongoDB.Bson;

namespace Zuehlke.Camp2013.NoSQL.DAL.Entities
{
    public class DomainEntity
    {
        public virtual ObjectId Id { get; private set; }
    }
}
