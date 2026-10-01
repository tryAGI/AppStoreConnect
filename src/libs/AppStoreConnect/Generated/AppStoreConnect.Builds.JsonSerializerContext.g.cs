
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUpdateRequestDataType), TypeInfoPropertyName = "BuildUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUpdateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUpdateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUpdateRequestDataRelationshipsAppEncryptionDeclaration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUpdateRequestDataRelationshipsAppEncryptionDeclarationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUpdateRequestDataRelationshipsAppEncryptionDeclarationDataType), TypeInfoPropertyName = "BuildUpdateRequestDataRelationshipsAppEncryptionDeclarationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DiagnosticSignature))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DiagnosticSignatureType), TypeInfoPropertyName = "DiagnosticSignatureType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DiagnosticSignatureAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DiagnosticSignatureAttributesDiagnosticType), TypeInfoPropertyName = "DiagnosticSignatureAttributesDiagnosticType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DiagnosticInsight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DiagnosticSignatureRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DiagnosticSignatureRelationshipsLogs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DiagnosticSignaturesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.DiagnosticSignature>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildAppLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildAppLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildAppLinkageResponseDataType), TypeInfoPropertyName = "BuildAppLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEncryptionDeclarationWithoutIncludesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildAppEncryptionDeclarationLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildAppEncryptionDeclarationLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildAppEncryptionDeclarationLinkageResponseDataType), TypeInfoPropertyName = "BuildAppEncryptionDeclarationLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildAppEncryptionDeclarationLinkageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildAppEncryptionDeclarationLinkageRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildAppEncryptionDeclarationLinkageRequestDataType), TypeInfoPropertyName = "BuildAppEncryptionDeclarationLinkageRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildAppStoreVersionLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildAppStoreVersionLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildAppStoreVersionLinkageResponseDataType), TypeInfoPropertyName = "BuildAppStoreVersionLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppReviewSubmissionWithoutIncludesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBetaAppReviewSubmissionLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBetaAppReviewSubmissionLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBetaAppReviewSubmissionLinkageResponseDataType), TypeInfoPropertyName = "BuildBetaAppReviewSubmissionLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationsWithoutIncludesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBetaBuildLocalizationsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaBuildLocalizationsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBetaBuildLocalizationsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBetaBuildLocalizationsLinkagesResponseDataItemType), TypeInfoPropertyName = "BuildBetaBuildLocalizationsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBetaGroupsLinkagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaGroupsLinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBetaGroupsLinkagesRequestDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBetaGroupsLinkagesRequestDataItemType), TypeInfoPropertyName = "BuildBetaGroupsLinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBuildBetaDetailLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBuildBetaDetailLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBuildBetaDetailLinkageResponseDataType), TypeInfoPropertyName = "BuildBuildBetaDetailLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildDiagnosticSignaturesLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildDiagnosticSignaturesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildDiagnosticSignaturesLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildDiagnosticSignaturesLinkagesResponseDataItemType), TypeInfoPropertyName = "BuildDiagnosticSignaturesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildIconsWithoutIncludesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildIconsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildIconsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildIconsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildIconsLinkagesResponseDataItemType), TypeInfoPropertyName = "BuildIconsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildIndividualTestersLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildIndividualTestersLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildIndividualTestersLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildIndividualTestersLinkagesResponseDataItemType), TypeInfoPropertyName = "BuildIndividualTestersLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildIndividualTestersLinkagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildIndividualTestersLinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildIndividualTestersLinkagesRequestDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildIndividualTestersLinkagesRequestDataItemType), TypeInfoPropertyName = "BuildIndividualTestersLinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PrereleaseVersionWithoutIncludesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildPreReleaseVersionLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildPreReleaseVersionLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildPreReleaseVersionLinkageResponseDataType), TypeInfoPropertyName = "BuildPreReleaseVersionLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DiagnosticInsightType), TypeInfoPropertyName = "DiagnosticInsightType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.DiagnosticInsightReferenceVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DiagnosticInsightReferenceVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFilterProcessingStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFilterProcessingStateItem), TypeInfoPropertyName = "BuildsGetCollectionFilterProcessingStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem), TypeInfoPropertyName = "BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFilterPreReleaseVersionPlatformItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFilterPreReleaseVersionPlatformItem), TypeInfoPropertyName = "BuildsGetCollectionFilterPreReleaseVersionPlatformItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFilterBuildAudienceTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFilterBuildAudienceTypeItem), TypeInfoPropertyName = "BuildsGetCollectionFilterBuildAudienceTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionSortItem), TypeInfoPropertyName = "BuildsGetCollectionSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuild), TypeInfoPropertyName = "BuildsGetCollectionFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsPreReleaseVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFieldsPreReleaseVersion), TypeInfoPropertyName = "BuildsGetCollectionFieldsPreReleaseVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBetaTester>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaTester), TypeInfoPropertyName = "BuildsGetCollectionFieldsBetaTester2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBetaGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaGroup), TypeInfoPropertyName = "BuildsGetCollectionFieldsBetaGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBetaBuildLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaBuildLocalization), TypeInfoPropertyName = "BuildsGetCollectionFieldsBetaBuildLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsAppEncryptionDeclaration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFieldsAppEncryptionDeclaration), TypeInfoPropertyName = "BuildsGetCollectionFieldsAppEncryptionDeclaration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBetaAppReviewSubmission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaAppReviewSubmission), TypeInfoPropertyName = "BuildsGetCollectionFieldsBetaAppReviewSubmission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFieldsApp), TypeInfoPropertyName = "BuildsGetCollectionFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBuildBetaDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildBetaDetail), TypeInfoPropertyName = "BuildsGetCollectionFieldsBuildBetaDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFieldsAppStoreVersion), TypeInfoPropertyName = "BuildsGetCollectionFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBuildIcon>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildIcon), TypeInfoPropertyName = "BuildsGetCollectionFieldsBuildIcon2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBuildBundle>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildBundle), TypeInfoPropertyName = "BuildsGetCollectionFieldsBuildBundle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBuildUpload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildUpload), TypeInfoPropertyName = "BuildsGetCollectionFieldsBuildUpload2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionIncludeItem), TypeInfoPropertyName = "BuildsGetCollectionIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuild), TypeInfoPropertyName = "BuildsGetInstanceFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsPreReleaseVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetInstanceFieldsPreReleaseVersion), TypeInfoPropertyName = "BuildsGetInstanceFieldsPreReleaseVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBetaTester>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaTester), TypeInfoPropertyName = "BuildsGetInstanceFieldsBetaTester2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBetaGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaGroup), TypeInfoPropertyName = "BuildsGetInstanceFieldsBetaGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBetaBuildLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaBuildLocalization), TypeInfoPropertyName = "BuildsGetInstanceFieldsBetaBuildLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsAppEncryptionDeclaration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetInstanceFieldsAppEncryptionDeclaration), TypeInfoPropertyName = "BuildsGetInstanceFieldsAppEncryptionDeclaration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBetaAppReviewSubmission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaAppReviewSubmission), TypeInfoPropertyName = "BuildsGetInstanceFieldsBetaAppReviewSubmission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetInstanceFieldsApp), TypeInfoPropertyName = "BuildsGetInstanceFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBuildBetaDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildBetaDetail), TypeInfoPropertyName = "BuildsGetInstanceFieldsBuildBetaDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetInstanceFieldsAppStoreVersion), TypeInfoPropertyName = "BuildsGetInstanceFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBuildIcon>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildIcon), TypeInfoPropertyName = "BuildsGetInstanceFieldsBuildIcon2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBuildBundle>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildBundle), TypeInfoPropertyName = "BuildsGetInstanceFieldsBuildBundle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBuildUpload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildUpload), TypeInfoPropertyName = "BuildsGetInstanceFieldsBuildUpload2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetInstanceIncludeItem), TypeInfoPropertyName = "BuildsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppGetToOneRelatedFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsAppGetToOneRelatedFieldsApp), TypeInfoPropertyName = "BuildsAppGetToOneRelatedFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration), TypeInfoPropertyName = "BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion), TypeInfoPropertyName = "BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsApp), TypeInfoPropertyName = "BuildsAppStoreVersionGetToOneRelatedFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization), TypeInfoPropertyName = "BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsBuild), TypeInfoPropertyName = "BuildsAppStoreVersionGetToOneRelatedFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease), TypeInfoPropertyName = "BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion), TypeInfoPropertyName = "BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage), TypeInfoPropertyName = "BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail), TypeInfoPropertyName = "BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission), TypeInfoPropertyName = "BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience), TypeInfoPropertyName = "BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment), TypeInfoPropertyName = "BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage), TypeInfoPropertyName = "BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedIncludeItem), TypeInfoPropertyName = "BuildsAppStoreVersionGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsBetaAppReviewSubmissionGetToOneRelatedFieldsBetaAppReviewSubmission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsBetaAppReviewSubmissionGetToOneRelatedFieldsBetaAppReviewSubmission), TypeInfoPropertyName = "BuildsBetaAppReviewSubmissionGetToOneRelatedFieldsBetaAppReviewSubmission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsBetaBuildLocalizationsGetToManyRelatedFieldsBetaBuildLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsBetaBuildLocalizationsGetToManyRelatedFieldsBetaBuildLocalization), TypeInfoPropertyName = "BuildsBetaBuildLocalizationsGetToManyRelatedFieldsBetaBuildLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsBuildBetaDetailGetToOneRelatedFieldsBuildBetaDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsBuildBetaDetailGetToOneRelatedFieldsBuildBetaDetail), TypeInfoPropertyName = "BuildsBuildBetaDetailGetToOneRelatedFieldsBuildBetaDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsBuildBetaDetailGetToOneRelatedFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsBuildBetaDetailGetToOneRelatedFieldsBuild), TypeInfoPropertyName = "BuildsBuildBetaDetailGetToOneRelatedFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsBuildBetaDetailGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsBuildBetaDetailGetToOneRelatedIncludeItem), TypeInfoPropertyName = "BuildsBuildBetaDetailGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItem), TypeInfoPropertyName = "BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature), TypeInfoPropertyName = "BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsIconsGetToManyRelatedFieldsBuildIcon>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsIconsGetToManyRelatedFieldsBuildIcon), TypeInfoPropertyName = "BuildsIconsGetToManyRelatedFieldsBuildIcon2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsIndividualTestersGetToManyRelatedFieldsBetaTester>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsIndividualTestersGetToManyRelatedFieldsBetaTester), TypeInfoPropertyName = "BuildsIndividualTestersGetToManyRelatedFieldsBetaTester2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsPerfPowerMetricsGetToManyRelatedFilterPlatformItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsPerfPowerMetricsGetToManyRelatedFilterPlatformItem), TypeInfoPropertyName = "BuildsPerfPowerMetricsGetToManyRelatedFilterPlatformItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem), TypeInfoPropertyName = "BuildsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsPreReleaseVersionGetToOneRelatedFieldsPreReleaseVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsPreReleaseVersionGetToOneRelatedFieldsPreReleaseVersion), TypeInfoPropertyName = "BuildsPreReleaseVersionGetToOneRelatedFieldsPreReleaseVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUpdateRequestDataType?), TypeInfoPropertyName = "NullableBuildUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUpdateRequestDataRelationshipsAppEncryptionDeclarationDataType?), TypeInfoPropertyName = "NullableBuildUpdateRequestDataRelationshipsAppEncryptionDeclarationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DiagnosticSignatureType?), TypeInfoPropertyName = "NullableDiagnosticSignatureType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DiagnosticSignatureAttributesDiagnosticType?), TypeInfoPropertyName = "NullableDiagnosticSignatureAttributesDiagnosticType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildAppLinkageResponseDataType?), TypeInfoPropertyName = "NullableBuildAppLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildAppEncryptionDeclarationLinkageResponseDataType?), TypeInfoPropertyName = "NullableBuildAppEncryptionDeclarationLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildAppEncryptionDeclarationLinkageRequestDataType?), TypeInfoPropertyName = "NullableBuildAppEncryptionDeclarationLinkageRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildAppStoreVersionLinkageResponseDataType?), TypeInfoPropertyName = "NullableBuildAppStoreVersionLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBetaAppReviewSubmissionLinkageResponseDataType?), TypeInfoPropertyName = "NullableBuildBetaAppReviewSubmissionLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBetaBuildLocalizationsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableBuildBetaBuildLocalizationsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBetaGroupsLinkagesRequestDataItemType?), TypeInfoPropertyName = "NullableBuildBetaGroupsLinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBuildBetaDetailLinkageResponseDataType?), TypeInfoPropertyName = "NullableBuildBuildBetaDetailLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildDiagnosticSignaturesLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableBuildDiagnosticSignaturesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildIconsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableBuildIconsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildIndividualTestersLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableBuildIndividualTestersLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildIndividualTestersLinkagesRequestDataItemType?), TypeInfoPropertyName = "NullableBuildIndividualTestersLinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildPreReleaseVersionLinkageResponseDataType?), TypeInfoPropertyName = "NullableBuildPreReleaseVersionLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DiagnosticInsightType?), TypeInfoPropertyName = "NullableDiagnosticInsightType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFilterProcessingStateItem?), TypeInfoPropertyName = "NullableBuildsGetCollectionFilterProcessingStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem?), TypeInfoPropertyName = "NullableBuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFilterPreReleaseVersionPlatformItem?), TypeInfoPropertyName = "NullableBuildsGetCollectionFilterPreReleaseVersionPlatformItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFilterBuildAudienceTypeItem?), TypeInfoPropertyName = "NullableBuildsGetCollectionFilterBuildAudienceTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionSortItem?), TypeInfoPropertyName = "NullableBuildsGetCollectionSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuild?), TypeInfoPropertyName = "NullableBuildsGetCollectionFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFieldsPreReleaseVersion?), TypeInfoPropertyName = "NullableBuildsGetCollectionFieldsPreReleaseVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaTester?), TypeInfoPropertyName = "NullableBuildsGetCollectionFieldsBetaTester2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaGroup?), TypeInfoPropertyName = "NullableBuildsGetCollectionFieldsBetaGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaBuildLocalization?), TypeInfoPropertyName = "NullableBuildsGetCollectionFieldsBetaBuildLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFieldsAppEncryptionDeclaration?), TypeInfoPropertyName = "NullableBuildsGetCollectionFieldsAppEncryptionDeclaration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaAppReviewSubmission?), TypeInfoPropertyName = "NullableBuildsGetCollectionFieldsBetaAppReviewSubmission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFieldsApp?), TypeInfoPropertyName = "NullableBuildsGetCollectionFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildBetaDetail?), TypeInfoPropertyName = "NullableBuildsGetCollectionFieldsBuildBetaDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFieldsAppStoreVersion?), TypeInfoPropertyName = "NullableBuildsGetCollectionFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildIcon?), TypeInfoPropertyName = "NullableBuildsGetCollectionFieldsBuildIcon2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildBundle?), TypeInfoPropertyName = "NullableBuildsGetCollectionFieldsBuildBundle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildUpload?), TypeInfoPropertyName = "NullableBuildsGetCollectionFieldsBuildUpload2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetCollectionIncludeItem?), TypeInfoPropertyName = "NullableBuildsGetCollectionIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuild?), TypeInfoPropertyName = "NullableBuildsGetInstanceFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetInstanceFieldsPreReleaseVersion?), TypeInfoPropertyName = "NullableBuildsGetInstanceFieldsPreReleaseVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaTester?), TypeInfoPropertyName = "NullableBuildsGetInstanceFieldsBetaTester2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaGroup?), TypeInfoPropertyName = "NullableBuildsGetInstanceFieldsBetaGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaBuildLocalization?), TypeInfoPropertyName = "NullableBuildsGetInstanceFieldsBetaBuildLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetInstanceFieldsAppEncryptionDeclaration?), TypeInfoPropertyName = "NullableBuildsGetInstanceFieldsAppEncryptionDeclaration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaAppReviewSubmission?), TypeInfoPropertyName = "NullableBuildsGetInstanceFieldsBetaAppReviewSubmission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetInstanceFieldsApp?), TypeInfoPropertyName = "NullableBuildsGetInstanceFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildBetaDetail?), TypeInfoPropertyName = "NullableBuildsGetInstanceFieldsBuildBetaDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetInstanceFieldsAppStoreVersion?), TypeInfoPropertyName = "NullableBuildsGetInstanceFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildIcon?), TypeInfoPropertyName = "NullableBuildsGetInstanceFieldsBuildIcon2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildBundle?), TypeInfoPropertyName = "NullableBuildsGetInstanceFieldsBuildBundle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildUpload?), TypeInfoPropertyName = "NullableBuildsGetInstanceFieldsBuildUpload2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableBuildsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsAppGetToOneRelatedFieldsApp?), TypeInfoPropertyName = "NullableBuildsAppGetToOneRelatedFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration?), TypeInfoPropertyName = "NullableBuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion?), TypeInfoPropertyName = "NullableBuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsApp?), TypeInfoPropertyName = "NullableBuildsAppStoreVersionGetToOneRelatedFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization?), TypeInfoPropertyName = "NullableBuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsBuild?), TypeInfoPropertyName = "NullableBuildsAppStoreVersionGetToOneRelatedFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease?), TypeInfoPropertyName = "NullableBuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion?), TypeInfoPropertyName = "NullableBuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage?), TypeInfoPropertyName = "NullableBuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail?), TypeInfoPropertyName = "NullableBuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission?), TypeInfoPropertyName = "NullableBuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience?), TypeInfoPropertyName = "NullableBuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment?), TypeInfoPropertyName = "NullableBuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage?), TypeInfoPropertyName = "NullableBuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedIncludeItem?), TypeInfoPropertyName = "NullableBuildsAppStoreVersionGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsBetaAppReviewSubmissionGetToOneRelatedFieldsBetaAppReviewSubmission?), TypeInfoPropertyName = "NullableBuildsBetaAppReviewSubmissionGetToOneRelatedFieldsBetaAppReviewSubmission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsBetaBuildLocalizationsGetToManyRelatedFieldsBetaBuildLocalization?), TypeInfoPropertyName = "NullableBuildsBetaBuildLocalizationsGetToManyRelatedFieldsBetaBuildLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsBuildBetaDetailGetToOneRelatedFieldsBuildBetaDetail?), TypeInfoPropertyName = "NullableBuildsBuildBetaDetailGetToOneRelatedFieldsBuildBetaDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsBuildBetaDetailGetToOneRelatedFieldsBuild?), TypeInfoPropertyName = "NullableBuildsBuildBetaDetailGetToOneRelatedFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsBuildBetaDetailGetToOneRelatedIncludeItem?), TypeInfoPropertyName = "NullableBuildsBuildBetaDetailGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItem?), TypeInfoPropertyName = "NullableBuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature?), TypeInfoPropertyName = "NullableBuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsIconsGetToManyRelatedFieldsBuildIcon?), TypeInfoPropertyName = "NullableBuildsIconsGetToManyRelatedFieldsBuildIcon2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsIndividualTestersGetToManyRelatedFieldsBetaTester?), TypeInfoPropertyName = "NullableBuildsIndividualTestersGetToManyRelatedFieldsBetaTester2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsPerfPowerMetricsGetToManyRelatedFilterPlatformItem?), TypeInfoPropertyName = "NullableBuildsPerfPowerMetricsGetToManyRelatedFilterPlatformItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem?), TypeInfoPropertyName = "NullableBuildsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsPreReleaseVersionGetToOneRelatedFieldsPreReleaseVersion?), TypeInfoPropertyName = "NullableBuildsPreReleaseVersionGetToOneRelatedFieldsPreReleaseVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.DiagnosticSignature>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildBetaBuildLocalizationsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildBetaGroupsLinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildDiagnosticSignaturesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildIconsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildIndividualTestersLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildIndividualTestersLinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.DiagnosticInsightReferenceVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFilterProcessingStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFilterPreReleaseVersionPlatformItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFilterBuildAudienceTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFieldsPreReleaseVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFieldsBetaTester>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFieldsBetaGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFieldsBetaBuildLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFieldsAppEncryptionDeclaration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFieldsBetaAppReviewSubmission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFieldsBuildBetaDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFieldsBuildIcon>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFieldsBuildBundle>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFieldsBuildUpload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetInstanceFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetInstanceFieldsPreReleaseVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetInstanceFieldsBetaTester>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetInstanceFieldsBetaGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetInstanceFieldsBetaBuildLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetInstanceFieldsAppEncryptionDeclaration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetInstanceFieldsBetaAppReviewSubmission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetInstanceFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetInstanceFieldsBuildBetaDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetInstanceFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetInstanceFieldsBuildIcon>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetInstanceFieldsBuildBundle>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetInstanceFieldsBuildUpload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsAppGetToOneRelatedFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsBetaAppReviewSubmissionGetToOneRelatedFieldsBetaAppReviewSubmission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsBetaBuildLocalizationsGetToManyRelatedFieldsBetaBuildLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsBuildBetaDetailGetToOneRelatedFieldsBuildBetaDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsBuildBetaDetailGetToOneRelatedFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsBuildBetaDetailGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsIconsGetToManyRelatedFieldsBuildIcon>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsIndividualTestersGetToManyRelatedFieldsBetaTester>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsPerfPowerMetricsGetToManyRelatedFilterPlatformItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsPreReleaseVersionGetToOneRelatedFieldsPreReleaseVersion>))]
    internal sealed partial class BuildsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BuildsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static BuildsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private BuildsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.BuildUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUpdateRequestDataRelationshipsAppEncryptionDeclarationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUpdateRequestDataRelationshipsAppEncryptionDeclarationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.DiagnosticSignatureType)

                    || typeToConvert == typeof(global::AppStoreConnect.DiagnosticSignatureType?)

                    || typeToConvert == typeof(global::AppStoreConnect.DiagnosticSignatureAttributesDiagnosticType)

                    || typeToConvert == typeof(global::AppStoreConnect.DiagnosticSignatureAttributesDiagnosticType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAppLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAppLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAppEncryptionDeclarationLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAppEncryptionDeclarationLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAppEncryptionDeclarationLinkageRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAppEncryptionDeclarationLinkageRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAppStoreVersionLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAppStoreVersionLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaAppReviewSubmissionLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaAppReviewSubmissionLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaBuildLocalizationsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaBuildLocalizationsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaGroupsLinkagesRequestDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaGroupsLinkagesRequestDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBuildBetaDetailLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBuildBetaDetailLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildDiagnosticSignaturesLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildDiagnosticSignaturesLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildIconsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildIconsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildIndividualTestersLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildIndividualTestersLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildIndividualTestersLinkagesRequestDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildIndividualTestersLinkagesRequestDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildPreReleaseVersionLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildPreReleaseVersionLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.DiagnosticInsightType)

                    || typeToConvert == typeof(global::AppStoreConnect.DiagnosticInsightType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFilterProcessingStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFilterProcessingStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFilterPreReleaseVersionPlatformItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFilterPreReleaseVersionPlatformItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFilterBuildAudienceTypeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFilterBuildAudienceTypeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsPreReleaseVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsPreReleaseVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaTester)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaTester?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaBuildLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaBuildLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsAppEncryptionDeclaration)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsAppEncryptionDeclaration?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaAppReviewSubmission)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaAppReviewSubmission?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildBetaDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildBetaDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildIcon)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildIcon?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildBundle)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildBundle?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildUpload)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildUpload?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsPreReleaseVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsPreReleaseVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaTester)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaTester?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaBuildLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaBuildLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsAppEncryptionDeclaration)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsAppEncryptionDeclaration?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaAppReviewSubmission)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaAppReviewSubmission?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildBetaDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildBetaDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildIcon)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildIcon?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildBundle)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildBundle?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildUpload)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildUpload?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppGetToOneRelatedFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppGetToOneRelatedFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsBetaAppReviewSubmissionGetToOneRelatedFieldsBetaAppReviewSubmission)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsBetaAppReviewSubmissionGetToOneRelatedFieldsBetaAppReviewSubmission?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsBetaBuildLocalizationsGetToManyRelatedFieldsBetaBuildLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsBetaBuildLocalizationsGetToManyRelatedFieldsBetaBuildLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsBuildBetaDetailGetToOneRelatedFieldsBuildBetaDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsBuildBetaDetailGetToOneRelatedFieldsBuildBetaDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsBuildBetaDetailGetToOneRelatedFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsBuildBetaDetailGetToOneRelatedFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsBuildBetaDetailGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsBuildBetaDetailGetToOneRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsIconsGetToManyRelatedFieldsBuildIcon)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsIconsGetToManyRelatedFieldsBuildIcon?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsIndividualTestersGetToManyRelatedFieldsBetaTester)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsIndividualTestersGetToManyRelatedFieldsBetaTester?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsPerfPowerMetricsGetToManyRelatedFilterPlatformItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsPerfPowerMetricsGetToManyRelatedFilterPlatformItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsPreReleaseVersionGetToOneRelatedFieldsPreReleaseVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsPreReleaseVersionGetToOneRelatedFieldsPreReleaseVersion?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.BuildUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUpdateRequestDataRelationshipsAppEncryptionDeclarationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUpdateRequestDataRelationshipsAppEncryptionDeclarationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUpdateRequestDataRelationshipsAppEncryptionDeclarationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUpdateRequestDataRelationshipsAppEncryptionDeclarationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DiagnosticSignatureType))
                {
                    return new global::AppStoreConnect.JsonConverters.DiagnosticSignatureTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DiagnosticSignatureType?))
                {
                    return new global::AppStoreConnect.JsonConverters.DiagnosticSignatureTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DiagnosticSignatureAttributesDiagnosticType))
                {
                    return new global::AppStoreConnect.JsonConverters.DiagnosticSignatureAttributesDiagnosticTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DiagnosticSignatureAttributesDiagnosticType?))
                {
                    return new global::AppStoreConnect.JsonConverters.DiagnosticSignatureAttributesDiagnosticTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAppLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAppLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAppLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAppLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAppEncryptionDeclarationLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAppEncryptionDeclarationLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAppEncryptionDeclarationLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAppEncryptionDeclarationLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAppEncryptionDeclarationLinkageRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAppEncryptionDeclarationLinkageRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAppEncryptionDeclarationLinkageRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAppEncryptionDeclarationLinkageRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAppStoreVersionLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAppStoreVersionLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAppStoreVersionLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAppStoreVersionLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaAppReviewSubmissionLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaAppReviewSubmissionLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaAppReviewSubmissionLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaAppReviewSubmissionLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaBuildLocalizationsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaBuildLocalizationsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaBuildLocalizationsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaBuildLocalizationsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaGroupsLinkagesRequestDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaGroupsLinkagesRequestDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaGroupsLinkagesRequestDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaGroupsLinkagesRequestDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBuildBetaDetailLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBuildBetaDetailLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBuildBetaDetailLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBuildBetaDetailLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildDiagnosticSignaturesLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildDiagnosticSignaturesLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildDiagnosticSignaturesLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildDiagnosticSignaturesLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildIconsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildIconsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildIconsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildIconsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildIndividualTestersLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildIndividualTestersLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildIndividualTestersLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildIndividualTestersLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildIndividualTestersLinkagesRequestDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildIndividualTestersLinkagesRequestDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildIndividualTestersLinkagesRequestDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildIndividualTestersLinkagesRequestDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildPreReleaseVersionLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildPreReleaseVersionLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildPreReleaseVersionLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildPreReleaseVersionLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DiagnosticInsightType))
                {
                    return new global::AppStoreConnect.JsonConverters.DiagnosticInsightTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DiagnosticInsightType?))
                {
                    return new global::AppStoreConnect.JsonConverters.DiagnosticInsightTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFilterProcessingStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFilterProcessingStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFilterProcessingStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFilterProcessingStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFilterPreReleaseVersionPlatformItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFilterPreReleaseVersionPlatformItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFilterPreReleaseVersionPlatformItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFilterPreReleaseVersionPlatformItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFilterBuildAudienceTypeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFilterBuildAudienceTypeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFilterBuildAudienceTypeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFilterBuildAudienceTypeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsPreReleaseVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsPreReleaseVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsPreReleaseVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsPreReleaseVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaTester))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBetaTesterJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaTester?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBetaTesterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBetaGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBetaGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaBuildLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBetaBuildLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaBuildLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBetaBuildLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsAppEncryptionDeclaration))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsAppEncryptionDeclarationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsAppEncryptionDeclaration?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsAppEncryptionDeclarationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaAppReviewSubmission))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBetaAppReviewSubmissionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaAppReviewSubmission?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBetaAppReviewSubmissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildBetaDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBuildBetaDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildBetaDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBuildBetaDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildIcon))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBuildIconJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildIcon?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBuildIconNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildBundle))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBuildBundleJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildBundle?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBuildBundleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildUpload))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBuildUploadJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildUpload?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBuildUploadNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsPreReleaseVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsPreReleaseVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsPreReleaseVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsPreReleaseVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaTester))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBetaTesterJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaTester?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBetaTesterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBetaGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBetaGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaBuildLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBetaBuildLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaBuildLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBetaBuildLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsAppEncryptionDeclaration))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsAppEncryptionDeclarationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsAppEncryptionDeclaration?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsAppEncryptionDeclarationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaAppReviewSubmission))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBetaAppReviewSubmissionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaAppReviewSubmission?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBetaAppReviewSubmissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildBetaDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBuildBetaDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildBetaDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBuildBetaDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildIcon))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBuildIconJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildIcon?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBuildIconNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildBundle))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBuildBundleJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildBundle?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBuildBundleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildUpload))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBuildUploadJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildUpload?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBuildUploadNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppGetToOneRelatedFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppGetToOneRelatedFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppGetToOneRelatedFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppGetToOneRelatedFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclarationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclaration?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppEncryptionDeclarationGetToOneRelatedFieldsAppEncryptionDeclarationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmissionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperienceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperienceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperimentJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperimentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsBetaAppReviewSubmissionGetToOneRelatedFieldsBetaAppReviewSubmission))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsBetaAppReviewSubmissionGetToOneRelatedFieldsBetaAppReviewSubmissionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsBetaAppReviewSubmissionGetToOneRelatedFieldsBetaAppReviewSubmission?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsBetaAppReviewSubmissionGetToOneRelatedFieldsBetaAppReviewSubmissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsBetaBuildLocalizationsGetToManyRelatedFieldsBetaBuildLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsBetaBuildLocalizationsGetToManyRelatedFieldsBetaBuildLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsBetaBuildLocalizationsGetToManyRelatedFieldsBetaBuildLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsBetaBuildLocalizationsGetToManyRelatedFieldsBetaBuildLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsBuildBetaDetailGetToOneRelatedFieldsBuildBetaDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsBuildBetaDetailGetToOneRelatedFieldsBuildBetaDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsBuildBetaDetailGetToOneRelatedFieldsBuildBetaDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsBuildBetaDetailGetToOneRelatedFieldsBuildBetaDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsBuildBetaDetailGetToOneRelatedFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsBuildBetaDetailGetToOneRelatedFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsBuildBetaDetailGetToOneRelatedFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsBuildBetaDetailGetToOneRelatedFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsBuildBetaDetailGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsBuildBetaDetailGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsBuildBetaDetailGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsBuildBetaDetailGetToOneRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignatureJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignatureNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsIconsGetToManyRelatedFieldsBuildIcon))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsIconsGetToManyRelatedFieldsBuildIconJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsIconsGetToManyRelatedFieldsBuildIcon?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsIconsGetToManyRelatedFieldsBuildIconNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsIndividualTestersGetToManyRelatedFieldsBetaTester))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsIndividualTestersGetToManyRelatedFieldsBetaTesterJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsIndividualTestersGetToManyRelatedFieldsBetaTester?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsIndividualTestersGetToManyRelatedFieldsBetaTesterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsPerfPowerMetricsGetToManyRelatedFilterPlatformItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsPerfPowerMetricsGetToManyRelatedFilterPlatformItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsPerfPowerMetricsGetToManyRelatedFilterPlatformItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsPerfPowerMetricsGetToManyRelatedFilterPlatformItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsPreReleaseVersionGetToOneRelatedFieldsPreReleaseVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsPreReleaseVersionGetToOneRelatedFieldsPreReleaseVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsPreReleaseVersionGetToOneRelatedFieldsPreReleaseVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsPreReleaseVersionGetToOneRelatedFieldsPreReleaseVersionNullableJsonConverter();
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
                    0 => new BuildsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::AppStoreConnect.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}