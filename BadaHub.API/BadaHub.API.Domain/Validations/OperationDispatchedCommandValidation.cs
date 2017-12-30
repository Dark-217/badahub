using BadaHub.API.Domain.Commands;

namespace BadaHub.API.Domain.Validations
{

    public class OperationDispatchedCommandValidation : OperationValidation<OperationDispatchedCommand>
    {
        public OperationDispatchedCommandValidation()
        {
            ValidatePayload();
        }
    }
}
