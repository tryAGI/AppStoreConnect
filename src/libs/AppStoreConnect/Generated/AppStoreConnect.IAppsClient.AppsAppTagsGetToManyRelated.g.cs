#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterVisibleInAppStore"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsAppTags"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitTerritories"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppTagsResponse> AppsAppTagsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterVisibleInAppStore = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppTagsGetToManyRelatedSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppTagsGetToManyRelatedFieldsAppTag>? fieldsAppTags = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppTagsGetToManyRelatedFieldsTerritorie>? fieldsTerritories = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppTagsGetToManyRelatedIncludeItem>? include = default,
            int? limitTerritories = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterVisibleInAppStore"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsAppTags"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitTerritories"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppTagsResponse>> AppsAppTagsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterVisibleInAppStore = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppTagsGetToManyRelatedSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppTagsGetToManyRelatedFieldsAppTag>? fieldsAppTags = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppTagsGetToManyRelatedFieldsTerritorie>? fieldsTerritories = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppTagsGetToManyRelatedIncludeItem>? include = default,
            int? limitTerritories = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}