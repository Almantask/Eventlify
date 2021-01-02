using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Eventlify.Application.Commands;
using Eventlify.Application.Queries;
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

        [HttpPost]
        public async Task<IActionResult> Get([FromBody]GetDomainEventsQuery query)
        {
            return Ok(await _getEvents.GetEvents(query));
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody]SaveDomainEventsCommand domainEventCommand)
        {
            await _saveEvents.SaveEvents(domainEventCommand);

            return Ok();
        }
    }
}
