using Eventlify.SharedKernel.Handlers;

namespace Eventlify.Application.Handlers
{
    public interface IDomainEventHandlers
    {
        public interface IGetDomainEvents : IQueryHandler<Models.DomainEvent>
        {
        }

        public interface ISaveDomainEvent : ICommandHandler<Models.DomainEvent>
        {
        }
    }
}
