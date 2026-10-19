namespace SanskarConnectX.Protocol.Models;

public readonly record struct MessageVersion(int Major, int Minor)
{
    public static MessageVersion Current => new(1, 0);
    public override string ToString() => $"{Major}.{Minor}";
}
