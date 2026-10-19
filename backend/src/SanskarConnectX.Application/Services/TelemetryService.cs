using SanskarConnectX.Application.Abstractions;
using SanskarConnectX.Application.Common;
using SanskarConnectX.Application.DTOs;
using SanskarConnectX.Domain.Entities;
using SanskarConnectX.Domain.Enums;

namespace SanskarConnectX.Application.Services;

public sealed class TelemetryService : ITelemetryService
{
    private readonly IDeviceRepository devices;
    private readonly ITelemetryRepository telemetry;
    private readonly IUnitOfWork unitOfWork;

    public TelemetryService(IDeviceRepository devices, ITelemetryRepository telemetry, IUnitOfWork unitOfWork)
    {
        this.devices = devices;
        this.telemetry = telemetry;
        this.unitOfWork = unitOfWork;
    }

    public async Task<ApiResult<string>> IngestAsync(TelemetryIngestRequest request, CancellationToken cancellationToken)
    {
        var device = await devices.FindByDeviceIdAsync(request.DeviceId, cancellationToken);
        if (device is null)
        {
            return ApiResult<string>.Failure("device_not_registered", "Device must be registered before telemetry ingestion.");
        }

        device.MarkSeen(DeviceConnectionState.Online, "unknown", request.TimestampUtc);
        await telemetry.AddAsync(new TelemetrySample(device.Id, request.TimestampUtc, request.Rssi, request.TemperatureCelsius, request.SupplyMillivolts, request.PayloadJson), cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return ApiResult<string>.Success("accepted");
    }
}
