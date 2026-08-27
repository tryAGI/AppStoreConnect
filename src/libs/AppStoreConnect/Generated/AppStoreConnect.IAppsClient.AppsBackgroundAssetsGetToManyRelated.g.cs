#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterArchived"></param>
        /// <param name="filterAssetPackIdentifier"></param>
        /// <param name="filterVersionsLocale"></param>
        /// <param name="filterVersionsPlatforms"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsBackgroundAssets"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsBackgroundAssetVersions"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BackgroundAssetsResponse> AppsBackgroundAssetsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterArchived = default,
            global::System.Collections.Generic.IList<string>? filterAssetPackIdentifier = default,
            global::System.Collections.Generic.IList<string>? filterVersionsLocale = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBackgroundAssetsGetToManyRelatedFilterVersionsPlatform>? filterVersionsPlatforms = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBackgroundAssetsGetToManyRelatedSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAsset>? fieldsBackgroundAssets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBackgroundAssetsGetToManyRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetVersion>? fieldsBackgroundAssetVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBackgroundAssetsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterArchived"></param>
        /// <param name="filterAssetPackIdentifier"></param>
        /// <param name="filterVersionsLocale"></param>
        /// <param name="filterVersionsPlatforms"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsBackgroundAssets"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsBackgroundAssetVersions"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BackgroundAssetsResponse>> AppsBackgroundAssetsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterArchived = default,
            global::System.Collections.Generic.IList<string>? filterAssetPackIdentifier = default,
            global::System.Collections.Generic.IList<string>? filterVersionsLocale = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBackgroundAssetsGetToManyRelatedFilterVersionsPlatform>? filterVersionsPlatforms = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBackgroundAssetsGetToManyRelatedSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAsset>? fieldsBackgroundAssets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBackgroundAssetsGetToManyRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBackgroundAssetsGetToManyRelatedFieldsBackgroundAssetVersion>? fieldsBackgroundAssetVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBackgroundAssetsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}