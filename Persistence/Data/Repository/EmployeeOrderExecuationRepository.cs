using Application.Interfaces.Repository;
using Domain.Interfaces;
using Domain.Models;

namespace Persistence.Data.Repository
{
    public class EmployeeOrderExecuationRepository : Repository<EmployeeOrderTypeExecuation>, IEmployeeOrderExecuationRepository
    {
        public EmployeeOrderExecuationRepository(SallaryCQRSAppContext context, IAuthService authService) : base(context, authService)
        {
        }
    }
}
