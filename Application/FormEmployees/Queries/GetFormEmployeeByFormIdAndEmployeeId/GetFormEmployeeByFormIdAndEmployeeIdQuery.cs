using Application.Common.Messaging;
using Application.EmployeesForm.Queries.GetEmployeeByFormId;
using Application.Form;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Shared;
using static Application.EmployeesForm.Queries.GetEmployeeByFormId.GetEmployeeByFormIdQuerySpec;

namespace Application.FormEmployees.Queries.NewFolder
{
    public record GetFormEmployeeByFormIdAndEmployeeIdQuery(GetEmployeeByFormIdQueryParam param) : IQuery<FormEmployeeDto>;
    public class GetFormEmployeeByFormIdAndEmployeeIdQueryHandler : IQueryHandler<GetFormEmployeeByFormIdAndEmployeeIdQuery, FormEmployeeDto>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetFormEmployeeByFormIdAndEmployeeIdQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result<FormEmployeeDto>> Handle(GetFormEmployeeByFormIdAndEmployeeIdQuery request, CancellationToken cancellationToken)
        {
            request.param.pageIndex= 0;
            var spec = new GetEmployeeByFormIdQuerySpec(request.param);
        
            Domain.Models.FormEmployee emps =  _uow.FormEmployeeRepository.GetAllBySpecAsync(spec).Result.Data.FirstOrDefault();
            if (emps == null)
            {
                return Result<FormEmployeeDto>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            var empToReturn = _mapper.Map<FormEmployeeDto>(emps);
            return Result<FormEmployeeDto>.Success(empToReturn);
        }

     
    }





}
