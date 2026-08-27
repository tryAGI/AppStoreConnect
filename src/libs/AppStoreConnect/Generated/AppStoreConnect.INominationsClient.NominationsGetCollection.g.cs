#nullable enable

namespace AppStoreConnect
{
    public partial interface INominationsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterType"></param>
        /// <param name="filterState"></param>
        /// <param name="filterHasInAppEvents"></param>
        /// <param name="filterRelatedApps"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsNominations"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsActors"></param>
        /// <param name="fieldsAppEvents"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitInAppEvents"></param>
        /// <param name="limitRelatedApps"></param>
        /// <param name="limitSupportedTerritories"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.NominationsResponse> NominationsGetCollectionAsync(
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionFilterStateItem> filterState,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionFilterTypeItem>? filterType = default,
            global::System.Collections.Generic.IList<string>? filterHasInAppEvents = default,
            global::System.Collections.Generic.IList<string>? filterRelatedApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionFieldsNomination>? fieldsNominations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionFieldsActor>? fieldsActors = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionFieldsAppEvent>? fieldsAppEvents = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionFieldsTerritorie>? fieldsTerritories = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionIncludeItem>? include = default,
            int? limitInAppEvents = default,
            int? limitRelatedApps = default,
            int? limitSupportedTerritories = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterType"></param>
        /// <param name="filterState"></param>
        /// <param name="filterHasInAppEvents"></param>
        /// <param name="filterRelatedApps"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsNominations"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsActors"></param>
        /// <param name="fieldsAppEvents"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitInAppEvents"></param>
        /// <param name="limitRelatedApps"></param>
        /// <param name="limitSupportedTerritories"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.NominationsResponse>> NominationsGetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionFilterStateItem> filterState,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionFilterTypeItem>? filterType = default,
            global::System.Collections.Generic.IList<string>? filterHasInAppEvents = default,
            global::System.Collections.Generic.IList<string>? filterRelatedApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionFieldsNomination>? fieldsNominations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionFieldsActor>? fieldsActors = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionFieldsAppEvent>? fieldsAppEvents = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionFieldsTerritorie>? fieldsTerritories = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionIncludeItem>? include = default,
            int? limitInAppEvents = default,
            int? limitRelatedApps = default,
            int? limitSupportedTerritories = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}