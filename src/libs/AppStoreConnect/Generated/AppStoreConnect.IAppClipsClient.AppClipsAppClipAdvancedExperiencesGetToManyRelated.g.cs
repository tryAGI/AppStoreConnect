#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppClipsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterStatus"></param>
        /// <param name="filterPlaceStatus"></param>
        /// <param name="filterAction"></param>
        /// <param name="fieldsAppClipAdvancedExperiences"></param>
        /// <param name="fieldsAppClips"></param>
        /// <param name="fieldsAppClipAdvancedExperienceImages"></param>
        /// <param name="fieldsAppClipAdvancedExperienceLocalizations"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppClipAdvancedExperiencesResponse> AppClipsAppClipAdvancedExperiencesGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterStatu>? filterStatus = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterPlaceStatu>? filterPlaceStatus = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterActionItem>? filterAction = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience>? fieldsAppClipAdvancedExperiences = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClip>? fieldsAppClips = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceImage>? fieldsAppClipAdvancedExperienceImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceLocalization>? fieldsAppClipAdvancedExperienceLocalizations = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedIncludeItem>? include = default,
            int? limitLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterStatus"></param>
        /// <param name="filterPlaceStatus"></param>
        /// <param name="filterAction"></param>
        /// <param name="fieldsAppClipAdvancedExperiences"></param>
        /// <param name="fieldsAppClips"></param>
        /// <param name="fieldsAppClipAdvancedExperienceImages"></param>
        /// <param name="fieldsAppClipAdvancedExperienceLocalizations"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppClipAdvancedExperiencesResponse>> AppClipsAppClipAdvancedExperiencesGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterStatu>? filterStatus = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterPlaceStatu>? filterPlaceStatus = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterActionItem>? filterAction = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperience>? fieldsAppClipAdvancedExperiences = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClip>? fieldsAppClips = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceImage>? fieldsAppClipAdvancedExperienceImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedFieldsAppClipAdvancedExperienceLocalization>? fieldsAppClipAdvancedExperienceLocalizations = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipsAppClipAdvancedExperiencesGetToManyRelatedIncludeItem>? include = default,
            int? limitLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}