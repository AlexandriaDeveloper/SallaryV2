using Application.Interfaces.Repository;
using Domain.Interfaces;
using Domain.Models;

namespace Persistence.Data.Repository
{
    public class PeriodicSubscriptionRepository : Repository<PeriodicSubscription>, IPeriodicSubscriptionRepository
    {
        public PeriodicSubscriptionRepository(SallaryCQRSAppContext context, IAuthService authService) : base(context, authService)
        {
        }
    }
}
