namespace Application.OrderFiles.Queries;
//public record GetAllOrderFilesQuery : IQuery<List<OrderFileDto>>;
//public class GetAllOrderFilesQueryHandler : IQueryHandler<GetAllOrderFilesQuery, List<OrderFileDto>>

//{
//    private readonly IUOW _uow;
//    private readonly IMapper _mapper;

//    public GetAllOrderFilesQueryHandler(IUOW uow, IMapper mapper)
//    {
//        _uow = uow;
//        _mapper = mapper;
//    }
//    public async Task<Result<List<OrderFileDto>>> Handle(GetAllOrderFilesQuery request, CancellationToken cancellationToken)
//    {
//      IReadOnlyList<OrderFile> OrderFileFromDb = await _uow.OrderFileRepository.GetAllAsync();

//        if(OrderFileFromDb== null) {
//            return  Result<List<OrderFileDto>>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
//        }

//       List<OrderFileDto> resultToReturn = _mapper.Map<List< OrderFileDto>>(OrderFileFromDb);

//        return  Result<List<OrderFileDto>>.Success(resultToReturn);
//    }
//}

