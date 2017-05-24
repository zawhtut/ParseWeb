using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace ParseWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load("http://www.cbbank.com.mm/exchange_rate.aspx");

            HtmlNode[] nodes = document.DocumentNode.SelectNodes("//td").ToArray(); //table[@id='tablepress-1']
            foreach (HtmlNode item in nodes)
            {
                Console.WriteLine(item.InnerText + " ");
            }
            Console.Read();
        }
    }
}
