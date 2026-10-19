namespace SanskarConnectX.Sdk.Retry;

public sealed class RetryPolicy
{
    public int MaxAttempts { get; init; } = 3;
    public TimeSpan Delay { get; init; } = TimeSpan.FromMilliseconds(250);

    public async Task<T> ExecuteAsync<T>(Func<Task<T>> action)
    {
        Exception? lastError = null;
        for (var attempt = 1; attempt <= MaxAttempts; attempt++)
        {
            try
            {
                return await action();
            }
            catch (Exception ex) when (attempt < MaxAttempts)
            {
                lastError = ex;
                await Task.Delay(Delay);
            }
        }

        throw lastError ?? new InvalidOperationException("Retry failed without exception.");
    }
}

