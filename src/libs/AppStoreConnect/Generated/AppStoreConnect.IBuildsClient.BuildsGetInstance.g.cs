#nullable enable

namespace AppStoreConnect
{
    public partial interface IBuildsClient
    {
        /// <summary>
        ///
        /// </summary>
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
        /// <param name="include"></param>
        /// <param name="limitBetaBuildLocalizations"></param>
        /// <param name="limitBetaGroups"></param>
        /// <param name="limitBuildBundles"></param>
        /// <param name="limitIcons"></param>
        /// <param name="limitIndividualTesters"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BuildResponse> BuildsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsPreReleaseVersion>? fieldsPreReleaseVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBetaTester>? fieldsBetaTesters = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBetaGroup>? fieldsBetaGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBetaBuildLocalization>? fieldsBetaBuildLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsAppEncryptionDeclaration>? fieldsAppEncryptionDeclarations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBetaAppReviewSubmission>? fieldsBetaAppReviewSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBuildBetaDetail>? fieldsBuildBetaDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBuildIcon>? fieldsBuildIcons = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBuildBundle>? fieldsBuildBundles = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBuildUpload>? fieldsBuildUploads = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceIncludeItem>? include = default,
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
        /// <param name="include"></param>
        /// <param name="limitBetaBuildLocalizations"></param>
        /// <param name="limitBetaGroups"></param>
        /// <param name="limitBuildBundles"></param>
        /// <param name="limitIcons"></param>
        /// <param name="limitIndividualTesters"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BuildResponse>> BuildsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsPreReleaseVersion>? fieldsPreReleaseVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBetaTester>? fieldsBetaTesters = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBetaGroup>? fieldsBetaGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBetaBuildLocalization>? fieldsBetaBuildLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsAppEncryptionDeclaration>? fieldsAppEncryptionDeclarations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBetaAppReviewSubmission>? fieldsBetaAppReviewSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBuildBetaDetail>? fieldsBuildBetaDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBuildIcon>? fieldsBuildIcons = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBuildBundle>? fieldsBuildBundles = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBuildUpload>? fieldsBuildUploads = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceIncludeItem>? include = default,
            int? limitBetaBuildLocalizations = default,
            int? limitBetaGroups = default,
            int? limitBuildBundles = default,
            int? limitIcons = default,
            int? limitIndividualTesters = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}