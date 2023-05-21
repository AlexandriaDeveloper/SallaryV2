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
   
        private Lazy<IOrderRepository> _orderRepository;
        private Lazy<IBudgetItemRepository> _budgetItemRepository;
        private Lazy<IFormEmployeeOrderRepository> _employeeOrderRepository;
        private Lazy<IFormEmployeeOrderExecuationRepository> _employeeOrderExecuationRepository;
        private Lazy<IEmployeeGradeRepository> _employeeGradeRepository;
        private Lazy<IGradeRepository> _gradeRepository;
        private Lazy<ISubscriptionRepository> _subscriptionRepository;
        private Lazy<IEmployeeSubscriptionRepository> _employeeSubscriptionRepository;
        private Lazy<IBankRepository> _bankRepository;
        private Lazy<IBranchRepository> _branchRepository;
        private Lazy<IEmployeeBankAccountRepository> _employeeBankRepository;
        private Lazy<IFormRepository> _formRepository;
        private Lazy<ICollectionRepository> _collectionRepository;
        private Lazy<IEmployeeCollectionsRepository> _employeeCollectionsRepository;
        private Lazy<IFormEmployeeRepository> _formEmployeeRepository;
        private Lazy<IFormEmployeeOrderExecutionRepository> _formEmployeeOrderExecutionRepository;
        private Lazy<IFormEmployeeSubscriptionRepository> _formEmployeeSubscriptionRepository;
        private Lazy<IEmployeeBasicFinancialDataRepository> _employeeBasicFinancialDataRepository;
        private Lazy<IFinancialDataTypesRepository> _financialDataTypesRepository;
        private Lazy<IVacationTypeRepository> _vacationTypeRepository;
        private Lazy<IFormEmployeeVacationTypeRepository> _formEmployeeVacationRepository;
      //  private Lazy<IEmployeeOrderTypeRepository> _employeeOrderTypeRepository;
        public UOW(SallaryCQRSAppContext context, IAuthService authService)
        {
            this._context = context;
            this._authService = authService;
            LazyInitializer(context, authService);

        }


        public IEmployeeRepository EmployeeRepository => _employeeRepository.Value;
      //  public IEmployeeBasicSallaryRepository EmployeeBasicSallaryRepository => _employeeSallaryRepository.Value;
        public IOrderRepository OrderRepository => _orderRepository.Value;
        public IFormEmployeeOrderExecuationRepository EmployeeOrderExecuationRepository => _employeeOrderExecuationRepository.Value;
        public IBudgetItemRepository BudgetItemRepository => _budgetItemRepository.Value;
        public IFormEmployeeOrderRepository FormEmployeeOrderRepository => _employeeOrderRepository.Value;
        public IEmployeeGradeRepository EmployeeGradeRepository => _employeeGradeRepository.Value;
        public ISubscriptionRepository SubscriptionRepository => _subscriptionRepository.Value;
        public IEmployeeSubscriptionRepository EmployeeSubscriptionRepository => _employeeSubscriptionRepository.Value;
        public IGradeRepository GradeRepository => _gradeRepository.Value;
        public IBankRepository BankRepository => _bankRepository.Value;
        public IBranchRepository BranchRepository => _branchRepository.Value;
        public IEmployeeBankAccountRepository EmployeeBankRepository => _employeeBankRepository.Value;
        public IFormRepository FormRepository => _formRepository.Value;
        public IFormEmployeeOrderExecutionRepository FormEmployeeOrderExecutionRepository => _formEmployeeOrderExecutionRepository.Value;
        public ICollectionRepository CollectionRepository => _collectionRepository.Value;
        public IEmployeeCollectionsRepository EmployeeCollectionsRepository => _employeeCollectionsRepository.Value;
        public IFormEmployeeRepository FormEmployeeRepository => _formEmployeeRepository.Value;
        public IEmployeeBasicFinancialDataRepository EmployeeBasicFinancialDataRepository => _employeeBasicFinancialDataRepository.Value;
        public IFinancialDataTypesRepository FinancialDataTypesRepository => _financialDataTypesRepository.Value;
        public IFormEmployeeSubscriptionRepository FormEmployeeSubscriptionRepository => _formEmployeeSubscriptionRepository.Value;
        public IFormEmployeeVacationTypeRepository FormEmployeeVacationTypeRepository => _formEmployeeVacationRepository.Value;
        public IVacationTypeRepository VacationTypeRepository => _vacationTypeRepository.Value;
     //   public IEmployeeOrderTypeRepository EmployeeOrderTypeRepository => _employeeOrderTypeRepository.Value;


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
            this._orderRepository = this._orderRepository ?? new Lazy<IOrderRepository>(() => new OrderRepository(context, authService));
            this._employeeOrderExecuationRepository = this._employeeOrderExecuationRepository ?? new Lazy<IFormEmployeeOrderExecuationRepository>(() => new EmployeeOrderExecuationRepository(context, authService));
            this._budgetItemRepository = this._budgetItemRepository ?? new Lazy<IBudgetItemRepository>(() => new BudgetItemRepository(context, authService));
            this._employeeOrderRepository = this._employeeOrderRepository ?? new Lazy<IFormEmployeeOrderRepository>(() => new EmployeeOrderRepository(context, authService));
            this._employeeGradeRepository = this._employeeGradeRepository ?? new Lazy<IEmployeeGradeRepository>(() => new EmployeeGradeRepository(context, authService));
            this._gradeRepository = this._gradeRepository ?? new Lazy<IGradeRepository>(() => new GradeRepository(context, authService));
            this._subscriptionRepository = this._subscriptionRepository ?? new Lazy<ISubscriptionRepository>(() => new SubscriptionRepository(context, authService));
            this._employeeSubscriptionRepository = this._employeeSubscriptionRepository ?? new Lazy<IEmployeeSubscriptionRepository>(() => new EmployeeSubscriptionRepository(context, authService));
            this._bankRepository = this._bankRepository ?? new Lazy<IBankRepository>(() => new BankRepository(context, authService));
            this._branchRepository = this._branchRepository ?? new Lazy<IBranchRepository>(() => new BranchRepository(context, authService));
            this._employeeBankRepository = this._employeeBankRepository ?? new Lazy<IEmployeeBankAccountRepository>(() => new EmployeeBankAccountRepository(context, authService));
            this._collectionRepository = this._collectionRepository ?? new Lazy<ICollectionRepository>(() => new CollectionRepository(context, authService));
            this._employeeCollectionsRepository = this._employeeCollectionsRepository ?? new Lazy<IEmployeeCollectionsRepository>(() => new EmployeeCollectionsRepository(context, authService));
            this._formRepository = this._formRepository ?? new Lazy<IFormRepository>(() => new FormRepository(context, authService));
            this._formEmployeeRepository = this._formEmployeeRepository ?? new Lazy<IFormEmployeeRepository>(() => new FormEmployeeRepository(context, authService));
            this._formEmployeeSubscriptionRepository = this._formEmployeeSubscriptionRepository ?? new Lazy<IFormEmployeeSubscriptionRepository>(() => new FormEmployeeSubscriptionRepository(context, authService));
            this._employeeBasicFinancialDataRepository = this._employeeBasicFinancialDataRepository ?? new Lazy<IEmployeeBasicFinancialDataRepository>(() => new EmployeeBasicFinancialDataRepository(context, authService));
            this._financialDataTypesRepository = this._financialDataTypesRepository ?? new Lazy<IFinancialDataTypesRepository>(() => new FinancialDataTypesRepository(context, authService));
            this._vacationTypeRepository = this._vacationTypeRepository ?? new Lazy<IVacationTypeRepository>(() => new VacationTypeRepository(context, authService));
            this._formEmployeeVacationRepository = this._formEmployeeVacationRepository ?? new Lazy<IFormEmployeeVacationTypeRepository>(() => new FormEmployeeVacationTypeRepository(context, authService));
            this._formEmployeeOrderExecutionRepository = this._formEmployeeOrderExecutionRepository ?? new Lazy<IFormEmployeeOrderExecutionRepository>(() => new FormEmployeeOrderExecutionsRepository(context, authService));
        }

    }
}
