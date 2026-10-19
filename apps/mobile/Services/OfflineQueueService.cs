namespace SanskarConnectX.Mobile.Services;

public sealed class OfflineQueueService
{
    private readonly Queue<string> operations = new();

    public void Enqueue(string operation) => operations.Enqueue(operation);
    public int Count => operations.Count;
}

