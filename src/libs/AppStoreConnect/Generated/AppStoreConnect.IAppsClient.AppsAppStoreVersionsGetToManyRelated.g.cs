#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterPlatform"></param>
        /// <param name="filterVersionString"></param>
        /// <param name="filterAppStoreState"></param>
        /// <param name="filterAppVersionState"></param>
        /// <param name="filterId"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsAppStoreVersionLocalizations"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="fieldsAppStoreVersionPhasedReleases"></param>
        /// <param name="fieldsGameCenterAppVersions"></param>
        /// <param name="fieldsRoutingAppCoverages"></param>
        /// <param name="fieldsAppStoreReviewDetails"></param>
        /// <param name="fieldsAppStoreVersionSubmissions"></param>
        /// <param name="fieldsAppClipDefaultExperiences"></param>
        /// <param name="fieldsAppStoreVersionExperiments"></param>
        /// <param name="fieldsAlternativeDistributionPackages"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitAppStoreVersionLocalizations"></param>
        /// <param name="limitAppStoreVersionExperiments"></param>
        /// <param name="limitAppStoreVersionExperimentsV2"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppStoreVersionsResponse> AppsAppStoreVersionsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppStoreVersionsGetToManyRelatedFilterPlatformItem>? filterPlatform = default,
            global::System.Collections.Generic.IList<string>? filterVersionString = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem>? filterAppStoreState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem>? filterAppVersionState = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppStoreVersionsGetToManyRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionLocalization>? fieldsAppStoreVersionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppStoreVersionsGetToManyRelatedFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionPhasedRelease>? fieldsAppStoreVersionPhasedReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppStoreVersionsGetToManyRelatedFieldsGameCenterAppVersion>? fieldsGameCenterAppVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppStoreVersionsGetToManyRelatedFieldsRoutingAppCoverage>? fieldsRoutingAppCoverages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreReviewDetail>? fieldsAppStoreReviewDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionSubmission>? fieldsAppStoreVersionSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppStoreVersionsGetToManyRelatedFieldsAppClipDefaultExperience>? fieldsAppClipDefaultExperiences = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionExperiment>? fieldsAppStoreVersionExperiments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppStoreVersionsGetToManyRelatedFieldsAlternativeDistributionPackage>? fieldsAlternativeDistributionPackages = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppStoreVersionsGetToManyRelatedIncludeItem>? include = default,
            int? limitAppStoreVersionLocalizations = default,
            int? limitAppStoreVersionExperiments = default,
            int? limitAppStoreVersionExperimentsV2 = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterPlatform"></param>
        /// <param name="filterVersionString"></param>
        /// <param name="filterAppStoreState"></param>
        /// <param name="filterAppVersionState"></param>
        /// <param name="filterId"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsAppStoreVersionLocalizations"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="fieldsAppStoreVersionPhasedReleases"></param>
        /// <param name="fieldsGameCenterAppVersions"></param>
        /// <param name="fieldsRoutingAppCoverages"></param>
        /// <param name="fieldsAppStoreReviewDetails"></param>
        /// <param name="fieldsAppStoreVersionSubmissions"></param>
        /// <param name="fieldsAppClipDefaultExperiences"></param>
        /// <param name="fieldsAppStoreVersionExperiments"></param>
        /// <param name="fieldsAlternativeDistributionPackages"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitAppStoreVersionLocalizations"></param>
        /// <param name="limitAppStoreVersionExperiments"></param>
        /// <param name="limitAppStoreVersionExperimentsV2"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppStoreVersionsResponse>> AppsAppStoreVersionsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppStoreVersionsGetToManyRelatedFilterPlatformItem>? filterPlatform = default,
            global::System.Collections.Generic.IList<string>? filterVersionString = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppStoreVersionsGetToManyRelatedFilterAppStoreStateItem>? filterAppStoreState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppStoreVersionsGetToManyRelatedFilterAppVersionStateItem>? filterAppVersionState = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppStoreVersionsGetToManyRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionLocalization>? fieldsAppStoreVersionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppStoreVersionsGetToManyRelatedFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionPhasedRelease>? fieldsAppStoreVersionPhasedReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppStoreVersionsGetToManyRelatedFieldsGameCenterAppVersion>? fieldsGameCenterAppVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppStoreVersionsGetToManyRelatedFieldsRoutingAppCoverage>? fieldsRoutingAppCoverages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreReviewDetail>? fieldsAppStoreReviewDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionSubmission>? fieldsAppStoreVersionSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppStoreVersionsGetToManyRelatedFieldsAppClipDefaultExperience>? fieldsAppClipDefaultExperiences = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionExperiment>? fieldsAppStoreVersionExperiments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppStoreVersionsGetToManyRelatedFieldsAlternativeDistributionPackage>? fieldsAlternativeDistributionPackages = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppStoreVersionsGetToManyRelatedIncludeItem>? include = default,
            int? limitAppStoreVersionLocalizations = default,
            int? limitAppStoreVersionExperiments = default,
            int? limitAppStoreVersionExperimentsV2 = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}