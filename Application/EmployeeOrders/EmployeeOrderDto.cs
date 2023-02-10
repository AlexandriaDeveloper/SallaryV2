namespace Domain.EmployeeOrders
{
    public class EmployeeOrderDto
    {
        public int Id { get; set; }

        public int FormId { get; set; }
        public string OrderNumber { get; set; }
        public string? Details { get; set; }
        public int OrderId { get; set; }
        //public int EmployeeSubscriptionId { get; set; }
        public int EmployeeId { get; set; }
        // public decimal? Amount { get; set; }
        public int FinancialYearId { get; set; }
        public int OrderFileId { get; set; }
        public int? Quantity { get; set; }
        public char CreditOrDepit { get; set; } = 'd';
        public DateTime? StartFrom { get; set; }
        public DateTime? EndAt { get; set; }

        public decimal? Amount { get; set; }
    }

    public record EmployeeSubscriptionOrderDto(int? Id, int SubscriptionId);


    public record EmployeeOrderDetailsByOrderFileIdDto
        (int? Id, string tabCode, string tegaraCode, string employeeName, string orderName, string details, int? quantity, DateTime? startFrom, DateTime? endAt, decimal amount);


}
