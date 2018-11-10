using System;
using System.Collections.Generic;
using System.Text;

namespace ParserLib.DocParsers
{
    public class HTownBluesHoundVenues : IParser
    {
        public HTownBluesHoundVenues( string doc)
        {
            Html = doc;

        }
        public string Html { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual List<Venue> Parse()
        {
            List<Venue> lv = new List<Venue>();
            return lv;
        }
    }
}
