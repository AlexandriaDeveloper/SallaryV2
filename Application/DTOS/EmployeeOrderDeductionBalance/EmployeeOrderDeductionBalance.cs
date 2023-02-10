namespace Domain.DTOS.EmployeeOrderDeductionBalance
{
    public class EmployeeOrderDeductionBalanceDto
    {

        public int EmployeeId { get; set; }

        public List<EmployeeTotalOrderDto>? EmployeeOrdersDtos { get; set; }
        public EmployeeOrderDeductionBalanceDto()
        {
            if (EmployeeOrdersDtos == null)
            {
                EmployeeOrdersDtos = new List<EmployeeTotalOrderDto>();
            }
        }
    }

    public class EmployeeTotalOrderDto
    {
        public int OrderId { get; set; }
        public string OrderFileName { get; set; }
        public string OrderName { get; set; }
        public string OrderDeductionName { get; set; }
        public decimal OrderTotal { get; set; } = 0;
        public char CreditOrDebit { get; set; }
        public decimal DeductionTotal { get; set; } = 0;
        public decimal Net { get => OrderTotal - DeductionTotal; }


    }

    public class EmployeeTotalOrderDeductionDto
    {
        public int OrderDeductionId { get; set; }
        public string OrderDeductionName { get; set; }
        public decimal Total { get; set; }


    }
}
