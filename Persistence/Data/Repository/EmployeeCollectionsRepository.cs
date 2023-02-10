using Application.Interfaces.Repository;
using Domain.Interfaces;
using Domain.Models;
using System.Linq;

namespace Persistence.Data.Repository
{
    public class EmployeeCollectionsRepository : Repository<EmployeeCollection>, IEmployeeCollectionsRepository
    {
        private readonly SallaryCQRSAppContext _context;

        public EmployeeCollectionsRepository(SallaryCQRSAppContext context, IAuthService authService) : base(context, authService)
        {
            _context = context;
        }

        public int MaxOrderByCollectionId(int collectionId)
        {
            int count = -1;

            var collection = _context.EmployeeCollections.Where(x => x.CollectionId == collectionId);
            if (collection.Any())
                count = collection.Max(x => x.EmployeeOrderInCollection.Value);
            return count;
        }
    }
}
