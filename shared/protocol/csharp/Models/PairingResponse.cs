namespace SanskarConnectX.Protocol.Models;

public sealed record PairingResponse(
    bool Accepted,
    string PairingSessionId,
    string DeviceId,
    ErrorCode ErrorCode,
    string Message);
