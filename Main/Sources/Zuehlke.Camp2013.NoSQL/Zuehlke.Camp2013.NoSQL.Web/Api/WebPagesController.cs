using System.Web.Http;
using Zuehlke.Camp2013.NoSQL.DAL.Services;
using WebPage = Zuehlke.Camp2013.NoSQL.Shared.Models.WebPage;

namespace Zuehlke.Camp2013.NoSQL.Web.Api
{
    public class WebPagesController : ApiController
    {
        private readonly ISearchContext context;

        public WebPagesController()
        {
            this.context = new MongoDBClient();
        }

        // POST api/webpages
        public void Post([FromBody]WebPage webPage)
        {
            var engine = new SearchEngine(context);
            engine.InsertPage(webPage);
        }

        public void Get()
        {
            // "Ok";
        }
    }
}
