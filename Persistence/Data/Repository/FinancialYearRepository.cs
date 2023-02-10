using Application.Interfaces.Repository;
using Domain.Interfaces;
using Domain.Models;

namespace Persistence.Data.Repository
{
    public class FinancialYearRepository : Repository<FinancialYear>, IFinancialYearRepository
    {
        public FinancialYearRepository(SallaryCQRSAppContext context, IAuthService authService) : base(context, authService)
        {
        }


    }
}
