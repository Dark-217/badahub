using BadaHub.API.Domain.Commands;
using System;
using BadaHub.API.Domain.Core.Bus;
using BadaHub.API.Domain.Core.Notifications;
using BadaHub.API.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BadaHub.API.Domain.CommandHandlers
{
    public class OperationCommandHandler : CommandHandler,
        INotificationHandler<OperationDispatchedCommand>
    {
        public OperationCommandHandler(IUnitOfWork uow, IMediatorHandler bus, INotificationHandler<DomainNotification> notifications) : base(uow, bus, notifications)
        {
        }

        public Task Handle(OperationDispatchedCommand notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
