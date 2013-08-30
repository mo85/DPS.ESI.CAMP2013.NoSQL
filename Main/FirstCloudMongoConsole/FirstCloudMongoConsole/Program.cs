using System;
using FirstCloudMongoConsole.Crawler;
using FirstCloudMongoConsole.Model;
using FirstCloudMongoConsole.Services;
using MongoDB.Driver;

namespace FirstCloudMongoConsole
{
    class Program
    {
        private const string User = "FirstCloudMongoConsole";

        private const string Password = "secret";

        private const string DataBaseName = "WebCrawlerDbTest";

        static void Main(string[] args)
        {
            var db = ConnectToMongoDb();

            var linkService = new LinkService(db);
            var crawler = new WebsiteCrawler(linkService);
            
            ClearAllExistingLinks(linkService);

            CrawlPages(crawler);

            PrintAllLinks(linkService);
            
            Console.ReadKey();
        }

        private static void PrintAllLinks(LinkService linkService)
        {
            foreach (var link in linkService.AllLinks())
            {
                Console.WriteLine(link);
            }
        }

        private static void CrawlPages(WebsiteCrawler crawler)
        {
            crawler.SaveLinksOfURI(new Uri("http://stars-hockey.ch"));
        }

        private static void ClearAllExistingLinks(LinkService linkService)
        {
            // Clean Up db
            linkService.DeleteAll();
        }


        private static MongoDatabase ConnectToMongoDb()
        {
            var client = new MongoClient(ConnectionString); // connect to localhost
            MongoServer server = client.GetServer();
            var db = server.GetDatabase(DataBaseName);
            return db;
        }

        private static string ConnectionString
        {
            get { return String.Format("mongodb://{0}:{1}@dharma.mongohq.com:10065/WebCrawlerDbTest", User, Password); }
        }
    }
}
