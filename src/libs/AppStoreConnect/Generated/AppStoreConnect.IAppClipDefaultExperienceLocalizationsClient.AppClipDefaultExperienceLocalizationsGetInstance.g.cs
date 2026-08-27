#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppClipDefaultExperienceLocalizationsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppClipDefaultExperienceLocalizations"></param>
        /// <param name="fieldsAppClipDefaultExperiences"></param>
        /// <param name="fieldsAppClipHeaderImages"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppClipDefaultExperienceLocalizationResponse> AppClipDefaultExperienceLocalizationsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperienceLocalization>? fieldsAppClipDefaultExperienceLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperience>? fieldsAppClipDefaultExperiences = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipHeaderImage>? fieldsAppClipHeaderImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperienceLocalizationsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppClipDefaultExperienceLocalizations"></param>
        /// <param name="fieldsAppClipDefaultExperiences"></param>
        /// <param name="fieldsAppClipHeaderImages"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppClipDefaultExperienceLocalizationResponse>> AppClipDefaultExperienceLocalizationsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperienceLocalization>? fieldsAppClipDefaultExperienceLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipDefaultExperience>? fieldsAppClipDefaultExperiences = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperienceLocalizationsGetInstanceFieldsAppClipHeaderImage>? fieldsAppClipHeaderImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperienceLocalizationsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}