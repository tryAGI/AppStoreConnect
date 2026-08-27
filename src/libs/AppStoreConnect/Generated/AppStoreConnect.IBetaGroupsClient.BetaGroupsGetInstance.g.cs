#nullable enable

namespace AppStoreConnect
{
    public partial interface IBetaGroupsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsBetaGroups"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="fieldsBetaTesters"></param>
        /// <param name="fieldsBetaRecruitmentCriteria"></param>
        /// <param name="include"></param>
        /// <param name="limitBetaTesters"></param>
        /// <param name="limitBuilds"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BetaGroupResponse> BetaGroupsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsGetInstanceFieldsBetaGroup>? fieldsBetaGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsGetInstanceFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsGetInstanceFieldsBetaTester>? fieldsBetaTesters = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsGetInstanceFieldsBetaRecruitmentCriteriaItem>? fieldsBetaRecruitmentCriteria = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsGetInstanceIncludeItem>? include = default,
            int? limitBetaTesters = default,
            int? limitBuilds = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsBetaGroups"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="fieldsBetaTesters"></param>
        /// <param name="fieldsBetaRecruitmentCriteria"></param>
        /// <param name="include"></param>
        /// <param name="limitBetaTesters"></param>
        /// <param name="limitBuilds"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BetaGroupResponse>> BetaGroupsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsGetInstanceFieldsBetaGroup>? fieldsBetaGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsGetInstanceFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsGetInstanceFieldsBetaTester>? fieldsBetaTesters = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsGetInstanceFieldsBetaRecruitmentCriteriaItem>? fieldsBetaRecruitmentCriteria = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsGetInstanceIncludeItem>? include = default,
            int? limitBetaTesters = default,
            int? limitBuilds = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}