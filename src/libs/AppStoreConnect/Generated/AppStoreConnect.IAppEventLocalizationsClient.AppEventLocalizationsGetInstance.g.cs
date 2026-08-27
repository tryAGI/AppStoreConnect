#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppEventLocalizationsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppEventLocalizations"></param>
        /// <param name="fieldsAppEvents"></param>
        /// <param name="fieldsAppEventScreenshots"></param>
        /// <param name="fieldsAppEventVideoClips"></param>
        /// <param name="include"></param>
        /// <param name="limitAppEventScreenshots"></param>
        /// <param name="limitAppEventVideoClips"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppEventLocalizationResponse> AppEventLocalizationsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEventLocalization>? fieldsAppEventLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEvent>? fieldsAppEvents = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEventScreenshot>? fieldsAppEventScreenshots = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEventVideoClip>? fieldsAppEventVideoClips = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventLocalizationsGetInstanceIncludeItem>? include = default,
            int? limitAppEventScreenshots = default,
            int? limitAppEventVideoClips = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppEventLocalizations"></param>
        /// <param name="fieldsAppEvents"></param>
        /// <param name="fieldsAppEventScreenshots"></param>
        /// <param name="fieldsAppEventVideoClips"></param>
        /// <param name="include"></param>
        /// <param name="limitAppEventScreenshots"></param>
        /// <param name="limitAppEventVideoClips"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppEventLocalizationResponse>> AppEventLocalizationsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEventLocalization>? fieldsAppEventLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEvent>? fieldsAppEvents = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEventScreenshot>? fieldsAppEventScreenshots = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventLocalizationsGetInstanceFieldsAppEventVideoClip>? fieldsAppEventVideoClips = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventLocalizationsGetInstanceIncludeItem>? include = default,
            int? limitAppEventScreenshots = default,
            int? limitAppEventVideoClips = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}