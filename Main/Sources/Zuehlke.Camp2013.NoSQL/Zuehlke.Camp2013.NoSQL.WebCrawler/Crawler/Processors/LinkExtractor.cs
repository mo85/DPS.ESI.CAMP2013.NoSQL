using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;

namespace Zuehlke.Camp2013.NoSQL.WebCrawler.Crawler.Processors
{
    public class LinkExtractor
    {
        public string[] ExtractLinks(string html)
        {
            var links = new List<string>();

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            const string xpathExpression = "//a[@href]";
            var linkNodes = htmlDoc.DocumentNode.SelectNodes(xpathExpression);

            if (linkNodes != null)
            {
                foreach (var linkNode in linkNodes)
                {
                    var hrefAttribute = linkNode.Attributes["href"];
                    if (hrefAttribute != null)
                    {
                        var uri = hrefAttribute.Value;
                        if (!string.IsNullOrWhiteSpace(uri))
                        {
                            links.Add(hrefAttribute.Value);
                        }
                    }
                }
            }

            return links.ToArray();
        }
    }
}
