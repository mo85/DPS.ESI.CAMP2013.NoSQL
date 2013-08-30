using System.Data.Entity;
using Zuehlke.Camp2013.NoSQL.DAL.Entities;

namespace Zuehlke.Camp2013.NoSQL.DAL.Services
{
    public class SearchEngineContext : DbContext
    {
        public SearchEngineContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<WebPageEntity> WebPages { get; set; }

        public DbSet<SearchIndexEntryEntity> SearchIndexEntries { get; set; }
    }
}