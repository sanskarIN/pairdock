using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SanskarConnectX.Domain.Entities;

namespace SanskarConnectX.Infrastructure.Persistence.Configurations;

public sealed class FirmwareVersionConfiguration : IEntityTypeConfiguration<FirmwareVersion>
{
    public void Configure(EntityTypeBuilder<FirmwareVersion> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Version).HasMaxLength(64).IsRequired();
        builder.Property(x => x.HardwareRevision).HasMaxLength(64).IsRequired();
        builder.Property(x => x.PackageUrl).IsRequired();
        builder.Property(x => x.Sha256).HasMaxLength(64).IsRequired();
        builder.Property(x => x.Signature).IsRequired();
        builder.HasIndex(x => new { x.Version, x.HardwareRevision }).IsUnique();
        builder.HasIndex(x => x.IsActive);
    }
}
