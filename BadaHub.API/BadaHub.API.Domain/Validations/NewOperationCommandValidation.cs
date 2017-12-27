using BadaHub.API.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

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
