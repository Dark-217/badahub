using System;
using System.Collections.Generic;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using BadaHub.API.Application.EventSourcedNormalizers;
using BadaHub.API.Application.Interfaces;
using BadaHub.API.Application.ViewModels;
using BadaHub.API.Domain.Core.Bus;
using BadaHub.API.Domain.Interfaces;
using BadaHub.API.Data.Repository.EventSourcing;
using BadaHub.API.Domain.Commands;

namespace BadaHub.API.Application.Services
{
    public class OperationAppService : IOperationAppService
    {
        private readonly IMapper _mapper;
        private readonly IOperationRepository _operationRepository;
        private readonly IEventStoreRepository _eventStoreRepository;
        private readonly IMediatorHandler _bus;

        public OperationAppService(IMapper mapper,
                                  IOperationRepository customerRepository,
                                  IMediatorHandler bus,
                                  IEventStoreRepository eventStoreRepository)
        {
            _mapper = mapper;
            _operationRepository = customerRepository;
            _bus = bus;
            _eventStoreRepository = eventStoreRepository;
        }

        public IEnumerable<OperationViewModel> GetAll()
        {
            return _operationRepository.GetAll().ProjectTo<OperationViewModel>();
        }

        public OperationViewModel GetById(Guid id)
        {
            return _mapper.Map<OperationViewModel>(_operationRepository.GetById(id));
        }

        public Guid Dispatch(OperationViewModel operationViewModel)
        {

            var newOperationCommand = _mapper.Map<OperationDispatchedCommand>(operationViewModel);
            _bus.SendCommand(newOperationCommand);
            return newOperationCommand.Id;
        }
        
        public IList<OperationHistoryData> GetAllHistory(Guid id)
        {
            return OperationHistory.ToJavaScriptCustomerHistory(_eventStoreRepository.All(id));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}