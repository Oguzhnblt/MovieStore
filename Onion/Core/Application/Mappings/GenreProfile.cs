using Application.DTO.GenreModel;
using Application.Features.CQRS.Commands.GenreOperations;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings
{
    public class GenreProfile : Profile
    {
        public GenreProfile()
        {
            CreateMap<Genre, GenreViewModel>()
                .ForMember(dest => dest.GenreID, opt => opt.MapFrom(src => src.GenreID))
                .ForMember(dest => dest.GenreName, opt => opt.MapFrom(src => src.GenreName))
                .ReverseMap();

            CreateMap<CreateGenreModel, CreateGenreCommand>()
                .ForMember(dest => dest.GenreName, opt => opt.MapFrom(src => src.GenreName));

            CreateMap<UpdateGenreModel, UpdateGenreCommand>()
                .ForMember(dest => dest.GenreID, opt => opt.MapFrom(src => src.GenreID))
                .ForMember(dest => dest.GenreName, opt => opt.MapFrom(src => src.GenreName));
        }
    }

}
