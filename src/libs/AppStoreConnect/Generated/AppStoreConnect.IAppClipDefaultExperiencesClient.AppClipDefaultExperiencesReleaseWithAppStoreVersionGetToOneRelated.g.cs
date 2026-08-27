#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppClipDefaultExperiencesClient
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
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppStoreVersionResponse> AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization>? fieldsAppStoreVersionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease>? fieldsAppStoreVersionPhasedReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion>? fieldsGameCenterAppVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage>? fieldsRoutingAppCoverages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail>? fieldsAppStoreReviewDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission>? fieldsAppStoreVersionSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience>? fieldsAppClipDefaultExperiences = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment>? fieldsAppStoreVersionExperiments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage>? fieldsAlternativeDistributionPackages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedIncludeItem>? include = default,
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
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppStoreVersionResponse>> AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization>? fieldsAppStoreVersionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease>? fieldsAppStoreVersionPhasedReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion>? fieldsGameCenterAppVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage>? fieldsRoutingAppCoverages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail>? fieldsAppStoreReviewDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission>? fieldsAppStoreVersionSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience>? fieldsAppClipDefaultExperiences = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment>? fieldsAppStoreVersionExperiments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage>? fieldsAlternativeDistributionPackages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedIncludeItem>? include = default,
            int? limitAppStoreVersionLocalizations = default,
            int? limitAppStoreVersionExperiments = default,
            int? limitAppStoreVersionExperimentsV2 = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}