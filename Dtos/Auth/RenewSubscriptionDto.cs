using System;

namespace PrometheusSuite.Shared.Dtos.Auth;

public class RenewSubscriptionDto
{
    public string BranchId { get; set; } = string.Empty;
    public DateTime EndDate { get; set; }
}
