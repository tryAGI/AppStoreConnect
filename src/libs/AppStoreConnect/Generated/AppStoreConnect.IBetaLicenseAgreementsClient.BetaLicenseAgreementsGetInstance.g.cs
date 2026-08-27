#nullable enable

namespace AppStoreConnect
{
    public partial interface IBetaLicenseAgreementsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsBetaLicenseAgreements"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BetaLicenseAgreementResponse> BetaLicenseAgreementsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaLicenseAgreementsGetInstanceFieldsBetaLicenseAgreement>? fieldsBetaLicenseAgreements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaLicenseAgreementsGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaLicenseAgreementsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsBetaLicenseAgreements"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BetaLicenseAgreementResponse>> BetaLicenseAgreementsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaLicenseAgreementsGetInstanceFieldsBetaLicenseAgreement>? fieldsBetaLicenseAgreements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaLicenseAgreementsGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaLicenseAgreementsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}