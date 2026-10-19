namespace SanskarConnectX.Sdk.Logging;

public interface ISdkLogger
{
    void Info(string message);
    void Warning(string message);
    void Error(string message, Exception? exception = null);
}
