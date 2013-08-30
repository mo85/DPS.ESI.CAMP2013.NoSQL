using System.Linq;
using HtmlAgilityPack;

namespace Zuehlke.Camp2013.NoSQL.WebCrawler.Crawler.Processors
{
    public class DescriptionExtractor
    {
        public string ExtractDescription(string html)
        {
            var doc = new HtmlDocument();
            doc.LoadHtml(html);

            string desc = (from x in doc.DocumentNode.Descendants() 
                where x.Name.ToLower() == "meta"
                      && x.Attributes["name"] != null
                      && x.Attributes["name"].Value.ToLower() == "description"
                select x.Attributes["content"].Value).FirstOrDefault();

            return desc;
        }
    }
}