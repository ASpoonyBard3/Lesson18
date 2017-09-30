using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
using System.Net;

namespace MyCodeLibrary
{
    public class Scrape
    {
        public string ScrapeWebpage(string url)
        {
            return GetWebPage(url);
        }

        public string ScrapeWebpage(string url, string filepath)
        {
            string reply = GetWebPage(url);
            File.WriteAllText(filepath, reply);
            return reply;
        }

        private string GetWebPage(string url)
        {
            WebClient client = new WebClient();
            string content = client.DownloadString(url);
            content += "That's all folks!";
            return content;
        }
    }
}