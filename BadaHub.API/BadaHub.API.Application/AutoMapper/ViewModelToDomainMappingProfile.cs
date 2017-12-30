using AutoMapper;
using BadaHub.API.Application.ViewModels;
using BadaHub.API.Domain.Commands;

namespace BadaHub.API.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<OperationViewModel, OperationDispatchedCommand>()
                .ConstructUsing(c => new OperationDispatchedCommand(c.Id, c.Type, c.Payload));
        }
    }
}
