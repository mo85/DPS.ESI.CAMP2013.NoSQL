using System;
using System.Data.Entity;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zuehlke.Camp2013.NoSQL.DAL.Entities;
using Zuehlke.Camp2013.NoSQL.DAL.Services;

namespace Zuehlke.Camp2013.NoSQL.Web.Test
{
    [TestClass]
    public class SearchEngineTests
    {
        [TestInitialize]
        public void TestInitialize()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<SearchEngineContext>());
        }

        [TestMethod]
        public void RebuildIndex_WordInTitle_HasRangingOf50()
        {
            using (var context = new SearchEngineContext())
            {
                // arrange
                var page = new WebPageEntity
                    {
                        Url = "http://heise.de",
                        Content = HtmlStrings.TestHtml
                    };

                context.Add(page);
                context.SaveChanges();

                var engine = new SearchEngine(context);

                // act
                //engine.CreateIndexEntries(page);

                // assert
                var indexEntry = context.IndexEntries.Single(i => i.Word == "title");
                Assert.AreEqual(50, indexEntry.Rangking);

                indexEntry = context.IndexEntries.Single(i => i.Word == "test");
                Assert.AreEqual(51, indexEntry.Rangking);
            }
        }
    }
}
