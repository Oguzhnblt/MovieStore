using Application.DTO.MovieModel;
using Domain.Entities;
using MediatR;

namespace Application.Features.CQRS.Commands.MovieOperations
{
    public class CreateMovieCommand : IRequest<MovieViewModel>
    {
        public string MovieName { get; set; }
        public DateTime MovieYear { get; set; }
        public Genre MovieGenre { get; set; }
        public decimal MoviePrice { get; set; }
        public ICollection<int> ActorIds { get; set; }
        public int DirectorId { get; set; }
    }


}
