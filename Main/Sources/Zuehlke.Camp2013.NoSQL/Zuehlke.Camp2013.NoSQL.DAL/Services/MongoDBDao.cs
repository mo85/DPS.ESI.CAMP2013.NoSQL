using System;
using System.Collections.Generic;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

using System.Linq;

namespace Zuehlke.Camp2013.NoSQL.DAL.Services
{
    using MongoDB.Bson;

    using Zuehlke.Camp2013.NoSQL.DAL.Entities;

    public class MongoDbDao : IDisposable
    {
        private readonly MongoCollection<WebPage> _webPagesCollection;

        private readonly MongoCollection<SearchIndexEntry> _searchWordsCollection;

        public MongoDbDao()
        {
            var database = new MongoClient().GetServer().GetDatabase("Camp2013");
            _webPagesCollection = database.GetCollection<WebPage>("WebPages");
            _searchWordsCollection = database.GetCollection<SearchIndexEntry>("SearchWords");
        }

        public WebPage GetWebPageById(ObjectId id)
        {
            return _webPagesCollection.AsQueryable().Single(wp => wp.Id == id);
        }

        public bool InsertPage(WebPage webPage)
        {
            var result = _webPagesCollection.Insert(webPage);
            return result.Ok;
        }

        public bool AddWebPageToSearchIndexEntry(string word, SearchIndexRanking searchIndexRanking)
        {
            SearchIndexEntry searchIndexEntry;
            if (_searchWordsCollection.AsQueryable().Any(sie => sie.Word == word))
            {
                searchIndexEntry = _searchWordsCollection.AsQueryable().Single(sie => sie.Word == word);
            }
            else
            {
                searchIndexEntry = new SearchIndexEntry { Word = word, WebPages = new List<SearchIndexRanking>() };
            }
            searchIndexEntry.WebPages.Add(searchIndexRanking);
            var result = _searchWordsCollection.Save(searchIndexEntry);
            return result.Ok;
        }

        public List<SearchIndexEntry> GetSearchIndexEntries(IEnumerable<string> keyWords)
        {
            return _searchWordsCollection.AsQueryable().Where(sie => keyWords.Contains(sie.Word)).ToList();
        }

        public long GetNrPagesCrawled()
        {
            return _webPagesCollection.Count();
        }

        public long GetNrPagesIndexed()
        {
            // TODO aggregate
            return
                _searchWordsCollection.AsQueryable().ToList()
                                      .SelectMany(sie => sie.WebPages.Select(sir => sir.WebPageId))
                                      .Distinct()
                                      .Count();
        }

        public long GetNrDistinctWords()
        {
            return _searchWordsCollection.Count();
        }

        public long GetNrIndexesTotal()
        {
            // TODO aggregate
            return _searchWordsCollection.AsQueryable().ToList().SelectMany(sie => sie.WebPages).Count();
        }

        public Dictionary<string, int> FindWebPagesWithMostIndexes(int nrResults)
        {
            // TODO evtl aggregate
            return new Dictionary<string, int>();

        //    return
        //        _webPagesCollection.Aggregate(
        //            new BsonDocument("$match", new BsonDocument("SearchIndexEntries", new BsonDocument("$ne", BsonNull.Value))),
        //            new BsonDocument("$unwind", "$SearchIndexEntries"),
        //            new BsonDocument(
        //                "$group",
        //                new BsonDocument(
        //                    new[]
        //                        {
        //                            new BsonElement("_id", "$Url"),
        //                            new BsonElement("numberOfIndexes", new BsonDocument("$sum", 1))
        //                        })))
        //                           .ResultDocuments.OrderByDescending(x => x["numberOfIndexes"].AsInt32)
        //                           .Take(nrResults)
        //                           .ToDictionary(x => x["_id"].AsString, x => x["numberOfIndexes"].AsInt32);

        //    //return
        //    //    _webPagesCollection.AsQueryable()
        //    //                       .Where(wp => wp.SearchIndexEntries != null)
        //    //                       .Select(wp => new { wp.Url, Indexcount = wp.SearchIndexEntries.Count() })
        //    //                       .ToList()
        //    //                       .OrderByDescending(x => x.Indexcount)
        //    //                       .Take(nrResults)
        //    //                       .ToDictionary(x => x.Url, x => x.Indexcount);
        }

        public Dictionary<string, int> FindWebPagesWithLeastIndexes(int nrResults)
        {
            // TODO evtl aggregate
            return new Dictionary<string, int>();

        //public Dictionary<string, int> FindWebPagesWithLeastIndexes(int nrResults)
        //{
        //    return
        //        _webPagesCollection.Aggregate(
        //            new BsonDocument("$match", new BsonDocument("SearchIndexEntries", new BsonDocument("$ne", BsonNull.Value))),
        //            new BsonDocument("$unwind", "$SearchIndexEntries"),
        //            new BsonDocument(
        //                "$group",
        //                new BsonDocument(
        //                    new[]
        //                        {
        //                            new BsonElement("_id", "$Url"),
        //                            new BsonElement("numberOfIndexes", new BsonDocument("$sum", 1))
        //                        })))
        //                           .ResultDocuments.OrderBy(x => x["numberOfIndexes"].AsInt32)
        //                           .Take(nrResults)
        //                           .ToDictionary(x => x["_id"].AsString, x => x["numberOfIndexes"].AsInt32);

        //    //return
        //    //    _webPagesCollection.AsQueryable()
        //    //                       .Where(wp => wp.SearchIndexEntries != null)
        //    //                       .Select(wp => new { wp.Url, Indexcount = wp.SearchIndexEntries.Count() })
        //    //                       .ToList()
        //    //                       .OrderBy(x => x.Indexcount)
        //    //                       .Take(nrResults)
        //    //                       .ToDictionary(x => x.Url, x => x.Indexcount);
        }

        public void Dispose(){}
    }
}
