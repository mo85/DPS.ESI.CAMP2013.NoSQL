using System;
using System.IO;
using System.Linq;
using System.Net;
using FirstCloudMongoConsole.Model;
using FirstCloudMongoConsole.Services;
using HtmlAgilityPack;
using MongoDB.Driver.Builders;

namespace FirstCloudMongoConsole.Crawler
{
    public class WebsiteCrawler
    {
        private readonly LinkService service;

        public WebsiteCrawler(LinkService service)
        {
            this.service = service;
        }

        public void SaveLinksOfURI(Uri documentUrl)
        {
            var document = new HtmlDocument();
            var tempFile = Path.GetTempFileName();
            
            using (var client = new WebClient())
            {
                client.DownloadFile(documentUrl, tempFile);
                document.Load(tempFile);

                foreach (HtmlNode link in document.DocumentNode.SelectNodes("//a[@href]"))
                {
                    var label = link.InnerText;
                    var url = link.GetAttributeValue("href", string.Empty);

                    var crawledLink = new CrawledLink
                        {
                            Label = label,
                            ReferencedURL = url
                        };

                    if (this.service.FindByQuery(Query<CrawledLink>.Where(x => x.Label == label && x.ReferencedURL == url)).Any())

                    service.Save(crawledLink);
                }
            }

            File.Delete(tempFile);
        }
    }
}
