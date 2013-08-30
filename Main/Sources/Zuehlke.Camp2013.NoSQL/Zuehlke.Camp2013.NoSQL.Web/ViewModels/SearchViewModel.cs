using Zuehlke.Camp2013.NoSQL.Shared.Models;

namespace Zuehlke.Camp2013.NoSQL.Web.ViewModels
{
    public class SearchViewModel
    {
        public PagedSearchResult PagedSearchResult { get; set; }

        public SearchParameter SearchParameter { get; set; }
    }
}