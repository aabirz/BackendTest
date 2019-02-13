using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsEventsAPI.Models;
using SportsEventsAPI.Services;

namespace SportsEventsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IEventService eventService;
        public ValuesController(IEventService _eventService)
        {
            eventService = _eventService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Event>> GetAllEvents()
        {
            var events = eventService.GetAllEvents();
            return Ok(events);
        }

    }
}
