using System;
using System.Collections.Generic;
using SportsEventsAPI.Data;
using SportsEventsAPI.Models;

namespace SportsEventsAPI.Services
{
    public class EventService : IEventService
    {
        private IEventRepository repo;
        public EventService(IEventRepository _repo)
        {
            repo = _repo;
        }
        public List<Event> GetAllEvents()
        {
            List<Event> events = repo.GetAllEvents();
            return events;
        }
    }
}
