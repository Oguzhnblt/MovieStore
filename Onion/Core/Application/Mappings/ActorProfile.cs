using Application.DTO.ActorDTOModel;
using Application.DTO.ActorModel;
using Application.Features.CQRS.Commands.ActorOperations;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings
{
    public class ActorProfile : Profile
    {
        public ActorProfile()
        {
            CreateMap<Actor, ActorViewModel>()
                .ForMember(dest => dest.ActorID, opt => opt.MapFrom(src => src.ActorID))
                .ForMember(dest => dest.ActorName, opt => opt.MapFrom(src => src.ActorName))
                .ForMember(dest => dest.ActorSurname, opt => opt.MapFrom(src => src.ActorSurname))
                .ForMember(dest => dest.Movies, opt => opt.MapFrom(src => src.Movies))
                .ReverseMap();

            CreateMap<CreateActorModel, CreateActorCommand>()
                .ForMember(dest => dest.ActorName, opt => opt.MapFrom(src => src.ActorName))
                .ForMember(dest => dest.ActorSurname, opt => opt.MapFrom(src => src.ActorSurname))
                .ReverseMap();

            CreateMap<UpdateActorModel, UpdateActorModel>()
                .ForMember(dest => dest.ActorID, opt => opt.MapFrom(src => src.ActorID))
                .ForMember(dest => dest.ActorName, opt => opt.MapFrom(src => src.ActorName))
                .ForMember(dest => dest.ActorSurname, opt => opt.MapFrom(src => src.ActorSurname))
                .ReverseMap();
        }
    }

}