using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forms.Models;

namespace Forms.DAL
{
    public class MemoryConferenceData : IConferenceData
    {
        private static List<ConferenceUser> _context = new List<ConferenceUser>();

        public  MemoryConferenceData()
        {
        }
        public IEnumerable<ConferenceUser> GetAll()
        {
            return _context;
        }

        public void SaveConferenceUser(ConferenceUser conferenceUser)
        {
            _context.Add(conferenceUser);   
        }
    }
}
