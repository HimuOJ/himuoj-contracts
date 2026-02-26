using Refit;
using HimuOJ.Contracts.Refit.Models;
using HimuOJ.Contracts.Refit.Models.Submissions;

namespace HimuOJ.Contracts.Refit;

public interface ISubmissionsApi
{
    [Get("/api/v1/submissions")]
    Task<IApiResponse<PagedSubmissionSummaryResponse>> ListSubmissionsAsync(
        [Query] int page = 1,
        [Query] int pageSize = 20,
        [Query] long? userId = null,
        [Query] long? problemId = null,
        [Query] string? language = null,
        [Query] JudgeStatus? status = null,
        CancellationToken cancellationToken = default
    );

    [Post("/api/v1/submissions")]
    Task<IApiResponse<SubmissionAcceptedResponse>> CreateSubmissionAsync(
        [Body] CreateSubmissionRequest request,
        CancellationToken cancellationToken = default
    );

    [Get("/api/v1/submissions/{submissionId}")]
    Task<IApiResponse<SubmissionDetail>> GetSubmissionByIdAsync(
        [AliasAs("submissionId")] long submissionId,
        CancellationToken cancellationToken = default
    );

    [Get("/api/v1/submissions/{submissionId}/test-case-results")]
    Task<IApiResponse<TestCaseResultListResponse>> ListSubmissionTestCaseResultsAsync(
        [AliasAs("submissionId")] long submissionId,
        CancellationToken cancellationToken = default
    );
}
