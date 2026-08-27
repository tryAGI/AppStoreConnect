#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterActivityLocalizationsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsGameCenterActivityLocalizations"></param>
        /// <param name="fieldsGameCenterActivityVersions"></param>
        /// <param name="fieldsGameCenterActivityImages"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterActivityLocalizationResponse> GameCenterActivityLocalizationsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityLocalization>? fieldsGameCenterActivityLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityVersion>? fieldsGameCenterActivityVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityImage>? fieldsGameCenterActivityImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityLocalizationsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsGameCenterActivityLocalizations"></param>
        /// <param name="fieldsGameCenterActivityVersions"></param>
        /// <param name="fieldsGameCenterActivityImages"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterActivityLocalizationResponse>> GameCenterActivityLocalizationsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityLocalization>? fieldsGameCenterActivityLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityVersion>? fieldsGameCenterActivityVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityImage>? fieldsGameCenterActivityImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityLocalizationsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}