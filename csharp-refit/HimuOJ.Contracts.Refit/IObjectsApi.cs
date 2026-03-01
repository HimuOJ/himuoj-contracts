using HimuOJ.Contracts.Refit.Models.Objects;
using Refit;

namespace HimuOJ.Contracts.Refit;

public interface IObjectsApi
{
    [Post("/api/v1/objects/uploads")]
    Task<IApiResponse<ObjectUploadDetail>> CreateObjectUploadAsync(
        [Body] CreateObjectUploadRequest request,
        CancellationToken cancellationToken = default
    );

    [Post("/api/v1/objects/uploads/{uploadId}/complete")]
    Task<IApiResponse<ObjectUploadDetail>> CompleteObjectUploadAsync(
        [AliasAs("uploadId")] string uploadId,
        [Body] CompleteObjectUploadRequest request,
        CancellationToken cancellationToken = default
    );

    [Get("/api/v1/objects/uploads/{uploadId}")]
    Task<IApiResponse<ObjectUploadDetail>> GetObjectUploadByIdAsync(
        [AliasAs("uploadId")] string uploadId,
        CancellationToken cancellationToken = default
    );

    [Post("/api/v1/objects/uploads/{uploadId}/download-url")]
    Task<IApiResponse<ObjectDownloadUrlResponse>> CreateObjectDownloadUrlAsync(
        [AliasAs("uploadId")] string uploadId,
        [Body] CreateObjectDownloadUrlRequest request,
        CancellationToken cancellationToken = default
    );
}
