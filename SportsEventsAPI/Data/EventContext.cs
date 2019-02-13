using Microsoft.EntityFrameworkCore;
using SportsEventsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsEventsAPI.Data
{
    public class EventContext : DbContext
    {
        public EventContext(DbContextOptions<EventContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<Event>().HasData(
                    new Event() { Id = 1, Name = "Manchester United VS Paris Saint-Germain", StartDate = new DateTime(2019, 2, 12), EndDate = new DateTime(2019, 2, 12), Result = "0-2" },
                    new Event() { Id = 2, Name = "Roma VS Paris FC Porto", StartDate = new DateTime(2019, 2, 12), EndDate = new DateTime(2019, 2, 12), Result = "2-1" },
                    new Event() { Id = 3, Name = "FC Viktoria Plzen VS Roma", StartDate = new DateTime(2018, 12, 12), EndDate = new DateTime(2018, 12, 12), Result = "2-1" }
            );
        }

        public DbSet<Event> Events { get; set; }
    }
}
