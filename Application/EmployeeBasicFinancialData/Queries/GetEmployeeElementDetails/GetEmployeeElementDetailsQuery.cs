using Application.Common.Messaging;
using AutoMapper;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;

namespace Application.EmployeeBasicFinancialDatas.Queries.GetEmployeeElementDetails
{

    public record GetEmployeeElementDetailsQuery(int employeeId, int finicialDataTypeId, DateTime reservationDate) : IQuery<EmployeeFinicialElementDto>;
    public class GetEmployeeElementDetailsQueryHandler : IQueryHandler<GetEmployeeElementDetailsQuery, EmployeeFinicialElementDto>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetEmployeeElementDetailsQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result<EmployeeFinicialElementDto>> Handle(GetEmployeeElementDetailsQuery request, CancellationToken cancellationToken)
        {
            GetEmployeeElementDetailsQuerySpecification spec = new GetEmployeeElementDetailsQuerySpecification(request.employeeId, request.finicialDataTypeId, request.reservationDate);
            var empFinicialFromDb = await _uow.EmployeeBasicFinancialDataRepository.GetAllBySpecAsync(spec);

            EmployeeFinicialElementDto result = new EmployeeFinicialElementDto();
            foreach (var item in empFinicialFromDb.Data)
            {
                result.EmployeeFinicialElementDataDto.Add(new EmployeeFinicialElementDataDto()
                {
                    Id = item.Id,
                    Amount = item.Amount,
                    Name = item.FinancialDataTypes.Name,
                    ReservationDate = item.FinancialDataTypes.ReservationDate

                });
            }


            return Result.Success(result);
        }
    }

    public class GetEmployeeElementDetailsQuerySpecification : Specification<EmployeeBasicFinancialData>
    {


        public GetEmployeeElementDetailsQuerySpecification(int employeeId, int finicialDataTypeId, DateTime reservationDate)
        {
            AddInclude(x => x.FinancialDataTypes);


            AddCriteries(x => x.FinancialDataTypes.ParentFinancialDataTypeId == finicialDataTypeId);
            AddCriteries(x => x.EmployeeId == employeeId);
            AddCriteries(x => x.FinancialDataTypes.ReservationDate <= reservationDate);
        }
    }


    public class EmployeeFinicialElementDto
    {

        public decimal Total { get => EmployeeFinicialElementDataDto.Sum(t => t.Amount); }

        public List<EmployeeFinicialElementDataDto> EmployeeFinicialElementDataDto { get; set; }

        public EmployeeFinicialElementDto()
        {
            EmployeeFinicialElementDataDto = new List<EmployeeFinicialElementDataDto>();
        }
    }

    public class EmployeeFinicialElementDataDto
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Amount { get; set; }

        public DateTime ReservationDate { get; set; }
    }
}
