using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zuehlke.Camp2013.NoSQL.Shared.Models;
using Zuehlke.Camp2013.NoSQL.WebCrawler.Crawler;

namespace Zuehlke.Camp2013.NoSQL.WebCrawler.Test
{
    [TestClass]
    public class ApiClientTest
    {
        [TestMethod]
        public void TestPostWebPage()
        {
            // Arrange
            var apiClient = new ApiClient();
            var samplePage = new WebPage
                {
                    Content = "Dummy Page Content", 
                    PageHeadings = new PageHeading[]{}, 
                    ReferencedUrls = new string[] {}, 
                    Url = "http://example.ch"
                };

            // Act
            var task = ExecuteRequest(apiClient, samplePage);
            var response = task.GetAwaiter().GetResult();

            // Assert
            Assert.IsTrue(response.IsSuccessStatusCode);
        }

        private static async Task<HttpResponseMessage> ExecuteRequest(ApiClient client, WebPage page)
        {
            var response = await client.PostWebPage(page);
            return response;
        }
    }
}
