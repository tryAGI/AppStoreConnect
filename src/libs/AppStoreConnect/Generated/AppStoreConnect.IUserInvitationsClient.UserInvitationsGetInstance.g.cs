#nullable enable

namespace AppStoreConnect
{
    public partial interface IUserInvitationsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsUserInvitations"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="include"></param>
        /// <param name="limitVisibleApps"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.UserInvitationResponse> UserInvitationsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UserInvitationsGetInstanceFieldsUserInvitation>? fieldsUserInvitations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UserInvitationsGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UserInvitationsGetInstanceIncludeItem>? include = default,
            int? limitVisibleApps = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsUserInvitations"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="include"></param>
        /// <param name="limitVisibleApps"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.UserInvitationResponse>> UserInvitationsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UserInvitationsGetInstanceFieldsUserInvitation>? fieldsUserInvitations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UserInvitationsGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UserInvitationsGetInstanceIncludeItem>? include = default,
            int? limitVisibleApps = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}