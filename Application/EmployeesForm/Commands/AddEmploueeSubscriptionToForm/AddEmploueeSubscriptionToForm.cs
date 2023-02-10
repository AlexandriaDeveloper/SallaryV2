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
            var periodicSubscriptions = await _uow.PeriodicSubscriptionRepository.GetAllByExpressionAsync(x => x.FormId == request.FormId && x.CreditOrDebit == 'd');




            foreach (var subscription in request.subscriptions)
            {
                if (subscription.Checked)
                {
                    if (!periodicSubscriptions.Any(x => x.SubscriptionId == subscription.SubscriptionId))
                    {

                        //get all subscripers 
                        List<EmployeeSubscription> employeeSubscriptions = await _uow.EmployeeSubscriptionRepository
                            .GetAllByExpressionAsync(x => x.SubscriptionId == subscription.SubscriptionId && x.IsActive);


                        foreach (var employeeSubscription in employeeSubscriptions)
                        {
                            if (_uow.EmployeeFormRepository.CheckByExpressionAsync(x => x.EmployeeId == employeeSubscription.EmployeeId && x.FormId == request.FormId))
                            {

                                //var emp = await _uow.EmployeeFormRepository.GetByExpressionAsync(x => x.EmployeeId == employeeSubscription.EmployeeId);
                                // if (emp != null)
                                //   {
                                await _uow.PeriodicSubscriptionRepository.AddItem(new PeriodicSubscription()
                                {
                                    EmployeeId = employeeSubscription.EmployeeId,
                                    FormId = request.FormId,
                                    Amount = employeeSubscription.Amount,
                                    CreditOrDebit = 'd',
                                    SubscriptionId = subscription.SubscriptionId.Value

                                });
                                //     }
                            }

                        }
                        // await _uow.SaveChangesAsync(cancellationToken);
                    }
                }
                else
                {
                    if (periodicSubscriptions.Any(x => x.SubscriptionId == subscription.SubscriptionId))
                    {

                        foreach (var periodicSubscription1 in periodicSubscriptions.Where(x => x.SubscriptionId == subscription.SubscriptionId))
                        {
                            await _uow.PeriodicSubscriptionRepository.HardDelete(periodicSubscription1.Id);
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


}
