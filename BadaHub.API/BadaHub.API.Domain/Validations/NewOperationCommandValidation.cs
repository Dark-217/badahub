using BadaHub.API.Domain.Commands;

namespace BadaHub.API.Domain.Validations
{

    public class NewOperationCommandValidation : OperationValidation<NewOperationCommand>
    {
        public NewOperationCommandValidation()
        {
            ValidatePayload();
        }
    }
}
