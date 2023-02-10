using Application.Common.Messaging;
using AutoMapper;
using Domain.Interfaces;
using Domain.Shared;

namespace Application.EmployeeCollections.Queries.GetEmployeeListCollection
{
    public record GetEmployeeListCollectionQuery(int collectionId) : IQuery<IReadOnlyList<EmployeeCollectionListDto>>;
    public class GetEmployeeListCollectionQueryHandler : IQueryHandler<GetEmployeeListCollectionQuery, IReadOnlyList<EmployeeCollectionListDto>>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetEmployeeListCollectionQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result<IReadOnlyList<EmployeeCollectionListDto>>> Handle(GetEmployeeListCollectionQuery request, CancellationToken cancellationToken)
        {
            var spec = new GetEmployeeListCollectionQuerySpecification(request.collectionId);
            var empCollectionFromDb = await _uow.EmployeeCollectionsRepository.GetAllBySpecAsync(spec);
            var empToReturn = _mapper.Map<IReadOnlyList<EmployeeCollectionListDto>>(empCollectionFromDb.Data);
            return Result<IReadOnlyList<EmployeeCollectionListDto>>.Success(empToReturn);
        }
    }



}
