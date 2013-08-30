using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zuehlke.Camp2013.NoSQL.WebCrawler.Crawler.Processors;

namespace Zuehlke.Camp2013.NoSQL.WebCrawler.Test.Crawler.Processors
{
    [TestClass]
    public class TitleExtractorTest
    {
        [TestMethod]
        public void TestExtractTitle()
        {
            // Arrange
            var extractor = new TitleExtractor();
            var htmlString = SampleHtmlDocumentWithTitle();

            // Act
            var title = extractor.ExtractTitle(htmlString);

            // Assert
            Assert.AreEqual("Test Title", title);
        }

        [TestMethod]
        public void TestExtractTitle_With_HtmlDocumentNotContainingTitle_ReturnsEmptyString()
        {
            // Arrange
            var extractor = new TitleExtractor();
            var htmlString = SampleHtmlDocumentWithoutTitle();

            // Act
            var title = extractor.ExtractTitle(htmlString);

            // Assert
            Assert.AreEqual(string.Empty, title);
        }

        private string SampleHtmlDocumentWithoutTitle()
        {
            // This html is invalid! => a title tag is required
            return @"<!DOCTYPE html>
                        <html>
                            <head>
                            </head>
                            <body>
                            </body>
                        </html>"; ;
        }

        private string SampleHtmlDocumentWithTitle()
        {
            return @"<!DOCTYPE html>
                        <html>
                            <head>
                                <title>Test Title</title>
                            </head>
                            <body>
                                <h1>Sample Page containing Links</h1>
                                
                                <p>Test Content</p>
                            </body>
                        </html>"; ;
        }
    }
}
