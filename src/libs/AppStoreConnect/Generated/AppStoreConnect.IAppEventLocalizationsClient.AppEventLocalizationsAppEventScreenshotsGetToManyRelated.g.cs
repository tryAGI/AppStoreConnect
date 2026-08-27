#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppEventLocalizationsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppEventScreenshots"></param>
        /// <param name="fieldsAppEventLocalizations"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppEventScreenshotsResponse> AppEventLocalizationsAppEventScreenshotsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventScreenshot>? fieldsAppEventScreenshots = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventLocalization>? fieldsAppEventLocalizations = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventLocalizationsAppEventScreenshotsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppEventScreenshots"></param>
        /// <param name="fieldsAppEventLocalizations"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppEventScreenshotsResponse>> AppEventLocalizationsAppEventScreenshotsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventScreenshot>? fieldsAppEventScreenshots = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventLocalizationsAppEventScreenshotsGetToManyRelatedFieldsAppEventLocalization>? fieldsAppEventLocalizations = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventLocalizationsAppEventScreenshotsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}