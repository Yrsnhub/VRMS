namespace VRMS.Models.Accounts;

public class CustomerAccount
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public string Username { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;

    public bool IsEnabled { get; set; }

    public bool MustChangePassword { get; set; }

    public DateTime? LastLoginAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public int CreatedByAgentId { get; set; }
}