using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Shared;

namespace Application.Collections.Queries;

public record GetListCollectionsQuery : IQuery<IReadOnlyList<CollectionDto>>;
public class GetListCollectionsQueryHandler : IQueryHandler<GetListCollectionsQuery, IReadOnlyList<CollectionDto>>
{
    private readonly IUOW _uow;
    private readonly IMapper _mapper;

    public GetListCollectionsQueryHandler(IUOW uow, IMapper mapper)
    {
        _uow = uow;
        _mapper = mapper;
    }
    public async Task<Result<IReadOnlyList<CollectionDto>>> Handle(GetListCollectionsQuery request, CancellationToken cancellationToken)
    {
        var collectionsFromDb = await _uow.CollectionRepository.GetAllAsync();
        if (collectionsFromDb == null)
        {
            return Result.Failure<IReadOnlyList<CollectionDto>>(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
        }
        var collectionToReturn = _mapper.Map<IReadOnlyList<CollectionDto>>(collectionsFromDb);

        return Result<IReadOnlyList<CollectionDto>>.Success(collectionToReturn);
    }
}

