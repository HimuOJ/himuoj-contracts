using Refit;

namespace HimuOJ.Contracts.Refit;

public interface IHelloApi
{
    [Get("/api/v1/hello")]
    Task<HelloResponse> GetHelloAsync(CancellationToken cancellationToken = default);
}

public sealed record HelloResponse(string Message, DateTimeOffset Timestamp);
