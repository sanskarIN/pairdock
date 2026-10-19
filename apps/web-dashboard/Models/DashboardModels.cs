namespace SanskarConnectX.WebDashboard.Models;

public sealed record DashboardSummary(
    int TotalDevices,
    int OnlineDevices,
    int ProvisioningDevices,
    int FirmwareUpdatesPending,
    int AlertsOpen);

public sealed record DeviceDashboardRow(
    string DeviceId,
    string DisplayName,
    string State,
    int Rssi,
    string FirmwareVersion,
    DateTimeOffset LastSeenUtc);

public sealed record ActivityEvent(string Severity, string Title, string Message, DateTimeOffset TimestampUtc);

public sealed record FirmwareRolloutStatus(string Version, string HardwareRevision, int EligibleDevices, int CompletedDevices, int FailedDevices);
