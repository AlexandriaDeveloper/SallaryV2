using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;

namespace Application.PeriodicSubscriptions.Queries.GetEmployeesSubscriptionByFormId
{
    public record GetEmployeesSubscriptionByFormIdQuery(int formId, int subscriptionId) : IQuery<EmployeeSubscriptionForm>;
    public class GetEmployeesSubscriptionByFormIdQueryHandler : IQueryHandler<GetEmployeesSubscriptionByFormIdQuery, EmployeeSubscriptionForm>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetEmployeesSubscriptionByFormIdQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result<EmployeeSubscriptionForm>> Handle(GetEmployeesSubscriptionByFormIdQuery request, CancellationToken cancellationToken)
        {
            Subscription subscription = await _uow.SubscriptionRepository.GetByIdAsync(request.subscriptionId);
            if (subscription == null)
            {
                return Result<EmployeeSubscriptionForm>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            Domain.Models.Form form = await _uow.FormRepository.GetByIdAsync(request.formId);
            if (subscription == null)
            {
                return Result<EmployeeSubscriptionForm>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }

            EmployeeSubscriptionForm employeesSubscription = new EmployeeSubscriptionForm();
            employeesSubscription.SubscriptionName = subscription.Name;
            employeesSubscription.FormName = form.Details;


            employeesSubscription.Data = new List<EmployeeSubscriptionForm.EmployeeSubscriptionDataForm>();
            var periodicSubscriptions = await _uow.PeriodicSubscriptionRepository.GetAllBySpecAsync(new GetEmployeesSubscriptionByFormIdQuerySpecification(request.formId, request.subscriptionId));
            foreach (var periodicSubscription in periodicSubscriptions.Data)
            {
                employeesSubscription.Data.Add(new EmployeeSubscriptionForm.EmployeeSubscriptionDataForm()
                {

                    EmployeeName = periodicSubscription.Employee.Name,
                    Amount = periodicSubscription.Amount,
                    EmployeeTabCode = periodicSubscription.Employee.TabCode,
                    CredirOrDebit = periodicSubscription.CreditOrDebit,
                    EmployeeTegaraCode = periodicSubscription.Employee.TegaraCode,
                    Id = periodicSubscription.Id

                });
            }


            return Result<EmployeeSubscriptionForm>.Success(employeesSubscription);

        }
    }
}
public class GetEmployeesSubscriptionByFormIdQuerySpecification : Specification<Domain.Models.PeriodicSubscription>
{

    public GetEmployeesSubscriptionByFormIdQuerySpecification(int formId, int subscriptionId)
    {
        AddCriteries(x => x.FormId == formId);
        AddCriteries(x => x.SubscriptionId == subscriptionId);
        AddInclude(x => x.Employee);
        AddOrderBy(x => x.Employee.TegaraCode);

    }
}
public class EmployeeSubscriptionForm
{

    public string SubscriptionName { get; set; }
    public string FormName { get; set; }
    public List<EmployeeSubscriptionDataForm> Data { get; set; }
    public decimal TotalDebit { get => this.Data.Where(t => t.CredirOrDebit == 'd').Sum(t => t.Amount); }
    public decimal TotalCredit { get => this.Data.Where(t => t.CredirOrDebit == 'c').Sum(t => t.Amount); }
    public decimal Net { get => this.TotalCredit - this.TotalDebit; }
    public class EmployeeSubscriptionDataForm
    {

        public int? Id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeTabCode { get; set; }
        public string EmployeeTegaraCode { get; set; }
        public decimal Amount { get; set; }
        public char CredirOrDebit { get; set; }


    }
}