#nullable enable

namespace AppStoreConnect
{
    public partial interface IEndUserLicenseAgreementsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsEndUserLicenseAgreements"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="include"></param>
        /// <param name="limitTerritories"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.EndUserLicenseAgreementResponse> EndUserLicenseAgreementsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceFieldsEndUserLicenseAgreement>? fieldsEndUserLicenseAgreements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceFieldsTerritorie>? fieldsTerritories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceIncludeItem>? include = default,
            int? limitTerritories = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsEndUserLicenseAgreements"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="include"></param>
        /// <param name="limitTerritories"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.EndUserLicenseAgreementResponse>> EndUserLicenseAgreementsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceFieldsEndUserLicenseAgreement>? fieldsEndUserLicenseAgreements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceFieldsTerritorie>? fieldsTerritories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.EndUserLicenseAgreementsGetInstanceIncludeItem>? include = default,
            int? limitTerritories = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}