using SportsEventsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsEventsAPI.Data
{
    public interface IEventRepository
    {
        List<Event> GetAllEvents();
    }
}
