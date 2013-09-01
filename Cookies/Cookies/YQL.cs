using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Diagnostics;


namespace Cookies
{
    class YQL
    {
        string restQuery;
        XDocument website;

        public YQL(string query)
        {
            //Change this to parse query, for now, assume already formated as rest Query
            this.restQuery = query;
            this.website = XDocument.Load(restQuery);
            Debug.Write(website);
        }

    }
}
