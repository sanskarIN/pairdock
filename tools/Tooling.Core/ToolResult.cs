namespace SanskarConnectX.Tools.Core;

public sealed record ToolResult(bool Succeeded, string Message)
{
    public static ToolResult Success(string message) => new(true, message);
    public static ToolResult Failure(string message) => new(false, message);
}

