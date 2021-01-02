using System.Threading.Tasks;
using Eventlify.Application.Models;

namespace Eventlify.Application.UseCases
{
    /// <summary>
    /// Save event use case.
    /// </summary>
    public interface ISaveEventUseCase
    {
        Task Execute(DomainEvent domainEvent);
    }

    public class SaveEventUseCase : ISaveEventUseCase
    {
        public Task Execute(DomainEvent domainEvent)
        {
            throw new System.NotImplementedException();
        }
    }
}
