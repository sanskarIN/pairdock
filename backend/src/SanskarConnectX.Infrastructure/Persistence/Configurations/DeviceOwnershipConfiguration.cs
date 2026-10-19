using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SanskarConnectX.Domain.Entities;

namespace SanskarConnectX.Infrastructure.Persistence.Configurations;

public sealed class DeviceOwnershipConfiguration : IEntityTypeConfiguration<DeviceOwnership>
{
    public void Configure(EntityTypeBuilder<DeviceOwnership> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Relationship).HasMaxLength(32).IsRequired();
        builder.HasIndex(x => new { x.UserId, x.DeviceId }).IsUnique();
    }
}
