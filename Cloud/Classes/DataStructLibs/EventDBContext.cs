using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructLib
{
    public class EventDBContext : DbContext
    {
        private string connectionString = "Server=(localdb)\\mssqllocaldb;database=HoundDB;Trusted_Connection=True;MultipleActiveResultSets=true";
        public DbSet<Event> Events { get; set; }

        public DbSet<Venue> Venues { get; set; }

        public EventDBContext()
        {

        }
        public EventDBContext(string connString)
        {
            if (!string.IsNullOrEmpty(connString))
                connectionString = connString;


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected  override void OnModelCreating(ModelBuilder mb)
        {

        }

    }
}
