#nullable enable

namespace AppStoreConnect
{
    public partial interface IBuildBetaDetailsClient
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
        /// <param name="limitIndividualTesters"></param>
        /// <param name="limitBetaGroups"></param>
        /// <param name="limitBetaBuildLocalizations"></param>
        /// <param name="limitIcons"></param>
        /// <param name="limitBuildBundles"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BuildResponse> BuildBetaDetailsBuildGetToOneRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsPreReleaseVersion>? fieldsPreReleaseVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester>? fieldsBetaTesters = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup>? fieldsBetaGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaBuildLocalization>? fieldsBetaBuildLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration>? fieldsAppEncryptionDeclarations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaAppReviewSubmission>? fieldsBetaAppReviewSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBetaDetail>? fieldsBuildBetaDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildIcon>? fieldsBuildIcons = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle>? fieldsBuildBundles = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload>? fieldsBuildUploads = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedIncludeItem>? include = default,
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
        /// <param name="limitIndividualTesters"></param>
        /// <param name="limitBetaGroups"></param>
        /// <param name="limitBetaBuildLocalizations"></param>
        /// <param name="limitIcons"></param>
        /// <param name="limitBuildBundles"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BuildResponse>> BuildBetaDetailsBuildGetToOneRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsPreReleaseVersion>? fieldsPreReleaseVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester>? fieldsBetaTesters = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup>? fieldsBetaGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaBuildLocalization>? fieldsBetaBuildLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration>? fieldsAppEncryptionDeclarations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaAppReviewSubmission>? fieldsBetaAppReviewSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBetaDetail>? fieldsBuildBetaDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildIcon>? fieldsBuildIcons = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle>? fieldsBuildBundles = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload>? fieldsBuildUploads = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedIncludeItem>? include = default,
            int? limitIndividualTesters = default,
            int? limitBetaGroups = default,
            int? limitBetaBuildLocalizations = default,
            int? limitIcons = default,
            int? limitBuildBundles = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}