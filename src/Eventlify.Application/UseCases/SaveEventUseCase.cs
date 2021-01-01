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

    public class SaveEventUseCase : ISaveEventUseCase
    {
        public void Execute(DomainEvent domainEvent)
        {
            throw new System.NotImplementedException();
        }
    }
}
