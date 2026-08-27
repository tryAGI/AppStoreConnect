#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterMatchmakingRuleSetsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsGameCenterMatchmakingRuleSets"></param>
        /// <param name="fieldsGameCenterMatchmakingTeams"></param>
        /// <param name="fieldsGameCenterMatchmakingRules"></param>
        /// <param name="fieldsGameCenterMatchmakingQueues"></param>
        /// <param name="include"></param>
        /// <param name="limitMatchmakingQueues"></param>
        /// <param name="limitRules"></param>
        /// <param name="limitTeams"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterMatchmakingRuleSetResponse> GameCenterMatchmakingRuleSetsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet>? fieldsGameCenterMatchmakingRuleSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeam>? fieldsGameCenterMatchmakingTeams = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule>? fieldsGameCenterMatchmakingRules = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue>? fieldsGameCenterMatchmakingQueues = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceIncludeItem>? include = default,
            int? limitMatchmakingQueues = default,
            int? limitRules = default,
            int? limitTeams = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsGameCenterMatchmakingRuleSets"></param>
        /// <param name="fieldsGameCenterMatchmakingTeams"></param>
        /// <param name="fieldsGameCenterMatchmakingRules"></param>
        /// <param name="fieldsGameCenterMatchmakingQueues"></param>
        /// <param name="include"></param>
        /// <param name="limitMatchmakingQueues"></param>
        /// <param name="limitRules"></param>
        /// <param name="limitTeams"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterMatchmakingRuleSetResponse>> GameCenterMatchmakingRuleSetsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet>? fieldsGameCenterMatchmakingRuleSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeam>? fieldsGameCenterMatchmakingTeams = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule>? fieldsGameCenterMatchmakingRules = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue>? fieldsGameCenterMatchmakingQueues = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceIncludeItem>? include = default,
            int? limitMatchmakingQueues = default,
            int? limitRules = default,
            int? limitTeams = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}