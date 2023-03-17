using Application.Interfaces.Repository;
using Domain.Interfaces;
using Domain.Models;

namespace Persistence.Data.Repository
{
    public class VacationTypeRepository : Repository<Vacation>, IVacationTypeRepository
    {
        public VacationTypeRepository(SallaryCQRSAppContext context, IAuthService authService) : base(context, authService)
        {
        }
    }
}
