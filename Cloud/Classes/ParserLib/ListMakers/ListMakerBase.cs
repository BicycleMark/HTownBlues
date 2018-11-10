using System;
using System.Collections.Generic;
using System.Text;
using HtmlAgilityPack;
using ParserLib.DocParsers;

namespace ParserLib.ListMakers
{
    public abstract class ListMakerBase
    {
        public string Html { get; set; }
        HtmlDocument doc;
        public ListMakerBase(string html)
        {
            Html = html;
            doc = new HtmlDocument();
            doc.LoadHtml(html);
        }
        

       


    }
    public class EventListMaker : ListMakerBase
    {

        public EventListMaker(string html) : base(html)
        {


        }
        public List<BluesEvent> ToList()
        {
            return null;
        }


    }

    public class VenueListMaker : ListMakerBase
    {

        public VenueListMaker(string html) : base(html)
        {


        }
        public List<BluesVenue> ToList()
        {
            return null;
        }


    }


}
