using PrometheusSuite.Shared.Enums;

namespace PrometheusSuite.Shared.Dtos.Sales;

public class ParsedLabelResponseDto
{
    public string ClientName { get; set; } = string.Empty;
    public string ClientPhone { get; set; } = string.Empty;
    public string ClientEmail { get; set; } = string.Empty;
    public string Waybill { get; set; } = string.Empty;
    public Carrier Carrier { get; set; }
}
