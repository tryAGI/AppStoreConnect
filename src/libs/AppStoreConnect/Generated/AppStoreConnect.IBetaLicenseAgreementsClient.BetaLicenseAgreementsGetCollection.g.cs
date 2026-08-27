#nullable enable

namespace AppStoreConnect
{
    public partial interface IBetaLicenseAgreementsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterApp"></param>
        /// <param name="fieldsBetaLicenseAgreements"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BetaLicenseAgreementsResponse> BetaLicenseAgreementsGetCollectionAsync(
            global::System.Collections.Generic.IList<string>? filterApp = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaLicenseAgreementsGetCollectionFieldsBetaLicenseAgreement>? fieldsBetaLicenseAgreements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaLicenseAgreementsGetCollectionFieldsApp>? fieldsApps = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaLicenseAgreementsGetCollectionIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterApp"></param>
        /// <param name="fieldsBetaLicenseAgreements"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BetaLicenseAgreementsResponse>> BetaLicenseAgreementsGetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<string>? filterApp = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaLicenseAgreementsGetCollectionFieldsBetaLicenseAgreement>? fieldsBetaLicenseAgreements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaLicenseAgreementsGetCollectionFieldsApp>? fieldsApps = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaLicenseAgreementsGetCollectionIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}