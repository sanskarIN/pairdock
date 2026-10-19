namespace SanskarConnectX.Domain.ValueObjects;

public readonly record struct DeviceIdentifier(string Value)
{
    public override string ToString() => Value;
}

