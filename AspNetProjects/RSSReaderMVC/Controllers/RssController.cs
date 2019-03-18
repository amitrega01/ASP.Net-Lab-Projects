using RSSReaderMVC.Models;
using System.Linq;
using System.Web.Mvc;
using System.Xml.Linq;

namespace RSSReaderMVC.Controllers
{
    public class RssController : Controller
    {
        // GET: Rss
        public ActionResult Index()
        {
            var link = "http://www.polsatnews.pl/rss/polska.xml";
            var root = XElement.Load(link);
            var items = root.Descendants("item").Select(x =>
              new RssItem
              {
                  Title = x.Element("title").Value,
                  PubDate = x.Element("pubDate").Value,
                  Description = x.Element("description").Value,
                  Link = x.Element("link").Value
              }
             );
            return View(items);
        }
    }
}