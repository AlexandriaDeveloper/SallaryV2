using Application.Interfaces.Repository;
using Domain.Interfaces;
using Domain.Models;

namespace Persistence.Data.Repository
{
    public class FormEmployeeOrderExecutionsRepository : Repository<FormEmployeeOrderExecuation>, IFormEmployeeOrderExecutionRepository
    {
        public FormEmployeeOrderExecutionsRepository(SallaryCQRSAppContext context, IAuthService authService) : base(context, authService)
        {
        }
    }
}
