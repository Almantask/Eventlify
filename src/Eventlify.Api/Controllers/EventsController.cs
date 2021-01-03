using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using AutoMapper;
using Eventlify.Api.Messages;
using Eventlify.Application.Commands;
using Eventlify.Application.Queries;
using Eventlify.Application.UseCases;
using Eventlify.SharedKernel.Validation;

namespace Eventlify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IGetEventsUseCase _getEvents;
        private readonly ISaveEventUseCase _saveEvents;
        private readonly IMapper _mapper;

        public EventsController(IGetEventsUseCase getEvents, ISaveEventUseCase saveEvents, IMapper mapper)
        {
            Require.NotNull(getEvents);
            Require.NotNull(saveEvents);
            Require.NotNull(mapper);

            _getEvents = getEvents;
            _saveEvents = saveEvents;
            _mapper = mapper;
        }

        [HttpPost("query")]
        public async Task<IActionResult> Get([FromBody]GetDomainEventsRequest request)
        {
            var query = _mapper.Map<GetDomainEventsQuery>(request);
            return Ok(await _getEvents.GetEvents(query));
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody]SaveDomainEventsRequest request)
        {
            var command = _mapper.Map<SaveDomainEventsCommand>(request);
            await _saveEvents.SaveEvents(command);

            return Ok();
        }
    }
}
