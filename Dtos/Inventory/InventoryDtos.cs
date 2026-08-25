namespace PrometheusSuite.Shared.Dtos.Inventory;

public sealed class InventoryProductDto
{
    public string Id { get; set; } = string.Empty;
    public string BranchId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal PurchasePrice { get; set; }
    public decimal SalePrice { get; set; }
    public int StockQty { get; set; }
}

public sealed class CreateInventoryProductDto
{
    public string BranchId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal PurchasePrice { get; set; }
    public decimal SalePrice { get; set; }
    public int StockQty { get; set; }
}

public sealed class InventoryStockAdjustmentDto
{
    public int Delta { get; set; }
    public string? Notes { get; set; }
}

public sealed class InventorySupplyDto
{
    public string Id { get; set; } = string.Empty;
    public string BranchId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Measure { get; set; } = string.Empty;
    public int PendingUnits { get; set; }
    public int ActiveUnits { get; set; }
    public int FinishedUnits { get; set; }
    public System.Collections.Generic.List<SupplyUnitDto> Units { get; set; } = new();
}

public sealed class SupplyUnitDto
{
    public string Id { get; set; } = string.Empty;
    public string SupplyId { get; set; } = string.Empty;
    public int UnitNumber { get; set; }
    public string Status { get; set; } = string.Empty;
    public int UsageCount { get; set; }
    public DateTime? ActivatedOn { get; set; }
    public DateTime? FinishedOn { get; set; }
}

public sealed class CreateInventorySupplyDto
{
    public string BranchId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Measure { get; set; } = string.Empty;
    public int Units { get; set; } = 1;
}

public sealed class AddSupplyUnitsDto
{
    public int Units { get; set; } = 1;
}

public sealed class InventoryAuditLogDto
{
    public long Id { get; set; }
    public string BranchId { get; set; } = string.Empty;
    public DateTime Timestamp { get; set; }
    public Guid EmployeeId { get; set; }
    public string EmployeeName { get; set; } = string.Empty;
    public string Action { get; set; } = string.Empty;
    public string EntityType { get; set; } = string.Empty;
    public string EntityId { get; set; } = string.Empty;
    public string EntityName { get; set; } = string.Empty;
    public int? UnitNumber { get; set; }
    public string? SaleId { get; set; }
    public string? SaleFolio { get; set; }
    public string? Delta { get; set; }
    public string? Notes { get; set; }
}
