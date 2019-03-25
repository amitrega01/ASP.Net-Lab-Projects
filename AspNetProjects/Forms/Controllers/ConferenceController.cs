using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Forms.DAL;
using Forms.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using PagedList;
using ReflectionIT.Mvc.Paging;

namespace Forms.Controllers
{
    public class ConferenceController : Controller
    {
        private IConferenceData _conferenceData;

        public ConferenceController()
        {
            //_conferenceData = new DbConfereneceData();
            //_conferenceData = new JsonConferenceData();
            _conferenceData = new MemoryConferenceData();

        }

        // GET: Conference
        public ActionResult Index(int page = 1)
        {
            var users = _conferenceData.GetAll().ToList();
            var model = PagingList.Create(users, 10, page);
            return View(model);
        }

        public ActionResult Confirm()
        {
            return View(true);
        }
        // GET: Conference/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Conference/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ConferenceUser conferenceUser)
        {
            try
            {
                _conferenceData.SaveConferenceUser(conferenceUser);
                return RedirectToAction(nameof(Confirm));

                // TODO: Add insert logic here

            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(ConferenceUser conferenceUser)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}