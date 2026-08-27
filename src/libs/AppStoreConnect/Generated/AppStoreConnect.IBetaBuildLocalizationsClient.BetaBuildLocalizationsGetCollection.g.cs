#nullable enable

namespace AppStoreConnect
{
    public partial interface IBetaBuildLocalizationsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterLocale"></param>
        /// <param name="filterBuild"></param>
        /// <param name="fieldsBetaBuildLocalizations"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BetaBuildLocalizationsResponse> BetaBuildLocalizationsGetCollectionAsync(
            global::System.Collections.Generic.IList<string>? filterLocale = default,
            global::System.Collections.Generic.IList<string>? filterBuild = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaBuildLocalizationsGetCollectionFieldsBetaBuildLocalization>? fieldsBetaBuildLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaBuildLocalizationsGetCollectionFieldsBuild>? fieldsBuilds = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaBuildLocalizationsGetCollectionIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterLocale"></param>
        /// <param name="filterBuild"></param>
        /// <param name="fieldsBetaBuildLocalizations"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BetaBuildLocalizationsResponse>> BetaBuildLocalizationsGetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<string>? filterLocale = default,
            global::System.Collections.Generic.IList<string>? filterBuild = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaBuildLocalizationsGetCollectionFieldsBetaBuildLocalization>? fieldsBetaBuildLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaBuildLocalizationsGetCollectionFieldsBuild>? fieldsBuilds = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaBuildLocalizationsGetCollectionIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}