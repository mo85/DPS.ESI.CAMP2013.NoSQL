using System.Web.Mvc;
using Zuehlke.Camp2013.NoSQL.DAL.Services;

namespace Zuehlke.Camp2013.NoSQL.Web.Controllers
{
    using Zuehlke.Camp2013.NoSQL.Web.ViewModels.Admin;

    using System.Linq;

    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            var vm = new IndexViewModel();

            using (var mongoDbDao = new MongoDbDao())
            {
                vm.NrPagesCrawled = mongoDbDao.GetNrPagesCrawled();
                vm.NrPagesIndexed = mongoDbDao.GetNrPagesIndexed();
                vm.NrDistinctWords = mongoDbDao.GetNrDistinctWords();
                vm.NrIndexesTotal = mongoDbDao.GetNrIndexesTotal();
                vm.PagesWithMostIndexes = mongoDbDao.FindWebPagesWithMostIndexes(5);
                vm.PagesWithLeastIndexes = mongoDbDao.FindWebPagesWithLeastIndexes(5);
            }

            return View(vm);
        }

        [HttpPost]
        public ActionResult RebuildIndex()
        {
            using (var mongoDbDao = new MongoDbDao())
            {
                var engine = new SearchEngine(mongoDbDao);
            }

            return RedirectToAction("Index");
        }

    }
}
