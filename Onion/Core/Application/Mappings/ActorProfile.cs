using Application.DTO.ActorDTOModel;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings
{
    public class ActorProfile : Profile
    {
        public ActorProfile()
        {
            //Actor Mapping

            CreateMap<int, Actor>().ForMember(c => c.ActorID, c => c.MapFrom(c => c));

            CreateMap<CreateActorDTO, Actor>();

            CreateMap<UpdateActorDTO, Actor>();


            CreateMap<Actor, ActorDTO>().ForMember(c => c.Movies, c => c.MapFrom(c => c.Movies.Select(c => c.MovieName).ToList()));

            CreateMap<Actor, ActorDTO>().ForMember(c => c.Movies, c => c.MapFrom(c => c.Movies.Select(c => c.MovieName).ToList()));

        }

    }
}