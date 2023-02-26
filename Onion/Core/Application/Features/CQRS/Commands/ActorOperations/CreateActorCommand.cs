using Application.DTO.ActorDTOModel;
using MediatR;

namespace Application.Features.CQRS.Commands.ActorOperations
{
    public class CreateActorCommand : IRequest<ActorViewModel>
    {
        public string ActorName { get; set; }
        public string ActorSurname { get; set; }
    }
}
