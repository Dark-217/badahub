using BadaHub.API.Domain.Validations;
using System;

namespace BadaHub.API.Domain.Commands
{
    public class NewOperationCommand : OperationCommand
    {
        public NewOperationCommand(Guid id, OperationType type, dynamic payload)
        {
            Id = id;
            Type = type;
            Payload = payload;
        }

        public override bool IsValid()
        {
            ValidationResult = new NewOperationCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
