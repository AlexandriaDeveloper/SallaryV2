using Application.Interfaces.Repository;
using Domain.Interfaces;
using Domain.Models;

namespace Persistence.Data.Repository
{
    public class FormEmployeeVacationTypeRepository : Repository<FormEmployeeVacation>, IFormEmployeeVacationTypeRepository
    {
        public FormEmployeeVacationTypeRepository(SallaryCQRSAppContext context, IAuthService authService) : base(context, authService)
        {
        }
    }
}
