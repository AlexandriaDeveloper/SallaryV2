using Domain.Interfaces;
using Domain.Models;

namespace Application.Interfaces.Repository
{
    public interface IEmployeeCollectionsRepository : IRepository<EmployeeCollection>
    {

        int MaxOrderByCollectionId(int collectionId);

    }
}
