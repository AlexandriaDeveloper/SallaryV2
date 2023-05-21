using Application.Interfaces.Repository;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Persistence.Data.Repository
{
    public class FormEmployeeRepository : Repository<FormEmployee>, IFormEmployeeRepository
    {
        private readonly SallaryCQRSAppContext _context;

        public FormEmployeeRepository(SallaryCQRSAppContext context, IAuthService authService) : base(context, authService)
        {
            _context = context;
        }

        public async Task< FormEmployee >GetByFormIdAndEmployeeId(int formId, int employeeId) { 
        
        return await _context.FormEmployees.SingleOrDefaultAsync(x => x.FormId== formId && x.EmployeeId== employeeId)??default;
        }

        public int GetMaxOrderInFile(int formId)
        {
            int count = -1;

            var forms = _context.FormEmployees.Where(x => x.FormId == formId);
            if (forms.Any())
                count = forms.Max(x => x.EmployeeOrderNumber);
            return count;

        }


        public async Task<int?> NextEmployeeInForm(int orderNumber, int formId)
        {


            var ids = await _context.FormEmployees.
                Where(x => x.EmployeeOrderNumber > orderNumber && x.FormId == formId && x.DeletedDate == null)
                .OrderBy(t => t.EmployeeOrderNumber)
                .Select(x => x.EmployeeId).FirstOrDefaultAsync();
            return ids;
        }
        public async Task<int?> PreviousEmployeeInForm(int orderNumber, int formId)
        {
            var ids = await _context.FormEmployees
                .Where(x => x.EmployeeOrderNumber < orderNumber && x.FormId == formId && x.DeletedDate == null)
                .OrderByDescending(t => t.EmployeeOrderNumber)
                .Select(x => x.EmployeeId).FirstOrDefaultAsync();
            return ids;
        }
    }
}
