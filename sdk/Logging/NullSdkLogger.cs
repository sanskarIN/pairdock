namespace SanskarConnectX.Sdk.Logging;

public sealed class NullSdkLogger : ISdkLogger
{
    public void Info(string message)
    {
    }

    public void Warning(string message)
    {
    }

    public void Error(string message, Exception? exception = null)
    {
    }
}

