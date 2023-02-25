using Domain.Interfaces;
using Domain.Models;

namespace Application.Interfaces.Repository
{
    public interface IFinancialDataTypesRepository : IRepository<FinancialDataType>
    {
        int GetMaxChildId(int parentId);
        int GetMaxParentId();
    }
}
