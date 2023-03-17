﻿using Application.Interfaces.Repository;
using Domain.Enums;

namespace Domain.Interfaces
{
    public interface IUOW : IDisposable
    {
        IEmployeeRepository EmployeeRepository { get; }
      //  IEmployeeBasicSallaryRepository EmployeeBasicSallaryRepository { get; }

        IOrderRepository OrderRepository { get; }

        IEmployeeOrderRepository EmployeeOrderRepository { get; }
        IEmployeeOrderExecuationRepository EmployeeOrderExecuationRepository { get; }

        IBudgetItemRepository BudgetItemRepository { get; }

        IEmployeeGradeRepository EmployeeGradeRepository { get; }

        IEmployeeBasicFinancialDataRepository EmployeeBasicFinancialDataRepository { get; }
        IFinancialDataTypesRepository FinancialDataTypesRepository { get; }
        IGradeRepository GradeRepository { get; }
        IEmployeeFormRepository EmployeeFormRepository { get; }
        IBankRepository BankRepository { get; }
        IBranchRepository BranchRepository { get; }
        //  IFinancialYearRepository FinancialYearRepository { get; }
        IEmployeeBankRepository EmployeeBankRepository { get; }
        IEmployeeSubscriptionRepository EmployeeSubscriptionRepository { get; }
        ISubscriptionRepository SubscriptionRepository { get; }

        IFormRepository FormRepository { get; }
        IPeriodicSubscriptionRepository PeriodicSubscriptionRepository { get; }
        ICollectionRepository CollectionRepository { get; }
        IEmployeeCollectionsRepository EmployeeCollectionsRepository { get; }
        IVacationTypeRepository VacationTypeRepository { get; }
        IEmployeeVacationTypeRepository EmployeeVacationTypeRepository { get; }
        Task<SaveState> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
