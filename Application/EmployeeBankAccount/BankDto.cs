namespace Application.EmployeeBankAccount
{
    public record BankDto(int? Id, string Name, ICollection<BankDto> Branches);
    public record BrancheDto(int? Id, string Name, int BankId);
    public record EmployeeBankAccountDto(int? Id, int EmployeeId, int BranchId, string AccountNumber);

}
