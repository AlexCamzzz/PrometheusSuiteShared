namespace PrometheusSuite.Shared.Dtos;

public class UpdateSubscriptionPackagesDto
{
    public required string BranchId { get; set; }
    public bool IsAiEnabled { get; set; }
    public bool IsNativeTrackingEnabled { get; set; }
}
