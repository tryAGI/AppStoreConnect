#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppEventsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppEventLocalizations"></param>
        /// <param name="fieldsAppEvents"></param>
        /// <param name="fieldsAppEventScreenshots"></param>
        /// <param name="fieldsAppEventVideoClips"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitAppEventScreenshots"></param>
        /// <param name="limitAppEventVideoClips"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppEventLocalizationsResponse> AppEventsLocalizationsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventsLocalizationsGetToManyRelatedFieldsAppEventLocalization>? fieldsAppEventLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventsLocalizationsGetToManyRelatedFieldsAppEvent>? fieldsAppEvents = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventsLocalizationsGetToManyRelatedFieldsAppEventScreenshot>? fieldsAppEventScreenshots = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClip>? fieldsAppEventVideoClips = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventsLocalizationsGetToManyRelatedIncludeItem>? include = default,
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
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitAppEventScreenshots"></param>
        /// <param name="limitAppEventVideoClips"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppEventLocalizationsResponse>> AppEventsLocalizationsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventsLocalizationsGetToManyRelatedFieldsAppEventLocalization>? fieldsAppEventLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventsLocalizationsGetToManyRelatedFieldsAppEvent>? fieldsAppEvents = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventsLocalizationsGetToManyRelatedFieldsAppEventScreenshot>? fieldsAppEventScreenshots = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventsLocalizationsGetToManyRelatedFieldsAppEventVideoClip>? fieldsAppEventVideoClips = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventsLocalizationsGetToManyRelatedIncludeItem>? include = default,
            int? limitAppEventScreenshots = default,
            int? limitAppEventVideoClips = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}