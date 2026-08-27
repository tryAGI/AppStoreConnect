#nullable enable

namespace AppStoreConnect
{
    public partial interface IDevicesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterName"></param>
        /// <param name="filterPlatform"></param>
        /// <param name="filterUdid"></param>
        /// <param name="filterStatus"></param>
        /// <param name="filterId"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsDevices"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.DevicesResponse> DevicesGetCollectionAsync(
            global::System.Collections.Generic.IList<string>? filterName = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.DevicesGetCollectionFilterPlatformItem>? filterPlatform = default,
            global::System.Collections.Generic.IList<string>? filterUdid = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.DevicesGetCollectionFilterStatu>? filterStatus = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.DevicesGetCollectionSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.DevicesGetCollectionFieldsDevice>? fieldsDevices = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterName"></param>
        /// <param name="filterPlatform"></param>
        /// <param name="filterUdid"></param>
        /// <param name="filterStatus"></param>
        /// <param name="filterId"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsDevices"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.DevicesResponse>> DevicesGetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<string>? filterName = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.DevicesGetCollectionFilterPlatformItem>? filterPlatform = default,
            global::System.Collections.Generic.IList<string>? filterUdid = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.DevicesGetCollectionFilterStatu>? filterStatus = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.DevicesGetCollectionSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.DevicesGetCollectionFieldsDevice>? fieldsDevices = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}