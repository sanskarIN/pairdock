using SanskarConnectX.Domain.Common;
using SanskarConnectX.Domain.Enums;

namespace SanskarConnectX.Domain.Entities;

public sealed class User : Entity
{
    public string Email { get; private set; } = string.Empty;
    public string DisplayName { get; private set; } = string.Empty;
    public string PasswordHash { get; private set; } = string.Empty;
    public UserRole Role { get; private set; } = UserRole.User;

    private User()
    {
    }

    public User(string email, string displayName, string passwordHash, UserRole role)
    {
        Email = email.Trim().ToLowerInvariant();
        DisplayName = displayName.Trim();
        PasswordHash = passwordHash;
        Role = role;
    }
}

