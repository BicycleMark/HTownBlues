using ContentLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParserLib.DocParsers;
using ParserLib.ListMakers;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ParserLib
{
    [TestClass]
    public class TestParserLib
    {


        [TestMethod]
        public async Task TestParseVenuesFile()
        {
            HtmlItem html = HtmlItemFactory.GetHtmlItem(ContentLib.Constants.LocationType.FILE, @"Cloud\\Classes\\Data\\Venues.html");
            int i = await html.GrabAsync();
            //var parser = ParserLib.ParserFactory.GetParser(ParserLib.Constants.Site.BluesHound,
            //                                                    ParserLib.Constants.SiteType.VENUE,
            //                                                    html.Html) as HTownBluesHoundVenues;
            //List<Venue> lv = parser.Parse();

            Assert.AreNotEqual(i, 0);
        }

        [TestMethod]
        public async Task TestParseEventsFile()
        {
            HtmlItem html = HtmlItemFactory.GetHtmlItem(ContentLib.Constants.LocationType.FILE, @"Cloud\\Classes\\Data\\Events.html");
            int i = await html.GrabAsync();
            //var parser = ParserLib.ParserFactory.GetParser(ParserLib.Constants.Site.BluesHound,
            //                                                    ParserLib.Constants.SiteType.CALENDAR,
            //                                                    html.Html) as HTownBluesHoundEvents;
            //List < BluesEvent > le = parser.Parse();

            Assert.AreNotEqual(i, 0);
        }

        [TestMethod]
        public async Task TestParseVenuesWeb()
        {
            HtmlItem html = HtmlItemFactory.GetHtmlItem(ContentLib.Constants.LocationType.WEB, "https://theblueshound.com/venue-listing");
            int i = await html.GrabAsync();
            Assert.AreNotEqual(i, 0);
        }

        [TestMethod]
        public async Task TestParseEventsWeb()
        {
            HtmlItem html = HtmlItemFactory.GetHtmlItem(ContentLib.Constants.LocationType.WEB, "https://theblueshound.com/music-calendar");
            int i = await html.GrabAsync();
            Assert.AreNotEqual(i, 0);
        }

        [TestMethod]
        public async Task TestVenueListMakerWeb()
        {
            HtmlItem html = HtmlItemFactory.GetHtmlItem(ContentLib.Constants.LocationType.WEB, "https://theblueshound.com/venue-listing");
            int i = await html.GrabAsync();
            var lm = new VenueListMaker(html.Html);
            Assert.AreNotEqual(lm, null);
        }

        [TestMethod]
        public async Task TestEventListMakerWeb()
        {
            HtmlItem html = HtmlItemFactory.GetHtmlItem(ContentLib.Constants.LocationType.WEB, "https://theblueshound.com/music-calendar");
            int i = await html.GrabAsync();
            var lm = new EventListMaker(html.Html);
            Assert.AreNotEqual(lm, null);
        }

        [TestMethod]
       public async  Task TestVenueListMakerFile()

        {
            HtmlItem html = HtmlItemFactory.GetHtmlItem(ContentLib.Constants.LocationType.FILE, @"Cloud\\Classes\\Data\\Venues.html");
            int i = await html.GrabAsync();
            var lm = new VenueListMaker(html.Html);
           

            Assert.AreNotEqual(lm,null);
        }

        [TestMethod]
        public async Task TestEventListMakerFile()
        {
            HtmlItem html = HtmlItemFactory.GetHtmlItem(ContentLib.Constants.LocationType.FILE, @"Cloud\\Classes\\Data\\Events.html");
            int i = await html.GrabAsync();
            var lm = new EventListMaker(html.Html);
            Assert.AreNotEqual(lm, null);
        }



    }
}
