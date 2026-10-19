namespace SanskarConnectX.Protocol.Models;

public sealed record PairingRequest(
    string AppInstanceId,
    string PairingCode,
    DateTimeOffset RequestedUtc);

