using FluentValidation;
using BadaHub.API.Domain.Commands;

namespace BadaHub.API.Domain.Validations
{
    public abstract class OperationValidation<T> : AbstractValidator<T> where T : OperationCommand
    {
        protected void ValidatePayload()
        {
            RuleFor(c => c.Payload)
                .NotEmpty().WithMessage("Please provide a payload");
                //.Length(2, 150).WithMessage("The Name must have between 2 and 150 characters");
        }
    }
}