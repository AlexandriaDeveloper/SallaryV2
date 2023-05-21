namespace Domain.EmployeeOrders
{
    public class EmployeeOrderDeductionDto
    {
        public int? Id { get; set; }
        public string? Details { get; set; }
        public int OrderId { get; set; }
        public int FormEmployeeId { get; set; }
        public decimal Amount { get; set; }
        public char CreditOrDepit { get; set; } = 'c';

    }
}
