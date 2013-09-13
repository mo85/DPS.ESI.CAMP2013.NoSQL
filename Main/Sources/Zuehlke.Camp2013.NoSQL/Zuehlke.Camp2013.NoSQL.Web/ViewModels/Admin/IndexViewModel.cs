namespace Zuehlke.Camp2013.NoSQL.Web.ViewModels.Admin
{
    using System.Collections.Generic;

    public class IndexViewModel
    {
        public long NrPagesCrawled { get; set; }

        public long NrPagesIndexed { get; set; }

        public long NrDistinctWords { get; set; }

        public long NrIndexesTotal { get; set; }

        public double AvgIndexesPerPage
        {
            get
            {
                return (double)NrIndexesTotal / NrPagesIndexed;
            }
        }

        public Dictionary<string, int> PagesWithMostIndexes { get; set; }

        public Dictionary<string, int> PagesWithLeastIndexes { get; set; }
    }
}