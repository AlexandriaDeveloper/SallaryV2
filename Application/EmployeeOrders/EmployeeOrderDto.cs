namespace Domain.EmployeeOrders
{
    public class EmployeeOrderDto
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public string? Details { get; set; }
        public int EmployeeId { get; set; }

        public DateTime SelectedDate { get; set; }
        public EmployeeOrderTypeDto EmployeeOrderType { get; set; }

    }

    public class EmployeeOrderTypeDto
    {
        public int Id { get; set; }
        public int EmployeeOrderId { get; set; }
        public int? Quantity { get; set; }
        public char CreditOrDebit { get; set; } = 'd';
        public int FormId { get; set; }
        public decimal? Amount { get; set; }
        public int OrderId { get; set; }
    }

    public record EmployeeSubscriptionOrderDto(int? Id, int SubscriptionId);


    public record EmployeeOrderDetailsByOrderFileIdDto
        (int? Id, string tabCode, string tegaraCode, string employeeName, string orderName, string details, int? quantity, decimal amount);


}
