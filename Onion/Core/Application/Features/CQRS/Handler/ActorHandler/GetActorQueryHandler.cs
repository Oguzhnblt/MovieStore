using Application.DTO.ActorDTOModel;
using Application.Features.CQRS.Queries.ActorQueries;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.CQRS.Handler.ActorHandler
{
    public class GetActorQueryHandler : IRequestHandler<GetActorQueryRequest, ActorDTO>
    {
        private readonly IRepository<Actor> _repository;
        private readonly IMapper _mapper;

        public GetActorQueryHandler(IRepository<Actor> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ActorDTO> Handle(GetActorQueryRequest request, CancellationToken cancellationToken)
        {
            var actor = await _repository.GetByFilterAsync(x => x.ActorID == request.ID);

            return _mapper.Map<ActorDTO>(actor);
        }
    }
}

