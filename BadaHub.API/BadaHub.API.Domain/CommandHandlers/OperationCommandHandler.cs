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
    class OperationCommandHandler : CommandHandler,
        INotificationHandler<NewOperationCommand>
    {
        public OperationCommandHandler(IUnitOfWork uow, IMediatorHandler bus, INotificationHandler<DomainNotification> notifications) : base(uow, bus, notifications)
        {
        }

        public Task Handle(NewOperationCommand notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
