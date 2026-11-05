#nullable enable

namespace AppStoreConnect
{
    public partial interface IRetentionMessageLocalizationsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsRetentionMessageLocalizations"></param>
        /// <param name="fieldsRetentionMessageVersions"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.RetentionMessageLocalizationResponse> RetentionMessageLocalizationsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessageLocalizationsGetInstanceFieldsRetentionMessageLocalization>? fieldsRetentionMessageLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessageLocalizationsGetInstanceFieldsRetentionMessageVersion>? fieldsRetentionMessageVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessageLocalizationsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsRetentionMessageLocalizations"></param>
        /// <param name="fieldsRetentionMessageVersions"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.RetentionMessageLocalizationResponse>> RetentionMessageLocalizationsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessageLocalizationsGetInstanceFieldsRetentionMessageLocalization>? fieldsRetentionMessageLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessageLocalizationsGetInstanceFieldsRetentionMessageVersion>? fieldsRetentionMessageVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessageLocalizationsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}