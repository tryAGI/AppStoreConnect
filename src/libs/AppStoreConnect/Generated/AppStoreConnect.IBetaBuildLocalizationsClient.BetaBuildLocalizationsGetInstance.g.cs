#nullable enable

namespace AppStoreConnect
{
    public partial interface IBetaBuildLocalizationsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsBetaBuildLocalizations"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BetaBuildLocalizationResponse> BetaBuildLocalizationsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaBuildLocalizationsGetInstanceFieldsBetaBuildLocalization>? fieldsBetaBuildLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaBuildLocalizationsGetInstanceFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaBuildLocalizationsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsBetaBuildLocalizations"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BetaBuildLocalizationResponse>> BetaBuildLocalizationsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaBuildLocalizationsGetInstanceFieldsBetaBuildLocalization>? fieldsBetaBuildLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaBuildLocalizationsGetInstanceFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaBuildLocalizationsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}