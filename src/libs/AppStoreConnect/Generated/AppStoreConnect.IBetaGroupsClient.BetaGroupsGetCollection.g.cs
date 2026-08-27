#nullable enable

namespace AppStoreConnect
{
    public partial interface IBetaGroupsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterName"></param>
        /// <param name="filterIsInternalGroup"></param>
        /// <param name="filterPublicLinkEnabled"></param>
        /// <param name="filterPublicLinkLimitEnabled"></param>
        /// <param name="filterPublicLink"></param>
        /// <param name="filterApp"></param>
        /// <param name="filterBuilds"></param>
        /// <param name="filterId"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsBetaGroups"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="fieldsBetaTesters"></param>
        /// <param name="fieldsBetaRecruitmentCriteria"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitBetaTesters"></param>
        /// <param name="limitBuilds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BetaGroupsResponse> BetaGroupsGetCollectionAsync(
            global::System.Collections.Generic.IList<string>? filterName = default,
            global::System.Collections.Generic.IList<string>? filterIsInternalGroup = default,
            global::System.Collections.Generic.IList<string>? filterPublicLinkEnabled = default,
            global::System.Collections.Generic.IList<string>? filterPublicLinkLimitEnabled = default,
            global::System.Collections.Generic.IList<string>? filterPublicLink = default,
            global::System.Collections.Generic.IList<string>? filterApp = default,
            global::System.Collections.Generic.IList<string>? filterBuilds = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsGetCollectionSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsGetCollectionFieldsBetaGroup>? fieldsBetaGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsGetCollectionFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsGetCollectionFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsGetCollectionFieldsBetaTester>? fieldsBetaTesters = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsGetCollectionFieldsBetaRecruitmentCriteriaItem>? fieldsBetaRecruitmentCriteria = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsGetCollectionIncludeItem>? include = default,
            int? limitBetaTesters = default,
            int? limitBuilds = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterName"></param>
        /// <param name="filterIsInternalGroup"></param>
        /// <param name="filterPublicLinkEnabled"></param>
        /// <param name="filterPublicLinkLimitEnabled"></param>
        /// <param name="filterPublicLink"></param>
        /// <param name="filterApp"></param>
        /// <param name="filterBuilds"></param>
        /// <param name="filterId"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsBetaGroups"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="fieldsBetaTesters"></param>
        /// <param name="fieldsBetaRecruitmentCriteria"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitBetaTesters"></param>
        /// <param name="limitBuilds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BetaGroupsResponse>> BetaGroupsGetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<string>? filterName = default,
            global::System.Collections.Generic.IList<string>? filterIsInternalGroup = default,
            global::System.Collections.Generic.IList<string>? filterPublicLinkEnabled = default,
            global::System.Collections.Generic.IList<string>? filterPublicLinkLimitEnabled = default,
            global::System.Collections.Generic.IList<string>? filterPublicLink = default,
            global::System.Collections.Generic.IList<string>? filterApp = default,
            global::System.Collections.Generic.IList<string>? filterBuilds = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsGetCollectionSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsGetCollectionFieldsBetaGroup>? fieldsBetaGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsGetCollectionFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsGetCollectionFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsGetCollectionFieldsBetaTester>? fieldsBetaTesters = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsGetCollectionFieldsBetaRecruitmentCriteriaItem>? fieldsBetaRecruitmentCriteria = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsGetCollectionIncludeItem>? include = default,
            int? limitBetaTesters = default,
            int? limitBuilds = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}