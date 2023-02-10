using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;

namespace Application.EmployeePartTimes.Queries.GetPartTimeByEmployeeId
{
    public record GetPartTimeByEmployeeIdQuery(int employeeId) : IQuery<EmployeePartTimeDto>;
    public class GetPartTimeByEmployeeIdQueryHandler : IQueryHandler<GetPartTimeByEmployeeIdQuery, EmployeePartTimeDto>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetPartTimeByEmployeeIdQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result<EmployeePartTimeDto>> Handle(GetPartTimeByEmployeeIdQuery request, CancellationToken cancellationToken)
        {
            EmployeePartTime employeePartTime = await _uow.EmployeePartTimeRepository.GetCurrentEmployeeInPartTimeByEmployeeId(request.employeeId);

            if (employeePartTime == null)
            {
                return Result<EmployeePartTimeDto>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }

            EmployeePartTimeDto employeePartTimeDtoToReturn = _mapper.Map<EmployeePartTimeDto>(employeePartTime);

            return Result<EmployeePartTimeDto>.Success(employeePartTimeDtoToReturn);
        }
    }
}
