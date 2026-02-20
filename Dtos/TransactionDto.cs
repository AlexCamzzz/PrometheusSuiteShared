using PrometheusSuite.Shared.Enums;

namespace PrometheusSuite.Shared.Dtos;

public class TransactionDto
{
    
    public string? Id { get; set; }
    
    public required string BranchId { get; set; }
    
    public required Guid EmployeeId { get; set; }
    
    public required string Folio { get; set; }
    
    public required DateTime Date { get; set; }
    
    public required decimal Amount { get; set; }
    public required string Description { get; set; }
    
    public required TransactionMethod Method { get; set; }
    public required TransactionType Type { get; set; }
}