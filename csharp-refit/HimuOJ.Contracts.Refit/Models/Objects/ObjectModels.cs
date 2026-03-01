namespace HimuOJ.Contracts.Refit.Models.Objects;

public enum ObjectPurpose
{
    [System.Runtime.Serialization.EnumMember(Value = "problem.description")]
    ProblemDescription,
    [System.Runtime.Serialization.EnumMember(Value = "problem.testcase.input")]
    ProblemTestcaseInput,
    [System.Runtime.Serialization.EnumMember(Value = "problem.testcase.output")]
    ProblemTestcaseOutput,
    [System.Runtime.Serialization.EnumMember(Value = "submission.source-code")]
    SubmissionSourceCode,
    [System.Runtime.Serialization.EnumMember(Value = "judge.actual-output")]
    JudgeActualOutput
}

public enum ObjectPolicy
{
    [System.Runtime.Serialization.EnumMember(Value = "problem-public-read")]
    ProblemPublicRead,
    [System.Runtime.Serialization.EnumMember(Value = "problem-admin-only")]
    ProblemAdminOnly,
    [System.Runtime.Serialization.EnumMember(Value = "submission-owner-private")]
    SubmissionOwnerPrivate,
    [System.Runtime.Serialization.EnumMember(Value = "judge-internal")]
    JudgeInternal
}

public enum ObjectUploadStatus
{
    Initiated,
    Uploaded,
    Completed,
    Expired,
    Cancelled
}

public sealed record CreateObjectUploadRequest(
    [property: System.Text.Json.Serialization.JsonPropertyName("purpose")] ObjectPurpose Purpose,
    [property: System.Text.Json.Serialization.JsonPropertyName("policy")] ObjectPolicy Policy,
    [property: System.Text.Json.Serialization.JsonPropertyName("fileName")] string FileName,
    [property: System.Text.Json.Serialization.JsonPropertyName("contentType")] string ContentType,
    [property: System.Text.Json.Serialization.JsonPropertyName("contentLength")] long ContentLength
);

public sealed record CompleteObjectUploadRequest(
    [property: System.Text.Json.Serialization.JsonPropertyName("sha256")] string? Sha256 = null
);

public sealed record UploadTransport(
    [property: System.Text.Json.Serialization.JsonPropertyName("method")] string Method,
    [property: System.Text.Json.Serialization.JsonPropertyName("uploadUrl")] string? UploadUrl = null,
    [property: System.Text.Json.Serialization.JsonPropertyName("headers")] IReadOnlyDictionary<string, string>? Headers = null,
    [property: System.Text.Json.Serialization.JsonPropertyName("formFields")] IReadOnlyDictionary<string, string>? FormFields = null,
    [property: System.Text.Json.Serialization.JsonPropertyName("expiresAt")] DateTimeOffset? ExpiresAt = null
);

public sealed record ObjectUploadDetail(
    [property: System.Text.Json.Serialization.JsonPropertyName("uploadId")] string UploadId,
    [property: System.Text.Json.Serialization.JsonPropertyName("purpose")] ObjectPurpose Purpose,
    [property: System.Text.Json.Serialization.JsonPropertyName("policy")] ObjectPolicy Policy,
    [property: System.Text.Json.Serialization.JsonPropertyName("fileName")] string FileName,
    [property: System.Text.Json.Serialization.JsonPropertyName("contentType")] string ContentType,
    [property: System.Text.Json.Serialization.JsonPropertyName("contentLength")] long ContentLength,
    [property: System.Text.Json.Serialization.JsonPropertyName("status")] ObjectUploadStatus Status,
    [property: System.Text.Json.Serialization.JsonPropertyName("sha256")] string? Sha256,
    [property: System.Text.Json.Serialization.JsonPropertyName("objectKey")] string? ObjectKey,
    [property: System.Text.Json.Serialization.JsonPropertyName("upload")] UploadTransport? Upload,
    [property: System.Text.Json.Serialization.JsonPropertyName("createdAt")] DateTimeOffset CreatedAt,
    [property: System.Text.Json.Serialization.JsonPropertyName("completedAt")] DateTimeOffset? CompletedAt,
    [property: System.Text.Json.Serialization.JsonPropertyName("expiresAt")] DateTimeOffset? ExpiresAt
);

public sealed record CreateObjectDownloadUrlRequest(
    [property: System.Text.Json.Serialization.JsonPropertyName("ttlSeconds")] int? TtlSeconds = null
);

public sealed record ObjectDownloadUrlResponse(
    [property: System.Text.Json.Serialization.JsonPropertyName("downloadUrl")] string DownloadUrl,
    [property: System.Text.Json.Serialization.JsonPropertyName("expiresAt")] DateTimeOffset ExpiresAt
);
