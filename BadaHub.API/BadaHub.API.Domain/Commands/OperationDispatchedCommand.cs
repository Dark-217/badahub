using BadaHub.API.Domain.Validations;
using System;

namespace BadaHub.API.Domain.Commands
{
    public class OperationDispatchedCommand : OperationCommand
    {
        public OperationDispatchedCommand(Guid id, OperationType type, dynamic payload)
        {
            Id = id;
            Type = type;
            Payload = payload;
        }

        public override bool IsValid()
        {
            ValidationResult = new OperationDispatchedCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
