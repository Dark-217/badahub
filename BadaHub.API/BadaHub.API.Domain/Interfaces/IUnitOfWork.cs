using BadaHub.API.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace BadaHub.API.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        CommandResponse Commit();
    }
}
