using Application.DTO.MovieModel;
using Domain.Entities;
using MediatR;

namespace Application.Features.CQRS.Commands.MovieOperations
{
    public class UpdateMovieCommand : IRequest<MovieViewModel>
    {
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public DateTime MovieYear { get; set; }
        public Genre MovieGenre { get; set; }
        public decimal MoviePrice { get; set; }
        public ICollection<int> ActorIds { get; set; }
        public int DirectorId { get; set; }
    }

}
