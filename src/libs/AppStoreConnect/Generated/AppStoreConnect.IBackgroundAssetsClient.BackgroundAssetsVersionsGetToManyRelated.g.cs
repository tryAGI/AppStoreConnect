#nullable enable

namespace AppStoreConnect
{
    public partial interface IBackgroundAssetsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterLocale"></param>
        /// <param name="filterPlatforms"></param>
        /// <param name="filterState"></param>
        /// <param name="filterVersion"></param>
        /// <param name="filterInternalBetaReleaseState"></param>
        /// <param name="filterExternalBetaReleaseState"></param>
        /// <param name="filterAppStoreReleaseState"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsBackgroundAssetVersions"></param>
        /// <param name="fieldsBackgroundAssets"></param>
        /// <param name="fieldsBackgroundAssetVersionInternalBetaReleases"></param>
        /// <param name="fieldsBackgroundAssetVersionExternalBetaReleases"></param>
        /// <param name="fieldsBackgroundAssetVersionAppStoreReleases"></param>
        /// <param name="fieldsBackgroundAssetUploadFiles"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BackgroundAssetVersionsResponse> BackgroundAssetsVersionsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterLocale = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterPlatform>? filterPlatforms = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterStateItem>? filterState = default,
            global::System.Collections.Generic.IList<string>? filterVersion = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterInternalBetaReleaseStateItem>? filterInternalBetaReleaseState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem>? filterExternalBetaReleaseState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem>? filterAppStoreReleaseState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion>? fieldsBackgroundAssetVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset>? fieldsBackgroundAssets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionInternalBetaRelease>? fieldsBackgroundAssetVersionInternalBetaReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionExternalBetaRelease>? fieldsBackgroundAssetVersionExternalBetaReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionAppStoreRelease>? fieldsBackgroundAssetVersionAppStoreReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile>? fieldsBackgroundAssetUploadFiles = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterLocale"></param>
        /// <param name="filterPlatforms"></param>
        /// <param name="filterState"></param>
        /// <param name="filterVersion"></param>
        /// <param name="filterInternalBetaReleaseState"></param>
        /// <param name="filterExternalBetaReleaseState"></param>
        /// <param name="filterAppStoreReleaseState"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsBackgroundAssetVersions"></param>
        /// <param name="fieldsBackgroundAssets"></param>
        /// <param name="fieldsBackgroundAssetVersionInternalBetaReleases"></param>
        /// <param name="fieldsBackgroundAssetVersionExternalBetaReleases"></param>
        /// <param name="fieldsBackgroundAssetVersionAppStoreReleases"></param>
        /// <param name="fieldsBackgroundAssetUploadFiles"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BackgroundAssetVersionsResponse>> BackgroundAssetsVersionsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterLocale = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterPlatform>? filterPlatforms = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterStateItem>? filterState = default,
            global::System.Collections.Generic.IList<string>? filterVersion = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterInternalBetaReleaseStateItem>? filterInternalBetaReleaseState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem>? filterExternalBetaReleaseState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem>? filterAppStoreReleaseState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion>? fieldsBackgroundAssetVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset>? fieldsBackgroundAssets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionInternalBetaRelease>? fieldsBackgroundAssetVersionInternalBetaReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionExternalBetaRelease>? fieldsBackgroundAssetVersionExternalBetaReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionAppStoreRelease>? fieldsBackgroundAssetVersionAppStoreReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile>? fieldsBackgroundAssetUploadFiles = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}