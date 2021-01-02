using System.Collections.Generic;
using Eventlify.Application.Models;

namespace Eventlify.Application.Commands
{
    public class SaveDomainEventsCommand
    {
        public IEnumerable<DomainEvent> DomainEvents { get; set; }
    }
}