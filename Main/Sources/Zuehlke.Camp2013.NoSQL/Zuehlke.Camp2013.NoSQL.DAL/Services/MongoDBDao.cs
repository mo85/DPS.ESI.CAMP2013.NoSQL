using System;
using System.Collections.Generic;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using Zuehlke.Camp2013.NoSQL.DAL.Entities;
using System.Linq;

namespace Zuehlke.Camp2013.NoSQL.DAL.Services
{
    public class MongoDbDao : IDisposable
    {
        private readonly MongoCollection<WebPage> _webPagesCollection;
        public MongoDbDao()
        {
            _webPagesCollection = new MongoClient().GetServer().GetDatabase("Camp2013").GetCollection<WebPage>("WebPages");
        }

        public bool InsertPage(WebPage webPage)
        {
            var result = _webPagesCollection.Insert(webPage);
            return result.Ok;
        }

        public IEnumerable<WebPage> GetAllWebPages()
        {
            return _webPagesCollection.FindAll();
        }

        public bool UpdateWebPage(WebPage webPage)
        {
            var query = Query<WebPage>.EQ(wp => wp.Id, webPage.Id);
            var update = Update<WebPage>.Set(wp => wp.SearchIndexEntries, webPage.SearchIndexEntries);
            return  _webPagesCollection.Update(query, update).Ok;
        }

        public IEnumerable<WebPage> FindWebPagesByKeyWords(IEnumerable<string> keyWords)
        {
            return from wp in _webPagesCollection.AsQueryable()
                where wp.SearchIndexEntries.Any(sie => keyWords.Contains(sie.Word))
                select wp;
        }

        public void Dispose(){}
    }
}
