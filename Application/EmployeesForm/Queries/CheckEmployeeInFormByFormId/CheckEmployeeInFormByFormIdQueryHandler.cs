using Application.Common.Messaging;
using AutoMapper;
using Domain.Interfaces;
using Domain.Shared;
using FluentValidation;

namespace Application.EmployeesForm.Queries.CheckEmployeeInFormByFormId
{

    public record CheckEmployeeInFormByFormIdQuery(int formId, int employeeId) : IQuery<bool>;
    public class CheckEmployeeInFormByFormIdQueryHandler : IQueryHandler<CheckEmployeeInFormByFormIdQuery, bool>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public CheckEmployeeInFormByFormIdQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result<bool>> Handle(CheckEmployeeInFormByFormIdQuery request, CancellationToken cancellationToken)
        {
            return _uow.EmployeeFormRepository.CheckByExpressionAsync(x => x.EmployeeId == request.employeeId && x.FormId == request.formId);
        }
    }

    public class CheckEmployeeInFormByFormIdQueryValidator : AbstractValidator<CheckEmployeeInFormByFormIdQuery>
    {
        public CheckEmployeeInFormByFormIdQueryValidator()
        {
            RuleFor(p => p.formId).NotEmpty().NotNull();
            RuleFor(p => p.employeeId).NotEmpty().NotNull();
        }
    }
}
