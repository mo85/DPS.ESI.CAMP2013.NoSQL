using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zuehlke.Camp2013.NoSQL.Shared.Models;
using Zuehlke.Camp2013.NoSQL.WebCrawler.Crawler.Processors;
using Zuehlke.Camp2013.NoSQL.WebCrawler.Test.Helpers;

namespace Zuehlke.Camp2013.NoSQL.WebCrawler.Test.Crawler.Processors
{
    [TestClass]
    public class HeadingExtractorTest
    {
        [TestMethod]
        public void TestExtractHeadings()
        {
            // Arrange
            var extractor = new HeadingExtractor();
            var sampleHtml = SampleHtml();

            // Act
            var headings = extractor.ExtractPageHeadings(sampleHtml).ToList();

            // Assert
            Assert.AreEqual(1, headings.Count(x => x.Level == HeadingLevel.H1));
            Assert.AreEqual(2, headings.Count(x => x.Level == HeadingLevel.H2));
            Assert.AreEqual(3, headings.Count(x => x.Level == HeadingLevel.H3));
            
            Assert.AreEqual(1, headings.Count(x => x.Level == HeadingLevel.H4));
            Assert.AreEqual(2, headings.Count(x => x.Level == HeadingLevel.H5));
            Assert.AreEqual(3, headings.Count(x => x.Level == HeadingLevel.H6));

            // h1 Headings
            var h1Heading = headings.First(h => h.Level == HeadingLevel.H1);
            Assert.AreEqual("This is the most important Heading", h1Heading.Content);

            // h2 Headings
            var h2Headings = headings.Where(h => h.Level == HeadingLevel.H2).ToList();
            Assert.IsNotNull(h2Headings.First(x => x.Content == "Sub Heading 1"));
            Assert.IsNotNull(h2Headings.First(x => x.Content == "Sub Heading 2"));

            // h3 Headings
            var h3Headings = headings.Where(h => h.Level == HeadingLevel.H3).ToList();
            Assert.IsNotNull(h3Headings.First(x => x.Content == "Sub Sub Heading 1"));
            Assert.IsNotNull(h3Headings.First(x => x.Content == "Sub Sub Heading 2"));
            Assert.IsNotNull(h3Headings.First(x => x.Content == "Sub Sub Heading 3"));

            // h4 Headings
            var h4Heading = headings.First(h => h.Level == HeadingLevel.H4);
            Assert.AreEqual("Heading Level 4", h4Heading.Content);

            // h5 Headings
            var h5Headings = headings.Where(h => h.Level == HeadingLevel.H5).ToList();
            Assert.IsNotNull(h5Headings.First(x => x.Content == "Heading Level 5 1"));
            Assert.IsNotNull(h5Headings.First(x => x.Content == "Heading Level 5 2"));
            
            // h6 Headings
            var h6Headings = headings.Where(h => h.Level == HeadingLevel.H6).ToList();
            Assert.IsNotNull(h6Headings.First(x => x.Content == "Heading Level 6 1"));
            Assert.IsNotNull(h6Headings.First(x => x.Content == "Heading Level 6 1"));
            Assert.IsNotNull(h6Headings.First(x => x.Content == "Heading Level 6 1"));
        }

        [TestMethod]
        public void TestExtractHeadings_With_EmptyHtmlDocument_Returns_EmptyArrayOfHeadings()
        {
            // Arrange
            var extractor = new HeadingExtractor();
            var html = SampleHtmlGenerator.EmptyValidHtmlString();

            // Act
            var headings = extractor.ExtractPageHeadings(html);

            // Assert
            Assert.AreEqual(0, headings.Count());
        }

        private static string SampleHtml()
        {
            // Valid Html 5!
            return @"<!DOCTYPE html>
                    <html>
                        <head>
                            <title>Test Page</title>
                        </head>
                        <body>
                            <h1>This is the most important Heading</h1>

                            <h2>Sub Heading 1</h2>
                            <h2>Sub Heading 2</h2>

                            <h3>Sub Sub Heading 1</h3>
                            <h3>Sub Sub Heading 2</h3>
                            <h3>Sub Sub Heading 3</h3>
                            
                            <h4>Heading Level 4</h4>
                            
                            <h5>Heading Level 5 1</h5>
                            <h5>Heading Level 5 2</h5>

                            <h6>Heading Level 6 1</h6>
                            <h6>Heading Level 6 2</h6>
                            <h6>Heading Level 6 3</h6>
                        </body>
                    </html>";
        }
    }
}
