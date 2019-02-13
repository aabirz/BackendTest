using SportsEventsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsEventsAPI.Services
{
    public interface IEventService
    {
        List<Event> GetAllEvents();
    }
}
