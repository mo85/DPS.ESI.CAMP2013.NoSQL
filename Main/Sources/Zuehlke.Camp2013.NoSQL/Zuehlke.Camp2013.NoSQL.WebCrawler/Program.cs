using System;
using System.Configuration;
using System.Net;
using Abot.Crawler;
using Zuehlke.Camp2013.NoSQL.Shared.Models;
using Zuehlke.Camp2013.NoSQL.WebCrawler.Crawler;

namespace Zuehlke.Camp2013.NoSQL.WebCrawler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var crawler = CreateCrawler();
            var crawlerEntryUri = ConfigurationManager.AppSettings["CrawlerEntryURI"];

            crawler.Crawl(new Uri(crawlerEntryUri));
            
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        private static PoliteWebCrawler CreateCrawler()
        {
            // Will use app.config for confguration
            var crawler = new PoliteWebCrawler();
            crawler.PageCrawlCompletedAsync += ProcessCrawledPage;
            return crawler;
        }

        private static void ProcessCrawledPage(object sender, PageCrawlCompletedArgs e)
        {
            var crawledPage = e.CrawledPage;

            if (crawledPage.WebException != null || crawledPage.HttpWebResponse.StatusCode != HttpStatusCode.OK)
            {
                Console.WriteLine("Crawl of page failed {0}", crawledPage.Uri.AbsoluteUri);
            }
            else
            {
                Console.WriteLine("Crawl of page succeeded {0}", crawledPage.Uri.AbsoluteUri);
                var page = WebPageFactory.CreateWebPage(crawledPage);

                PostWebPageToServer(page);
            }

            if (string.IsNullOrEmpty(crawledPage.RawContent))
            {
                Console.WriteLine("Page had no content {0}", crawledPage.Uri.AbsoluteUri);
            }
        }

        private static async void PostWebPageToServer(WebPage page)
        {
            var response = await new ApiClient().PostWebPage(page);
            //response.EnsureSuccessStatusCode();
        }
    }
}
