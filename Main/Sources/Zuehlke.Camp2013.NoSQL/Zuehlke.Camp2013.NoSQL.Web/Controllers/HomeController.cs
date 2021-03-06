﻿using System.Web.Mvc;
using Zuehlke.Camp2013.NoSQL.DAL.Services;
using Zuehlke.Camp2013.NoSQL.Shared.Models;
using Zuehlke.Camp2013.NoSQL.Web.ViewModels;

namespace Zuehlke.Camp2013.NoSQL.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return this.View();
        }

        [HttpGet]
        public ActionResult Search(SearchParameter parameter)
        {
            return this.View(CreateSearchViewModel(parameter));
        }

        [HttpGet]
        public ActionResult AjaxSearch(string query, int page)
        {
            return this.PartialView(
                "_SearchResults",
                CreateSearchViewModel(
                new SearchParameter { Page = page - 1, Query = query }));
        }

        private static SearchViewModel CreateSearchViewModel(SearchParameter parameter)
        {
            using (var context = new SearchEngineContext())
            {
                var engine = new SearchEngine(context);
                var viewModel = new SearchViewModel
                {
                    SearchParameter = parameter,
                    PagedSearchResult = engine.Search(parameter)
                };

                return viewModel;
            }
        }
    }
}
