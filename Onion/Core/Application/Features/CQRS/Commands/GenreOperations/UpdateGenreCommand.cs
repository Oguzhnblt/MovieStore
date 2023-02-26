using Application.DTO.GenreModel;
using MediatR;

namespace Application.Features.CQRS.Commands.GenreOperations
{
    public class UpdateGenreCommand : IRequest<GenreViewModel>
    {
        public int GenreID { get; set; }
        public string GenreName { get; set; }
        public string Description { get; set; }
    }
}
