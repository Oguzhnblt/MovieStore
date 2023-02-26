using Application.DTO.DirectorModel;
using Application.Features.CQRS.Commands.DirectorOperations;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings
{
    public class DirectorProfile : Profile
    {
        public DirectorProfile()
        {
            CreateMap<Director, DirectorViewModel>()
                .ForMember(dest => dest.DirectorID, opt => opt.MapFrom(src => src.DirectorID))
                .ForMember(dest => dest.DirectorName, opt => opt.MapFrom(src => src.DirectorName))
                .ForMember(dest => dest.DirectorSurname, opt => opt.MapFrom(src => src.DirectorSurname))
                .ReverseMap();

            CreateMap<CreateDirectorModel, CreateDirectorCommand>()
                .ForMember(dest => dest.DirectorName, opt => opt.MapFrom(src => src.DirectorName))
                .ForMember(dest => dest.DirectorSurname, opt => opt.MapFrom(src => src.DirectorSurname));

            CreateMap<UpdateDirectorModel, UpdateDirectorCommand>()
                .ForMember(dest => dest.DirectorID, opt => opt.MapFrom(src => src.DirectorID))
                .ForMember(dest => dest.DirectorName, opt => opt.MapFrom(src => src.DirectorName))
                .ForMember(dest => dest.DirectorSurname, opt => opt.MapFrom(src => src.DirectorSurname));
        }
    }
}