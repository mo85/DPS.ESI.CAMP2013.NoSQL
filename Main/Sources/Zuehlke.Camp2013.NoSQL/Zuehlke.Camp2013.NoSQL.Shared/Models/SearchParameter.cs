namespace Zuehlke.Camp2013.NoSQL.Shared.Models
{
    public class SearchParameter
    {
        private int pageSize = 5;
        
        public string Query { get; set; }
        
        public int Page { get; set; }

        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = value; }
        }
    }
}