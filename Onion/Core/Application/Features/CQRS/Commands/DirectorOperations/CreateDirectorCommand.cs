using Application.DTO.DirectorModel;
using MediatR;

namespace Application.Features.CQRS.Commands.DirectorOperations
{
    public class CreateDirectorCommand : IRequest<DirectorViewModel>
    {
        public string DirectorName { get; set; }

        public string DirectorSurname { get; set; }
    }

}
