using Application.Common.Messaging;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;

namespace Domain.EmployeesSallaries.Queries.GetEmployeeBasicSallary
{
    public record GetEmployeeLastBasicSallaryQuery(int id) : IQuery<EmployeeBasicSallary>;
    public class GetEmployeeBasicSallaryQueryHandler : IQueryHandler<GetEmployeeLastBasicSallaryQuery, EmployeeBasicSallary>
    {
        private readonly IUOW _uow;

        public GetEmployeeBasicSallaryQueryHandler(IUOW uow)
        {
            _uow = uow;
        }

        public async Task<Result<EmployeeBasicSallary>> Handle(GetEmployeeLastBasicSallaryQuery request, CancellationToken cancellationToken)
        {



            var result = await _uow.EmployeeBasicSallaryRepository.GetLastEmployeeBasicSallaryAsync(request.id);
            if (result == null)
            {

                return Result<EmployeeBasicSallary>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }

            return Result<EmployeeBasicSallary>.Success(result);
        }
    }


}
