using System.Collections.Generic;
using System.IO;
using Forms.Models;
using Newtonsoft.Json;

namespace Forms.DAL
{
    public class JsonConferenceData : IConferenceData
    {
        private List<ConferenceUser> _context;

        public JsonConferenceData()
        {
            Update();
        }
        public IEnumerable<ConferenceUser> GetAll()
        {
            return _context;
        }

        public void SaveConferenceUser(ConferenceUser conferenceUser)
        {
            _context.Add(conferenceUser);
            string json = JsonConvert.SerializeObject(_context.ToArray());
            File.WriteAllText("data.json", json);
        }
        private void Update()
        {

            using (StreamReader r = new StreamReader("data.json"))
            {
                string json = r.ReadToEnd();
                List<ConferenceUser> items = JsonConvert.DeserializeObject<List<ConferenceUser>>(json);
                _context = items;
            }
        }
    }
}
