#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppClipDefaultExperienceLocalizationsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppClipHeaderImages"></param>
        /// <param name="fieldsAppClipDefaultExperienceLocalizations"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppClipHeaderImageResponse> AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipHeaderImage>? fieldsAppClipHeaderImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipDefaultExperienceLocalization>? fieldsAppClipDefaultExperienceLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppClipHeaderImages"></param>
        /// <param name="fieldsAppClipDefaultExperienceLocalizations"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppClipHeaderImageResponse>> AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipHeaderImage>? fieldsAppClipHeaderImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedFieldsAppClipDefaultExperienceLocalization>? fieldsAppClipDefaultExperienceLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperienceLocalizationsAppClipHeaderImageGetToOneRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}