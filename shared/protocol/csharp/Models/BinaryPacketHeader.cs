namespace SanskarConnectX.Protocol.Models;

public sealed record BinaryPacketHeader(
    ushort Magic,
    byte Version,
    byte MessageType,
    byte Flags,
    uint Sequence,
    ushort PayloadLength,
    ushort HeaderCrc);

