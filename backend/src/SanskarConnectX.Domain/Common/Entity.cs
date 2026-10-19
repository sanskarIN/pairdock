namespace SanskarConnectX.Domain.Common;

public abstract class Entity
{
    public Guid Id { get; protected set; } = Guid.NewGuid();
    public DateTimeOffset CreatedUtc { get; protected set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? UpdatedUtc { get; protected set; }

    public void Touch(DateTimeOffset timestampUtc)
    {
        UpdatedUtc = timestampUtc;
    }
}

