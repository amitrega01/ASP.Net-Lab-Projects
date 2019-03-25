
using Forms.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forms.DAL
{
    public class DbConferenceContext : DbContext
    {
        private const string connectionString = @"Server=localhost\SQLEXPRESS;Database=conference;Trusted_Connection=True;";
        public DbSet<ConferenceUser> ConferenceUsers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
