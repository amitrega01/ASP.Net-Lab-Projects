using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Forms.Models
{
    public enum ConferenceType
    {
        Lecture,
        Workshop
    }
    public class ConferenceUser
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ConferenceType? ConferenceType { get; set; }
        public string ProfilePicUrl { get; set; }
    }
}
