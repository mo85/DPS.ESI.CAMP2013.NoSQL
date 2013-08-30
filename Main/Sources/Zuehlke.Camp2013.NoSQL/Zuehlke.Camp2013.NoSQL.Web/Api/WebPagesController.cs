using System;
using System.Web.Http;
using Zuehlke.Camp2013.NoSQL.DAL.Entities;
using Zuehlke.Camp2013.NoSQL.DAL.Services;
using WebPage = Zuehlke.Camp2013.NoSQL.Shared.Models.WebPage;

namespace Zuehlke.Camp2013.NoSQL.Web.Api
{
    public class WebPagesController : ApiController
    {
        // POST api/webpages
        public void Post([FromBody]WebPage webPage)
        {
            using (var context = new SearchEngineContext())
            {
                var engine = new SearchEngine(context);
                engine.InsertPage(webPage);
            }
        }
    }
}
