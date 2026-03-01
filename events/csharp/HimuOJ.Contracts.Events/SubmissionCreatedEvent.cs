namespace HimuOJ.Contracts.Events;

public sealed record SubmissionCreatedEvent
{
    public Guid EventId { get; init; }
    public long SubmissionId { get; init; }
    public long ProblemId { get; init; }
    public long UserId { get; init; }
    public string Language { get; init; } = string.Empty;
    public string CodeUploadId { get; init; } = string.Empty;
    public DateTimeOffset CreatedAt { get; init; }
}
