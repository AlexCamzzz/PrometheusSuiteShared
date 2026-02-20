namespace PrometheusSuite.Shared.Dtos.Auth;

public class LoginFromClientDto
{
    public required string Email { get; set; }
    
    public required string LicenseKey { get; set; }
    
    public required string HardwareId { get; set; }
}