using PrometheusSuite.Shared.Enums;

namespace PrometheusSuite.Shared.Dtos.Auth;

public class LoginResultDto
{
    public required BranchDto? BranchInfo { get; set; }
    public required bool HasAccess { get; set; }
    public required LoginStatus Status { get; set; }
    public required bool CanInteract { get; set; }
    public required string Message { get; set; }
}