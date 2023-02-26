using Application.DTO.DirectorModel;
using MediatR;

namespace Application.Features.CQRS.Commands.DirectorOperations
{
    public class UpdateDirectorCommand : IRequest<DirectorViewModel>
    {
        public int DirectorID { get; set; }
        public string DirectorName { get; set; }
        public string DirectorSurname { get; set; }
    }
}
