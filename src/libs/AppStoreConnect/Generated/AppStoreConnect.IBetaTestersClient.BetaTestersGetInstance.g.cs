#nullable enable

namespace AppStoreConnect
{
    public partial interface IBetaTestersClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsBetaTesters"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsBetaGroups"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="include"></param>
        /// <param name="limitApps"></param>
        /// <param name="limitBetaGroups"></param>
        /// <param name="limitBuilds"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BetaTesterResponse> BetaTestersGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTestersGetInstanceFieldsBetaTester>? fieldsBetaTesters = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTestersGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTestersGetInstanceFieldsBetaGroup>? fieldsBetaGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTestersGetInstanceFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTestersGetInstanceIncludeItem>? include = default,
            int? limitApps = default,
            int? limitBetaGroups = default,
            int? limitBuilds = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsBetaTesters"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsBetaGroups"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="include"></param>
        /// <param name="limitApps"></param>
        /// <param name="limitBetaGroups"></param>
        /// <param name="limitBuilds"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BetaTesterResponse>> BetaTestersGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTestersGetInstanceFieldsBetaTester>? fieldsBetaTesters = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTestersGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTestersGetInstanceFieldsBetaGroup>? fieldsBetaGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTestersGetInstanceFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTestersGetInstanceIncludeItem>? include = default,
            int? limitApps = default,
            int? limitBetaGroups = default,
            int? limitBuilds = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}