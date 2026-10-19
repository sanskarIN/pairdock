using SanskarConnectX.Application.Abstractions;
using SanskarConnectX.Application.Common;
using SanskarConnectX.Application.DTOs;
using SanskarConnectX.Application.Validation;
using SanskarConnectX.Domain.Entities;

namespace SanskarConnectX.Application.Services;

public sealed class DeviceService : IDeviceService
{
    private readonly IDeviceRepository devices;
    private readonly ICommandRepository commands;
    private readonly IDeviceOwnershipRepository ownerships;
    private readonly IUnitOfWork unitOfWork;

    public DeviceService(IDeviceRepository devices, ICommandRepository commands, IDeviceOwnershipRepository ownerships, IUnitOfWork unitOfWork)
    {
        this.devices = devices;
        this.commands = commands;
        this.ownerships = ownerships;
        this.unitOfWork = unitOfWork;
    }

    public async Task<ApiResult<IReadOnlyList<DeviceDto>>> ListAsync(CancellationToken cancellationToken)
    {
        var items = await devices.ListAsync(cancellationToken);
        return ApiResult<IReadOnlyList<DeviceDto>>.Success(items.Select(ToDto).ToList());
    }

    public async Task<ApiResult<DeviceDto>> RegisterAsync(RegisterDeviceRequest request, CancellationToken cancellationToken)
    {
        if (!RequestValidator.HasDeviceId(request.DeviceId) || !RequestValidator.HasSerialNumber(request.SerialNumber) || !RequestValidator.HasDisplayName(request.DisplayName))
        {
            return ApiResult<DeviceDto>.Failure("validation_failed", "DeviceId, serial number, display name, and hardware revision are required.");
        }

        var existingDevice = await devices.FindByDeviceIdAsync(request.DeviceId, cancellationToken);
        if (existingDevice is not null)
        {
            return ApiResult<DeviceDto>.Failure("device_exists", "A device with this device ID already exists.");
        }

        var existingSerial = await devices.FindBySerialNumberAsync(request.SerialNumber, cancellationToken);
        if (existingSerial is not null)
        {
            return ApiResult<DeviceDto>.Failure("serial_exists", "A device with this serial number already exists.");
        }

        var device = new Device(request.DeviceId, request.SerialNumber, request.DisplayName, request.HardwareRevision);
        await devices.AddAsync(device, cancellationToken);

        if (request.OwnerUserId is Guid ownerUserId && !await ownerships.ExistsAsync(ownerUserId, device.Id, cancellationToken))
        {
            await ownerships.AddAsync(new DeviceOwnership(ownerUserId, device.Id, "Owner"), cancellationToken);
        }

        await unitOfWork.SaveChangesAsync(cancellationToken);
        return ApiResult<DeviceDto>.Success(ToDto(device));
    }

    public async Task<ApiResult<DeviceCommandDto>> QueueCommandAsync(string deviceId, CreateDeviceCommandRequest request, CancellationToken cancellationToken)
    {
        var device = await devices.FindByDeviceIdAsync(deviceId, cancellationToken);
        if (device is null)
        {
            return ApiResult<DeviceCommandDto>.Failure("device_not_found", "Device was not found.");
        }

        if (string.IsNullOrWhiteSpace(request.CommandType) || !RequestValidator.IsLikelyJsonObject(request.PayloadJson))
        {
            return ApiResult<DeviceCommandDto>.Failure("validation_failed", "Command type and JSON object payload are required.");
        }

        var command = new DeviceCommand(device.Id, request.CommandType, request.PayloadJson);
        await commands.AddAsync(command, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return ApiResult<DeviceCommandDto>.Success(new DeviceCommandDto(command.Id, command.DeviceId, command.CommandType, command.PayloadJson, command.Status));
    }

    private static DeviceDto ToDto(Device device) =>
        new(device.Id, device.DeviceId, device.SerialNumber, device.DisplayName, device.FirmwareVersion, device.ConnectionState, device.LastSeenUtc);
}
