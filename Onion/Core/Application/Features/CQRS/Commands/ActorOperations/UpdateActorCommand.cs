using Application.DTO.ActorDTOModel;
using MediatR;

namespace Application.Features.CQRS.Commands.ActorOperations
{
    public class UpdateActorModel : IRequest<ActorViewModel>
    {
        public int ActorID { get; set; }

        public string ActorName { get; set; }

        public string ActorSurname { get; set; }
    }
}
