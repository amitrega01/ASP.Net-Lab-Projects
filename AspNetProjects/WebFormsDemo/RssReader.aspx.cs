using System;
using System.Linq;
using System.Xml.Linq;
using WebFormsDemo.models;

namespace WebFormsDemo
{
    public partial class RssReader : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

            

        }

        protected void BtnLoad_Click(object sender, EventArgs e)
        {
            var link = RssText.Text;
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
            Repeater1.DataSource = items.ToList();
            Repeater1.DataBind();
        }
    }
}