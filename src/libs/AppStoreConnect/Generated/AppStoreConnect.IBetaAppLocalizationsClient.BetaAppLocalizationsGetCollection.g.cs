#nullable enable

namespace AppStoreConnect
{
    public partial interface IBetaAppLocalizationsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterLocale"></param>
        /// <param name="filterApp"></param>
        /// <param name="fieldsBetaAppLocalizations"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BetaAppLocalizationsResponse> BetaAppLocalizationsGetCollectionAsync(
            global::System.Collections.Generic.IList<string>? filterLocale = default,
            global::System.Collections.Generic.IList<string>? filterApp = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppLocalizationsGetCollectionFieldsBetaAppLocalization>? fieldsBetaAppLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppLocalizationsGetCollectionFieldsApp>? fieldsApps = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppLocalizationsGetCollectionIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterLocale"></param>
        /// <param name="filterApp"></param>
        /// <param name="fieldsBetaAppLocalizations"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BetaAppLocalizationsResponse>> BetaAppLocalizationsGetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<string>? filterLocale = default,
            global::System.Collections.Generic.IList<string>? filterApp = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppLocalizationsGetCollectionFieldsBetaAppLocalization>? fieldsBetaAppLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppLocalizationsGetCollectionFieldsApp>? fieldsApps = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppLocalizationsGetCollectionIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}