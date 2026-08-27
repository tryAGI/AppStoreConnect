#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterBundleId"></param>
        /// <param name="fieldsAppClips"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsAppClipDefaultExperiences"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitAppClipDefaultExperiences"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppClipsResponse> AppsAppClipsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterBundleId = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppClipsGetToManyRelatedFieldsAppClip>? fieldsAppClips = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppClipsGetToManyRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppClipsGetToManyRelatedFieldsAppClipDefaultExperience>? fieldsAppClipDefaultExperiences = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppClipsGetToManyRelatedIncludeItem>? include = default,
            int? limitAppClipDefaultExperiences = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterBundleId"></param>
        /// <param name="fieldsAppClips"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsAppClipDefaultExperiences"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitAppClipDefaultExperiences"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppClipsResponse>> AppsAppClipsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterBundleId = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppClipsGetToManyRelatedFieldsAppClip>? fieldsAppClips = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppClipsGetToManyRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppClipsGetToManyRelatedFieldsAppClipDefaultExperience>? fieldsAppClipDefaultExperiences = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppClipsGetToManyRelatedIncludeItem>? include = default,
            int? limitAppClipDefaultExperiences = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}