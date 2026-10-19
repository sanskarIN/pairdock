namespace SanskarConnectX.Sdk.Http;

public sealed class SanskarConnectXClientOptions
{
    public required Uri BaseAddress { get; init; }
    public string? AccessToken { get; init; }
    public TimeSpan Timeout { get; init; } = TimeSpan.FromSeconds(30);
}
