using System;
using System.Text.Json.Serialization;
using PrometheusSuite.Shared.Enums;

namespace PrometheusSuite.Shared.Dtos.Coupons;

public class CouponDto
{
    public string? Id { get; set; }
    public string BranchId { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public CouponDiscountType Type { get; set; }
    public decimal Value { get; set; }
    public DateTime? ExpirationDate { get; set; }
    public int UsageLimit { get; set; } = 1;
    public int TimesUsed { get; set; } = 0;
    public decimal? MinSaleAmount { get; set; }
    public bool IsActive { get; set; } = true;
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    [JsonIgnore]
    public bool IsPercentage => Type == CouponDiscountType.Percentage;

    [JsonIgnore]
    public string FormattedValue => Type == CouponDiscountType.Percentage
        ? $"{Value:N0}%"
        : $"${Value:N2}";

    [JsonIgnore]
    public string FormattedDiscountText => Type == CouponDiscountType.Percentage
        ? $"{Value:N0}% de descuento"
        : $"${Value:N2} de descuento";

    [JsonIgnore]
    public string TypeLabel => Type == CouponDiscountType.Percentage
        ? "Porcentual"
        : "Monto Fijo";
}

public class ValidateCouponRequestDto
{
    public string Code { get; set; } = string.Empty;
    public string BranchId { get; set; } = string.Empty;
    public decimal SaleAmount { get; set; }
}

public class ValidateCouponResponseDto
{
    public bool IsValid { get; set; }
    public string? Message { get; set; }
    public CouponDto? Coupon { get; set; }
    public decimal DiscountAmount { get; set; }
}

public class RedeemCouponRequestDto
{
    public string Code { get; set; } = string.Empty;
    public string BranchId { get; set; } = string.Empty;
    public string? SaleFolio { get; set; }
}
