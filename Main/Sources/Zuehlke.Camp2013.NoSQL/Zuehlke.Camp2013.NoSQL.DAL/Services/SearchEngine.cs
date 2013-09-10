using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using Zuehlke.Camp2013.NoSQL.DAL.Entities;
using Zuehlke.Camp2013.NoSQL.Shared.Models;

namespace Zuehlke.Camp2013.NoSQL.DAL.Services
{
    public class SearchEngine
    {
        private readonly ISearchContext context;
        private readonly Regex regex = new Regex("(?<Word>[a-zA-Z0-9]{2,})");

        public SearchEngine(ISearchContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            this.context = context;
        }

        public void InsertPage(WebPage webPage)
        {
            var pageEntity = new WebPageEntity
                {
                    Content = webPage.Content,
                    Url = webPage.Url,
                    Title = webPage.Title,
                    Description = webPage.Description,
                    SearchIndexEntities = CreateSearchIndexEntryEntities(webPage)
                };

            this.context.Add(pageEntity);
        }

        private IEnumerable<SearchIndexEntryEntity> CreateSearchIndexEntryEntities(WebPage page)
        {
            var document = new HtmlDocument();
            document.LoadHtml(page.Content);
            var newIndexEntries = document.DocumentNode.SelectNodes("//text()")
                                          .SelectMany(n => this.ParseWords(n)
                                                  .Select(w => Tuple.Create(w, this.CalculateElementBasedRangking(n))))
                                                  .GroupBy(w => w.Item1)
                                          .Select(g => new SearchIndexEntryEntity
                                              {
                                                  Word = g.Key,
                                                  Rangking = g.Sum(w => w.Item2),
                                              });
            return newIndexEntries;
        }

        public PagedSearchResult Search(SearchParameter parameter)
        {
            var searchQueryElements = (parameter.Query ?? string.Empty).ToUpperInvariant().Split(' ');

            var query = FindMatchingWebPages(searchQueryElements).ToList();

            var result = query.OrderByDescending(p => FilterIndexEntities(p.SearchIndexEntities, searchQueryElements).Sum(i => i.Rangking))
                .Skip(parameter.Page * parameter.PageSize)
                .Take(parameter.PageSize)
                .Select(p => new SearchResult
                {
                    Url = p.Url,
                    Title = p.Title,
                    Description = p.Description,
                    Ranking = p.SearchIndexEntities.Sum(i => i.Rangking)
                });

            return new PagedSearchResult
            {
                TotalRecords = query.Count(),
                SearchResults = result.ToArray(),
            };
        }

        private static IEnumerable<SearchIndexEntryEntity> FilterIndexEntities(IEnumerable<SearchIndexEntryEntity> searchIndexEntities, IEnumerable<string> searchQueryElements)
        {
            // var query = searchIndexEntities.Where(i => searchQueryElements.Any(e => i.Word.Contains(e)));
            var query = searchIndexEntities.Where(i => searchQueryElements.Contains(i.Word)); //Any(e => i.Word.Contains(e)));
            return query;
        } 

        private IEnumerable<WebPageEntity> FindMatchingWebPages(IEnumerable<string> searchQueryElements)
        {
            return this.context.Pages.Where(p => p.SearchIndexEntities.Any(i => searchQueryElements.Contains(i.Word)));
        }

        private IEnumerable<string> ParseWords(HtmlNode n)
        {
            return this.regex.Matches(n.InnerText).OfType<Match>()
                .Select(g => g.Value.ToUpperInvariant());
        }

        private int CalculateElementBasedRangking(HtmlNode n)
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
