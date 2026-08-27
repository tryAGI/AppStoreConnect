#nullable enable

namespace AppStoreConnect
{
    public partial interface IUsersClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterUsername"></param>
        /// <param name="filterRoles"></param>
        /// <param name="filterVisibleApps"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsUsers"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitVisibleApps"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.UsersResponse> UsersGetCollectionAsync(
            global::System.Collections.Generic.IList<string>? filterUsername = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UsersGetCollectionFilterRole>? filterRoles = default,
            global::System.Collections.Generic.IList<string>? filterVisibleApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UsersGetCollectionSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UsersGetCollectionFieldsUser>? fieldsUsers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UsersGetCollectionFieldsApp>? fieldsApps = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UsersGetCollectionIncludeItem>? include = default,
            int? limitVisibleApps = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterUsername"></param>
        /// <param name="filterRoles"></param>
        /// <param name="filterVisibleApps"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsUsers"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitVisibleApps"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.UsersResponse>> UsersGetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<string>? filterUsername = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UsersGetCollectionFilterRole>? filterRoles = default,
            global::System.Collections.Generic.IList<string>? filterVisibleApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UsersGetCollectionSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UsersGetCollectionFieldsUser>? fieldsUsers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UsersGetCollectionFieldsApp>? fieldsApps = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UsersGetCollectionIncludeItem>? include = default,
            int? limitVisibleApps = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}