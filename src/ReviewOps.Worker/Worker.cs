namespace ReviewOps.Worker;

public sealed partial class Worker(ILogger<Worker> logger) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            if (logger.IsEnabled(LogLevel.Information))
            {
                LogWorkerRunning(logger, DateTimeOffset.UtcNow);
            }

            await Task.Delay(1000, stoppingToken);
        }
    }

    [LoggerMessage(EventId = 1, Level = LogLevel.Information, Message = "Worker running at: {Timestamp}")]
    private static partial void LogWorkerRunning(ILogger logger, DateTimeOffset timestamp);
}
