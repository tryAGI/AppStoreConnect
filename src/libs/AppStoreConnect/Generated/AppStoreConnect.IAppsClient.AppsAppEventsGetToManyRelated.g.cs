#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterEventState"></param>
        /// <param name="filterId"></param>
        /// <param name="fieldsAppEvents"></param>
        /// <param name="fieldsAppEventLocalizations"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppEventsResponse> AppsAppEventsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppEventsGetToManyRelatedFilterEventStateItem>? filterEventState = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppEventsGetToManyRelatedFieldsAppEvent>? fieldsAppEvents = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppEventsGetToManyRelatedFieldsAppEventLocalization>? fieldsAppEventLocalizations = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppEventsGetToManyRelatedIncludeItem>? include = default,
            int? limitLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterEventState"></param>
        /// <param name="filterId"></param>
        /// <param name="fieldsAppEvents"></param>
        /// <param name="fieldsAppEventLocalizations"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppEventsResponse>> AppsAppEventsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppEventsGetToManyRelatedFilterEventStateItem>? filterEventState = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppEventsGetToManyRelatedFieldsAppEvent>? fieldsAppEvents = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppEventsGetToManyRelatedFieldsAppEventLocalization>? fieldsAppEventLocalizations = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppEventsGetToManyRelatedIncludeItem>? include = default,
            int? limitLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}