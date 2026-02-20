namespace PrometheusSuite.Shared.Dtos;

public class BranchDto
{
    public required string Id { get; set; }
    public required string Zone { get; set; } 
    public required string Email { get; set; }
    
    public required string Phone { get; set; }
    
    public required int SalesQty { get; set; }
    
    public required int TransactionsQty { get; set; }
    
    public required decimal ExpectedMoney { get; set; }
    
    public required SuscriptionDto Suscription { get; set; }

    public required List<EmployeeDto> Employees { get; set; } = new List<EmployeeDto>();
}