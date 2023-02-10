namespace Application.OrderFiles.Queries;
//public record GetPaginatedOrderFilesQuery (GetPaginatedOrderFilesQueryParam param) : IQuery<PagedList<OrderFileDto>>;
//    public class GetPaginatedOrderFilesQueryHandler : IQueryHandler<GetPaginatedOrderFilesQuery, PagedList<OrderFileDto>>

//    {
//        private readonly IUOW _uow;
//        private readonly IMapper _mapper;

//        public GetPaginatedOrderFilesQueryHandler(IUOW uow, IMapper mapper)
//        {
//            _uow = uow;
//            _mapper = mapper;
//        }
//        public async Task<Result<PagedList<OrderFileDto>>> Handle(GetPaginatedOrderFilesQuery request, CancellationToken cancellationToken)
//        {


//          PagedList<OrderFile> OrderFileFromDb = await _uow.OrderFileRepository.GetAllBySpecAsync(new GetPaginatedOrderFilesQuerySpecification(request.param));

//            if(OrderFileFromDb== null) {
//                return  Result<PagedList<OrderFileDto>>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
//            }

//        PagedList<OrderFileDto> resultToReturn = _mapper.Map<PagedList< OrderFileDto>>(OrderFileFromDb);

//            return  Result<PagedList<OrderFileDto>>.Success(resultToReturn);
//        }
//    }

