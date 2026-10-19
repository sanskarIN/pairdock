using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SanskarConnectX.Domain.Entities;

namespace SanskarConnectX.Infrastructure.Persistence.Configurations;

public sealed class TelemetrySampleConfiguration : IEntityTypeConfiguration<TelemetrySample>
{
    public void Configure(EntityTypeBuilder<TelemetrySample> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.PayloadJson).IsRequired();
        builder.HasIndex(x => new { x.DeviceId, x.TimestampUtc });
    }
}
