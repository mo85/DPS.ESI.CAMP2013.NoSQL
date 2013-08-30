namespace Zuehlke.Camp2013.NoSQL.Shared.Models
{
    public class WebPage
    {
        public string Url { get; set; }

        public string Content { get; set; }

        public string[] ReferencedUrls { get; set; }

        public PageHeading[] PageHeadings { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}