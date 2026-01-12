using System;
using VRMS.Enums;

namespace VRMS.DTOs;

public class CustomerAccountSummaryDto
{
    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = string.Empty;

    public string Username { get; set; } = string.Empty;

    public AccountStatus AccountStatus { get; set; }

    public DateTime? LastLoginAt { get; set; }

    // UI-friendly display
    public string AccountStatusDisplay =>
        AccountStatus.ToString();

    public string LastLoginDisplay =>
        LastLoginAt == null
            ? "—"
            : LastLoginAt.Value.ToString("yyyy-MM-dd HH:mm");
}