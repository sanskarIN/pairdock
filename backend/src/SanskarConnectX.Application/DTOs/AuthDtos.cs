namespace SanskarConnectX.Application.DTOs;

public sealed record RegisterRequest(string Email, string DisplayName, string Password);
public sealed record LoginRequest(string Email, string Password);
public sealed record AuthResponse(string AccessToken, string Email, string DisplayName, string Role);
