using ContentLib;
using DataStructLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParserLib.ListMakers;
using System;
using System.Threading.Tasks;

namespace ParserControllerLib
{
    [TestClass]
    public class TestParserControllerLib { 


      

        [TestMethod]
        public async Task TestParseVenuesWeb()
        {
            HtmlItem html = HtmlItemFactory.GetHtmlItem(Constants.LocationType.WEB, "https://theblueshound.com/venue-listing");
            int i = await html.GrabAsync();
            var lm = new VenueListMaker(html.Html);
            Assert.AreNotEqual(lm, null);
           
        }

        [TestMethod]
        public async Task TestParseEventsWeb()
        {
            HtmlItem html = HtmlItemFactory.GetHtmlItem(Constants.LocationType.WEB, "https://theblueshound.com/music-calendar");
            int i = await html.GrabAsync();
            var lm = new EventListMaker(html.Html);
            Assert.AreNotEqual(lm, null);
            
        }





    }
}
