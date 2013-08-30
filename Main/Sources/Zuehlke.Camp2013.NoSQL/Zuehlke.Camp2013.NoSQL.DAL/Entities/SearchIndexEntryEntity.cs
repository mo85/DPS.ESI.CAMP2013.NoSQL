using System;

namespace Zuehlke.Camp2013.NoSQL.DAL.Entities
{
    public class SearchIndexEntryEntity
    {
        public virtual Guid Id { get; set; }

        public virtual string Word { get; set; }

        public virtual WebPageEntity WebPage { get; set; }

        public virtual int Rangking { get; set; }
    }
}