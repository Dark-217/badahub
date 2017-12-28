using BadaHub.API.Domain.Commands;
using BadaHub.API.Domain.Core.Events;
using System;

namespace BadaHub.API.Domain.Events
{
    public class OperationDispatchedEvent : Event
    {
        public OperationDispatchedEvent(Guid id, OperationType type, dynamic payload)
        {
            Id = id;
            Type = type;
            Payload = payload;
            AggregateId = id;
        }
        public Guid Id { get; protected set; }

        public OperationType Type { get; protected set; }

        public dynamic Payload { get; protected set; }
    }
}
