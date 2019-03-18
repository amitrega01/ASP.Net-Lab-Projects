using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Forms.Models
{
    public enum ConferenceType
    {
        Lecture,
        Workshop
    }
    public class ConferenceUser
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ConferenceType? ConferenceType { get; set; }
        public IFormFile ProfilePicUrl { get; set; }
    }
}
