#nullable enable

namespace AppStoreConnect
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsUsers"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="include"></param>
        /// <param name="limitVisibleApps"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.UserResponse> UsersGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UsersGetInstanceFieldsUser>? fieldsUsers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UsersGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UsersGetInstanceIncludeItem>? include = default,
            int? limitVisibleApps = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsUsers"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="include"></param>
        /// <param name="limitVisibleApps"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.UserResponse>> UsersGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UsersGetInstanceFieldsUser>? fieldsUsers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UsersGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UsersGetInstanceIncludeItem>? include = default,
            int? limitVisibleApps = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}