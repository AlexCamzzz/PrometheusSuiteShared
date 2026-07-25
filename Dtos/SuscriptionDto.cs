using PrometheusSuite.Shared.Enums;

namespace PrometheusSuite.Shared.Dtos;

public class SuscriptionDto
{
    public required string LicenseKey { get; set; }
    public required SubscriptionStatus Status { get; set; }
    public required DateTime EndDate { get; set; }
    
    public required string HardwareId { get; set; }
    public required bool IsAiEnabled { get; set; }
    public required bool IsNativeTrackingEnabled { get; set; }
}