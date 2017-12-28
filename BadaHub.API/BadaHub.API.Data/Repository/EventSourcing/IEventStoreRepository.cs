using System;
using System.Collections.Generic;
using BadaHub.API.Domain.Core.Events;

namespace BadaHub.API.Data.Repository.EventSourcing
{
    public interface IEventStoreRepository : IDisposable
    {
        void Store(StoredEvent theEvent);
        IList<StoredEvent> All(Guid aggregateId);
    }
}