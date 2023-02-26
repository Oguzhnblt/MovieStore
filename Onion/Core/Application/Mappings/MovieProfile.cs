using Application.DTO.MovieModel;
using Application.Features.CQRS.Commands.MovieOperations;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<Movie, MovieViewModel>()
                .ForMember(dest => dest.MovieID, opt => opt.MapFrom(src => src.MovieID))
                .ForMember(dest => dest.MovieName, opt => opt.MapFrom(src => src.MovieName))
                .ForMember(dest => dest.MovieYear, opt => opt.MapFrom(src => src.MovieYear))
                .ForMember(dest => dest.MovieGenre, opt => opt.MapFrom(src => src.MovieGenre))
                .ForMember(dest => dest.MoviePrice, opt => opt.MapFrom(src => src.MoviePrice))
                .ForMember(dest => dest.Actor, opt => opt.MapFrom(src => src.Actor))
                .ForMember(dest => dest.Director, opt => opt.MapFrom(src => src.Director))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                .ReverseMap();

            CreateMap<CreateMovieModel, CreateMovieCommand>()
                .ForMember(dest => dest.MovieName, opt => opt.MapFrom(src => src.MovieName))
                .ForMember(dest => dest.MovieYear, opt => opt.MapFrom(src => src.MovieYear))
                .ForMember(dest => dest.MovieGenre, opt => opt.MapFrom(src => src.MovieGenre))
                .ForMember(dest => dest.MoviePrice, opt => opt.MapFrom(src => src.MoviePrice))
                .ForMember(dest => dest.ActorIds, opt => opt.MapFrom(src => src.Actor))
                .ForMember(dest => dest.DirectorId, opt => opt.MapFrom(src => src.Director))
                .ReverseMap();

            CreateMap<UpdateMovieModel, UpdateMovieCommand>()
                .ForMember(dest => dest.MovieID, opt => opt.MapFrom(src => src.MovieID))
                .ForMember(dest => dest.MovieName, opt => opt.MapFrom(src => src.MovieName))
                .ForMember(dest => dest.MovieYear, opt => opt.MapFrom(src => src.MovieYear))
                .ForMember(dest => dest.MovieGenre, opt => opt.MapFrom(src => src.MovieGenre))
                .ForMember(dest => dest.MoviePrice, opt => opt.MapFrom(src => src.MoviePrice))
                .ForMember(dest => dest.ActorIds, opt => opt.MapFrom(src => src.Actor))
                .ForMember(dest => dest.DirectorId, opt => opt.MapFrom(src => src.Director))
                .ReverseMap();
        }
    }

}