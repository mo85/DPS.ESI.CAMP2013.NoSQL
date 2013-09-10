//using System;
//using System.Data.Entity;
//using System.Linq;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Zuehlke.Camp2013.NoSQL.DAL.Services;

//namespace Zuehlke.Camp2013.NoSQL.Web.Test
//{
//    [TestClass]
//    public class SearchEngineTests
//    {
//        [TestInitialize]
//        public void TestInitialize()
//        {
//            Database.SetInitializer(new DropCreateDatabaseAlways<SearchEngineContext>());
//        }

//        [TestMethod]
//        public void RebuildIndex_WordInTitle_HasRangingOf50()
//        {
//            using (var context = new SearchEngineContext())
//            {
//                // arrange
//                var page = context.WebPages.Create();
//                page.Id = Guid.NewGuid();
//                page.Url = "http://heise.de";
//                page.Content = HtmlStrings.TestHtml;

//                context.WebPages.Add(page);
//                context.SaveChanges();

//                var engine = new SearchEngine(context);

//                // act
//                engine.RebuildIndex(page);

//                // assert
//                var indexEntry = context.SearchIndexEntries.Single(i => i.Word == "title");
//                Assert.AreEqual(50, indexEntry.Ranking);

//                indexEntry = context.SearchIndexEntries.Single(i => i.Word == "test");
//                Assert.AreEqual(51, indexEntry.Ranking);
//            }
//        }
//    }
//}
