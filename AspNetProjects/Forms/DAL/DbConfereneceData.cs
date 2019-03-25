using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forms.Models;

namespace Forms.DAL
{
    public class DbConfereneceData : IConferenceData
    {
        private DbConferenceContext _context;

        public DbConfereneceData()
        {
            _context = new DbConferenceContext();
        }
        public IEnumerable<ConferenceUser> GetAll()
        {
            _context.Database.EnsureCreated();
            return _context.ConferenceUsers.ToList();

        }

        public void SaveConferenceUser(ConferenceUser conferenceUser)
        {

            _context.Add(conferenceUser);
            _context.SaveChanges();

        }
    }
}
