#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterMatchmakingRuleSetsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsGameCenterMatchmakingQueues"></param>
        /// <param name="fieldsGameCenterMatchmakingRuleSets"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterMatchmakingQueuesResponse> GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingQueue>? fieldsGameCenterMatchmakingQueues = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingRuleSet>? fieldsGameCenterMatchmakingRuleSets = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsGameCenterMatchmakingQueues"></param>
        /// <param name="fieldsGameCenterMatchmakingRuleSets"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterMatchmakingQueuesResponse>> GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingQueue>? fieldsGameCenterMatchmakingQueues = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingRuleSet>? fieldsGameCenterMatchmakingRuleSets = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}