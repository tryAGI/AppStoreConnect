#nullable enable

namespace AppStoreConnect
{
    public partial interface IBuildBetaDetailsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterBuild"></param>
        /// <param name="filterId"></param>
        /// <param name="fieldsBuildBetaDetails"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BuildBetaDetailsResponse> BuildBetaDetailsGetCollectionAsync(
            global::System.Collections.Generic.IList<string>? filterBuild = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsGetCollectionFieldsBuildBetaDetail>? fieldsBuildBetaDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsGetCollectionFieldsBuild>? fieldsBuilds = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsGetCollectionIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterBuild"></param>
        /// <param name="filterId"></param>
        /// <param name="fieldsBuildBetaDetails"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BuildBetaDetailsResponse>> BuildBetaDetailsGetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<string>? filterBuild = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsGetCollectionFieldsBuildBetaDetail>? fieldsBuildBetaDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsGetCollectionFieldsBuild>? fieldsBuilds = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsGetCollectionIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}