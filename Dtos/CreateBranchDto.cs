namespace PrometheusSuite.Shared.Dtos;

public class CreateBranchDto
{
    public required string Zone { get; set; } 
    public required string Email { get; set; }
    public required string Phone { get; set; }
    public required string LicenseKey { get; set; }
    
}