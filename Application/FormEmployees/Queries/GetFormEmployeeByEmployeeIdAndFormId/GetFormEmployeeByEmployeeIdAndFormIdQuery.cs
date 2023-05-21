using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.FormEmployee.Queries.GetFormEmployeeByEmployeeIdAndFormId
{
    public record GetFormEmployeeByEmployeeIdAndFormIdQuery (FormEmployeeQueryParam param):IQuery<FormEmployeeDto>;
    public class GetFormEmployeeByEmployeeIdAndFormIdQueryHandler : IQueryHandler<GetFormEmployeeByEmployeeIdAndFormIdQuery, FormEmployeeDto>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetFormEmployeeByEmployeeIdAndFormIdQueryHandler(IUOW uow , IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result<FormEmployeeDto>> Handle(GetFormEmployeeByEmployeeIdAndFormIdQuery request, CancellationToken cancellationToken)
        {
            Domain.Models.FormEmployee formEmployee =await _uow.FormEmployeeRepository
                .GetByFormIdAndEmployeeId(request.param.FormId.Value, request.param.EmployeeId.Value);


            if (formEmployee == null) {
                return Result.Failure< FormEmployeeDto>(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }

            FormEmployeeDto formEmployeeToReturn = _mapper.Map<FormEmployeeDto>(formEmployee);

            return Result.Success(formEmployeeToReturn);    
        }
    }



    public class FormEmployeeDto {

        public int? Id { get; set; }
        public int EmployeeId { get; set; }
        public int FormId { get; set; }
        public int EmployeeOrderNumber { get; set; }
    }
}
