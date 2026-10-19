namespace SanskarConnectX.Protocol.Models;

public sealed record ProtocolEnvelope<TPayload>(
    string ProtocolVersion,
    string MessageType,
    string MessageId,
    DateTimeOffset TimestampUtc,
    TPayload Payload);
