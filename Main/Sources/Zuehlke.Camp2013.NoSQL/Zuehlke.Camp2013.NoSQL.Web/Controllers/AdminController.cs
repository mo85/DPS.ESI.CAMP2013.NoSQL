using System.Linq;
using System.Web.Mvc;
using Zuehlke.Camp2013.NoSQL.DAL.Services;
using Zuehlke.Camp2013.NoSQL.Web.Models;

namespace Zuehlke.Camp2013.NoSQL.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly ISearchContext context;

        public AdminController(ISearchContext context)
        {
            this.context = context;
        }

        public ActionResult Index()
        {
            var statsModel = new StatsModel();
            var mongoClient = new MongoDBClient();
            statsModel.NumberOfPages = mongoClient.Pages.Count();
            statsModel.NumberOfIndexEntries = mongoClient.Pages.AsQueryable().Sum(p => p.SearchIndexEntities.Count());
            return View(statsModel);
        }

        [HttpPost]
        public ActionResult RebuildIndex()
        {
            var engine = new SearchEngine(context);
            //engine.RebuildIndex();
            
            return RedirectToAction("Index");
        }

    }
}
