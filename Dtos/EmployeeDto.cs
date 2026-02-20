using PrometheusSuite.Shared.Enums;

namespace PrometheusSuite.Shared.Dtos;

public class EmployeeDto
{
    public required Guid Id { get; set; } = Guid.NewGuid();
    
    public required string Name { get; set; } = string.Empty;
    public required string Password { get; set; } = string.Empty;
    
    public required EmployeeRole Role { get; set; } = EmployeeRole.Employee;
    
    public required bool IsActive { get; set; } = true;
}