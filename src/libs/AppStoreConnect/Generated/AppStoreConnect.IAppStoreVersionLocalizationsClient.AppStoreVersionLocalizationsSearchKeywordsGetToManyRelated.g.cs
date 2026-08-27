#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppStoreVersionLocalizationsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterPlatform"></param>
        /// <param name="filterLocale"></param>
        /// <param name="fieldsAppKeywords"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppKeywordsResponse> AppStoreVersionLocalizationsSearchKeywordsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterPlatform = default,
            global::System.Collections.Generic.IList<string>? filterLocale = default,
            global::System.Collections.Generic.IList<string>? fieldsAppKeywords = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterPlatform"></param>
        /// <param name="filterLocale"></param>
        /// <param name="fieldsAppKeywords"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppKeywordsResponse>> AppStoreVersionLocalizationsSearchKeywordsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterPlatform = default,
            global::System.Collections.Generic.IList<string>? filterLocale = default,
            global::System.Collections.Generic.IList<string>? fieldsAppKeywords = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}