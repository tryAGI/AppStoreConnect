#nullable enable

namespace AppStoreConnect
{
    public partial interface IBuildsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterVersion"></param>
        /// <param name="filterExpired"></param>
        /// <param name="filterProcessingState"></param>
        /// <param name="filterBetaAppReviewSubmissionBetaReviewState"></param>
        /// <param name="filterUsesNonExemptEncryption"></param>
        /// <param name="filterPreReleaseVersionVersion"></param>
        /// <param name="filterPreReleaseVersionPlatform"></param>
        /// <param name="filterBuildAudienceType"></param>
        /// <param name="filterPreReleaseVersion"></param>
        /// <param name="filterApp"></param>
        /// <param name="filterBetaGroups"></param>
        /// <param name="filterAppStoreVersion"></param>
        /// <param name="filterId"></param>
        /// <param name="existsUsesNonExemptEncryption"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="fieldsPreReleaseVersions"></param>
        /// <param name="fieldsBetaTesters"></param>
        /// <param name="fieldsBetaGroups"></param>
        /// <param name="fieldsBetaBuildLocalizations"></param>
        /// <param name="fieldsAppEncryptionDeclarations"></param>
        /// <param name="fieldsBetaAppReviewSubmissions"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsBuildBetaDetails"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="fieldsBuildIcons"></param>
        /// <param name="fieldsBuildBundles"></param>
        /// <param name="fieldsBuildUploads"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitBetaBuildLocalizations"></param>
        /// <param name="limitBetaGroups"></param>
        /// <param name="limitBuildBundles"></param>
        /// <param name="limitIcons"></param>
        /// <param name="limitIndividualTesters"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BuildsResponse> BuildsGetCollectionAsync(
            global::System.Collections.Generic.IList<string>? filterVersion = default,
            global::System.Collections.Generic.IList<string>? filterExpired = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFilterProcessingStateItem>? filterProcessingState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem>? filterBetaAppReviewSubmissionBetaReviewState = default,
            global::System.Collections.Generic.IList<string>? filterUsesNonExemptEncryption = default,
            global::System.Collections.Generic.IList<string>? filterPreReleaseVersionVersion = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFilterPreReleaseVersionPlatformItem>? filterPreReleaseVersionPlatform = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFilterBuildAudienceTypeItem>? filterBuildAudienceType = default,
            global::System.Collections.Generic.IList<string>? filterPreReleaseVersion = default,
            global::System.Collections.Generic.IList<string>? filterApp = default,
            global::System.Collections.Generic.IList<string>? filterBetaGroups = default,
            global::System.Collections.Generic.IList<string>? filterAppStoreVersion = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            bool? existsUsesNonExemptEncryption = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsPreReleaseVersion>? fieldsPreReleaseVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBetaTester>? fieldsBetaTesters = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBetaGroup>? fieldsBetaGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBetaBuildLocalization>? fieldsBetaBuildLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsAppEncryptionDeclaration>? fieldsAppEncryptionDeclarations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBetaAppReviewSubmission>? fieldsBetaAppReviewSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBuildBetaDetail>? fieldsBuildBetaDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBuildIcon>? fieldsBuildIcons = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBuildBundle>? fieldsBuildBundles = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBuildUpload>? fieldsBuildUploads = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionIncludeItem>? include = default,
            int? limitBetaBuildLocalizations = default,
            int? limitBetaGroups = default,
            int? limitBuildBundles = default,
            int? limitIcons = default,
            int? limitIndividualTesters = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterVersion"></param>
        /// <param name="filterExpired"></param>
        /// <param name="filterProcessingState"></param>
        /// <param name="filterBetaAppReviewSubmissionBetaReviewState"></param>
        /// <param name="filterUsesNonExemptEncryption"></param>
        /// <param name="filterPreReleaseVersionVersion"></param>
        /// <param name="filterPreReleaseVersionPlatform"></param>
        /// <param name="filterBuildAudienceType"></param>
        /// <param name="filterPreReleaseVersion"></param>
        /// <param name="filterApp"></param>
        /// <param name="filterBetaGroups"></param>
        /// <param name="filterAppStoreVersion"></param>
        /// <param name="filterId"></param>
        /// <param name="existsUsesNonExemptEncryption"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="fieldsPreReleaseVersions"></param>
        /// <param name="fieldsBetaTesters"></param>
        /// <param name="fieldsBetaGroups"></param>
        /// <param name="fieldsBetaBuildLocalizations"></param>
        /// <param name="fieldsAppEncryptionDeclarations"></param>
        /// <param name="fieldsBetaAppReviewSubmissions"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsBuildBetaDetails"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="fieldsBuildIcons"></param>
        /// <param name="fieldsBuildBundles"></param>
        /// <param name="fieldsBuildUploads"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitBetaBuildLocalizations"></param>
        /// <param name="limitBetaGroups"></param>
        /// <param name="limitBuildBundles"></param>
        /// <param name="limitIcons"></param>
        /// <param name="limitIndividualTesters"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BuildsResponse>> BuildsGetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<string>? filterVersion = default,
            global::System.Collections.Generic.IList<string>? filterExpired = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFilterProcessingStateItem>? filterProcessingState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem>? filterBetaAppReviewSubmissionBetaReviewState = default,
            global::System.Collections.Generic.IList<string>? filterUsesNonExemptEncryption = default,
            global::System.Collections.Generic.IList<string>? filterPreReleaseVersionVersion = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFilterPreReleaseVersionPlatformItem>? filterPreReleaseVersionPlatform = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFilterBuildAudienceTypeItem>? filterBuildAudienceType = default,
            global::System.Collections.Generic.IList<string>? filterPreReleaseVersion = default,
            global::System.Collections.Generic.IList<string>? filterApp = default,
            global::System.Collections.Generic.IList<string>? filterBetaGroups = default,
            global::System.Collections.Generic.IList<string>? filterAppStoreVersion = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            bool? existsUsesNonExemptEncryption = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsPreReleaseVersion>? fieldsPreReleaseVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBetaTester>? fieldsBetaTesters = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBetaGroup>? fieldsBetaGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBetaBuildLocalization>? fieldsBetaBuildLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsAppEncryptionDeclaration>? fieldsAppEncryptionDeclarations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBetaAppReviewSubmission>? fieldsBetaAppReviewSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBuildBetaDetail>? fieldsBuildBetaDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBuildIcon>? fieldsBuildIcons = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBuildBundle>? fieldsBuildBundles = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBuildUpload>? fieldsBuildUploads = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionIncludeItem>? include = default,
            int? limitBetaBuildLocalizations = default,
            int? limitBetaGroups = default,
            int? limitBuildBundles = default,
            int? limitIcons = default,
            int? limitIndividualTesters = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}