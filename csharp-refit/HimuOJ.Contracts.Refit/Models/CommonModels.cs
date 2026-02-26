namespace HimuOJ.Contracts.Refit.Models;

public sealed record PageMeta(
    [property: System.Text.Json.Serialization.JsonPropertyName("page")] int Page,
    [property: System.Text.Json.Serialization.JsonPropertyName("pageSize")] int PageSize,
    [property: System.Text.Json.Serialization.JsonPropertyName("totalItems")] int TotalItems,
    [property: System.Text.Json.Serialization.JsonPropertyName("totalPages")] int TotalPages
);

public sealed record ProblemDetails(
    [property: System.Text.Json.Serialization.JsonPropertyName("type")] string? Type,
    [property: System.Text.Json.Serialization.JsonPropertyName("title")] string Title,
    [property: System.Text.Json.Serialization.JsonPropertyName("status")] int Status,
    [property: System.Text.Json.Serialization.JsonPropertyName("detail")] string? Detail,
    [property: System.Text.Json.Serialization.JsonPropertyName("instance")] string? Instance
);

public enum JudgeStatus
{
    Pending,
    Running,
    Accepted,
    WrongAnswer,
    TimeLimitExceeded,
    MemoryLimitExceeded,
    RuntimeError,
    CompilationError,
    SystemError
}
