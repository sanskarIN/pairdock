namespace SanskarConnectX.WebDashboard.Services;

using SanskarConnectX.WebDashboard.Models;

public sealed class DashboardApiClient
{
    public Task<string> GetHealthAsync(CancellationToken cancellationToken) =>
        Task.FromResult("PairDock API reachable");

    public Task<DashboardSummary> GetSummaryAsync(CancellationToken cancellationToken) =>
        Task.FromResult(new DashboardSummary(
            TotalDevices: 24,
            OnlineDevices: 21,
            ProvisioningDevices: 2,
            FirmwareUpdatesPending: 5,
            AlertsOpen: 1));

    public Task<IReadOnlyList<DeviceDashboardRow>> GetDevicesAsync(CancellationToken cancellationToken) =>
        Task.FromResult<IReadOnlyList<DeviceDashboardRow>>(new[]
        {
            new DeviceDashboardRow("SCX-DEVKIT-001", "Lab DevKit", "Online", -48, "0.1.0", DateTimeOffset.UtcNow.AddMinutes(-1)),
            new DeviceDashboardRow("SCX-FACTORY-014", "Factory Station 14", "Provisioning", -61, "0.1.0", DateTimeOffset.UtcNow.AddMinutes(-6)),
            new DeviceDashboardRow("SCX-FLEET-087", "Conference Room Sensor", "Online", -55, "0.1.0", DateTimeOffset.UtcNow.AddMinutes(-3))
        });

    public Task<IReadOnlyList<ActivityEvent>> GetActivityAsync(CancellationToken cancellationToken) =>
        Task.FromResult<IReadOnlyList<ActivityEvent>>(new[]
        {
            new ActivityEvent("Info", "Telemetry accepted", "SCX-DEVKIT-001 uploaded a live telemetry packet.", DateTimeOffset.UtcNow.AddMinutes(-1)),
            new ActivityEvent("Warning", "Provisioning retry", "SCX-FACTORY-014 requested Wi-Fi provisioning retry.", DateTimeOffset.UtcNow.AddMinutes(-8)),
            new ActivityEvent("Info", "Firmware manifest checked", "Five rev-a devices are eligible for 0.1.1.", DateTimeOffset.UtcNow.AddMinutes(-12))
        });

    public Task<FirmwareRolloutStatus> GetFirmwareRolloutAsync(CancellationToken cancellationToken) =>
        Task.FromResult(new FirmwareRolloutStatus("0.1.1", "rev-a", 18, 13, 0));
}
