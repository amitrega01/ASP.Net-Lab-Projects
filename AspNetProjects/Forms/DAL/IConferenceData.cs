using Forms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forms.DAL
{
    interface IConferenceData
    {

        void SaveConferenceUser(ConferenceUser conferenceUser);
        IEnumerable<ConferenceUser> GetAll();
    }
}
