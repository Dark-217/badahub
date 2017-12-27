using System;
using BadaHub.API.Domain.Core.Commands;
using System.Collections.Generic;

namespace BadaHub.API.Domain.Commands
{
    public class OperationCommand : Command
    {
        public Guid Id { get; protected set; }

        public OperationType Type { get; protected set; }

        public dynamic Payload { get; protected set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
        
    }

    //TODO: add microservice for each operation type
    public enum OperationType
    {
        //add string descriptions

        //turn off lights, outlets
        HOME_ASSISTANT,

        //turn on tv and xbox,
        IR,

        //get containers and cpu usage
        JBHS,

        //get friends xbox actvity
        XBOX
    }

}
