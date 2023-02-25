using Application.Interfaces.Repository;
using Domain.Interfaces;
using Domain.Models;
using System;
using System.Linq;

namespace Persistence.Data.Repository
{
    public class FinancialDataTypesRepository : Repository<FinancialDataType>, IFinancialDataTypesRepository
    {
        private readonly SallaryCQRSAppContext _context;

        public FinancialDataTypesRepository(SallaryCQRSAppContext context, IAuthService authService) : base(context, authService)
        {
            _context = context;
        }


        public int GetMaxChildId(int parentId) { 
        
        return _context.FinancialDataTypes.Where(x => x.ParentFinancialDataTypeId== parentId).Max(x => x.Id);
        }
        public int GetMaxParentId()
        {

            return _context.FinancialDataTypes.Where(x => x.ParentFinancialDataTypeId == null).Max(x => x.Id);
        }
    }
}
