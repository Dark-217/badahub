using AutoMapper;
using BadaHub.API.Application.ViewModels;
using BadaHub.API.Domain.Commands;

namespace BadaHub.API.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<OperationViewModel, NewOperationCommand>()
                .ConstructUsing(c => new NewOperationCommand(c.Id, c.Type, c.Payload));
        }
    }
}
