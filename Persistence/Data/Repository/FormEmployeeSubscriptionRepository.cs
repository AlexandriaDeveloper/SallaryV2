using Application.Interfaces.Repository;
using Domain.Interfaces;
using Domain.Models;

namespace Persistence.Data.Repository
{
    public class FormEmployeeSubscriptionRepository : Repository<FormEmployeeSubscription>, IFormEmployeeSubscriptionRepository
    {
        public FormEmployeeSubscriptionRepository(SallaryCQRSAppContext context, IAuthService authService) : base(context, authService)
        {
        }
    }
}
