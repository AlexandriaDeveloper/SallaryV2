namespace Persistence.Data.Repository
{
    //public class OrderFileRepository : Repository<OrderFile>, IOrderFileRepository
    //{
    //    private readonly SallaryCQRSAppContext _context;

    //    public OrderFileRepository(SallaryCQRSAppContext context, IAuthService authService) : base(context, authService)
    //    {
    //        _context = context;
    //    }

    //    public async Task< List<EmployeeOrder>> GetOrdersByFileOrderId(int orderFileId )
    //    {
    //       var result=await _context.EmployeeOrders
    //            .Where(x => x.OrderFileId == orderFileId)
    //            .Include( t=> t.Employee)
    //            .Include(t => t.EmployeeOrderExecuations)
    //            .ToListAsync();
    //        return result;
    //    }
    //}
}
