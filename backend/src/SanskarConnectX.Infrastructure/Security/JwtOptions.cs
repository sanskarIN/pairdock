namespace SanskarConnectX.Infrastructure.Security;

public sealed class JwtOptions
{
    public string Issuer { get; set; } = "SanskarConnectX";
    public string Audience { get; set; } = "SanskarConnectX.Clients";
    public string SigningKey { get; set; } = string.Empty;
    public int ExpirationMinutes { get; set; } = 60;
}
