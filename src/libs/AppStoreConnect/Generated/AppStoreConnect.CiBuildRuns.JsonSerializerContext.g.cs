
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunCreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataType), TypeInfoPropertyName = "CiBuildRunCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsBuildRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsBuildRunData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsBuildRunDataType), TypeInfoPropertyName = "CiBuildRunCreateRequestDataRelationshipsBuildRunDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsWorkflow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsWorkflowData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsWorkflowDataType), TypeInfoPropertyName = "CiBuildRunCreateRequestDataRelationshipsWorkflowDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagDataType), TypeInfoPropertyName = "CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsPullRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsPullRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsPullRequestDataType), TypeInfoPropertyName = "CiBuildRunCreateRequestDataRelationshipsPullRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunActionsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunActionsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunActionsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunActionsLinkagesResponseDataItemType), TypeInfoPropertyName = "CiBuildRunActionsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunBuildsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunBuildsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunBuildsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunBuildsLinkagesResponseDataItemType), TypeInfoPropertyName = "CiBuildRunBuildsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiBuildRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiBuildRun), TypeInfoPropertyName = "CiBuildRunsGetInstanceFieldsCiBuildRun2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsBuild), TypeInfoPropertyName = "CiBuildRunsGetInstanceFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiWorkflow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiWorkflow), TypeInfoPropertyName = "CiBuildRunsGetInstanceFieldsCiWorkflow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiProduct), TypeInfoPropertyName = "CiBuildRunsGetInstanceFieldsCiProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmGitReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmGitReference), TypeInfoPropertyName = "CiBuildRunsGetInstanceFieldsScmGitReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmPullRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmPullRequest), TypeInfoPropertyName = "CiBuildRunsGetInstanceFieldsScmPullRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsGetInstanceIncludeItem), TypeInfoPropertyName = "CiBuildRunsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction), TypeInfoPropertyName = "CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun), TypeInfoPropertyName = "CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "CiBuildRunsActionsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem), TypeInfoPropertyName = "CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem), TypeInfoPropertyName = "CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem), TypeInfoPropertyName = "CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItem), TypeInfoPropertyName = "CiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedSortItem), TypeInfoPropertyName = "CiBuildRunsBuildsGetToManyRelatedSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuild), TypeInfoPropertyName = "CiBuildRunsBuildsGetToManyRelatedFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion), TypeInfoPropertyName = "CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester), TypeInfoPropertyName = "CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup), TypeInfoPropertyName = "CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalization), TypeInfoPropertyName = "CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration), TypeInfoPropertyName = "CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmission), TypeInfoPropertyName = "CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsApp), TypeInfoPropertyName = "CiBuildRunsBuildsGetToManyRelatedFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail), TypeInfoPropertyName = "CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion), TypeInfoPropertyName = "CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon), TypeInfoPropertyName = "CiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle), TypeInfoPropertyName = "CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload), TypeInfoPropertyName = "CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "CiBuildRunsBuildsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataType?), TypeInfoPropertyName = "NullableCiBuildRunCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsBuildRunDataType?), TypeInfoPropertyName = "NullableCiBuildRunCreateRequestDataRelationshipsBuildRunDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsWorkflowDataType?), TypeInfoPropertyName = "NullableCiBuildRunCreateRequestDataRelationshipsWorkflowDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagDataType?), TypeInfoPropertyName = "NullableCiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsPullRequestDataType?), TypeInfoPropertyName = "NullableCiBuildRunCreateRequestDataRelationshipsPullRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunActionsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableCiBuildRunActionsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunBuildsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableCiBuildRunBuildsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiBuildRun?), TypeInfoPropertyName = "NullableCiBuildRunsGetInstanceFieldsCiBuildRun2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsBuild?), TypeInfoPropertyName = "NullableCiBuildRunsGetInstanceFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiWorkflow?), TypeInfoPropertyName = "NullableCiBuildRunsGetInstanceFieldsCiWorkflow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiProduct?), TypeInfoPropertyName = "NullableCiBuildRunsGetInstanceFieldsCiProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmGitReference?), TypeInfoPropertyName = "NullableCiBuildRunsGetInstanceFieldsScmGitReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmPullRequest?), TypeInfoPropertyName = "NullableCiBuildRunsGetInstanceFieldsScmPullRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableCiBuildRunsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction?), TypeInfoPropertyName = "NullableCiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun?), TypeInfoPropertyName = "NullableCiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableCiBuildRunsActionsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem?), TypeInfoPropertyName = "NullableCiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem?), TypeInfoPropertyName = "NullableCiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem?), TypeInfoPropertyName = "NullableCiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItem?), TypeInfoPropertyName = "NullableCiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedSortItem?), TypeInfoPropertyName = "NullableCiBuildRunsBuildsGetToManyRelatedSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuild?), TypeInfoPropertyName = "NullableCiBuildRunsBuildsGetToManyRelatedFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion?), TypeInfoPropertyName = "NullableCiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester?), TypeInfoPropertyName = "NullableCiBuildRunsBuildsGetToManyRelatedFieldsBetaTester2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup?), TypeInfoPropertyName = "NullableCiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalization?), TypeInfoPropertyName = "NullableCiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration?), TypeInfoPropertyName = "NullableCiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmission?), TypeInfoPropertyName = "NullableCiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsApp?), TypeInfoPropertyName = "NullableCiBuildRunsBuildsGetToManyRelatedFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail?), TypeInfoPropertyName = "NullableCiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion?), TypeInfoPropertyName = "NullableCiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon?), TypeInfoPropertyName = "NullableCiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle?), TypeInfoPropertyName = "NullableCiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload?), TypeInfoPropertyName = "NullableCiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableCiBuildRunsBuildsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunActionsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunBuildsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiBuildRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiWorkflow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmGitReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmPullRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedIncludeItem>))]
    internal sealed partial class CiBuildRunsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CiBuildRunsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static CiBuildRunsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private CiBuildRunsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            global::AppStoreConnect.PartitionCoreSourceGenerationContext.AddConverters(options);
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsBuildRunDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsBuildRunDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsWorkflowDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsWorkflowDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsPullRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsPullRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunActionsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunActionsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunBuildsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunBuildsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiBuildRun)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiBuildRun?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiWorkflow)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiWorkflow?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiProduct)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiProduct?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmGitReference)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmGitReference?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmPullRequest)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmPullRequest?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmission)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmission?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsBuildRunDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunCreateRequestDataRelationshipsBuildRunDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsBuildRunDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunCreateRequestDataRelationshipsBuildRunDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsWorkflowDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunCreateRequestDataRelationshipsWorkflowDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsWorkflowDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunCreateRequestDataRelationshipsWorkflowDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsPullRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunCreateRequestDataRelationshipsPullRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsPullRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunCreateRequestDataRelationshipsPullRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunActionsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunActionsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunActionsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunActionsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunBuildsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunBuildsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunBuildsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunBuildsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiBuildRun))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsGetInstanceFieldsCiBuildRunJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiBuildRun?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsGetInstanceFieldsCiBuildRunNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsGetInstanceFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsGetInstanceFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiWorkflow))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsGetInstanceFieldsCiWorkflowJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiWorkflow?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsGetInstanceFieldsCiWorkflowNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiProduct))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsGetInstanceFieldsCiProductJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiProduct?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsGetInstanceFieldsCiProductNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmGitReference))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsGetInstanceFieldsScmGitReferenceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmGitReference?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsGetInstanceFieldsScmGitReferenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmPullRequest))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsGetInstanceFieldsScmPullRequestJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmPullRequest?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsGetInstanceFieldsScmPullRequestNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsGetInstanceIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsActionsGetToManyRelatedFieldsCiBuildActionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsActionsGetToManyRelatedFieldsCiBuildActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRunJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRunNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsActionsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsActionsGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBetaTesterJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBetaTesterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclarationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclarationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmission))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmissionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmission?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBuildIconJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBuildIconNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundleJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBuildUploadJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBuildUploadNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedIncludeItemNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new CiBuildRunsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::AppStoreConnect.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}