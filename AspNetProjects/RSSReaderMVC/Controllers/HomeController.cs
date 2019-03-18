using RSSReaderMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace RSSReaderMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
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
            link = "https://www.rmf24.pl/fakty/feed";
            root = XElement.Load(link);
            var items2 = root.Descendants("item").Select(x =>
              new RssItem
              {
                  Title = x.Element("title").Value,
                  PubDate = x.Element("pubDate").Value,
                  Description = x.Element("description").Value,
                  Link = x.Element("link").Value
              }
             );
           link = "https://news.google.com/rss?hl=pl&gl=PL&ceid=PL:pl";
            root = XElement.Load(link);
            var items3 = root.Descendants("item").Select(x =>
              new RssItem
              {
                  Title = x.Element("title").Value,
                  PubDate = x.Element("pubDate").Value,
                  Description = x.Element("description").Value,
                  Link = x.Element("link").Value
              }
             );
            items = items.Take(3);
            items2 = items2.Take(3);
            items3 = items3.Take(3);
            var res = items.Concat(items2).Concat(items3);
            return View(res);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}