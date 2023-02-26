using Application.DTO.ActorDTOModel;
using MediatR;

namespace Application.Features.CQRS.Queries.ActorQueries
{
    public class GetActorsQueryRequest : IRequest<ICollection<ActorViewModel>>
    {

    }
}

