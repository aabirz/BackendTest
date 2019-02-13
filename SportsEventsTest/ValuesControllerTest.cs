using Microsoft.AspNetCore.Mvc;
using SportsEventsAPI.Controllers;
using SportsEventsAPI.Models;
using SportsEventsAPI.Services;
using System;
using System.Collections.Generic;
using Xunit;

namespace SportsEventsTest
{
    public class ValuesControllerTest
    {
        private ValuesController valuesController;
        private IEventService eventService;
        public ValuesControllerTest()
        {
            eventService = new EventService();
            valuesController = new ValuesController(eventService);
        }
        [Fact]
        public void GetAllEvents_WhenCalled_ReturnsOkResult()
        {

            var okResult = valuesController.GetAllEvents();

            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Fact]
        public void GetAllEvents_WhenCalled_ReturnsAllEvents()
        {
            var okResult = valuesController.GetAllEvents().Result as OkObjectResult;

            var items = Assert.IsType<List<Event>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }
    }
}
