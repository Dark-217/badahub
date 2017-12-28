using BadaHub.API.Domain.Commands;
using BadaHub.API.Domain.Core.Models;
using System;

namespace BadaHub.API.Domain.Models
{
    public class Operation : Entity
    {
        public Operation(Guid id, OperationType type, dynamic payload)
        {
            Id = id;
            Type = type;
            Payload = payload;
        }

        // Empty constructor for EF
        protected Operation() { }

        public Guid Id { get; private set; }

        public OperationType Type { get; private set; }

        public dynamic Payload { get; private set; }
    }
}
