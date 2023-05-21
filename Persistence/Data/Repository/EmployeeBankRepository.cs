using Application.Interfaces.Repository;
using Domain.Interfaces;
using Domain.Models;

namespace Persistence.Data.Repository
{
    public class EmployeeBankAccountRepository : Repository<EmployeeBankAccount>, IEmployeeBankAccountRepository
    {
        public EmployeeBankAccountRepository(SallaryCQRSAppContext context, IAuthService authService) : base(context, authService)
        {
        }
    }
}
