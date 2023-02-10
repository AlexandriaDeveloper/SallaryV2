namespace Application.EmployeesForm
{

    public record AddEmployeeToFormParam(int employeeId, int formId);
    public class EmployeeFormParam
    {

        public int CollectionId { get; set; }
        public int FormId { get; set; }
    }
    public class GetCheckedSubscriptionByFormIdDto
    {
        public int? SubscriptionId { get; set; }
        public string SubscriptionName { get; set; }
        public bool Checked { get; set; }
    }
}
