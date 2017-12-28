using BadaHub.API.Domain.Core.Commands;
using System;

namespace BadaHub.API.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        CommandResponse Commit();
    }
}
