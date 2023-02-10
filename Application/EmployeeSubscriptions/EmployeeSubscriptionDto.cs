namespace Domain.EmployeeSubscriptions
{
    public record EmployeeSubscriptionDto(int? Id,
        int EmployeeId,
        int SubscriptionId,
        string? Details,
        decimal Amount,
        bool IsActive,
        string EmployeeTabCode,
        string EmployeeNationalId,
        string EmployeeTegaraCode,
        string EmployeeName,
        string EmployeeSection
      );


    public record EmployeeToSubscriptionDto(
        int? Id,
        int EmployeeId,
        int SubscriptionId,
        string? Details,
        decimal Amount,
        bool IsActive);

}
