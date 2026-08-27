#nullable enable

namespace AppStoreConnect
{
    public partial interface IUserInvitationsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterEmail"></param>
        /// <param name="filterRoles"></param>
        /// <param name="filterVisibleApps"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsUserInvitations"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitVisibleApps"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.UserInvitationsResponse> UserInvitationsGetCollectionAsync(
            global::System.Collections.Generic.IList<string>? filterEmail = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UserInvitationsGetCollectionFilterRole>? filterRoles = default,
            global::System.Collections.Generic.IList<string>? filterVisibleApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UserInvitationsGetCollectionSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UserInvitationsGetCollectionFieldsUserInvitation>? fieldsUserInvitations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UserInvitationsGetCollectionFieldsApp>? fieldsApps = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UserInvitationsGetCollectionIncludeItem>? include = default,
            int? limitVisibleApps = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterEmail"></param>
        /// <param name="filterRoles"></param>
        /// <param name="filterVisibleApps"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsUserInvitations"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitVisibleApps"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.UserInvitationsResponse>> UserInvitationsGetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<string>? filterEmail = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UserInvitationsGetCollectionFilterRole>? filterRoles = default,
            global::System.Collections.Generic.IList<string>? filterVisibleApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UserInvitationsGetCollectionSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UserInvitationsGetCollectionFieldsUserInvitation>? fieldsUserInvitations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UserInvitationsGetCollectionFieldsApp>? fieldsApps = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UserInvitationsGetCollectionIncludeItem>? include = default,
            int? limitVisibleApps = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}