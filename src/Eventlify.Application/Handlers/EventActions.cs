using Eventlify.SharedKernel.Handlers;

namespace Eventlify.Application.Handlers
{
    // ReSharper disable once InconsistentNaming
    public interface DomainEventHandlers
    {
        public interface IGetDomainEvents : IQueryHandler<Models.DomainEvent>
        {
        }

        public interface ISaveDomainEvent : ICommandHandler<Models.DomainEvent>
        {
        }
    }
}
