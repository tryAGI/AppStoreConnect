#nullable enable

namespace AppStoreConnect
{
    public partial interface IPassTypeIdsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsPassTypeIds"></param>
        /// <param name="fieldsCertificates"></param>
        /// <param name="include"></param>
        /// <param name="limitCertificates"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.PassTypeIdResponse> PassTypeIdsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PassTypeIdsGetInstanceFieldsPassTypeId>? fieldsPassTypeIds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PassTypeIdsGetInstanceFieldsCertificate>? fieldsCertificates = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PassTypeIdsGetInstanceIncludeItem>? include = default,
            int? limitCertificates = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsPassTypeIds"></param>
        /// <param name="fieldsCertificates"></param>
        /// <param name="include"></param>
        /// <param name="limitCertificates"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.PassTypeIdResponse>> PassTypeIdsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PassTypeIdsGetInstanceFieldsPassTypeId>? fieldsPassTypeIds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PassTypeIdsGetInstanceFieldsCertificate>? fieldsCertificates = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PassTypeIdsGetInstanceIncludeItem>? include = default,
            int? limitCertificates = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}