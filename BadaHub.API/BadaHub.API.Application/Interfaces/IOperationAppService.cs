using System;
using System.Collections.Generic;
using BadaHub.API.Application.EventSourcedNormalizers;
using BadaHub.API.Application.ViewModels;

namespace BadaHub.API.Application.Interfaces
{
    public interface IOperationAppService : IDisposable
    {
        Guid Dispatch(OperationViewModel operationViewModel);
        IEnumerable<OperationViewModel> GetAll();
        OperationViewModel GetById(Guid id);
        IList<OperationHistoryData> GetAllHistory(Guid id);
    }
}
