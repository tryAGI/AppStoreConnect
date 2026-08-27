#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterAppVersionsClient
    {
        /// <summary>
        /// 
        /// </summary>
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
        /// <param name="include"></param>
        /// <param name="limitAppStoreVersionLocalizations"></param>
        /// <param name="limitAppStoreVersionExperiments"></param>
        /// <param name="limitAppStoreVersionExperimentsV2"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppStoreVersionResponse> GameCenterAppVersionsAppStoreVersionGetToOneRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization>? fieldsAppStoreVersionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease>? fieldsAppStoreVersionPhasedReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion>? fieldsGameCenterAppVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage>? fieldsRoutingAppCoverages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail>? fieldsAppStoreReviewDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission>? fieldsAppStoreVersionSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience>? fieldsAppClipDefaultExperiences = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment>? fieldsAppStoreVersionExperiments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage>? fieldsAlternativeDistributionPackages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionsAppStoreVersionGetToOneRelatedIncludeItem>? include = default,
            int? limitAppStoreVersionLocalizations = default,
            int? limitAppStoreVersionExperiments = default,
            int? limitAppStoreVersionExperimentsV2 = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
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
        /// <param name="include"></param>
        /// <param name="limitAppStoreVersionLocalizations"></param>
        /// <param name="limitAppStoreVersionExperiments"></param>
        /// <param name="limitAppStoreVersionExperimentsV2"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppStoreVersionResponse>> GameCenterAppVersionsAppStoreVersionGetToOneRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization>? fieldsAppStoreVersionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease>? fieldsAppStoreVersionPhasedReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion>? fieldsGameCenterAppVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage>? fieldsRoutingAppCoverages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail>? fieldsAppStoreReviewDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission>? fieldsAppStoreVersionSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience>? fieldsAppClipDefaultExperiences = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment>? fieldsAppStoreVersionExperiments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage>? fieldsAlternativeDistributionPackages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionsAppStoreVersionGetToOneRelatedIncludeItem>? include = default,
            int? limitAppStoreVersionLocalizations = default,
            int? limitAppStoreVersionExperiments = default,
            int? limitAppStoreVersionExperimentsV2 = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}