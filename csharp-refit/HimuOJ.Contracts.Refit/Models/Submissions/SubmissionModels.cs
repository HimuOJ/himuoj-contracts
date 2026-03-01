using HimuOJ.Contracts.Refit.Models;

namespace HimuOJ.Contracts.Refit.Models.Submissions;

public sealed record SubmissionSummary(
    [property: System.Text.Json.Serialization.JsonPropertyName("id")] long Id,
    [property: System.Text.Json.Serialization.JsonPropertyName("userId")] long UserId,
    [property: System.Text.Json.Serialization.JsonPropertyName("problemId")] long ProblemId,
    [property: System.Text.Json.Serialization.JsonPropertyName("language")] string Language,
    [property: System.Text.Json.Serialization.JsonPropertyName("status")] JudgeStatus Status,
    [property: System.Text.Json.Serialization.JsonPropertyName("maxTimeConsumedMs")] int MaxTimeConsumedMs,
    [property: System.Text.Json.Serialization.JsonPropertyName("maxMemoryConsumedKb")] int MaxMemoryConsumedKb,
    [property: System.Text.Json.Serialization.JsonPropertyName("submittedAt")] DateTimeOffset SubmittedAt
);

public sealed record SubmissionDetail(
    [property: System.Text.Json.Serialization.JsonPropertyName("id")] long Id,
    [property: System.Text.Json.Serialization.JsonPropertyName("userId")] long UserId,
    [property: System.Text.Json.Serialization.JsonPropertyName("problemId")] long ProblemId,
    [property: System.Text.Json.Serialization.JsonPropertyName("language")] string Language,
    [property: System.Text.Json.Serialization.JsonPropertyName("status")] JudgeStatus Status,
    [property: System.Text.Json.Serialization.JsonPropertyName("maxTimeConsumedMs")] int MaxTimeConsumedMs,
    [property: System.Text.Json.Serialization.JsonPropertyName("maxMemoryConsumedKb")] int MaxMemoryConsumedKb,
    [property: System.Text.Json.Serialization.JsonPropertyName("submittedAt")] DateTimeOffset SubmittedAt,
    [property: System.Text.Json.Serialization.JsonPropertyName("codeUploadId")] string CodeUploadId
);

public sealed record CreateSubmissionRequest(
    [property: System.Text.Json.Serialization.JsonPropertyName("problemId")] long ProblemId,
    [property: System.Text.Json.Serialization.JsonPropertyName("language")] string Language,
    [property: System.Text.Json.Serialization.JsonPropertyName("codeUploadId")] string CodeUploadId
);

public sealed record SubmissionAcceptedResponse(
    [property: System.Text.Json.Serialization.JsonPropertyName("submissionId")] long SubmissionId,
    [property: System.Text.Json.Serialization.JsonPropertyName("status")] JudgeStatus Status
);

public sealed record PagedSubmissionSummaryResponse(
    [property: System.Text.Json.Serialization.JsonPropertyName("items")] IReadOnlyList<SubmissionSummary> Items,
    [property: System.Text.Json.Serialization.JsonPropertyName("meta")] PageMeta Meta
);

public sealed record TestCaseResultDetail(
    [property: System.Text.Json.Serialization.JsonPropertyName("id")] long Id,
    [property: System.Text.Json.Serialization.JsonPropertyName("submissionId")] long SubmissionId,
    [property: System.Text.Json.Serialization.JsonPropertyName("testCaseId")] long TestCaseId,
    [property: System.Text.Json.Serialization.JsonPropertyName("status")] JudgeStatus Status,
    [property: System.Text.Json.Serialization.JsonPropertyName("timeConsumedMs")] int TimeConsumedMs,
    [property: System.Text.Json.Serialization.JsonPropertyName("memoryConsumedKb")] int MemoryConsumedKb,
    [property: System.Text.Json.Serialization.JsonPropertyName("actualOutputUploadId")] string? ActualOutputUploadId,
    [property: System.Text.Json.Serialization.JsonPropertyName("errorMessage")] string? ErrorMessage
);

public sealed record TestCaseResultListResponse(
    [property: System.Text.Json.Serialization.JsonPropertyName("items")] IReadOnlyList<TestCaseResultDetail> Items
);
