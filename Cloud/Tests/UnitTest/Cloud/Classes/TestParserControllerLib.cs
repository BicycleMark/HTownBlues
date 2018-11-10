using ContentLib;
using DataStructLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace ParserControllerLib
{
    [TestClass]
    public class TestParserControllerLib
    {
       [TestMethod]
       public async Task TestParseVenuesFile()
        {
            HtmlItem html = HtmlItemFactory.GetHtmlItem(Constants.LocationType.FILE, @"Cloud\\Classes\\Data\\Venues.html");
            int i = await html.GrabAsync();
            var parser = ParserLib.DocParserFactory.GetParser(  ParserLib.Constants.Site.BluesHound, 
                                                                ParserLib.Constants.SiteType.VENUE,
                                                                html.Html);
            Assert.AreNotEqual(i, 0);
        }

        [TestMethod]
        public async Task TestParseEventsFile()
        {
            HtmlItem html = HtmlItemFactory.GetHtmlItem(Constants.LocationType.FILE, @"Cloud\\Classes\\Data\\Events.html");
            int i = await html.GrabAsync();
            var parser = ParserLib.DocParserFactory.GetParser(ParserLib.Constants.Site.BluesHound,
                                                                ParserLib.Constants.SiteType.CALENDAR,
                                                                html.Html);

            Assert.AreNotEqual(i, 0);
        }

        [TestMethod]
        public async Task TestParseVenuesWeb()
        {
            HtmlItem html = HtmlItemFactory.GetHtmlItem(Constants.LocationType.WEB, "https://theblueshound.com/venue-listing");
            int i = await html.GrabAsync();
            Assert.AreNotEqual(i, 0);
        }

        [TestMethod]
        public async Task TestParseEventsWeb()
        {
            HtmlItem html = HtmlItemFactory.GetHtmlItem(Constants.LocationType.WEB, "https://theblueshound.com/music-calendar");
            int i = await html.GrabAsync();
            Assert.AreNotEqual(i, 0);
        }



    }
}
