using System.Web.Http;
using Zuehlke.Camp2013.NoSQL.DAL.Services;
using WebPage = Zuehlke.Camp2013.NoSQL.Shared.Models.WebPage;

namespace Zuehlke.Camp2013.NoSQL.Web.Api
{
    public class WebPagesController : ApiController
    {
        // POST api/webpages
        public void Post([FromBody]WebPage webPage)
        {
            using (var mongoDbDao = new MongoDbDao())
            {
                var engine = new SearchEngine(mongoDbDao);
                engine.InsertPage(webPage);
            }
        }
    }
}
