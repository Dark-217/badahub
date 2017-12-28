using AutoMapper;
using BadaHub.API.Application.ViewModels;
using BadaHub.API.Domain.Models;

namespace BadaHub.API.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Operation, OperationViewModel>();
        }
    }
}
