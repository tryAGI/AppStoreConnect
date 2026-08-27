#nullable enable

namespace AppStoreConnect
{
    public partial interface IBetaTestersClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterFirstName"></param>
        /// <param name="filterLastName"></param>
        /// <param name="filterEmail"></param>
        /// <param name="filterInviteType"></param>
        /// <param name="filterApps"></param>
        /// <param name="filterBetaGroups"></param>
        /// <param name="filterBuilds"></param>
        /// <param name="filterId"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsBetaTesters"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsBetaGroups"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitApps"></param>
        /// <param name="limitBetaGroups"></param>
        /// <param name="limitBuilds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BetaTestersResponse> BetaTestersGetCollectionAsync(
            global::System.Collections.Generic.IList<string>? filterFirstName = default,
            global::System.Collections.Generic.IList<string>? filterLastName = default,
            global::System.Collections.Generic.IList<string>? filterEmail = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTestersGetCollectionFilterInviteTypeItem>? filterInviteType = default,
            global::System.Collections.Generic.IList<string>? filterApps = default,
            global::System.Collections.Generic.IList<string>? filterBetaGroups = default,
            global::System.Collections.Generic.IList<string>? filterBuilds = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTestersGetCollectionSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTestersGetCollectionFieldsBetaTester>? fieldsBetaTesters = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTestersGetCollectionFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTestersGetCollectionFieldsBetaGroup>? fieldsBetaGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTestersGetCollectionFieldsBuild>? fieldsBuilds = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTestersGetCollectionIncludeItem>? include = default,
            int? limitApps = default,
            int? limitBetaGroups = default,
            int? limitBuilds = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterFirstName"></param>
        /// <param name="filterLastName"></param>
        /// <param name="filterEmail"></param>
        /// <param name="filterInviteType"></param>
        /// <param name="filterApps"></param>
        /// <param name="filterBetaGroups"></param>
        /// <param name="filterBuilds"></param>
        /// <param name="filterId"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsBetaTesters"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsBetaGroups"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitApps"></param>
        /// <param name="limitBetaGroups"></param>
        /// <param name="limitBuilds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BetaTestersResponse>> BetaTestersGetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<string>? filterFirstName = default,
            global::System.Collections.Generic.IList<string>? filterLastName = default,
            global::System.Collections.Generic.IList<string>? filterEmail = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTestersGetCollectionFilterInviteTypeItem>? filterInviteType = default,
            global::System.Collections.Generic.IList<string>? filterApps = default,
            global::System.Collections.Generic.IList<string>? filterBetaGroups = default,
            global::System.Collections.Generic.IList<string>? filterBuilds = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTestersGetCollectionSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTestersGetCollectionFieldsBetaTester>? fieldsBetaTesters = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTestersGetCollectionFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTestersGetCollectionFieldsBetaGroup>? fieldsBetaGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTestersGetCollectionFieldsBuild>? fieldsBuilds = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTestersGetCollectionIncludeItem>? include = default,
            int? limitApps = default,
            int? limitBetaGroups = default,
            int? limitBuilds = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}