using HimuOJ.Contracts.Refit.Models;

namespace HimuOJ.Contracts.Refit.Models.Problems;

public sealed record ProblemSummary(
    [property: System.Text.Json.Serialization.JsonPropertyName("id")] long Id,
    [property: System.Text.Json.Serialization.JsonPropertyName("title")] string Title,
    [property: System.Text.Json.Serialization.JsonPropertyName("timeLimitMs")] int TimeLimitMs,
    [property: System.Text.Json.Serialization.JsonPropertyName("memoryLimitKb")] int MemoryLimitKb,
    [property: System.Text.Json.Serialization.JsonPropertyName("authorId")] long AuthorId,
    [property: System.Text.Json.Serialization.JsonPropertyName("createdAt")] DateTimeOffset CreatedAt
);

public sealed record ProblemDetail(
    [property: System.Text.Json.Serialization.JsonPropertyName("id")] long Id,
    [property: System.Text.Json.Serialization.JsonPropertyName("title")] string Title,
    [property: System.Text.Json.Serialization.JsonPropertyName("timeLimitMs")] int TimeLimitMs,
    [property: System.Text.Json.Serialization.JsonPropertyName("memoryLimitKb")] int MemoryLimitKb,
    [property: System.Text.Json.Serialization.JsonPropertyName("authorId")] long AuthorId,
    [property: System.Text.Json.Serialization.JsonPropertyName("createdAt")] DateTimeOffset CreatedAt,
    [property: System.Text.Json.Serialization.JsonPropertyName("descriptionObjectId")] string DescriptionObjectId
);

public sealed record CreateProblemRequest(
    [property: System.Text.Json.Serialization.JsonPropertyName("title")] string Title,
    [property: System.Text.Json.Serialization.JsonPropertyName("descriptionObjectId")] string DescriptionObjectId,
    [property: System.Text.Json.Serialization.JsonPropertyName("timeLimitMs")] int TimeLimitMs,
    [property: System.Text.Json.Serialization.JsonPropertyName("memoryLimitKb")] int MemoryLimitKb
);

public sealed record UpdateProblemRequest(
    [property: System.Text.Json.Serialization.JsonPropertyName("title")] string? Title = null,
    [property: System.Text.Json.Serialization.JsonPropertyName("descriptionObjectId")] string? DescriptionObjectId = null,
    [property: System.Text.Json.Serialization.JsonPropertyName("timeLimitMs")] int? TimeLimitMs = null,
    [property: System.Text.Json.Serialization.JsonPropertyName("memoryLimitKb")] int? MemoryLimitKb = null
);

public sealed record TestCaseDetail(
    [property: System.Text.Json.Serialization.JsonPropertyName("id")] long Id,
    [property: System.Text.Json.Serialization.JsonPropertyName("problemId")] long ProblemId,
    [property: System.Text.Json.Serialization.JsonPropertyName("inputObjectKey")] string InputObjectKey,
    [property: System.Text.Json.Serialization.JsonPropertyName("expectedOutputObjectKey")] string ExpectedOutputObjectKey,
    [property: System.Text.Json.Serialization.JsonPropertyName("scoreWeight")] int ScoreWeight,
    [property: System.Text.Json.Serialization.JsonPropertyName("isHidden")] bool IsHidden
);

public sealed record CreateTestCaseRequest(
    [property: System.Text.Json.Serialization.JsonPropertyName("inputObjectKey")] string InputObjectKey,
    [property: System.Text.Json.Serialization.JsonPropertyName("expectedOutputObjectKey")] string ExpectedOutputObjectKey,
    [property: System.Text.Json.Serialization.JsonPropertyName("scoreWeight")] int ScoreWeight,
    [property: System.Text.Json.Serialization.JsonPropertyName("isHidden")] bool IsHidden
);

public sealed record UpdateTestCaseRequest(
    [property: System.Text.Json.Serialization.JsonPropertyName("inputObjectKey")] string? InputObjectKey = null,
    [property: System.Text.Json.Serialization.JsonPropertyName("expectedOutputObjectKey")] string? ExpectedOutputObjectKey = null,
    [property: System.Text.Json.Serialization.JsonPropertyName("scoreWeight")] int? ScoreWeight = null,
    [property: System.Text.Json.Serialization.JsonPropertyName("isHidden")] bool? IsHidden = null
);

public sealed record PagedProblemSummaryResponse(
    [property: System.Text.Json.Serialization.JsonPropertyName("items")] IReadOnlyList<ProblemSummary> Items,
    [property: System.Text.Json.Serialization.JsonPropertyName("meta")] PageMeta Meta
);

public sealed record TestCaseListResponse(
    [property: System.Text.Json.Serialization.JsonPropertyName("items")] IReadOnlyList<TestCaseDetail> Items
);
