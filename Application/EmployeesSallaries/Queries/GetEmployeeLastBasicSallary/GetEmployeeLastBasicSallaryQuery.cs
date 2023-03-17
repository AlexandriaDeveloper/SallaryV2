
using Application.Common.Messaging;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;

namespace Domain.EmployeesSallaries.Queries.GetEmployeeBasicSallary
{
    public record GetEmployeeLastBasicSallaryQuery(int id, DateTime? reservationDate) : IQuery<EmployeeBasicSallaryDto>;
    public class GetEmployeeBasicSallaryQueryHandler : IQueryHandler<GetEmployeeLastBasicSallaryQuery, EmployeeBasicSallaryDto>
    {
        private readonly IUOW _uow;

        public GetEmployeeBasicSallaryQueryHandler(IUOW uow)
        {
            _uow = uow;
        }

        public async Task<Result<EmployeeBasicSallaryDto>> Handle(GetEmployeeLastBasicSallaryQuery request, CancellationToken cancellationToken)
        {

            var spec = new GetEmployeeLastBasicSallarySpecification(request.id, request.reservationDate);
            var result = await _uow.EmployeeBasicFinancialDataRepository.GetAllBySpecAsync(spec);
            if (result == null)
            {

                return Result<EmployeeBasicSallaryDto>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            var itemToReturn = new EmployeeBasicSallaryDto()
            {

                Wazifi = result.Data.Where(t => t.FinancialDataTypes.ParentFinancialDataTypeId == 1000).Sum(x => x.Amount),
                Mokamel = result.Data.Where(t => t.FinancialDataTypes.ParentFinancialDataTypeId == 2000).Sum(x => x.Amount),
                Taawidi = result.Data.Where(t => t.FinancialDataTypes.ParentFinancialDataTypeId == 4000).Sum(x => x.Amount)


            };
            return Result<EmployeeBasicSallaryDto>.Success(itemToReturn);
        }
    }


    public class GetEmployeeLastBasicSallarySpecification : Specification<EmployeeBasicFinancialData>
    {

        public GetEmployeeLastBasicSallarySpecification(int employeeId, DateTime? reservationDate)
        {
            AddInclude(x => x.FinancialDataTypes);


            AddCriteries(x => x.EmployeeId == employeeId);
            AddCriteries(x => x.FinancialDataTypes.ReservationDate <= reservationDate);
        }
    }

    public class EmployeeBasicSallaryDto
    {

        public decimal? Wazifi { get; set; }
        public decimal? Mokamel { get; set; }
        public decimal? Taawidi { get; set; }
    }


}
