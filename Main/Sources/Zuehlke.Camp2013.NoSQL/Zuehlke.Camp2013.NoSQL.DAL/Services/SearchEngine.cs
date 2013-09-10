using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using Zuehlke.Camp2013.NoSQL.DAL.Entities;
using Zuehlke.Camp2013.NoSQL.Shared.Models;
using WebPage = Zuehlke.Camp2013.NoSQL.DAL.Entities.WebPage;

namespace Zuehlke.Camp2013.NoSQL.DAL.Services
{
    public class SearchEngine
    {
        private readonly MongoDbDao _mongoDbDao;
        private readonly Regex _regex = new Regex("(?<Word>[a-zA-Z0-9]{2,})");

        public SearchEngine(MongoDbDao mongoDbDao)
        {
            if (mongoDbDao == null)
            {
                throw new ArgumentNullException("mongoDbDao");
            }
            _mongoDbDao = mongoDbDao;
        }

        public void InsertPage(Shared.Models.WebPage webPage)
        {
            var page = new WebPage
            {
                //Content = webPage.Content,
                Url = webPage.Url,
                Title = webPage.Title,
                Description = webPage.Description
            };
            var insertPage = _mongoDbDao.InsertPage(page);
            if (insertPage)
            {
                RebuildIndex(page, webPage.Content);
            }
        }

        //public void RebuildIndex()
        //{
        //    foreach (var page in _mongoDbDao.GetAllWebPages())
        //    {
        //        RebuildIndex(page);
        //    }
        //}

        public void RebuildIndex(WebPage page, string webPageContent)
        {
            page.SearchIndexEntries = CreateSearchIndexEntryEntities(webPageContent);
            _mongoDbDao.UpdateWebPage(page);
        }

        private IEnumerable<SearchIndexEntry> CreateSearchIndexEntryEntities(string webPageContent)
        {
            var document = new HtmlDocument();
            document.LoadHtml(webPageContent);
            var newIndexEntries = document.DocumentNode.SelectNodes("//text()")
                                          .SelectMany(n =>ParseWords(n)
                                                  .Select(w => Tuple.Create(w, CalculateElementBasedRangking(n))))
                                                  .GroupBy(w => w.Item1)
                                          .Select(g => new SearchIndexEntry
                                              {
                                                  Word = g.Key,
                                                  Ranking = g.Sum(w => w.Item2)
                                              });
            return newIndexEntries;
        }

        public PagedSearchResult Search(SearchParameter parameter)
        {
            var searchQueryElements = (parameter.Query ?? string.Empty).ToUpperInvariant().Split(' ');

            var webPages = _mongoDbDao.FindWebPagesByKeyWords(searchQueryElements);

            var result = webPages.OrderByDescending(
                wp => wp.SearchIndexEntries.Where(sie => searchQueryElements.Contains(sie.Word)).Sum(sie => sie.Ranking))
                .Skip(parameter.Page * parameter.PageSize)
                .Take(parameter.PageSize)
                .Select(wp => new SearchResult
                {
                    Url = wp.Url,
                    Title = wp.Title,
                    Description = wp.Description,
                    Ranking = wp.SearchIndexEntries.Where(sie => searchQueryElements.Contains(sie.Word)).Sum(sie => sie.Ranking)
                });

            var resultArray = result.ToArray();

            return new PagedSearchResult
            {
                TotalRecords = webPages.Count(),
                SearchResults = resultArray,
            };
        }

        private IEnumerable<string> ParseWords(HtmlNode n)
        {
            return _regex.Matches(n.InnerText).OfType<Match>()
                .Select(g => g.Value.ToUpperInvariant());
        }

        private static int CalculateElementBasedRangking(HtmlNode n)
        {
            switch (n.ParentNode.Name.ToUpperInvariant())
            {
                case "TITLE":
                    return 50;

                case "H1":
                case "H2":
                case "H3":
                case "H4":
                case "H5":
                case "H6":
                    return 20;

                case "A":
                    return 10;

                default:
                    return 1;
            }
        }
    }
}
