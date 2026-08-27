#nullable enable

namespace AppStoreConnect
{
    public partial interface IProfilesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsProfiles"></param>
        /// <param name="fieldsBundleIds"></param>
        /// <param name="fieldsDevices"></param>
        /// <param name="fieldsCertificates"></param>
        /// <param name="include"></param>
        /// <param name="limitCertificates"></param>
        /// <param name="limitDevices"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.ProfileResponse> ProfilesGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetInstanceFieldsProfile>? fieldsProfiles = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetInstanceFieldsBundleId>? fieldsBundleIds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetInstanceFieldsDevice>? fieldsDevices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetInstanceFieldsCertificate>? fieldsCertificates = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetInstanceIncludeItem>? include = default,
            int? limitCertificates = default,
            int? limitDevices = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsProfiles"></param>
        /// <param name="fieldsBundleIds"></param>
        /// <param name="fieldsDevices"></param>
        /// <param name="fieldsCertificates"></param>
        /// <param name="include"></param>
        /// <param name="limitCertificates"></param>
        /// <param name="limitDevices"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.ProfileResponse>> ProfilesGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetInstanceFieldsProfile>? fieldsProfiles = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetInstanceFieldsBundleId>? fieldsBundleIds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetInstanceFieldsDevice>? fieldsDevices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetInstanceFieldsCertificate>? fieldsCertificates = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetInstanceIncludeItem>? include = default,
            int? limitCertificates = default,
            int? limitDevices = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}