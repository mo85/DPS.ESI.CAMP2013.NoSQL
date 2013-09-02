using System.Web.Mvc;
using Zuehlke.Camp2013.NoSQL.DAL.Services;

namespace Zuehlke.Camp2013.NoSQL.Web.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RebuildIndex()
        {
            using (var context = new SearchEngineContext())
            {
                var engine = new SearchEngine(context);
                engine.RebuildIndex();
            }

            return RedirectToAction("Index");
        }

    }
}
