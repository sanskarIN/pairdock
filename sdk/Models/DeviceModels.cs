namespace SanskarConnectX.Sdk.Models;

public sealed record DeviceSummary(string DeviceId, string DisplayName, string FirmwareVersion, string ConnectionState, int Rssi);
public sealed record DeviceCommandRequest(string CommandType, IReadOnlyDictionary<string, string> Parameters);

