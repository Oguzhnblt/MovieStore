using System;
using Application.DTO.ActorDTOModel;
using MediatR;

namespace Application.Features.CQRS.Queries.ActorQueries
{
    public class GetActorQueryRequest : IRequest<ActorDTO>
    {
        public int ID { get; set; }

        public GetActorQueryRequest(int id)
        {
            ID = id;
        }
    }
}

