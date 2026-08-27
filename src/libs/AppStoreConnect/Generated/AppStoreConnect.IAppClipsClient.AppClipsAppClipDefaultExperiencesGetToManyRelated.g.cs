#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppClipsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="existsReleaseWithAppStoreVersion"></param>
        /// <param name="fieldsAppClipDefaultExperiences"></param>
        /// <param name="fieldsAppClips"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="fieldsAppClipDefaultExperienceLocalizations"></param>
        /// <param name="fieldsAppClipAppStoreReviewDetails"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitAppClipDefaultExperienceLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppClipDefaultExperiencesResponse> AppClipsAppClipDefaultExperiencesGetToManyRelatedAsync(
            string id,
            bool? existsReleaseWithAppStoreVersion = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipDefaultExperience>? fieldsAppClipDefaultExperiences = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClip>? fieldsAppClips = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipDefaultExperienceLocalization>? fieldsAppClipDefaultExperienceLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipAppStoreReviewDetail>? fieldsAppClipAppStoreReviewDetails = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipDefaultExperiencesGetToManyRelatedIncludeItem>? include = default,
            int? limitAppClipDefaultExperienceLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="existsReleaseWithAppStoreVersion"></param>
        /// <param name="fieldsAppClipDefaultExperiences"></param>
        /// <param name="fieldsAppClips"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="fieldsAppClipDefaultExperienceLocalizations"></param>
        /// <param name="fieldsAppClipAppStoreReviewDetails"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitAppClipDefaultExperienceLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppClipDefaultExperiencesResponse>> AppClipsAppClipDefaultExperiencesGetToManyRelatedAsResponseAsync(
            string id,
            bool? existsReleaseWithAppStoreVersion = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipDefaultExperience>? fieldsAppClipDefaultExperiences = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClip>? fieldsAppClips = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipDefaultExperienceLocalization>? fieldsAppClipDefaultExperienceLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppClipAppStoreReviewDetail>? fieldsAppClipAppStoreReviewDetails = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipDefaultExperiencesGetToManyRelatedIncludeItem>? include = default,
            int? limitAppClipDefaultExperienceLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}