using Application.Interfaces.Repository;
using Domain.Interfaces;
using Domain.Models;

namespace Persistence.Data.Repository
{
    public class EmployeeBankRepository : Repository<EmployeeBank>, IEmployeeBankRepository
    {
        public EmployeeBankRepository(SallaryCQRSAppContext context, IAuthService authService) : base(context, authService)
        {
        }
    }
}
