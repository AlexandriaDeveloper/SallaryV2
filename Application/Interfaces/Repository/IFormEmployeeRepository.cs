using Domain.Interfaces;
using Domain.Models;

namespace Application.Interfaces.Repository
{
    public interface IFormEmployeeRepository : IRepository<Domain.Models.FormEmployee>
    {

        int GetMaxOrderInFile(int formId);
        Task<Domain.Models.FormEmployee> GetByFormIdAndEmployeeId(int formId, int employeeId);
        public Task<int?> NextEmployeeInForm(int orderNumber, int formId);
        public Task<int?> PreviousEmployeeInForm(int orderNumber, int formId);

    }
}
