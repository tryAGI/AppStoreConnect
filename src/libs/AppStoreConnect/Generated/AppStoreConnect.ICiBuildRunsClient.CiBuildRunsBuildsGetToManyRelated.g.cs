#nullable enable

namespace AppStoreConnect
{
    public partial interface ICiBuildRunsClient
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
        /// <param name="limitIndividualTesters"></param>
        /// <param name="limitBetaGroups"></param>
        /// <param name="limitBetaBuildLocalizations"></param>
        /// <param name="limitIcons"></param>
        /// <param name="limitBuildBundles"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BuildsResponse> CiBuildRunsBuildsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterVersion = default,
            global::System.Collections.Generic.IList<string>? filterExpired = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem>? filterProcessingState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem>? filterBetaAppReviewSubmissionBetaReviewState = default,
            global::System.Collections.Generic.IList<string>? filterUsesNonExemptEncryption = default,
            global::System.Collections.Generic.IList<string>? filterPreReleaseVersionVersion = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem>? filterPreReleaseVersionPlatform = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItem>? filterBuildAudienceType = default,
            global::System.Collections.Generic.IList<string>? filterPreReleaseVersion = default,
            global::System.Collections.Generic.IList<string>? filterApp = default,
            global::System.Collections.Generic.IList<string>? filterBetaGroups = default,
            global::System.Collections.Generic.IList<string>? filterAppStoreVersion = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            bool? existsUsesNonExemptEncryption = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion>? fieldsPreReleaseVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester>? fieldsBetaTesters = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup>? fieldsBetaGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalization>? fieldsBetaBuildLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration>? fieldsAppEncryptionDeclarations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmission>? fieldsBetaAppReviewSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail>? fieldsBuildBetaDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon>? fieldsBuildIcons = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle>? fieldsBuildBundles = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload>? fieldsBuildUploads = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedIncludeItem>? include = default,
            int? limitIndividualTesters = default,
            int? limitBetaGroups = default,
            int? limitBetaBuildLocalizations = default,
            int? limitIcons = default,
            int? limitBuildBundles = default,
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
        /// <param name="limitIndividualTesters"></param>
        /// <param name="limitBetaGroups"></param>
        /// <param name="limitBetaBuildLocalizations"></param>
        /// <param name="limitIcons"></param>
        /// <param name="limitBuildBundles"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BuildsResponse>> CiBuildRunsBuildsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterVersion = default,
            global::System.Collections.Generic.IList<string>? filterExpired = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem>? filterProcessingState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem>? filterBetaAppReviewSubmissionBetaReviewState = default,
            global::System.Collections.Generic.IList<string>? filterUsesNonExemptEncryption = default,
            global::System.Collections.Generic.IList<string>? filterPreReleaseVersionVersion = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem>? filterPreReleaseVersionPlatform = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItem>? filterBuildAudienceType = default,
            global::System.Collections.Generic.IList<string>? filterPreReleaseVersion = default,
            global::System.Collections.Generic.IList<string>? filterApp = default,
            global::System.Collections.Generic.IList<string>? filterBetaGroups = default,
            global::System.Collections.Generic.IList<string>? filterAppStoreVersion = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            bool? existsUsesNonExemptEncryption = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion>? fieldsPreReleaseVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester>? fieldsBetaTesters = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup>? fieldsBetaGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalization>? fieldsBetaBuildLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration>? fieldsAppEncryptionDeclarations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmission>? fieldsBetaAppReviewSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail>? fieldsBuildBetaDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon>? fieldsBuildIcons = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle>? fieldsBuildBundles = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload>? fieldsBuildUploads = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedIncludeItem>? include = default,
            int? limitIndividualTesters = default,
            int? limitBetaGroups = default,
            int? limitBetaBuildLocalizations = default,
            int? limitIcons = default,
            int? limitBuildBundles = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}