namespace PrometheusSuite.Shared.Dtos.Transactions;

public class TransactionsByDateRangeDto
{
    public required string BranchId { get; set; }
    public required DateTime StartDate { get; set; }
    public required DateTime EndDate { get; set; }
    
}