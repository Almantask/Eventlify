using System;
using System.Collections.Generic;
using Eventlify.Application.Handlers;
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

    public class GetEventsUseCase : IGetEventsUseCase
    {
        private IDomainEventHandlers.IGetDomainEvents @object;

        public GetEventsUseCase(IDomainEventHandlers.IGetDomainEvents @object) => this.@object = @object;

        public IEnumerable<DomainEvent> Execute()
        {
            throw new NotImplementedException();
        }
    }
}
