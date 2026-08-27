#nullable enable

namespace AppStoreConnect
{
    public partial interface IProfilesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterName"></param>
        /// <param name="filterProfileType"></param>
        /// <param name="filterProfileState"></param>
        /// <param name="filterId"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsProfiles"></param>
        /// <param name="fieldsBundleIds"></param>
        /// <param name="fieldsDevices"></param>
        /// <param name="fieldsCertificates"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitCertificates"></param>
        /// <param name="limitDevices"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.ProfilesResponse> ProfilesGetCollectionAsync(
            global::System.Collections.Generic.IList<string>? filterName = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetCollectionFilterProfileTypeItem>? filterProfileType = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetCollectionFilterProfileStateItem>? filterProfileState = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetCollectionSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetCollectionFieldsProfile>? fieldsProfiles = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetCollectionFieldsBundleId>? fieldsBundleIds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetCollectionFieldsDevice>? fieldsDevices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetCollectionFieldsCertificate>? fieldsCertificates = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetCollectionIncludeItem>? include = default,
            int? limitCertificates = default,
            int? limitDevices = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterName"></param>
        /// <param name="filterProfileType"></param>
        /// <param name="filterProfileState"></param>
        /// <param name="filterId"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsProfiles"></param>
        /// <param name="fieldsBundleIds"></param>
        /// <param name="fieldsDevices"></param>
        /// <param name="fieldsCertificates"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitCertificates"></param>
        /// <param name="limitDevices"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.ProfilesResponse>> ProfilesGetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<string>? filterName = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetCollectionFilterProfileTypeItem>? filterProfileType = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetCollectionFilterProfileStateItem>? filterProfileState = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetCollectionSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetCollectionFieldsProfile>? fieldsProfiles = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetCollectionFieldsBundleId>? fieldsBundleIds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetCollectionFieldsDevice>? fieldsDevices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetCollectionFieldsCertificate>? fieldsCertificates = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetCollectionIncludeItem>? include = default,
            int? limitCertificates = default,
            int? limitDevices = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}