using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Shared;

namespace Application.Collections.Queries
{


    public record GetCollectionByIdQuery(int id) : IQuery<CollectionDto>;
    public class GetCollectionByIdQueryHandler : IQueryHandler<GetCollectionByIdQuery, CollectionDto>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetCollectionByIdQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result<CollectionDto>> Handle(GetCollectionByIdQuery request, CancellationToken cancellationToken)
        {
            var collectionsFromDb = await _uow.CollectionRepository.GetByIdAsync(request.id);
            if (collectionsFromDb == null)
            {
                return Result.Failure<CollectionDto>(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            var collectionToReturn = _mapper.Map<CollectionDto>(collectionsFromDb);

            return Result<CollectionDto>.Success(collectionToReturn);
        }
    }

}
