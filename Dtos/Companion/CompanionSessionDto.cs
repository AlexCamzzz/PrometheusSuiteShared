using System;

namespace PrometheusSuite.Shared.Dtos.Companion;

public class CompanionSessionDto
{
    public string SessionId { get; set; } = string.Empty;
    public string BranchId { get; set; } = string.Empty;
    public string Brand { get; set; } = "pqt"; // "pqt" or "prometheus"
    public string Status { get; set; } = "Waiting"; // "Waiting", "Connected", "Scanned"
    public string? LastScannedCode { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime ExpiresAt { get; set; } = DateTime.UtcNow.AddMinutes(15);
}

public class CompanionScanRequestDto
{
    public string SessionId { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
}

public class CompanionPollResponseDto
{
    public string SessionId { get; set; } = string.Empty;
    public string Status { get; set; } = "Waiting";
    public string? ScannedCode { get; set; }
    public bool HasCode => !string.IsNullOrEmpty(ScannedCode);
}
