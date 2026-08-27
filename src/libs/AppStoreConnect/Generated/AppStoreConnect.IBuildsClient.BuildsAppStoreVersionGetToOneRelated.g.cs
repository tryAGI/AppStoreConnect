#nullable enable

namespace AppStoreConnect
{
    public partial interface IBuildsClient
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
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppStoreVersionResponse> BuildsAppStoreVersionGetToOneRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization>? fieldsAppStoreVersionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease>? fieldsAppStoreVersionPhasedReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion>? fieldsGameCenterAppVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage>? fieldsRoutingAppCoverages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail>? fieldsAppStoreReviewDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission>? fieldsAppStoreVersionSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience>? fieldsAppClipDefaultExperiences = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment>? fieldsAppStoreVersionExperiments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage>? fieldsAlternativeDistributionPackages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedIncludeItem>? include = default,
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
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppStoreVersionResponse>> BuildsAppStoreVersionGetToOneRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization>? fieldsAppStoreVersionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease>? fieldsAppStoreVersionPhasedReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion>? fieldsGameCenterAppVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage>? fieldsRoutingAppCoverages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail>? fieldsAppStoreReviewDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission>? fieldsAppStoreVersionSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience>? fieldsAppClipDefaultExperiences = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment>? fieldsAppStoreVersionExperiments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage>? fieldsAlternativeDistributionPackages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedIncludeItem>? include = default,
            int? limitAppStoreVersionLocalizations = default,
            int? limitAppStoreVersionExperiments = default,
            int? limitAppStoreVersionExperimentsV2 = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}