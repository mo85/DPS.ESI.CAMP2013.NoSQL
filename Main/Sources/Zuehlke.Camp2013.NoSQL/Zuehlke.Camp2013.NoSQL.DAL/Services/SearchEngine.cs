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
        private readonly SearchEngineContext context;
        private readonly Regex regex = new Regex("(?<Word>[a-zA-Z0-9]{2,})");

        public SearchEngine(SearchEngineContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            this.context = context;
        }

        public void InsertPage(WebPage webPage)
        {
            WebPageEntity pageEntity = this.context.WebPages.Create();
            pageEntity.Id = Guid.NewGuid();
            pageEntity.Content = webPage.Content;
            pageEntity.Url = webPage.Url;
            pageEntity.Title = webPage.Title;
            pageEntity.Description = webPage.Description;

            this.context.WebPages.Add(pageEntity);
            this.context.SaveChanges();

            // excluded for performance reasons...
            // this.RebuildIndex(pageEntity);
        }

        public void RebuildIndex()
        {
            this.context.Configuration.AutoDetectChangesEnabled = false;
            DeleteExistingIndexEntries();

            foreach (WebPageEntity page in this.context.WebPages.ToList())
            {
                var newIndexEntities = this.CreateSearchIndexEntryEntities(page);
                SaveIndexEntries(newIndexEntities);
                this.context.SaveChanges();
            }
            this.context.Configuration.AutoDetectChangesEnabled = true;
        }

        private void SaveIndexEntries(IEnumerable<SearchIndexEntryEntity> newIndexEntries)
        {
            foreach (var entry in newIndexEntries)
            {
                this.context.SearchIndexEntries.Add(entry);
            }
        }

        private void DeleteExistingIndexEntries()
        {
            var existingSearchIndexEntries = this.context.SearchIndexEntries.ToList();

            DeleteIndexEntry(existingSearchIndexEntries);

            this.context.SaveChanges();
        }

        private void DeleteIndexEntry(IEnumerable<SearchIndexEntryEntity> existingSearchIndexEntries)
        {
            foreach (var indexEntry in existingSearchIndexEntries)
            {
                this.context.SearchIndexEntries.Remove(indexEntry);
            }
        }

        public void RebuildIndex(WebPageEntity page)
        {
            IEnumerable<SearchIndexEntryEntity> indexEntries = this.context.SearchIndexEntries.Where(i => i.WebPage.Id == page.Id);
            DeleteIndexEntry(indexEntries);

            var newIndexEntries = this.CreateSearchIndexEntryEntities(page);

            SaveIndexEntries(newIndexEntries);

            this.context.SaveChanges();
        }

        private IEnumerable<SearchIndexEntryEntity> CreateSearchIndexEntryEntities(WebPageEntity page)
        {
            var document = new HtmlDocument();
            document.LoadHtml(page.Content);
            var newIndexEntries = document.DocumentNode.SelectNodes("//text()")
                                          .SelectMany(n => this.ParseWords(n)
                                                  .Select(w => Tuple.Create(w, this.CalculateElementBasedRangking(n))))
                                                  .GroupBy(w => w.Item1)
                                          .Select(g => new SearchIndexEntryEntity
                                              {
                                                  Id = Guid.NewGuid(),
                                                  Word = g.Key,
                                                  Rangking = g.Sum(w => w.Item2),
                                                  WebPage = page
                                              });
            return newIndexEntries;
        }

        public PagedSearchResult Search(SearchParameter parameter)
        {
            var searchQueryElements = (parameter.Query ?? string.Empty).ToUpperInvariant().Split(' ');

            var query = this.context.SearchIndexEntries.Where(i => searchQueryElements.Contains(i.Word))
                .GroupBy(i => i.WebPage.Url);

            var result = query.OrderByDescending(i => i.Sum(x => x.Rangking))
                .Skip(parameter.Page * parameter.PageSize)
                .Take(parameter.PageSize)
                .Select(g => new SearchResult
                {
                    Url = g.Key,
                    Title = g.Select(i => i.WebPage.Title).FirstOrDefault(),
                    Description = g.Select(i => i.WebPage.Description).FirstOrDefault(),
                    Ranking = g.Sum(i => i.Rangking)
                });

            return new PagedSearchResult
            {
                TotalRecords = query.Count(),
                SearchResults = result.ToArray(),
            };
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
