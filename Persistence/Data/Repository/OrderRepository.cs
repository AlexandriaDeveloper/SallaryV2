using Application.Interfaces.Repository;
using Domain.Interfaces;
using Domain.Models;

namespace Persistence.Data.Repository
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(SallaryCQRSAppContext context, IAuthService authService) : base(context, authService)
        {
        }


    }
}
