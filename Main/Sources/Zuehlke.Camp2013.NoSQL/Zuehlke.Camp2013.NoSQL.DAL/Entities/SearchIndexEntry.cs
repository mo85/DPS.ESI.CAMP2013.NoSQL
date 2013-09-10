namespace Zuehlke.Camp2013.NoSQL.DAL.Entities
{
    public class SearchIndexEntry
    {
        public string Word { get; set; }

        public virtual int Ranking { get; set; }
    }
}