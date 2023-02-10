using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;

namespace Application.EmployeePartTimes.Queries.GetAllPartTimesByEmployeeId
{
    public record GetEmployeePartTimeHistoryQuery(int employeeId) : IQuery<List<EmployeePartTimeDto>>;
    public class GetEmployeePartTimeHistoryQueryHandler : IQueryHandler<GetEmployeePartTimeHistoryQuery, List<EmployeePartTimeDto>>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetEmployeePartTimeHistoryQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<Result<List<EmployeePartTimeDto>>> Handle(GetEmployeePartTimeHistoryQuery request, CancellationToken cancellationToken)
        {
            List<EmployeePartTime> employeePartTimeHistory = await _uow.EmployeePartTimeRepository.GetAllByExpressionAsync(x => x.EmployeeId == request.employeeId);

            if (employeePartTimeHistory == null)
            {
                return Result<List<EmployeePartTimeDto>>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }

            List<EmployeePartTimeDto> employeePartTimeDtos = _mapper.Map<List<EmployeePartTimeDto>>(employeePartTimeHistory);

            return Result.Success(employeePartTimeDtos);
        }
    }
}
