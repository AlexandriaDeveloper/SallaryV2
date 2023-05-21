using Domain.Primitives;

namespace Domain.Models
{
    public class FinancialDataType : Entity
    {
        public int? ParentFinancialDataTypeId { get; set; }
        public int? QanonId { get; set; }

        public DateTime ReservationDate { get; set; }
        public List<EmployeeBasicFinancialData>? EmployeesBasicFinancialData { get; set; }
        public FinancialDataType? ParentFinancialDataType { get; set; }
        public  List<FinancialDataType>? ChildsElements { get; set; }
        public Qanon? Qanon { get; set; }

    }
}
