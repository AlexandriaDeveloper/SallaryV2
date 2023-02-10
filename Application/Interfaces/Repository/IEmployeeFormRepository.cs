using Domain.Interfaces;
using Domain.Models;

namespace Application.Interfaces.Repository
{
    public interface IEmployeeFormRepository : IRepository<EmployeeForm>
    {

        int GetMaxOrderInFile(int formId);

        public Task<int?> NextEmployeeInForm(int orderNumber, int formId);
        public Task<int?> PreviousEmployeeInForm(int orderNumber, int formId);

    }
}
