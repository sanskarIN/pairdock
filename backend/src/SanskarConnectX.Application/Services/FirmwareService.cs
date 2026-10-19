using SanskarConnectX.Application.Abstractions;
using SanskarConnectX.Application.Common;
using SanskarConnectX.Application.DTOs;
using SanskarConnectX.Domain.Entities;

namespace SanskarConnectX.Application.Services;

public sealed class FirmwareService : IFirmwareService
{
    private readonly IFirmwareRepository firmware;
    private readonly IUnitOfWork unitOfWork;

    public FirmwareService(IFirmwareRepository firmware, IUnitOfWork unitOfWork)
    {
        this.firmware = firmware;
        this.unitOfWork = unitOfWork;
    }

    public async Task<ApiResult<IReadOnlyList<FirmwareVersionDto>>> ListAsync(CancellationToken cancellationToken)
    {
        var versions = await firmware.ListAsync(cancellationToken);
        return ApiResult<IReadOnlyList<FirmwareVersionDto>>.Success(versions.Select(ToDto).ToList());
    }

    public async Task<ApiResult<FirmwareVersionDto>> CreateAsync(CreateFirmwareVersionRequest request, CancellationToken cancellationToken)
    {
        var version = new FirmwareVersion(request.Version, request.HardwareRevision, request.PackageUrl, request.Sha256, request.Signature);
        await firmware.AddAsync(version, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return ApiResult<FirmwareVersionDto>.Success(ToDto(version));
    }

    private static FirmwareVersionDto ToDto(FirmwareVersion version) =>
        new(version.Id, version.Version, version.HardwareRevision, version.PackageUrl, version.Sha256, version.IsActive);
}

