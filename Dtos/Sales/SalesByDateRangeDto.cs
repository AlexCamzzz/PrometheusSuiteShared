namespace PrometheusSuite.Shared.Dtos.Sales;

public class SalesByDateRangeDto
{
    public required string BranchId { get; set; }
    public required DateTime StartDate { get; set; }
    public required DateTime EndDate { get; set; }
}