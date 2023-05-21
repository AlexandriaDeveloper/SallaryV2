using Domain.Interfaces;
using Domain.Models;

namespace Application.Interfaces.Repository
{
    public interface IEmployeeSubscriptionRepository : IRepository<RegisterdEmployeeSubscription>
    {
        Task<List<RegisterdEmployeeSubscription>> GetEmployeeSubscriptionBySubscriptionId(int subscriptionId);
        Task<List<RegisterdEmployeeSubscription>> GetSubscriptionsByEmployeeId(int employeeId);

    }
}
