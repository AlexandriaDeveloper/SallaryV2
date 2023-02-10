namespace Domain.DTOS.EmploueeOrdersDtos
{
    public class GetEmployeeOrdersDataDto
    {

        public ICollection<GetEmployeeOrdersListDto>? EmployeeOrders { get; set; }
        public ICollection<GetEmployeeDeductionsListDto>? EmployeeDeductions { get; set; }

        public GetEmployeeOrdersDataDto()
        {

            if (this.EmployeeOrders == null)
            {
                EmployeeOrders = new List<GetEmployeeOrdersListDto>();
            }

            if (this.EmployeeDeductions == null)
            {
                EmployeeDeductions = new List<GetEmployeeDeductionsListDto>();
            }

        }


        public class GetEmployeeOrdersListDto
        {
            public int Id { get; set; }

            public string? Details { get; set; }

            public int? Quantity { get; set; }
            public char CreditOrDebit { get; set; }

            public decimal Amount { get; set; }
            public string OrderFileName { get; set; }
            public DateTime? StartFrom { get; set; }
            public DateTime? EndAt { get; set; }

        }
        public class GetEmployeeDeductionsListDto
        {
            public string? Details { get; set; }

            public char CreditOrDebit { get; set; }
            public string OrderFileName { get; set; }

            public decimal Amount { get; set; }
        }
    }

}
