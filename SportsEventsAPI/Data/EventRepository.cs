using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportsEventsAPI.Models;

namespace SportsEventsAPI.Data
{
    public class EventRepository : IEventRepository
    {
        private EventContext context;
        public EventRepository(EventContext _context)
        {
            context = _context;
        }

        public List<Event> GetAllEvents()
        {
            List<Event> events = context.Events.ToList();
            return events;
        }
    }
}
