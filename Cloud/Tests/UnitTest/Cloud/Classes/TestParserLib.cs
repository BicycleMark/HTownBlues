using ContentLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParserLib.ListMakers;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ParserLib
{
    [TestClass]
    public class TestParserLib
    {

        [TestMethod]
        public async Task TestVenueListMakerWeb()
        {
            HtmlItem html = HtmlItemFactory.GetHtmlItem(ContentLib.Constants.LocationType.WEB, "https://theblueshound.com/venue-listing");
            int i = await html.GrabAsync();
            var lm = new VenueListMaker(html.Html);
            var vl = lm.ToXml();
            Assert.AreNotEqual(vl, null);
        }

        [TestMethod]
        public async Task TestEventListMakerWeb()
        {
            HtmlItem html = HtmlItemFactory.GetHtmlItem(ContentLib.Constants.LocationType.WEB, "https://theblueshound.com/music-calendar");
            int i = await html.GrabAsync();
            var lm = new EventListMaker(html.Html);
            var le = lm.ToXml();
            Assert.AreNotEqual(le, null);
            
        }

        [TestMethod]
       public async  Task TestVenueListMakerFile()

        {
            HtmlItem html = HtmlItemFactory.GetHtmlItem(ContentLib.Constants.LocationType.FILE, @"Cloud\\Classes\\Data\\Venues.html");
            int i = await html.GrabAsync();
            var lm = new VenueListMaker(html.Html);
            var vl = lm.ToXml();

            Assert.AreNotEqual(vl,null);
        }

        [TestMethod]
        public async Task TestEventListMakerFile()
        {
            HtmlItem html = HtmlItemFactory.GetHtmlItem(ContentLib.Constants.LocationType.FILE, @"Cloud\\Classes\\Data\\Events.html");
            int i = await html.GrabAsync();
            var lm = new EventListMaker(html.Html);
            var le = lm.ToXml();
            Assert.AreNotEqual(le, null);
        }



    }
}
