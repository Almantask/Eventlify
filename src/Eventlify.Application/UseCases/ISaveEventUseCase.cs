using System;
using System.Collections.Generic;
using System.Text;
using Eventlify.Application.Models;

namespace Eventlify.Application.UseCases
{
    /// <summary>
    /// Save event use case.
    /// </summary>
    public interface ISaveEventUseCase
    {
        void Execute(DomainEvent domainEvent);
    }
}
