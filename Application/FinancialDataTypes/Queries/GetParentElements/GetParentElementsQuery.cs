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

namespace Application.FinancialDataTypes.Queries.GetParentElements
{
    public record GetParentElementsQuery(ElementParameter param): IQuery<List<FinancialDataTypeDto>>;
    public class GetParentElementsQueryHandler : IQueryHandler<GetParentElementsQuery, List<FinancialDataTypeDto>>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetParentElementsQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result<List<FinancialDataTypeDto>>> Handle(GetParentElementsQuery request, CancellationToken cancellationToken)
        {
       


            GetParentElementsQuerySpecification spec = new GetParentElementsQuerySpecification(request.param);

            List<FinancialDataType> financialDataTypeFromDb = _uow.FinancialDataTypesRepository.GetAllBySpecAsync(spec).Result.Data;

            if (financialDataTypeFromDb == null) {
                Result.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }

            List<FinancialDataTypeDto> financialDataTypeDtos = _mapper.Map <List< FinancialDataTypeDto>>(financialDataTypeFromDb);

            return Result.Success(financialDataTypeDtos);



        }
    }


    public class GetParentElementsQuerySpecification : Specification<FinancialDataType> {

        public GetParentElementsQuerySpecification(ElementParameter param)
        {

            if (param.FinancialDataTypesId.HasValue)
            {
                AddCriteries(x => x.ParentFinancialDataTypeId == param.FinancialDataTypesId);
            }
            else {
                AddCriteries(x => x.ParentFinancialDataTypeId.HasValue == false);

            }

            if(!string.IsNullOrEmpty( param.Name))
            AddCriteries(x => x.Name.Contains( param.Name));
            if (param.ReservationDate.HasValue)
            {

                AddCriteries(x => x.ReservationDate <=param.ReservationDate);

            }

        }


    }

    public class ElementParameter{
        public int? FinancialDataTypesId { get; set; }
        public string? Name { get; set; }
        public DateTime? ReservationDate { get; set; }
       
    }
}
