using System.Collections.Generic;

namespace Zuehlke.Camp2013.NoSQL.Shared.Models
{
    public class PagedSearchResult
    {
        public IEnumerable<SearchResult> SearchResults { get; set; }

        public int TotalRecords { get; set; }
    }
}
