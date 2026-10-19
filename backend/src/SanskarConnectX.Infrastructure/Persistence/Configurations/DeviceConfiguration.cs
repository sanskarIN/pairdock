using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SanskarConnectX.Domain.Entities;

namespace SanskarConnectX.Infrastructure.Persistence.Configurations;

public sealed class DeviceConfiguration : IEntityTypeConfiguration<Device>
{
    public void Configure(EntityTypeBuilder<Device> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.DeviceId).HasMaxLength(64).IsRequired();
        builder.Property(x => x.SerialNumber).HasMaxLength(64).IsRequired();
        builder.Property(x => x.DisplayName).HasMaxLength(160).IsRequired();
        builder.Property(x => x.FirmwareVersion).HasMaxLength(64).IsRequired();
        builder.Property(x => x.HardwareRevision).HasMaxLength(64).IsRequired();
        builder.Property(x => x.ConnectionState).HasConversion<string>().HasMaxLength(32).IsRequired();
        builder.HasIndex(x => x.DeviceId).IsUnique();
        builder.HasIndex(x => x.SerialNumber).IsUnique();
        builder.HasIndex(x => x.ConnectionState);
    }
}
