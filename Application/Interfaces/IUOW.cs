using Application.Interfaces.Repository;
using Domain.Enums;

namespace Domain.Interfaces
{
    public interface IUOW : IDisposable
    {
        IEmployeeRepository EmployeeRepository { get; }
        IOrderRepository OrderRepository { get; }
      //  IEmployeeOrderTypeRepository EmployeeOrderTypeRepository { get; }
        IFormEmployeeOrderRepository FormEmployeeOrderRepository { get; }
        IFormEmployeeOrderExecuationRepository EmployeeOrderExecuationRepository { get; }
        IBudgetItemRepository BudgetItemRepository { get; }
        IEmployeeGradeRepository EmployeeGradeRepository { get; }
        IEmployeeBasicFinancialDataRepository EmployeeBasicFinancialDataRepository { get; }
        IFinancialDataTypesRepository FinancialDataTypesRepository { get; }
        IGradeRepository GradeRepository { get; }
        IFormEmployeeRepository FormEmployeeRepository { get; }
        IFormEmployeeOrderExecutionRepository FormEmployeeOrderExecutionRepository { get; }
        IBankRepository BankRepository { get; }
        IBranchRepository BranchRepository { get; }
        IEmployeeBankAccountRepository EmployeeBankRepository { get; }
        IEmployeeSubscriptionRepository EmployeeSubscriptionRepository { get; }
        ISubscriptionRepository SubscriptionRepository { get; }
        IFormRepository FormRepository { get; }
        IFormEmployeeSubscriptionRepository FormEmployeeSubscriptionRepository { get; }
        ICollectionRepository CollectionRepository { get; }
        IEmployeeCollectionsRepository EmployeeCollectionsRepository { get; }
        IVacationTypeRepository VacationTypeRepository { get; }
        IFormEmployeeVacationTypeRepository FormEmployeeVacationTypeRepository { get; }
        Task<SaveState> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
