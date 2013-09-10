using System.Collections.Generic;
using Zuehlke.Camp2013.NoSQL.DAL.Entities;

namespace Zuehlke.Camp2013.NoSQL.DAL.Services
{
    public interface ISearchContext
    {
        IEnumerable<WebPageEntity> Pages { get; }

        IEnumerable<SearchIndexEntryEntity> IndexEntries { get; }

        int SaveChanges();

        void Add(SearchIndexEntryEntity indexEntry);

        void Add(WebPageEntity page);

        void Remove(WebPageEntity page);

        void Remove(SearchIndexEntryEntity indexEntry);
    }
}
