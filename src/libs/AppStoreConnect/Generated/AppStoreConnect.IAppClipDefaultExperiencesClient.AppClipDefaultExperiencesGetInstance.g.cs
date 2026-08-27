#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppClipDefaultExperiencesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppClipDefaultExperiences"></param>
        /// <param name="fieldsAppClips"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="fieldsAppClipDefaultExperienceLocalizations"></param>
        /// <param name="fieldsAppClipAppStoreReviewDetails"></param>
        /// <param name="include"></param>
        /// <param name="limitAppClipDefaultExperienceLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppClipDefaultExperienceResponse> AppClipDefaultExperiencesGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesGetInstanceFieldsAppClipDefaultExperience>? fieldsAppClipDefaultExperiences = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesGetInstanceFieldsAppClip>? fieldsAppClips = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesGetInstanceFieldsAppClipDefaultExperienceLocalization>? fieldsAppClipDefaultExperienceLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesGetInstanceFieldsAppClipAppStoreReviewDetail>? fieldsAppClipAppStoreReviewDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesGetInstanceIncludeItem>? include = default,
            int? limitAppClipDefaultExperienceLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppClipDefaultExperiences"></param>
        /// <param name="fieldsAppClips"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="fieldsAppClipDefaultExperienceLocalizations"></param>
        /// <param name="fieldsAppClipAppStoreReviewDetails"></param>
        /// <param name="include"></param>
        /// <param name="limitAppClipDefaultExperienceLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppClipDefaultExperienceResponse>> AppClipDefaultExperiencesGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesGetInstanceFieldsAppClipDefaultExperience>? fieldsAppClipDefaultExperiences = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesGetInstanceFieldsAppClip>? fieldsAppClips = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesGetInstanceFieldsAppClipDefaultExperienceLocalization>? fieldsAppClipDefaultExperienceLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesGetInstanceFieldsAppClipAppStoreReviewDetail>? fieldsAppClipAppStoreReviewDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesGetInstanceIncludeItem>? include = default,
            int? limitAppClipDefaultExperienceLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}