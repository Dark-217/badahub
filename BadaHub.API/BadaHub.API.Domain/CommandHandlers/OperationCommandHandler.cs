using BadaHub.API.Domain.Commands;
using System;
using BadaHub.API.Domain.Core.Bus;
using BadaHub.API.Domain.Core.Notifications;
using BadaHub.API.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BadaHub.API.Domain.Models;
using BadaHub.API.Domain.Events;

namespace BadaHub.API.Domain.CommandHandlers
{
    public class OperationCommandHandler : CommandHandler,
        INotificationHandler<OperationDispatchedCommand>
    {

        private readonly IOperationRepository _operationRepository;
        private readonly IMediatorHandler Bus;

        public OperationCommandHandler(IOperationRepository operationRepository, IUnitOfWork uow, IMediatorHandler bus, INotificationHandler<DomainNotification> notifications) : base(uow, bus, notifications)
        {
            _operationRepository = operationRepository;
            Bus = bus;
        }

        public Task Handle(OperationDispatchedCommand operation, CancellationToken cancellationToken)
        {

            if (!operation.IsValid())
            {
                NotifyValidationErrors(operation);
                return Task.CompletedTask;
            }

            var newOperation = new Operation(Guid.NewGuid(), operation.Type, operation.Payload);


            _operationRepository.Add(newOperation);

            if (Commit())
            {
                Bus.RaiseEvent(new OperationDispatchedEvent(operation.Id, operation.Type, operation.Payload));
            }
            return Task.CompletedTask;
        }

        //public Task Handle(OperationDispatchedCommand notification, CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
