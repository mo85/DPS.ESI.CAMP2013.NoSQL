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
            var dict = this.CalculateWordRankings(webPageContent);
            foreach (var kv in dict)
            {
                _mongoDbDao.AddWebPageToSearchIndexEntry(
                    kv.Key, new SearchIndexRanking { Ranking = kv.Value, WebPageId = page.Id });
            }
        }

        private Dictionary<string, int> CalculateWordRankings(string webPageContent)
        {
            var document = new HtmlDocument();
            document.LoadHtml(webPageContent);
            var dictionary =
                document.DocumentNode.SelectNodes("//text()")
                        .SelectMany(n => ParseWords(n).Select(w => Tuple.Create(w, CalculateElementBasedRangking(n))))
                        .GroupBy(w => w.Item1)
                        .ToDictionary(g => g.Key, g => g.Sum(w => w.Item2));
            return dictionary;
        }

        public PagedSearchResult Search(SearchParameter parameter)
        {
            var searchQueryElements = (parameter.Query ?? string.Empty).ToUpperInvariant().Split(' ');

            var searchIndexEntries = _mongoDbDao.GetSearchIndexEntries(searchQueryElements);

            var webPageIds = searchIndexEntries.SelectMany(sie => sie.WebPages.Select(sir => sir.WebPageId)).Distinct();
            var totalRecords = webPageIds.Count();
            var webPageRankings =
                searchIndexEntries.SelectMany(sie => sie.WebPages.Select(sir => new { sir.WebPageId, sir.Ranking }));
            var grouped = webPageRankings.GroupBy(
                a => a.WebPageId,
                (id, aa) => new { WebPageId = id, TotalRanking = aa.Sum(a => a.Ranking) });
            var ordered = grouped.OrderByDescending(a => a.TotalRanking);
            var paged = ordered.Skip(parameter.Page * parameter.PageSize).Take(parameter.PageSize);
            var withWebPagesLoaded =
                paged.Select(a => new { WebPage = _mongoDbDao.GetWebPageById(a.WebPageId), a.TotalRanking });
            var searchResults =
                withWebPagesLoaded.Select(
                    a =>
                    new SearchResult
                        {
                            Url = a.WebPage.Url,
                            Title = a.WebPage.Title,
                            Description = a.WebPage.Description,
                            Ranking = a.TotalRanking
                        }).ToList();

            return new PagedSearchResult
            {
                TotalRecords = totalRecords,
                SearchResults = searchResults,
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
