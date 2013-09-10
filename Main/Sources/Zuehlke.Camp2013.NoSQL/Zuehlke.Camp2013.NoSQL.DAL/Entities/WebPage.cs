using System;
using System.Collections.Generic;
using MongoDB.Bson;

namespace Zuehlke.Camp2013.NoSQL.DAL.Entities
{
    public class WebPage
    {
        public ObjectId Id { get; set; }

        public string Url { get; set; }

        //public string Content { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public IEnumerable<SearchIndexEntry> SearchIndexEntries { get; set; }
    }
}