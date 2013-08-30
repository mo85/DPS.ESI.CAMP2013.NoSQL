using Abot.Poco;
using Zuehlke.Camp2013.NoSQL.Shared.Models;
using Zuehlke.Camp2013.NoSQL.WebCrawler.Crawler.Processors;

namespace Zuehlke.Camp2013.NoSQL.WebCrawler.Crawler
{
    public static class WebPageFactory
    {
        public static WebPage CreateWebPage(CrawledPage crawledPage)
        {
            var htmlContent = crawledPage.RawContent;
            var page = new WebPage
            {
                Content = htmlContent,
                Url = crawledPage.Uri.AbsoluteUri,
                PageHeadings = ExtractHeadings(htmlContent),
                ReferencedUrls = ExtractLinks(htmlContent),
                Title = ExtractTitle(htmlContent),
                Description = ExtractDescription(htmlContent),
            };

            return page;
        }

        private static string ExtractDescription(string htmlContent)
        {
            return new DescriptionExtractor().ExtractDescription(htmlContent);
        }

        private static string ExtractTitle(string htmlContent)
        {
            return new TitleExtractor().ExtractTitle(htmlContent);
        }

        private static PageHeading[] ExtractHeadings(string htmlContent)
        {
            return new HeadingExtractor().ExtractPageHeadings(htmlContent);
        }

        private static string[] ExtractLinks(string htmlContent)
        {
            return new LinkExtractor().ExtractLinks(htmlContent);
        }
    }
}
