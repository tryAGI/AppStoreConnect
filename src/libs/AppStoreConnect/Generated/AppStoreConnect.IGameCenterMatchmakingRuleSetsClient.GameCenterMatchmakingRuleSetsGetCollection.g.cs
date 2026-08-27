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
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitMatchmakingQueues"></param>
        /// <param name="limitRules"></param>
        /// <param name="limitTeams"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterMatchmakingRuleSetsResponse> GameCenterMatchmakingRuleSetsGetCollectionAsync(
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet>? fieldsGameCenterMatchmakingRuleSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeam>? fieldsGameCenterMatchmakingTeams = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule>? fieldsGameCenterMatchmakingRules = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue>? fieldsGameCenterMatchmakingQueues = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionIncludeItem>? include = default,
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
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitMatchmakingQueues"></param>
        /// <param name="limitRules"></param>
        /// <param name="limitTeams"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterMatchmakingRuleSetsResponse>> GameCenterMatchmakingRuleSetsGetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet>? fieldsGameCenterMatchmakingRuleSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeam>? fieldsGameCenterMatchmakingTeams = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule>? fieldsGameCenterMatchmakingRules = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue>? fieldsGameCenterMatchmakingQueues = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionIncludeItem>? include = default,
            int? limitMatchmakingQueues = default,
            int? limitRules = default,
            int? limitTeams = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}