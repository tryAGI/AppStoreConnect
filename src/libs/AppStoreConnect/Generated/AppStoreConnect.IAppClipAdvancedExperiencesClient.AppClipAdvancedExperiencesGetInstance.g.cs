#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppClipAdvancedExperiencesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppClipAdvancedExperiences"></param>
        /// <param name="fieldsAppClips"></param>
        /// <param name="fieldsAppClipAdvancedExperienceImages"></param>
        /// <param name="fieldsAppClipAdvancedExperienceLocalizations"></param>
        /// <param name="include"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppClipAdvancedExperienceResponse> AppClipAdvancedExperiencesGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperience>? fieldsAppClipAdvancedExperiences = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipAdvancedExperiencesGetInstanceFieldsAppClip>? fieldsAppClips = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperienceImage>? fieldsAppClipAdvancedExperienceImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperienceLocalization>? fieldsAppClipAdvancedExperienceLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipAdvancedExperiencesGetInstanceIncludeItem>? include = default,
            int? limitLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppClipAdvancedExperiences"></param>
        /// <param name="fieldsAppClips"></param>
        /// <param name="fieldsAppClipAdvancedExperienceImages"></param>
        /// <param name="fieldsAppClipAdvancedExperienceLocalizations"></param>
        /// <param name="include"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppClipAdvancedExperienceResponse>> AppClipAdvancedExperiencesGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperience>? fieldsAppClipAdvancedExperiences = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipAdvancedExperiencesGetInstanceFieldsAppClip>? fieldsAppClips = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperienceImage>? fieldsAppClipAdvancedExperienceImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipAdvancedExperiencesGetInstanceFieldsAppClipAdvancedExperienceLocalization>? fieldsAppClipAdvancedExperienceLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipAdvancedExperiencesGetInstanceIncludeItem>? include = default,
            int? limitLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}