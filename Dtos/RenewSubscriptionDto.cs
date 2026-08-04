namespace PrometheusSuite.Shared.Dtos;

public class RenewSubscriptionDto
{
    public required string BranchId { get; set; }
    public required DateTime EndDate { get; set; }
}
