using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RSSReaderMVC.Models
{
    public class RssItem
    {

        public string Title { get; set; }
        public string PubDate { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
    }
}