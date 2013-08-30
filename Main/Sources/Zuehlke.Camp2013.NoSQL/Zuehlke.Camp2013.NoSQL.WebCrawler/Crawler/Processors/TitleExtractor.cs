using HtmlAgilityPack;

namespace Zuehlke.Camp2013.NoSQL.WebCrawler.Crawler.Processors
{
    public class TitleExtractor
    {
        public string ExtractTitle(string html)
        {
            string result = string.Empty;
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            const string xpathExpression = "//title";
            var titleNode = htmlDoc.DocumentNode.SelectSingleNode(xpathExpression);

            if (titleNode != null)
            {
                result = titleNode.InnerText;
            }
            
            return result;
        }
    }
}
