using System.Threading.Tasks;
using BadaHub.API.Domain.Core.Commands;
using BadaHub.API.Domain.Core.Events;


namespace BadaHub.API.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
        Task RaiseEvent<T>(T @event) where T : Event;
    }
}