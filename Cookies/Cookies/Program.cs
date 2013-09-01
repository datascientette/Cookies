using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookies
{
    class Program
    {
        static void Main(string[] args)
        {
            YQL testYQL = new YQL("http://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20html%20where%20url%3D%22http%3A%2F%2Fallrecipes.com%2Frecipe%2Fcookie-jar-sugar-cookies%2F%22%20and%20compat%3D%22html5%22%20AND%20xpath%20%3D%20%22%2F%2F%40data-ingredientid%22&diagnostics=true");
        }
    }
}
