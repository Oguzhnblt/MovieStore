using Application.DTO.ActorDTOModel;
using Application.Features.CQRS.Queries.ActorQueries;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.CQRS.Handler.ActorHandler
{
    public class GetActorsQueryHandler : IRequestHandler<GetActorsQueryRequest, ICollection<ActorViewModel>>
    {

        private readonly IRepository<Actor> _repository;
        private readonly IMapper _mapper;

        public GetActorsQueryHandler(IRepository<Actor> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ICollection<ActorViewModel>> Handle(GetActorsQueryRequest request, CancellationToken cancellationToken)
        {
            var actors = await _repository.GetAllAsync();

            return _mapper.Map<ICollection<ActorViewModel>>(actors);
        }
    }
}

