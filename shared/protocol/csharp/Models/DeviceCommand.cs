namespace SanskarConnectX.Protocol.Models;

public sealed record DeviceCommand(
    string CommandId,
    string DeviceId,
    string CommandType,
    IReadOnlyDictionary<string, string> Parameters,
    DateTimeOffset ExpiresUtc);

