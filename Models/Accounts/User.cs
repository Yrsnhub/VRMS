using VRMS.Enums;

namespace VRMS.Models.Accounts;

public abstract class User
{
    public int Id { get; set; }

    public string Username { get; set; } = string.Empty;
    public string? FullName { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }

    public string PasswordHash { get; set; } = string.Empty;
    public UserRole Role { get; set; }
    public AccountStatus Status { get; set; }

    public string? PhotoPath { get; set; }
}
