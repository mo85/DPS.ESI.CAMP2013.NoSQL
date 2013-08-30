using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Zuehlke.Camp2013.NoSQL.Shared.Models;

namespace Zuehlke.Camp2013.NoSQL.WebCrawler.Crawler
{
    public class ApiClient
    {
        public async Task<HttpResponseMessage> PostWebPage(WebPage page)
        {
            const string jsonMimeType = "application/json";
            var webPagesUri = ConfigurationManager.AppSettings["WebPagesURI"];

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(jsonMimeType));

                var serializedObject = JsonConvert.SerializeObject(page);
                var content = new StringContent(serializedObject, Encoding.UTF8, jsonMimeType);

                return await client.PostAsync(webPagesUri, content);
            }
        }
    }
}
