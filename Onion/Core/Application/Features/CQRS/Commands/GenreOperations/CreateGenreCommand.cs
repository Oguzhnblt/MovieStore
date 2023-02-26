using Application.DTO.GenreModel;
using MediatR;

namespace Application.Features.CQRS.Commands.GenreOperations
{
    public class CreateGenreCommand : IRequest<GenreViewModel>
    {
        public string GenreName { get; set; }
        public string Description { get; set; }
    }
}
