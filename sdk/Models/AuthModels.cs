namespace SanskarConnectX.Sdk.Models;

public sealed record LoginRequest(string Email, string Password);
public sealed record RegisterRequest(string Email, string DisplayName, string Password);
public sealed record AuthSession(string AccessToken, string Email, string DisplayName, string Role);

