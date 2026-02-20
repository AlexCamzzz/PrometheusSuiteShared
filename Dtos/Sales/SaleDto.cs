using PrometheusSuite.Shared.Enums;

namespace PrometheusSuite.Shared.Dtos.Sales;

public class SaleDto
{
    //BSON ID
    public string? Id { get; set; } = string.Empty;
    
    //ID References as plaint text
    public required string BranchId { get; set; }
    public required Guid EmployeeId { get; set; }
    
    //General Sale Info
    public required string ClientName { get; set; }
    public required string ClientPhone { get; set; }
    public required string ClientEmail { get; set; }
    public required string Folio { get; set; }
    public required string Waybill { get; set; } = string.Empty;
    public required Carrier Carrier { get; set; }
    public required DateTime Date { get; set; }
    public required ShippingStatus StatusEnvio { get; set; }
    public required decimal Total { get; set; }
    public required decimal BaseQuote { get; set; }
    
    public required bool IsPiecesAdjusted { get; set; } = false;
    
    public required Guid LastModifiedBy { get; set; }
    
    public required DateTime LastModifiedOn { get; set; }
    
    //Nested Pieces List
    public List<PieceDto>? Pieces { get; set; } 
    
    public TransactionDto? Transaction { get; set; }
    
}

