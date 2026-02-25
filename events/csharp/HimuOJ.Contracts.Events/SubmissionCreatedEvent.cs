namespace HimuOJ.Contracts.Events;

public sealed record SubmissionCreatedEvent
{
    public Guid EventId { get; init; }
    public Guid SubmissionId { get; init; }
    public Guid ProblemId { get; init; }
    public Guid UserId { get; init; }
    public string Language { get; init; } = string.Empty;
    public string SourceCodePath { get; init; } = string.Empty;
    public DateTimeOffset CreatedAt { get; init; }
}
