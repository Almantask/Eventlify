using System;
using System.Collections.Generic;
using System.Text;
using Eventlify.Application.Models;

namespace Eventlify.Application.UseCases
{
    public interface IGetEventsUseCase
    {
        /// <summary>
        /// Gets all events.
        /// </summary>
        /// <returns></returns>
        IEnumerable<DomainEvent> Execute();
    }
}
