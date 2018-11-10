using System;
using System.Collections.Generic;
using System.Text;

namespace ParserLib
{
    public abstract class AbstractDocParser 
    {
        protected string html = string.Empty;
        public  AbstractDocParser(string doc = "")
        {
            html = doc;
            

        }

        public abstract void Parse(string html = "");
       
       
    }
}
