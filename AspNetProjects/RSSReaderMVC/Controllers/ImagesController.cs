using Newtonsoft.Json;
using RSSReaderMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace RSSReaderMVC.Controllers
{
    public class ImagesController : Controller
    {
        // GET: Images
        public ActionResult Index()
        {
            using (var client = new WebClient())
            {
                var json = client
                    .DownloadString("https://api.unsplash.com/photos?page=1&client_id=2a4f04e09bd42ca113fb9b9c39d8e980eb9925378f73920441f82ce6c8a921f4");
                var images = JsonConvert
                    .DeserializeObject<List<ApiImage>>(json);
                var list = images.Select(x => new ImageModel
                {
                    Regular = x.urls.regular,
                    Thumb = x.urls.thumb
                });

                return View(list);
            }
        }
    }
}