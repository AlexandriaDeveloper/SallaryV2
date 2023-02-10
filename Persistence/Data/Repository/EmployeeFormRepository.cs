using Application.Interfaces.Repository;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Persistence.Data.Repository
{
    public class EmployeeFormRepository : Repository<EmployeeForm>, IEmployeeFormRepository
    {
        private readonly SallaryCQRSAppContext _context;

        public EmployeeFormRepository(SallaryCQRSAppContext context, IAuthService authService) : base(context, authService)
        {
            _context = context;
        }

        public int GetMaxOrderInFile(int formId)
        {
            int count = -1;

            var forms = _context.EmployeeForms.Where(x => x.FormId == formId);
            if (forms.Any())
                count = forms.Max(x => x.EmployeeOrderNumber);
            return count;

        }


        public async Task<int?> NextEmployeeInForm(int orderNumber, int formId)
        {


            var ids = await _context.EmployeeForms.
                Where(x => x.EmployeeOrderNumber > orderNumber && x.FormId == formId && x.DeletedDate == null)
                .OrderBy(t => t.EmployeeOrderNumber)
                .Select(x => x.EmployeeId).FirstOrDefaultAsync();
            return ids;
        }
        public async Task<int?> PreviousEmployeeInForm(int orderNumber, int formId)
        {
            var ids = await _context.EmployeeForms
                .Where(x => x.EmployeeOrderNumber < orderNumber && x.FormId == formId && x.DeletedDate == null)
                .OrderByDescending(t => t.EmployeeOrderNumber)
                .Select(x => x.EmployeeId).FirstOrDefaultAsync();
            return ids;
        }
    }
}
