namespace Application.FinancialDataTypes
{
    public class FinancialDataTypeDto
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentFinancialDataTypeId { get; set; }

        public DateTime ReservationDate { get; set; }
    }
}
