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

        public DbSet<Event> Events { get; set; }
    }

   

   

}
