using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zuehlke.Camp2013.NoSQL.WebCrawler.Crawler.Processors;
using Zuehlke.Camp2013.NoSQL.WebCrawler.Test.Helpers;

namespace Zuehlke.Camp2013.NoSQL.WebCrawler.Test.Crawler.Processors
{
    [TestClass]
    public class LinkExtractorTest
    {
        [TestMethod]
        public void TestExtractLinks_With_EmptyHtmlDocument_Returns_EmptyArrayOfStrings()
        {
            // Arrange
            var extractor = new LinkExtractor();
            var html = SampleHtmlGenerator.EmptyValidHtmlString();

            // Act
            var links = extractor.ExtractLinks(html).ToList();

            // Assert
            Assert.AreEqual(0, links.Count);
        }

        [TestMethod]
        public void TestExtractLinks()
        {
            // Arrange
            var extractor = new LinkExtractor();
            var html = GenerateSampleHtmlContainingTwoLinks();

            // Act
            var links = extractor.ExtractLinks(html).ToList();

            // Assert
            Assert.AreEqual(2, links.Count());
            Assert.IsNotNull(links.First(x => x.Equals("http://www.google.ch")));
            Assert.IsNotNull(links.First(x => x.Equals("https://nzz.ch")));
        }

        private static string GenerateSampleHtmlContainingTwoLinks()
        {
            return @"<!DOCTYPE html>
                        <html>
                            <head>
                                <title>Test Page</title>
                            </head>
                            <body>
                                <h1>Sample Page containing Links</h1>

                                <p>
                                    <a href='http://www.google.ch'>Check this out...</a>
                                </p>

                                <div>
                                    <a href='https://nzz.ch'>Or try perhaps this...</a>
                                </div>
                            </body>
                        </html>";
        }
    }
}
