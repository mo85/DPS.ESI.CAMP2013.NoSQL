using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Zuehlke.Camp2013.NoSQL.DAL.Entities;

namespace Zuehlke.Camp2013.NoSQL.DAL.Services
{
    public class SearchEngineContext : DbContext, ISearchContext
    {
        public SearchEngineContext()
            : base("DefaultConnection")
        {
        }

        public IEnumerable<WebPageEntity> Pages 
        { 
            get { return WebPages.AsEnumerable(); }  
        }

        public IEnumerable<SearchIndexEntryEntity> IndexEntries
        {
            get { return SearchIndexEntries.AsEnumerable(); }
        }

        public void Add(SearchIndexEntryEntity indexEntry)
        {
            SearchIndexEntries.Add(indexEntry);
        }

        public void Add(WebPageEntity page)
        {
            WebPages.Add(page);
        }

        public void Remove(WebPageEntity page)
        {
            WebPages.Remove(page);
        }

        public void Remove(SearchIndexEntryEntity indexEntry)
        {
            SearchIndexEntries.Remove(indexEntry);
        }


        public DbSet<WebPageEntity> WebPages { get; set; }

        public DbSet<SearchIndexEntryEntity> SearchIndexEntries { get; set; }
    }
}