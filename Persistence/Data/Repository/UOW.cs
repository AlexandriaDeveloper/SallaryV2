using Application.Interfaces.Repository;
using Domain.Enums;
using Domain.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Persistence.Data.Repository
{
    internal class UOW : IUOW
    {
        private readonly SallaryCQRSAppContext _context;
        private readonly IAuthService _authService;


        private Lazy<IEmployeeRepository> _employeeRepository;
        private Lazy<IEmployeeBasicSallaryRepository> _employeeSallaryRepository;
        private Lazy<IEmployeePartTimeRepository> _employeePartTimeRrepository;
        private Lazy<IOrderRepository> _orderRepository;
        private Lazy<IBudgetItemRepository> _budgetItemRepository;
        private Lazy<IEmployeeOrderRepository> _employeeOrderRepository;
        private Lazy<IEmployeeOrderExecuationRepository> _employeeOrderExecuationRepository;
        //  private Lazy<IEmployeeOrderDeductionRepository> _employeeOrderDeductionRepository;
        //  private  Lazy<IEmployeeOrderDeductionExecuationRepository> _employeeOrderDeductionExecuationRepository;
        private Lazy<IEmployeeGradeRepository> _employeeGradeRepository;
        private Lazy<IGradeRepository> _gradeRepository;

        private Lazy<ISubscriptionRepository> _subscriptionRepository;
        private Lazy<IEmployeeSubscriptionRepository> _employeeSubscriptionRepository;
        private Lazy<IBankRepository> _bankRepository;
        private Lazy<IBranchRepository> _branchRepository;
        private Lazy<IEmployeeBankRepository> _employeeBankRepository;
        //   private Lazy<IOrderFileRepository> _orderFileRepository;
        private Lazy<IFinancialYearRepository> _financialYearRepository;
        private Lazy<IFormRepository> _formRepository;
        private Lazy<ICollectionRepository> _collectionRepository;
        private Lazy<IEmployeeCollectionsRepository> _employeeCollectionsRepository;
        private Lazy<IEmployeeFormRepository> _employeeFormRepository;
        private Lazy<IPeriodicSubscriptionRepository> _periodicSubscriptionRepository;
        public UOW(SallaryCQRSAppContext context, IAuthService authService)
        {
            this._context = context;
            this._authService = authService;
            LazyInitializer(context, authService);

        }

        public IEmployeePartTimeRepository EmployeePartTimeRepository => _employeePartTimeRrepository.Value;
        public IEmployeeRepository EmployeeRepository => _employeeRepository.Value;
        public IEmployeeBasicSallaryRepository EmployeeBasicSallaryRepository => _employeeSallaryRepository.Value;
        public IOrderRepository OrderRepository => _orderRepository.Value;
        public IEmployeeOrderExecuationRepository EmployeeOrderExecuationRepository => _employeeOrderExecuationRepository.Value;
        public IBudgetItemRepository BudgetItemRepository => _budgetItemRepository.Value;
        public IEmployeeOrderRepository EmployeeOrderRepository => _employeeOrderRepository.Value;
        // public IEmployeeOrderDeductionRepository EmployeeOrderDeductionRepository => _employeeOrderDeductionRepository.Value;
        //  public IEmployeeOrderDeductionExecuationRepository EmployeeOrderDeductionExecuationRepository => _employeeOrderDeductionExecuationRepository.Value;
        public IEmployeeGradeRepository EmployeeGradeRepository => _employeeGradeRepository.Value;
        public ISubscriptionRepository SubscriptionRepository => _subscriptionRepository.Value;
        public IEmployeeSubscriptionRepository EmployeeSubscriptionRepository => _employeeSubscriptionRepository.Value;
        public IGradeRepository GradeRepository => _gradeRepository.Value;
        public IBankRepository BankRepository => _bankRepository.Value;
        public IBranchRepository BranchRepository => _branchRepository.Value;
        public IEmployeeBankRepository EmployeeBankRepository => _employeeBankRepository.Value;
        //  public IOrderFileRepository OrderFileRepository => _orderFileRepository.Value;
        public IFinancialYearRepository FinancialYearRepository => _financialYearRepository.Value;
        public IFormRepository FormRepository => _formRepository.Value;
        public ICollectionRepository CollectionRepository => _collectionRepository.Value;
        public IEmployeeCollectionsRepository EmployeeCollectionsRepository => _employeeCollectionsRepository.Value;
        public IEmployeeFormRepository EmployeeFormRepository => _employeeFormRepository.Value;
        public IPeriodicSubscriptionRepository PeriodicSubscriptionRepository => _periodicSubscriptionRepository.Value;
        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<SaveState> SaveChangesAsync(CancellationToken cancellationToken)
        {
            try
            {
                await _context.SaveChangesAsync(cancellationToken);
                return SaveState.Saved;
            }
            catch (DbUpdateException ex)
            {
                SqlException innerException = ex.InnerException as SqlException;
                if (innerException != null && (innerException.Number == 2627 || innerException.Number == 2601))
                {


                    return SaveState.SqlDublicateException;
                }

                return SaveState.SqlException;

            }
            catch (Exception)
            {

                return SaveState.Exception;
            }

        }


        private void LazyInitializer(SallaryCQRSAppContext context, IAuthService authService)
        {
            this._employeeRepository = this._employeeRepository ?? new Lazy<IEmployeeRepository>(() => new EmployeeRepository(context, authService));
            this._employeePartTimeRrepository = this._employeePartTimeRrepository ?? new Lazy<IEmployeePartTimeRepository>(() => new EmployeePartTimeRepository(context, authService));
            this._orderRepository = this._orderRepository ?? new Lazy<IOrderRepository>(() => new OrderRepository(context, authService));
            this._employeeOrderExecuationRepository = this._employeeOrderExecuationRepository ?? new Lazy<IEmployeeOrderExecuationRepository>(() => new EmployeeOrderExecuationRepository(context, authService));
            this._budgetItemRepository = this._budgetItemRepository ?? new Lazy<IBudgetItemRepository>(() => new BudgetItemRepository(context, authService));
            this._employeeOrderRepository = this._employeeOrderRepository ?? new Lazy<IEmployeeOrderRepository>(() => new EmployeeOrderRepository(context, authService));
            this._employeeGradeRepository = this._employeeGradeRepository ?? new Lazy<IEmployeeGradeRepository>(() => new EmployeeGradeRepository(context, authService));
            this._gradeRepository = this._gradeRepository ?? new Lazy<IGradeRepository>(() => new GradeRepository(context, authService));
            this._employeeSallaryRepository = this._employeeSallaryRepository ?? new Lazy<IEmployeeBasicSallaryRepository>(() => new EmployeeBasicSallaryRepository(context, authService));
            this._subscriptionRepository = this._subscriptionRepository ?? new Lazy<ISubscriptionRepository>(() => new SubscriptionRepository(context, authService));
            this._employeeSubscriptionRepository = this._employeeSubscriptionRepository ?? new Lazy<IEmployeeSubscriptionRepository>(() => new EmployeeSubscriptionRepository(context, authService));
            this._bankRepository = this._bankRepository ?? new Lazy<IBankRepository>(() => new BankRepository(context, authService));
            this._branchRepository = this._branchRepository ?? new Lazy<IBranchRepository>(() => new BranchRepository(context, authService));
            this._employeeBankRepository = this._employeeBankRepository ?? new Lazy<IEmployeeBankRepository>(() => new EmployeeBankRepository(context, authService));
            //this._orderFileRepository = this._orderFileRepository ?? new Lazy<IOrderFileRepository>(() => new OrderFileRepository(context, authService));
            this._financialYearRepository = this._financialYearRepository ?? new Lazy<IFinancialYearRepository>(() => new FinancialYearRepository(context, authService));
            this._collectionRepository = this._collectionRepository ?? new Lazy<ICollectionRepository>(() => new CollectionRepository(context, authService));
            this._employeeCollectionsRepository = this._employeeCollectionsRepository ?? new Lazy<IEmployeeCollectionsRepository>(() => new EmployeeCollectionsRepository(context, authService));
            this._formRepository = this._formRepository ?? new Lazy<IFormRepository>(() => new FormRepository(context, authService));
            this._employeeFormRepository = this._employeeFormRepository ?? new Lazy<IEmployeeFormRepository>(() => new EmployeeFormRepository(context, authService));
            this._periodicSubscriptionRepository = this._periodicSubscriptionRepository ?? new Lazy<IPeriodicSubscriptionRepository>(() => new PeriodicSubscriptionRepository(context, authService));

        }

    }
}
