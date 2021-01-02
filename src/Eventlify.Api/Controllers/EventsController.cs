using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Eventlify.Application.Models;
using Eventlify.Application.UseCases;

namespace Eventlify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IGetEventsUseCase _getEvents;
        private readonly ISaveEventUseCase _saveEvents;

        public EventsController(IGetEventsUseCase getEvents, ISaveEventUseCase saveEvents)
        {
            _getEvents = getEvents;
            _saveEvents = saveEvents;
        }

        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _getEvents.Execute());

        [HttpPost]
        public async Task<IActionResult> Save([FromBody]DomainEvent domainEvent)
        {
            await _saveEvents.Execute(domainEvent);

            return Ok();
        }
    }
}
