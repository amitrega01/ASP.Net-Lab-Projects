using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forms.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Forms.Controllers
{
    public class ConferenceController : Controller
    {

        public static List<ConferenceUser> SavedUsers { get; private set; } = new List<ConferenceUser>();

        // GET: Conference
        public ActionResult Index()
        {
            return View(SavedUsers);
        }

      
        // GET: Conference/Create
        public ActionResult Create()
        {
            ViewBag.ConferenceType = new List<SelectListItem>
            {
                new SelectListItem{Text = "Wykłady", Value=ConferenceType.Lecture.ToString() },
                new SelectListItem{Text = "Warsztaty", Value=ConferenceType.Workshop.ToString() },
            };
            return View();
        }

        // POST: Conference/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ConferenceUser conferenceUser)
        {
            try
            {
                // TODO: Add insert logic here
                SavedUsers.Add(conferenceUser);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
    }
}