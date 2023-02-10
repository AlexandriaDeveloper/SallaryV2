namespace Application.OrderFiles.Queries;
//public record GetOrderFileByIdQuery(int orderFileId):IQuery<OrderFileDto>;
//public class GetOrderFileByIdQueryHandler : IQueryHandler<GetOrderFileByIdQuery, OrderFileDto>

//{
//    private readonly IUOW _uow;
//    private readonly IMapper _mapper;

//    public GetOrderFileByIdQueryHandler(IUOW uow, IMapper mapper)
//    {
//        _uow = uow;
//        _mapper = mapper;
//    }
//    public async Task<Result<OrderFileDto>> Handle(GetOrderFileByIdQuery request, CancellationToken cancellationToken)
//    {
//      OrderFile OrderFileFromDb = await _uow.OrderFileRepository.GetByIdAsync(request.orderFileId);

//        if(OrderFileFromDb== null) {
//            return  Result<OrderFileDto>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
//        }

//       OrderFileDto resultToReturn = _mapper.Map< OrderFileDto>(OrderFileFromDb);

//        return  Result<List<OrderFileDto>>.Success(resultToReturn);
//    }
//}

