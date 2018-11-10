using System;
using System.Collections.Generic;
using System.Text;

namespace ParserLib.DocParsers
{
    public class HTownBluesHoundEvents : IParser
    {
        public HTownBluesHoundEvents(string html)
        {
            Html = html;

        }
        public string Html { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual List<BluesEvent> Parse()
        {
            List<BluesEvent> be = new List<BluesEvent>();
            return be;
        }
    }
}
