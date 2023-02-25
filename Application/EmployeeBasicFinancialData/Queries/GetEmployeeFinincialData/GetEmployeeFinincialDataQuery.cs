using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmployeeBasicFinancialsDatas.Queries.GetEmployeeFinincialData
{

    public record GetEmployeeFinincialDataQuery (int employeeId,DateTime? dateOfElements ):IQuery<EmployeeFinicialDataDto>;
    public class GetEmployeeFinincialDataQueryHandler : IQueryHandler<GetEmployeeFinincialDataQuery,EmployeeFinicialDataDto>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetEmployeeFinincialDataQueryHandler( IUOW uow , IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<Result<EmployeeFinicialDataDto>> Handle(GetEmployeeFinincialDataQuery request, CancellationToken cancellationToken)
        {
            DateTime searchByDate= DateTime.Now;


            if (request.dateOfElements.HasValue)
                searchByDate = request.dateOfElements.Value;


            Domain.Models.FinancialDataType fType = await _uow.FinancialDataTypesRepository.GetByNameAsync(Constant.FinincialData.WAZIFI);
            if (fType == null)
            {

                return Result<EmployeeFinicialDataDto>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }


           GetEmployeeFinincialDataQuerySpecification spec = new GetEmployeeFinincialDataQuerySpecification(request.employeeId, fType.Id, request.dateOfElements);


            var Wazifi = await _uow.EmployeeBasicFinancialDataRepository.GetAllBySpecAsync(spec);
            decimal WazifiAmount =Wazifi.Data.Sum(x => x.Amount);



            Domain.Models.FinancialDataType fType2 = await _uow.FinancialDataTypesRepository.GetByNameAsync(Constant.FinincialData.MOKAMEL);
            GetEmployeeFinincialDataQuerySpecification spec2 = new GetEmployeeFinincialDataQuerySpecification(request.employeeId, fType2.Id, request.dateOfElements);
            var mokamle = await _uow.EmployeeBasicFinancialDataRepository.GetAllBySpecAsync(spec2);
           



            Domain.Models.FinancialDataType fType3 = await _uow.FinancialDataTypesRepository.GetByNameAsync("حافز تعويضى");
            GetEmployeeFinincialDataQuerySpecification spec3 = new GetEmployeeFinincialDataQuerySpecification(request.employeeId, fType3.Id, request.dateOfElements);
            var tawidi = await _uow.EmployeeBasicFinancialDataRepository.GetAllBySpecAsync(spec3);


            return Result<EmployeeFinicialDataDto>.Success(new EmployeeFinicialDataDto() { Wazifi = WazifiAmount, Mokamel=mokamle.Data.Sum(x => x.Amount) ,Tawidi=tawidi.Data.Sum(x=> x.Amount)});

        }
    }

    public class GetEmployeeFinincialDataQuerySpecification : Specification< EmployeeBasicFinancialData> {

        public GetEmployeeFinincialDataQuerySpecification(int employeeId,int FinicialDataTypeId,DateTime? dateElement)
        {
            AddInclude(x => x.FinancialDataTypes);
            AddCriteries(x => x.EmployeeId == employeeId);
            AddCriteries(x => x.FinancialDataTypes.ParentFinancialDataTypeId == FinicialDataTypeId);

            if (dateElement.HasValue) {
                AddCriteries(x => x.FinancialDataTypes.ReservationDate <= dateElement.Value);

            }
        }
    }

    public class EmployeeFinicialDataDto {

        public decimal Wazifi { get; set; }
        public decimal Mokamel { get; set; }
        public decimal Tawidi { get; set; }

    }
}
/*
3	213	5	246.00	Admin	2023-01-01 00:00:00.0000000	NULL	NULL	NULL	NULL
4	213	6	246.00	Admin	2023-01-01 00:00:00.0000000	NULL	NULL	NULL	NULL
5	213	7	340.00	Admin	2023-01-01 00:00:00.0000000	NULL	NULL	NULL	NULL
6	213	8	28.80	Admin	2023-01-01 00:00:00.0000000	NULL	NULL	NULL	NULL
7	213	28	20.00	Admin	2023-01-01 00:00:00.0000000	NULL	NULL	NULL	NULL
*/