using Application.Common.Messaging;
using Application.EmployeesForm.Queries.GetEmployeeByFormId;
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

namespace Application.JobRunners.Command.ExecuteJobRunner
{
    public record ExecuteJobRunnerCommand (int formId):ICommand;

    public class ExecuteJobRunnerCommandHandler : ICommandHandler<ExecuteJobRunnerCommand>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;
        private readonly IAuthService _authService;

        public ExecuteJobRunnerCommandHandler(IUOW uow , IMapper mapper,IAuthService authService)
        {
            _uow = uow;
            _mapper = mapper;
            _authService = authService;
        }

        public async Task<Result> Handle(ExecuteJobRunnerCommand request, CancellationToken cancellationToken)
        {

            GetEmployeeByFormIdQuerySpec spec = new GetEmployeeByFormIdQuerySpec(new GetEmployeeByFormIdQuerySpec.GetEmployeeByFormIdQueryParam() {FormId = request.formId });
            Domain.Models.FormEmployee empForm =await _uow.FormEmployeeRepository.GetBySingleOrDefaultAsync(spec);
            if(empForm == null)
            {
                return Result.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
          //  PagedList<FormEmployeeOrder> employeeOrderTypes = 
           //     await _uow.EmployeeOrderTypeRepository.GetAllBySpecAsync(new FormEmployeeOrderCommandSpecification(request.formId));
            //empForm..EmployeeOrderTypes = employeeOrderTypes.Data;
            //empForm.e


            return Result.Success();
        }
    }


    public class ExecuteJobRunnerCommandSpecification : Specification<Domain.Models.Form> {
        public ExecuteJobRunnerCommandSpecification()
        {
            //AddInclude(x => x.EmployeeOrderTypes);
            //AddInclude(x => x.);
        }
    }
    public class FormEmployeeOrderCommandSpecification : Specification<Domain.Models.FormEmployeeOrder> {

        public FormEmployeeOrderCommandSpecification(int formId)
        {
            AddInclude(x => x.FormEmployee);
            AddInclude(x => x.FormEmployee.Employee);
            AddInclude(x => x.FormEmployee.Form);
            AddInclude(x => x.FormEmployeeOrderExecuations);
            AddCriteries(x => x.FormEmployee.FormId.Equals(formId));
        }
    }
}
