#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterMatchmakingQueuesClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsGameCenterMatchmakingQueues"></param>
        /// <param name="fieldsGameCenterMatchmakingRuleSets"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterMatchmakingQueueResponse> GameCenterMatchmakingQueuesGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingQueue>? fieldsGameCenterMatchmakingQueues = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingRuleSet>? fieldsGameCenterMatchmakingRuleSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingQueuesGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsGameCenterMatchmakingQueues"></param>
        /// <param name="fieldsGameCenterMatchmakingRuleSets"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterMatchmakingQueueResponse>> GameCenterMatchmakingQueuesGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingQueue>? fieldsGameCenterMatchmakingQueues = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingRuleSet>? fieldsGameCenterMatchmakingRuleSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingQueuesGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}