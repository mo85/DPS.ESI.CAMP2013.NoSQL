using System;
using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;
using Zuehlke.Camp2013.NoSQL.Shared.Models;

namespace Zuehlke.Camp2013.NoSQL.WebCrawler.Crawler.Processors
{
    public class HeadingExtractor
    {
        public PageHeading[] ExtractPageHeadings(string html)
        {
            var headings = new List<PageHeading>();

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            foreach (HeadingLevel headingEnum in Enum.GetValues(typeof(HeadingLevel)))
            {
                var xpathExpression = string.Concat("//", headingEnum).ToLowerInvariant();
                var headingNodes = htmlDoc.DocumentNode.SelectNodes(xpathExpression);

                if (headingNodes != null)
                {
                    headings.AddRange(headingNodes.Select(headingNode => CreatePageHeadingFromHeadingNode(headingNode, headingEnum)));
                }
            }

            return headings.ToArray();
        }

        private static PageHeading CreatePageHeadingFromHeadingNode(HtmlNode headingNode, HeadingLevel headingEnum)
        {
            return new PageHeading { Content = headingNode.InnerText, Level = headingEnum };
        }
    }
}
