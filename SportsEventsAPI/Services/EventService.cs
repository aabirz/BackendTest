using System;
using System.Collections.Generic;
using SportsEventsAPI.Models;

namespace SportsEventsAPI.Services
{
    public class EventService : IEventService
    {
        public List<Event> GetAllEvents()
        {
            List<Event> events = new List<Event>() {
                new Event(){ Id = 1, Name = "Manchester United VS Paris Saint-Germain", StartDate = new DateTime(2019,2,12), EndDate = new DateTime(2019,2,12), Result = "0-2" },
                new Event(){ Id = 2, Name = "Roma VS Paris FC Porto", StartDate = new DateTime(2019,2,12), EndDate = new DateTime(2019,2,12), Result = "2-1" },
                new Event(){ Id = 3, Name = "FC Viktoria Plzen VS Roma", StartDate = new DateTime(2018,12,12), EndDate = new DateTime(2018,12,12), Result = "2-1" }
            };
            return events;
        }
    }
}
