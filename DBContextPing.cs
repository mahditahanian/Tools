public interface IMyDbContext : IDisposable
{
    Task Ping(CancellationToken cancellationToken);
}

public class MyMssqlDbContext : DbContext, IMyDbContext
{
    public async Task Ping(CancellationToken cancellationToken)
    {
         await Database
                .ExecuteSqlRawAsync("SELECT 1;", cancellationToken)
                .ConfigureAwait(false);
    }
}
