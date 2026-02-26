using Refit;
using HimuOJ.Contracts.Refit.Models;
using HimuOJ.Contracts.Refit.Models.Problems;

namespace HimuOJ.Contracts.Refit;

public interface IProblemsApi
{
    [Get("/api/v1/problems")]
    Task<IApiResponse<PagedProblemSummaryResponse>> ListProblemsAsync(
        [Query] int page = 1,
        [Query] int pageSize = 20,
        [Query] long? authorId = null,
        CancellationToken cancellationToken = default
    );

    [Post("/api/v1/problems")]
    Task<IApiResponse<ProblemDetail>> CreateProblemAsync(
        [Body] CreateProblemRequest request,
        CancellationToken cancellationToken = default
    );

    [Get("/api/v1/problems/{problemId}")]
    Task<IApiResponse<ProblemDetail>> GetProblemByIdAsync(
        [AliasAs("problemId")] long problemId,
        CancellationToken cancellationToken = default
    );

    [Patch("/api/v1/problems/{problemId}")]
    Task<IApiResponse<ProblemDetail>> UpdateProblemAsync(
        [AliasAs("problemId")] long problemId,
        [Body] UpdateProblemRequest request,
        CancellationToken cancellationToken = default
    );

    [Get("/api/v1/problems/{problemId}/test-cases")]
    Task<IApiResponse<TestCaseListResponse>> ListProblemTestCasesAsync(
        [AliasAs("problemId")] long problemId,
        [Query] bool includeHidden = false,
        CancellationToken cancellationToken = default
    );

    [Post("/api/v1/problems/{problemId}/test-cases")]
    Task<IApiResponse<TestCaseDetail>> CreateProblemTestCaseAsync(
        [AliasAs("problemId")] long problemId,
        [Body] CreateTestCaseRequest request,
        CancellationToken cancellationToken = default
    );

    [Patch("/api/v1/problems/{problemId}/test-cases/{testCaseId}")]
    Task<IApiResponse<TestCaseDetail>> UpdateProblemTestCaseAsync(
        [AliasAs("problemId")] long problemId,
        [AliasAs("testCaseId")] long testCaseId,
        [Body] UpdateTestCaseRequest request,
        CancellationToken cancellationToken = default
    );

    [Delete("/api/v1/problems/{problemId}/test-cases/{testCaseId}")]
    Task<IApiResponse> DeleteProblemTestCaseAsync(
        [AliasAs("problemId")] long problemId,
        [AliasAs("testCaseId")] long testCaseId,
        CancellationToken cancellationToken = default
    );
}
