using Domain.Interfaces;
using Domain.Models;

namespace Application.Interfaces.Repository
{
    public interface IEmployeeSubscriptionRepository : IRepository<EmployeeSubscription>
    {
        Task<List<EmployeeSubscription>> GetEmployeeSubscriptionBySubscriptionId(int subscriptionId);
        Task<List<EmployeeSubscription>> GetSubscriptionsByEmployeeId(int employeeId);

    }
}
