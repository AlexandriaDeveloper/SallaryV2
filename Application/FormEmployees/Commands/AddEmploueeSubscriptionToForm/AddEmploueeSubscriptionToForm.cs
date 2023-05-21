using Application.Common.Messaging;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;

namespace Application.EmployeesForm.Commands.AddEmploueeSubscriptionToForm
{
    public record AddEmployeeSubscriptionToFormCommand(int FormId, List<GetCheckedSubscriptionByFormIdDto> subscriptions) : ICommand;

    public class AddEmployeeSubscriptionToFormCommandHandler : ICommandHandler<AddEmployeeSubscriptionToFormCommand>
    {
        private readonly IUOW _uow;

        public AddEmployeeSubscriptionToFormCommandHandler(IUOW uow)
        {
            _uow = uow;
        }
        public async Task<Result> Handle(AddEmployeeSubscriptionToFormCommand request, CancellationToken cancellationToken)
        {
            AddEmployeeSubscriptionToFormCommandSpecification spec = new AddEmployeeSubscriptionToFormCommandSpecification(request.FormId);
            var periodicSubscriptions = await _uow.FormEmployeeSubscriptionRepository.GetAllBySpecAsync(spec);




            foreach (var subscription in request.subscriptions)
            {
                if (subscription.Checked)
                {
                    if (!periodicSubscriptions.Data.Any(x => x.SubscriptionId == subscription.SubscriptionId))
                    {

                        //get all subscripers 
               
                        List<RegisterdEmployeeSubscription> employeeSubscriptions = await _uow.EmployeeSubscriptionRepository
                            .GetAllByExpressionAsync(x => x.SubscriptionId == subscription.SubscriptionId && x.IsActive);


                        foreach (var employeeSubscription in employeeSubscriptions)
                        {
                            if (_uow.FormEmployeeRepository.CheckByExpressionAsync(x => x.EmployeeId == employeeSubscription.EmployeeId && x.FormId == request.FormId))
                            {
                                await _uow.FormEmployeeSubscriptionRepository.AddItem(new FormEmployeeSubscription()
                                {
                                    FormEmployeeId = _uow.FormEmployeeRepository.GetByExpressionAsync(x => x.FormId==request.FormId && x.EmployeeId== employeeSubscription.EmployeeId).Result.Id,
                                    Amount = employeeSubscription.Amount,
                                    CreditOrDebit = 'd',
                                    SubscriptionId = subscription.SubscriptionId.Value
                                });
                            }
                        }
                    }
                }
                else
                {
                    if (periodicSubscriptions.Data.Any(x => x.SubscriptionId == subscription.SubscriptionId))
                    {

                        foreach (var periodicSubscription1 in periodicSubscriptions.Data.Where(x => x.SubscriptionId == subscription.SubscriptionId))
                        {
                            await _uow.FormEmployeeSubscriptionRepository.HardDelete(periodicSubscription1.Id);
                        }
                        // await _uow.SaveChangesAsync(cancellationToken);
                    }
                }
            }
            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != Domain.Enums.SaveState.Saved)
            {

                return Result.Failure(result);
            }

            return Result.Success();
        }
    }
    public class AddEmployeeSubscriptionToFormCommandSpecification : Specification<FormEmployeeSubscription>{
        public AddEmployeeSubscriptionToFormCommandSpecification(int formId)
        {
            AddInclude(x => x.FormEmployee);
            AddInclude(x => x.FormEmployee.Form);

            AddCriteries(x => x.CreditOrDebit == 'd');
            AddCriteries(x => x.FormEmployee.FormId == formId);
        }
    
    }

}
