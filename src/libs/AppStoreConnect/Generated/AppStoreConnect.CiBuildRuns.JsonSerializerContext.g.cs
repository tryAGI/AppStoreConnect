
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ResourceLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PagedDocumentLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PagingInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DocumentLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Actor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclaration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageVariant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.RelationshipLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem), TypeInfoPropertyName = "IncludedItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem2), TypeInfoPropertyName = "IncludedItem22_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AndroidToIosAppMappingDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Platform), TypeInfoPropertyName = "Platform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipAdvancedExperienceImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ImageAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipAdvancedExperienceLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem3), TypeInfoPropertyName = "IncludedItem32_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClip))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem4), TypeInfoPropertyName = "IncludedItem42_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipAppStoreReviewDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperience))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem5), TypeInfoPropertyName = "IncludedItem52_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipHeaderImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem6), TypeInfoPropertyName = "IncludedItem62_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem7), TypeInfoPropertyName = "IncludedItem72_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem8), TypeInfoPropertyName = "IncludedItem82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem9), TypeInfoPropertyName = "IncludedItem92_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.App))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem10), TypeInfoPropertyName = "IncludedItem102_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCustomProductPageLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem11), TypeInfoPropertyName = "IncludedItem112_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCustomProductPageVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppKeyword))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem12), TypeInfoPropertyName = "IncludedItem122_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem13), TypeInfoPropertyName = "IncludedItem132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCustomProductPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem14), TypeInfoPropertyName = "IncludedItem142_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem15), TypeInfoPropertyName = "IncludedItem152_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem16), TypeInfoPropertyName = "IncludedItem162_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEncryptionDeclarationDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEncryptionDeclaration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEncryptionDeclarationType), TypeInfoPropertyName = "AppEncryptionDeclarationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEncryptionDeclarationAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEncryptionDeclarationState), TypeInfoPropertyName = "AppEncryptionDeclarationState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppDataType), TypeInfoPropertyName = "AppEncryptionDeclarationRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsBuilds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEncryptionDeclarationRelationshipsBuildsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsBuildsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsBuildsDataItemType), TypeInfoPropertyName = "AppEncryptionDeclarationRelationshipsBuildsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentDataType), TypeInfoPropertyName = "AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem18), TypeInfoPropertyName = "IncludedItem182")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Build))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem19), TypeInfoPropertyName = "IncludedItem192")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem20), TypeInfoPropertyName = "IncludedItem202")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventScreenshot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventVideoClip))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem21), TypeInfoPropertyName = "IncludedItem212")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionState), TypeInfoPropertyName = "AppStoreVersionState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem22), TypeInfoPropertyName = "IncludedItem222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem23), TypeInfoPropertyName = "IncludedItem232")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem24), TypeInfoPropertyName = "IncludedItem242")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem25), TypeInfoPropertyName = "IncludedItem252")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPricePointV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem26), TypeInfoPropertyName = "IncludedItem262")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Territory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem27), TypeInfoPropertyName = "IncludedItem272")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem28), TypeInfoPropertyName = "IncludedItem282")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem30), TypeInfoPropertyName = "IncludedItem302")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem31), TypeInfoPropertyName = "IncludedItem312")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem32), TypeInfoPropertyName = "IncludedItem322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreReviewAttachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreReviewDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem33), TypeInfoPropertyName = "IncludedItem332")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem34), TypeInfoPropertyName = "IncludedItem342")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem35), TypeInfoPropertyName = "IncludedItem352")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem36), TypeInfoPropertyName = "IncludedItem362")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem37), TypeInfoPropertyName = "IncludedItem372")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem38), TypeInfoPropertyName = "IncludedItem382")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem39), TypeInfoPropertyName = "IncludedItem392")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem40), TypeInfoPropertyName = "IncludedItem402")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem41), TypeInfoPropertyName = "IncludedItem412")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem42), TypeInfoPropertyName = "IncludedItem422")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem43), TypeInfoPropertyName = "IncludedItem432")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionPhasedRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionSubmission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionType), TypeInfoPropertyName = "AppStoreVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppVersionState), TypeInfoPropertyName = "AppVersionState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAttributesReviewType), TypeInfoPropertyName = "AppStoreVersionAttributesReviewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAttributesReleaseType), TypeInfoPropertyName = "AppStoreVersionAttributesReleaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppDataType), TypeInfoPropertyName = "AppStoreVersionRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItemType), TypeInfoPropertyName = "AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsBuild))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsBuildData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsBuildDataType), TypeInfoPropertyName = "AppStoreVersionRelationshipsBuildDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionPhasedRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionPhasedReleaseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionPhasedReleaseDataType), TypeInfoPropertyName = "AppStoreVersionRelationshipsAppStoreVersionPhasedReleaseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsGameCenterAppVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsGameCenterAppVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsGameCenterAppVersionDataType), TypeInfoPropertyName = "AppStoreVersionRelationshipsGameCenterAppVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsRoutingAppCoverage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsRoutingAppCoverageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsRoutingAppCoverageDataType), TypeInfoPropertyName = "AppStoreVersionRelationshipsRoutingAppCoverageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreReviewDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreReviewDetailData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreReviewDetailDataType), TypeInfoPropertyName = "AppStoreVersionRelationshipsAppStoreReviewDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionSubmission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionSubmissionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionSubmissionDataType), TypeInfoPropertyName = "AppStoreVersionRelationshipsAppStoreVersionSubmissionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppClipDefaultExperience))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppClipDefaultExperienceData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppClipDefaultExperienceDataType), TypeInfoPropertyName = "AppStoreVersionRelationshipsAppClipDefaultExperienceDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperiments))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsDataItemType), TypeInfoPropertyName = "AppStoreVersionRelationshipsAppStoreVersionExperimentsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItemType), TypeInfoPropertyName = "AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsCustomerReviews))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAlternativeDistributionPackage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAlternativeDistributionPackageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAlternativeDistributionPackageDataType), TypeInfoPropertyName = "AppStoreVersionRelationshipsAlternativeDistributionPackageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem44), TypeInfoPropertyName = "IncludedItem442")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.RoutingAppCoverage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem45), TypeInfoPropertyName = "IncludedItem452")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppType), TypeInfoPropertyName = "AppType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion), TypeInfoPropertyName = "SubscriptionStatusUrlVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppAttributesContentRightsDeclaration), TypeInfoPropertyName = "AppAttributesContentRightsDeclaration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAccessibilityDeclarations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppEncryptionDeclarations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsAppEncryptionDeclarationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppEncryptionDeclarationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppEncryptionDeclarationsDataItemType), TypeInfoPropertyName = "AppRelationshipsAppEncryptionDeclarationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppStoreIcon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppStoreIconData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppStoreIconDataType), TypeInfoPropertyName = "AppRelationshipsAppStoreIconDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsCiProduct))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsCiProductData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsCiProductDataType), TypeInfoPropertyName = "AppRelationshipsCiProductDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsBetaTesters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsBetaGroups))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsBetaGroupsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsBetaGroupsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsBetaGroupsDataItemType), TypeInfoPropertyName = "AppRelationshipsBetaGroupsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsAppStoreVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionsDataItemType), TypeInfoPropertyName = "AppRelationshipsAppStoreVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppTags))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsPreReleaseVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsPreReleaseVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsPreReleaseVersionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsPreReleaseVersionsDataItemType), TypeInfoPropertyName = "AppRelationshipsPreReleaseVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsBetaAppLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsBetaAppLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsBetaAppLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsBetaAppLocalizationsDataItemType), TypeInfoPropertyName = "AppRelationshipsBetaAppLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsBuilds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsBuildsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsBuildsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsBuildsDataItemType), TypeInfoPropertyName = "AppRelationshipsBuildsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsBetaLicenseAgreement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsBetaLicenseAgreementData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsBetaLicenseAgreementDataType), TypeInfoPropertyName = "AppRelationshipsBetaLicenseAgreementDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsBetaAppReviewDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsBetaAppReviewDetailData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsBetaAppReviewDetailDataType), TypeInfoPropertyName = "AppRelationshipsBetaAppReviewDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppInfos))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsAppInfosDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppInfosDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppInfosDataItemType), TypeInfoPropertyName = "AppRelationshipsAppInfosDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppClips))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsAppClipsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppClipsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppClipsDataItemType), TypeInfoPropertyName = "AppRelationshipsAppClipsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppPricePoints))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsEndUserLicenseAgreement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsEndUserLicenseAgreementData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsEndUserLicenseAgreementDataType), TypeInfoPropertyName = "AppRelationshipsEndUserLicenseAgreementDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppPriceSchedule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppAvailabilityV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsInAppPurchases))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsInAppPurchasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesDataItemType), TypeInfoPropertyName = "AppRelationshipsInAppPurchasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGroups))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsSubscriptionGroupsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGroupsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGroupsDataItemType), TypeInfoPropertyName = "AppRelationshipsSubscriptionGroupsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsGameCenterEnabledVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsGameCenterEnabledVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsGameCenterEnabledVersionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsGameCenterEnabledVersionsDataItemType), TypeInfoPropertyName = "AppRelationshipsGameCenterEnabledVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsPerfPowerMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppCustomProductPages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsAppCustomProductPagesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppCustomProductPagesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppCustomProductPagesDataItemType), TypeInfoPropertyName = "AppRelationshipsAppCustomProductPagesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsInAppPurchasesV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesV2DataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesV2DataItemType), TypeInfoPropertyName = "AppRelationshipsInAppPurchasesV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsPromotedPurchases))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsPromotedPurchasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsPromotedPurchasesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsPromotedPurchasesDataItemType), TypeInfoPropertyName = "AppRelationshipsPromotedPurchasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppEvents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsAppEventsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppEventsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppEventsDataItemType), TypeInfoPropertyName = "AppRelationshipsAppEventsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsReviewSubmissions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsReviewSubmissionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsReviewSubmissionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsReviewSubmissionsDataItemType), TypeInfoPropertyName = "AppRelationshipsReviewSubmissionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGracePeriod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGracePeriodData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGracePeriodDataType), TypeInfoPropertyName = "AppRelationshipsSubscriptionGracePeriodDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsCustomerReviews))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsCustomerReviewSummarizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsGameCenterDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsGameCenterDetailData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsGameCenterDetailDataType), TypeInfoPropertyName = "AppRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionExperimentsV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsAppStoreVersionExperimentsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionExperimentsV2DataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionExperimentsV2DataItemType), TypeInfoPropertyName = "AppRelationshipsAppStoreVersionExperimentsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAlternativeDistributionKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAnalyticsReportRequests))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsMarketplaceSearchDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsBuildUploads))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsBackgroundAssets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsBetaFeedbackScreenshotSubmissions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsBetaFeedbackCrashSubmissions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsSearchKeywords))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsWebhooks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAndroidToIosAppMappingDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsAndroidToIosAppMappingDetailsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAndroidToIosAppMappingDetailsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAndroidToIosAppMappingDetailsDataItemType), TypeInfoPropertyName = "AppRelationshipsAndroidToIosAppMappingDetailsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem46), TypeInfoPropertyName = "IncludedItem462")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppReviewDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaLicenseAgreement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildIcon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProduct))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.EndUserLicenseAgreement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterEnabledVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PrereleaseVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGracePeriod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem47), TypeInfoPropertyName = "IncludedItem472")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.StateDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.StateDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem50), TypeInfoPropertyName = "IncludedItem502")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem51), TypeInfoPropertyName = "IncludedItem512")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppReviewSubmission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppReviewSubmissionType), TypeInfoPropertyName = "BetaAppReviewSubmissionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppReviewSubmissionAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaReviewState), TypeInfoPropertyName = "BetaReviewState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppReviewSubmissionRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppReviewSubmissionRelationshipsBuild))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppReviewSubmissionRelationshipsBuildData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppReviewSubmissionRelationshipsBuildDataType), TypeInfoPropertyName = "BetaAppReviewSubmissionRelationshipsBuildDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.Build>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationType), TypeInfoPropertyName = "BetaBuildLocalizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationRelationshipsBuild))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationRelationshipsBuildData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationRelationshipsBuildDataType), TypeInfoPropertyName = "BetaBuildLocalizationRelationshipsBuildDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem52), TypeInfoPropertyName = "IncludedItem522")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaTester))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem53), TypeInfoPropertyName = "IncludedItem532")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem54), TypeInfoPropertyName = "IncludedItem542")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem55), TypeInfoPropertyName = "IncludedItem552")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaGroupType), TypeInfoPropertyName = "BetaGroupType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaGroupAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaGroupRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaGroupRelationshipsApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaGroupRelationshipsAppData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaGroupRelationshipsAppDataType), TypeInfoPropertyName = "BetaGroupRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaGroupRelationshipsBuilds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupRelationshipsBuildsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaGroupRelationshipsBuildsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaGroupRelationshipsBuildsDataItemType), TypeInfoPropertyName = "BetaGroupRelationshipsBuildsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaTesters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupRelationshipsBetaTestersDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaTestersDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaTestersDataItemType), TypeInfoPropertyName = "BetaGroupRelationshipsBetaTestersDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaRecruitmentCriteria))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaRecruitmentCriteriaData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaRecruitmentCriteriaDataType), TypeInfoPropertyName = "BetaGroupRelationshipsBetaRecruitmentCriteriaDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaRecruitmentCriterionCompatibleBuildCheck))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem56), TypeInfoPropertyName = "IncludedItem562")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaRecruitmentCriterion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem57), TypeInfoPropertyName = "IncludedItem572")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaTesterType), TypeInfoPropertyName = "BetaTesterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaTesterAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaInviteType), TypeInfoPropertyName = "BetaInviteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaTesterState), TypeInfoPropertyName = "BetaTesterState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTesterAttributesAppDevice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaTesterAttributesAppDevice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaTesterAttributesAppDevicePlatform), TypeInfoPropertyName = "BetaTesterAttributesAppDevicePlatform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaTesterRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaTesterRelationshipsApps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTesterRelationshipsAppsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaTesterRelationshipsAppsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaTesterRelationshipsAppsDataItemType), TypeInfoPropertyName = "BetaTesterRelationshipsAppsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaTesterRelationshipsBetaGroups))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTesterRelationshipsBetaGroupsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaTesterRelationshipsBetaGroupsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaTesterRelationshipsBetaGroupsDataItemType), TypeInfoPropertyName = "BetaTesterRelationshipsBetaGroupsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaTesterRelationshipsBuilds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTesterRelationshipsBuildsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaTesterRelationshipsBuildsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaTesterRelationshipsBuildsDataItemType), TypeInfoPropertyName = "BetaTesterRelationshipsBuildsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem58), TypeInfoPropertyName = "IncludedItem582")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem59), TypeInfoPropertyName = "IncludedItem592")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBetaDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBetaDetailType), TypeInfoPropertyName = "BuildBetaDetailType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBetaDetailAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InternalBetaState), TypeInfoPropertyName = "InternalBetaState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ExternalBetaState), TypeInfoPropertyName = "ExternalBetaState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBetaDetailRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBetaDetailRelationshipsBuild))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBetaDetailRelationshipsBuildData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBetaDetailRelationshipsBuildDataType), TypeInfoPropertyName = "BuildBetaDetailRelationshipsBuildDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleType), TypeInfoPropertyName = "BuildBundleType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleType2), TypeInfoPropertyName = "BuildBundleType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleRelationshipsAppClipDomainCacheStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleRelationshipsAppClipDomainCacheStatusData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleRelationshipsAppClipDomainCacheStatusDataType), TypeInfoPropertyName = "BuildBundleRelationshipsAppClipDomainCacheStatusDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleRelationshipsAppClipDomainDebugStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleRelationshipsAppClipDomainDebugStatusData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleRelationshipsAppClipDomainDebugStatusDataType), TypeInfoPropertyName = "BuildBundleRelationshipsAppClipDomainDebugStatusDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleRelationshipsBetaAppClipInvocations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBundleRelationshipsBetaAppClipInvocationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleRelationshipsBetaAppClipInvocationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleRelationshipsBetaAppClipInvocationsDataItemType), TypeInfoPropertyName = "BuildBundleRelationshipsBetaAppClipInvocationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleRelationshipsBuildBundleFileSizes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBundleRelationshipsBuildBundleFileSizesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleRelationshipsBuildBundleFileSizesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleRelationshipsBuildBundleFileSizesDataItemType), TypeInfoPropertyName = "BuildBundleRelationshipsBuildBundleFileSizesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildIconType), TypeInfoPropertyName = "BuildIconType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildIconAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IconAssetType), TypeInfoPropertyName = "IconAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUpload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadType), TypeInfoPropertyName = "BuildUploadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadAttributesState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadState), TypeInfoPropertyName = "BuildUploadState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadRelationshipsBuild))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadRelationshipsBuildData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadRelationshipsBuildDataType), TypeInfoPropertyName = "BuildUploadRelationshipsBuildDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetFileData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetFileDataType), TypeInfoPropertyName = "BuildUploadRelationshipsAssetFileDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetDescriptionFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetDescriptionFileData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetDescriptionFileDataType), TypeInfoPropertyName = "BuildUploadRelationshipsAssetDescriptionFileDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetSpiFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetSpiFileData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetSpiFileDataType), TypeInfoPropertyName = "BuildUploadRelationshipsAssetSpiFileDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadRelationshipsBuildUploadFiles))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem60), TypeInfoPropertyName = "IncludedItem602")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem61), TypeInfoPropertyName = "IncludedItem612")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildType), TypeInfoPropertyName = "BuildType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildAttributesProcessingState), TypeInfoPropertyName = "BuildAttributesProcessingState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildAudienceType), TypeInfoPropertyName = "BuildAudienceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsPreReleaseVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsPreReleaseVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsPreReleaseVersionDataType), TypeInfoPropertyName = "BuildRelationshipsPreReleaseVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsIndividualTesters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItemType), TypeInfoPropertyName = "BuildRelationshipsIndividualTestersDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsBetaGroups))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItemType), TypeInfoPropertyName = "BuildRelationshipsBetaGroupsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItemType), TypeInfoPropertyName = "BuildRelationshipsBetaBuildLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclaration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclarationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclarationDataType), TypeInfoPropertyName = "BuildRelationshipsAppEncryptionDeclarationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmissionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmissionDataType), TypeInfoPropertyName = "BuildRelationshipsBetaAppReviewSubmissionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsAppData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsAppDataType), TypeInfoPropertyName = "BuildRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsBuildBetaDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsBuildBetaDetailData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsBuildBetaDetailDataType), TypeInfoPropertyName = "BuildRelationshipsBuildBetaDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsAppStoreVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsAppStoreVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsAppStoreVersionDataType), TypeInfoPropertyName = "BuildRelationshipsAppStoreVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsIcons))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildRelationshipsIconsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsIconsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsIconsDataItemType), TypeInfoPropertyName = "BuildRelationshipsIconsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsBuildBundles))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItemType), TypeInfoPropertyName = "BuildRelationshipsBuildBundlesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsBuildUpload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsBuildUploadData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsBuildUploadDataType), TypeInfoPropertyName = "BuildRelationshipsBuildUploadDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsPerfPowerMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsDiagnosticSignatures))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem62>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem62), TypeInfoPropertyName = "IncludedItem622")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "BuildsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem63), TypeInfoPropertyName = "IncludedItem632")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BundleIdCapability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BundleId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem64), TypeInfoPropertyName = "IncludedItem642")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Profile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem65), TypeInfoPropertyName = "IncludedItem652")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Certificate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionType), TypeInfoPropertyName = "CiBuildActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiActionType), TypeInfoPropertyName = "CiActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiIssueCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiExecutionProgress), TypeInfoPropertyName = "CiExecutionProgress2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiCompletionStatus), TypeInfoPropertyName = "CiCompletionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionRelationshipsBuildRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionRelationshipsBuildRunData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionRelationshipsBuildRunDataType), TypeInfoPropertyName = "CiBuildActionRelationshipsBuildRunDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionRelationshipsArtifacts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionRelationshipsIssues))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionRelationshipsTestResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRun))]
    internal sealed partial class CiBuildRunsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunType), TypeInfoPropertyName = "CiBuildRunType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunAttributesSourceCommit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiGitUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunAttributesDestinationCommit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunAttributesStartReason), TypeInfoPropertyName = "CiBuildRunAttributesStartReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunAttributesCancelReason), TypeInfoPropertyName = "CiBuildRunAttributesCancelReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunRelationshipsBuilds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunRelationshipsBuildsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunRelationshipsBuildsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunRelationshipsBuildsDataItemType), TypeInfoPropertyName = "CiBuildRunRelationshipsBuildsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunRelationshipsWorkflow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunRelationshipsWorkflowData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunRelationshipsWorkflowDataType), TypeInfoPropertyName = "CiBuildRunRelationshipsWorkflowDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunRelationshipsProduct))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunRelationshipsProductData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunRelationshipsProductDataType), TypeInfoPropertyName = "CiBuildRunRelationshipsProductDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunRelationshipsSourceBranchOrTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunRelationshipsSourceBranchOrTagData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunRelationshipsSourceBranchOrTagDataType), TypeInfoPropertyName = "CiBuildRunRelationshipsSourceBranchOrTagDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunRelationshipsDestinationBranch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunRelationshipsDestinationBranchData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunRelationshipsDestinationBranchDataType), TypeInfoPropertyName = "CiBuildRunRelationshipsDestinationBranchDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunRelationshipsActions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunRelationshipsPullRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunRelationshipsPullRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunRelationshipsPullRequestDataType), TypeInfoPropertyName = "CiBuildRunRelationshipsPullRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem66), TypeInfoPropertyName = "IncludedItem662")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmGitReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmPullRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem67>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem67), TypeInfoPropertyName = "IncludedItem672")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "CiBuildRunResponseIncludedItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiMacOsVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiXcodeVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductType), TypeInfoPropertyName = "CiProductType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductAttributesProductType), TypeInfoPropertyName = "CiProductAttributesProductType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductRelationshipsApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductRelationshipsAppData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductRelationshipsAppDataType), TypeInfoPropertyName = "CiProductRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductRelationshipsBundleId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductRelationshipsBundleIdData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductRelationshipsBundleIdDataType), TypeInfoPropertyName = "CiProductRelationshipsBundleIdDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductRelationshipsWorkflows))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductRelationshipsPrimaryRepositories))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductRelationshipsPrimaryRepositoriesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductRelationshipsPrimaryRepositoriesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductRelationshipsPrimaryRepositoriesDataItemType), TypeInfoPropertyName = "CiProductRelationshipsPrimaryRepositoriesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductRelationshipsAdditionalRepositories))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductRelationshipsBuildRuns))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem68), TypeInfoPropertyName = "IncludedItem682")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmRepository))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem69), TypeInfoPropertyName = "IncludedItem692")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowType), TypeInfoPropertyName = "CiWorkflowType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBranchStartCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiTagStartCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiPullRequestStartCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiScheduledStartCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiManualBranchStartCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiManualTagStartCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiManualPullRequestStartCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowRelationshipsProduct))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowRelationshipsProductData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowRelationshipsProductDataType), TypeInfoPropertyName = "CiWorkflowRelationshipsProductDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowRelationshipsRepository))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowRelationshipsRepositoryData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowRelationshipsRepositoryDataType), TypeInfoPropertyName = "CiWorkflowRelationshipsRepositoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowRelationshipsXcodeVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowRelationshipsXcodeVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowRelationshipsXcodeVersionDataType), TypeInfoPropertyName = "CiWorkflowRelationshipsXcodeVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowRelationshipsMacOsVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowRelationshipsMacOsVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowRelationshipsMacOsVersionDataType), TypeInfoPropertyName = "CiWorkflowRelationshipsMacOsVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowRelationshipsBuildRuns))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem70), TypeInfoPropertyName = "IncludedItem702")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem71), TypeInfoPropertyName = "IncludedItem712")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiTestDestinationKind), TypeInfoPropertyName = "CiTestDestinationKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem72), TypeInfoPropertyName = "IncludedItem722")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem73), TypeInfoPropertyName = "IncludedItem732")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Device))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem74), TypeInfoPropertyName = "IncludedItem742")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementImageV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem75), TypeInfoPropertyName = "IncludedItem752")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem76), TypeInfoPropertyName = "IncludedItem762")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem77), TypeInfoPropertyName = "IncludedItem772")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem78), TypeInfoPropertyName = "IncludedItem782")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem79), TypeInfoPropertyName = "IncludedItem792")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem80), TypeInfoPropertyName = "IncludedItem802")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem83), TypeInfoPropertyName = "IncludedItem832")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem84), TypeInfoPropertyName = "IncludedItem842")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem85), TypeInfoPropertyName = "IncludedItem852")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem86), TypeInfoPropertyName = "IncludedItem862")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem87), TypeInfoPropertyName = "IncludedItem872")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem88), TypeInfoPropertyName = "IncludedItem882")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem89), TypeInfoPropertyName = "IncludedItem892")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem90), TypeInfoPropertyName = "IncludedItem902")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem91), TypeInfoPropertyName = "IncludedItem912")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem92), TypeInfoPropertyName = "IncludedItem922")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem93), TypeInfoPropertyName = "IncludedItem932")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem94), TypeInfoPropertyName = "IncludedItem942")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem95), TypeInfoPropertyName = "IncludedItem952")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem96), TypeInfoPropertyName = "IncludedItem962")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem97), TypeInfoPropertyName = "IncludedItem972")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallenge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem98), TypeInfoPropertyName = "IncludedItem982")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem99), TypeInfoPropertyName = "IncludedItem992")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem100), TypeInfoPropertyName = "IncludedItem1002")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem101), TypeInfoPropertyName = "IncludedItem1012")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem102), TypeInfoPropertyName = "IncludedItem1022")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem103), TypeInfoPropertyName = "IncludedItem1032")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem104), TypeInfoPropertyName = "IncludedItem1042")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem105), TypeInfoPropertyName = "IncludedItem1052")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardImageV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem106), TypeInfoPropertyName = "IncludedItem1062")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem107), TypeInfoPropertyName = "IncludedItem1072")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem108), TypeInfoPropertyName = "IncludedItem1082")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem109), TypeInfoPropertyName = "IncludedItem1092")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem110), TypeInfoPropertyName = "IncludedItem1102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem111), TypeInfoPropertyName = "IncludedItem1112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetImageV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem112), TypeInfoPropertyName = "IncludedItem1122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem113), TypeInfoPropertyName = "IncludedItem1132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem114), TypeInfoPropertyName = "IncludedItem1142")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem115), TypeInfoPropertyName = "IncludedItem1152")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem116), TypeInfoPropertyName = "IncludedItem1162")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem117), TypeInfoPropertyName = "IncludedItem1172")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem118), TypeInfoPropertyName = "IncludedItem1182")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem119), TypeInfoPropertyName = "IncludedItem1192")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem120), TypeInfoPropertyName = "IncludedItem1202")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem121), TypeInfoPropertyName = "IncludedItem1212")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem122), TypeInfoPropertyName = "IncludedItem1222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem123), TypeInfoPropertyName = "IncludedItem1232")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem124), TypeInfoPropertyName = "IncludedItem1242")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem125), TypeInfoPropertyName = "IncludedItem1252")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem126), TypeInfoPropertyName = "IncludedItem1262")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem127), TypeInfoPropertyName = "IncludedItem1272")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem128), TypeInfoPropertyName = "IncludedItem1282")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem129), TypeInfoPropertyName = "IncludedItem1292")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem130), TypeInfoPropertyName = "IncludedItem1302")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem131), TypeInfoPropertyName = "IncludedItem1312")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseAvailability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseImageV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseOfferCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem138), TypeInfoPropertyName = "IncludedItem1382")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchasePricePoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchasePriceSchedule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem139), TypeInfoPropertyName = "IncludedItem1392")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchasePrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem141), TypeInfoPropertyName = "IncludedItem1412")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem142), TypeInfoPropertyName = "IncludedItem1422")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem143), TypeInfoPropertyName = "IncludedItem1432")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem144), TypeInfoPropertyName = "IncludedItem1442")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem145), TypeInfoPropertyName = "IncludedItem1452")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem146), TypeInfoPropertyName = "IncludedItem1462")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem147), TypeInfoPropertyName = "IncludedItem1472")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PrereleaseVersionType), TypeInfoPropertyName = "PrereleaseVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PrereleaseVersionAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PrereleaseVersionRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsBuilds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.PrereleaseVersionRelationshipsBuildsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsBuildsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsBuildsDataItemType), TypeInfoPropertyName = "PrereleaseVersionRelationshipsBuildsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsAppData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsAppDataType), TypeInfoPropertyName = "PrereleaseVersionRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem148), TypeInfoPropertyName = "IncludedItem1482")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem149), TypeInfoPropertyName = "IncludedItem1492")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem150), TypeInfoPropertyName = "IncludedItem1502")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem151), TypeInfoPropertyName = "IncludedItem1512")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem152), TypeInfoPropertyName = "IncludedItem1522")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Subscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem153), TypeInfoPropertyName = "IncludedItem1532")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem154), TypeInfoPropertyName = "IncludedItem1542")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem155), TypeInfoPropertyName = "IncludedItem1552")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem156), TypeInfoPropertyName = "IncludedItem1562")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem157), TypeInfoPropertyName = "IncludedItem1572")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmGitReferenceType), TypeInfoPropertyName = "ScmGitReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmGitReferenceAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiGitRefKind), TypeInfoPropertyName = "CiGitRefKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmGitReferenceRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmGitReferenceRelationshipsRepository))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmGitReferenceRelationshipsRepositoryData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmGitReferenceRelationshipsRepositoryDataType), TypeInfoPropertyName = "ScmGitReferenceRelationshipsRepositoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmPullRequestType), TypeInfoPropertyName = "ScmPullRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmPullRequestAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmPullRequestRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmPullRequestRelationshipsRepository))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmPullRequestRelationshipsRepositoryData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmPullRequestRelationshipsRepositoryDataType), TypeInfoPropertyName = "ScmPullRequestRelationshipsRepositoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem158), TypeInfoPropertyName = "IncludedItem1582")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem159), TypeInfoPropertyName = "IncludedItem1592")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAvailability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupLocalizationV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem160), TypeInfoPropertyName = "IncludedItem1602")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem161), TypeInfoPropertyName = "IncludedItem1612")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem162), TypeInfoPropertyName = "IncludedItem1622")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem163), TypeInfoPropertyName = "IncludedItem1632")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImageV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionIntroductoryOffer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem164), TypeInfoPropertyName = "IncludedItem1642")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPricePoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem165), TypeInfoPropertyName = "IncludedItem1652")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalizationV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionOfferCodePrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem166), TypeInfoPropertyName = "IncludedItem1662")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem167), TypeInfoPropertyName = "IncludedItem1672")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem168), TypeInfoPropertyName = "IncludedItem1682")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPlanAvailability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem169), TypeInfoPropertyName = "IncludedItem1692")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem170), TypeInfoPropertyName = "IncludedItem1702")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem171), TypeInfoPropertyName = "IncludedItem1712")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionPromotionalOffer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem172), TypeInfoPropertyName = "IncludedItem1722")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem173), TypeInfoPropertyName = "IncludedItem1732")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem174), TypeInfoPropertyName = "IncludedItem1742")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem175), TypeInfoPropertyName = "IncludedItem1752")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem176), TypeInfoPropertyName = "IncludedItem1762")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOffer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem177), TypeInfoPropertyName = "IncludedItem1772")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem179), TypeInfoPropertyName = "IncludedItem1792")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunActionsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunActionsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunActionsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunActionsLinkagesResponseDataItemType), TypeInfoPropertyName = "CiBuildRunActionsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunBuildsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunBuildsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunBuildsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunBuildsLinkagesResponseDataItemType), TypeInfoPropertyName = "CiBuildRunBuildsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ErrorResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>), TypeInfoPropertyName = "OneOfErrorSourcePointerErrorSourceParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorSourcePointer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorSourceParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<string, global::AppStoreConnect.ErrorLinksAssociated>), TypeInfoPropertyName = "OneOfStringErrorLinksAssociated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorLinksAssociated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorLinksAssociatedMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PagingInformationPaging))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiActionDestination), TypeInfoPropertyName = "CiActionDestination2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiActionTestConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiActionTestConfigurationKind), TypeInfoPropertyName = "CiActionTestConfigurationKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiTestDestination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiTestDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiActionPlatform), TypeInfoPropertyName = "CiActionPlatform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBranchPatterns))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBranchPatternsPattern>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBranchPatternsPattern))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiFilesAndFoldersRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiFilesAndFoldersRuleMode), TypeInfoPropertyName = "CiFilesAndFoldersRuleMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiStartConditionFileMatcher>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiStartConditionFileMatcher))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiTagPatterns))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiScheduledStartConditionSchedule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleFrequency), TypeInfoPropertyName = "CiScheduledStartConditionScheduleFrequency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiScheduledStartConditionScheduleDay>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleDay), TypeInfoPropertyName = "CiScheduledStartConditionScheduleDay2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiTagPatternsPattern>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiTagPatternsPattern))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem?), TypeInfoPropertyName = "NullableIncludedItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem2?), TypeInfoPropertyName = "NullableIncludedItem22_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Platform?), TypeInfoPropertyName = "NullablePlatform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem3?), TypeInfoPropertyName = "NullableIncludedItem32_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem4?), TypeInfoPropertyName = "NullableIncludedItem42_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem5?), TypeInfoPropertyName = "NullableIncludedItem52_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem6?), TypeInfoPropertyName = "NullableIncludedItem62_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem7?), TypeInfoPropertyName = "NullableIncludedItem72_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem8?), TypeInfoPropertyName = "NullableIncludedItem82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem9?), TypeInfoPropertyName = "NullableIncludedItem92_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem10?), TypeInfoPropertyName = "NullableIncludedItem102_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem11?), TypeInfoPropertyName = "NullableIncludedItem112_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem12?), TypeInfoPropertyName = "NullableIncludedItem122_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem13?), TypeInfoPropertyName = "NullableIncludedItem132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem14?), TypeInfoPropertyName = "NullableIncludedItem142_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem15?), TypeInfoPropertyName = "NullableIncludedItem152_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem16?), TypeInfoPropertyName = "NullableIncludedItem162_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEncryptionDeclarationType?), TypeInfoPropertyName = "NullableAppEncryptionDeclarationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEncryptionDeclarationState?), TypeInfoPropertyName = "NullableAppEncryptionDeclarationState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppDataType?), TypeInfoPropertyName = "NullableAppEncryptionDeclarationRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsBuildsDataItemType?), TypeInfoPropertyName = "NullableAppEncryptionDeclarationRelationshipsBuildsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentDataType?), TypeInfoPropertyName = "NullableAppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem18?), TypeInfoPropertyName = "NullableIncludedItem182")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem19?), TypeInfoPropertyName = "NullableIncludedItem192")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem20?), TypeInfoPropertyName = "NullableIncludedItem202")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem21?), TypeInfoPropertyName = "NullableIncludedItem212")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionState?), TypeInfoPropertyName = "NullableAppStoreVersionState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem22?), TypeInfoPropertyName = "NullableIncludedItem222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem23?), TypeInfoPropertyName = "NullableIncludedItem232")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem24?), TypeInfoPropertyName = "NullableIncludedItem242")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem25?), TypeInfoPropertyName = "NullableIncludedItem252")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem26?), TypeInfoPropertyName = "NullableIncludedItem262")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem27?), TypeInfoPropertyName = "NullableIncludedItem272")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem28?), TypeInfoPropertyName = "NullableIncludedItem282")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem30?), TypeInfoPropertyName = "NullableIncludedItem302")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem31?), TypeInfoPropertyName = "NullableIncludedItem312")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem32?), TypeInfoPropertyName = "NullableIncludedItem322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem33?), TypeInfoPropertyName = "NullableIncludedItem332")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem34?), TypeInfoPropertyName = "NullableIncludedItem342")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem35?), TypeInfoPropertyName = "NullableIncludedItem352")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem36?), TypeInfoPropertyName = "NullableIncludedItem362")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem37?), TypeInfoPropertyName = "NullableIncludedItem372")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem38?), TypeInfoPropertyName = "NullableIncludedItem382")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem39?), TypeInfoPropertyName = "NullableIncludedItem392")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem40?), TypeInfoPropertyName = "NullableIncludedItem402")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem41?), TypeInfoPropertyName = "NullableIncludedItem412")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem42?), TypeInfoPropertyName = "NullableIncludedItem422")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem43?), TypeInfoPropertyName = "NullableIncludedItem432")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionType?), TypeInfoPropertyName = "NullableAppStoreVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppVersionState?), TypeInfoPropertyName = "NullableAppVersionState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAttributesReviewType?), TypeInfoPropertyName = "NullableAppStoreVersionAttributesReviewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAttributesReleaseType?), TypeInfoPropertyName = "NullableAppStoreVersionAttributesReleaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppDataType?), TypeInfoPropertyName = "NullableAppStoreVersionRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItemType?), TypeInfoPropertyName = "NullableAppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsBuildDataType?), TypeInfoPropertyName = "NullableAppStoreVersionRelationshipsBuildDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionPhasedReleaseDataType?), TypeInfoPropertyName = "NullableAppStoreVersionRelationshipsAppStoreVersionPhasedReleaseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsGameCenterAppVersionDataType?), TypeInfoPropertyName = "NullableAppStoreVersionRelationshipsGameCenterAppVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsRoutingAppCoverageDataType?), TypeInfoPropertyName = "NullableAppStoreVersionRelationshipsRoutingAppCoverageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreReviewDetailDataType?), TypeInfoPropertyName = "NullableAppStoreVersionRelationshipsAppStoreReviewDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionSubmissionDataType?), TypeInfoPropertyName = "NullableAppStoreVersionRelationshipsAppStoreVersionSubmissionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppClipDefaultExperienceDataType?), TypeInfoPropertyName = "NullableAppStoreVersionRelationshipsAppClipDefaultExperienceDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsDataItemType?), TypeInfoPropertyName = "NullableAppStoreVersionRelationshipsAppStoreVersionExperimentsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItemType?), TypeInfoPropertyName = "NullableAppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAlternativeDistributionPackageDataType?), TypeInfoPropertyName = "NullableAppStoreVersionRelationshipsAlternativeDistributionPackageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem44?), TypeInfoPropertyName = "NullableIncludedItem442")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem45?), TypeInfoPropertyName = "NullableIncludedItem452")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppType?), TypeInfoPropertyName = "NullableAppType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion?), TypeInfoPropertyName = "NullableSubscriptionStatusUrlVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppAttributesContentRightsDeclaration?), TypeInfoPropertyName = "NullableAppAttributesContentRightsDeclaration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppEncryptionDeclarationsDataItemType?), TypeInfoPropertyName = "NullableAppRelationshipsAppEncryptionDeclarationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppStoreIconDataType?), TypeInfoPropertyName = "NullableAppRelationshipsAppStoreIconDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsCiProductDataType?), TypeInfoPropertyName = "NullableAppRelationshipsCiProductDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsBetaGroupsDataItemType?), TypeInfoPropertyName = "NullableAppRelationshipsBetaGroupsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionsDataItemType?), TypeInfoPropertyName = "NullableAppRelationshipsAppStoreVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsPreReleaseVersionsDataItemType?), TypeInfoPropertyName = "NullableAppRelationshipsPreReleaseVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsBetaAppLocalizationsDataItemType?), TypeInfoPropertyName = "NullableAppRelationshipsBetaAppLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsBuildsDataItemType?), TypeInfoPropertyName = "NullableAppRelationshipsBuildsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsBetaLicenseAgreementDataType?), TypeInfoPropertyName = "NullableAppRelationshipsBetaLicenseAgreementDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsBetaAppReviewDetailDataType?), TypeInfoPropertyName = "NullableAppRelationshipsBetaAppReviewDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppInfosDataItemType?), TypeInfoPropertyName = "NullableAppRelationshipsAppInfosDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppClipsDataItemType?), TypeInfoPropertyName = "NullableAppRelationshipsAppClipsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsEndUserLicenseAgreementDataType?), TypeInfoPropertyName = "NullableAppRelationshipsEndUserLicenseAgreementDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesDataItemType?), TypeInfoPropertyName = "NullableAppRelationshipsInAppPurchasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGroupsDataItemType?), TypeInfoPropertyName = "NullableAppRelationshipsSubscriptionGroupsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsGameCenterEnabledVersionsDataItemType?), TypeInfoPropertyName = "NullableAppRelationshipsGameCenterEnabledVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppCustomProductPagesDataItemType?), TypeInfoPropertyName = "NullableAppRelationshipsAppCustomProductPagesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesV2DataItemType?), TypeInfoPropertyName = "NullableAppRelationshipsInAppPurchasesV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsPromotedPurchasesDataItemType?), TypeInfoPropertyName = "NullableAppRelationshipsPromotedPurchasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppEventsDataItemType?), TypeInfoPropertyName = "NullableAppRelationshipsAppEventsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsReviewSubmissionsDataItemType?), TypeInfoPropertyName = "NullableAppRelationshipsReviewSubmissionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGracePeriodDataType?), TypeInfoPropertyName = "NullableAppRelationshipsSubscriptionGracePeriodDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsGameCenterDetailDataType?), TypeInfoPropertyName = "NullableAppRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionExperimentsV2DataItemType?), TypeInfoPropertyName = "NullableAppRelationshipsAppStoreVersionExperimentsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsAndroidToIosAppMappingDetailsDataItemType?), TypeInfoPropertyName = "NullableAppRelationshipsAndroidToIosAppMappingDetailsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem46?), TypeInfoPropertyName = "NullableIncludedItem462")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem47?), TypeInfoPropertyName = "NullableIncludedItem472")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem50?), TypeInfoPropertyName = "NullableIncludedItem502")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem51?), TypeInfoPropertyName = "NullableIncludedItem512")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppReviewSubmissionType?), TypeInfoPropertyName = "NullableBetaAppReviewSubmissionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaReviewState?), TypeInfoPropertyName = "NullableBetaReviewState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppReviewSubmissionRelationshipsBuildDataType?), TypeInfoPropertyName = "NullableBetaAppReviewSubmissionRelationshipsBuildDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationType?), TypeInfoPropertyName = "NullableBetaBuildLocalizationType2")]
    internal sealed partial class CiBuildRunsSourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalizationRelationshipsBuildDataType?), TypeInfoPropertyName = "NullableBetaBuildLocalizationRelationshipsBuildDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem52?), TypeInfoPropertyName = "NullableIncludedItem522")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem53?), TypeInfoPropertyName = "NullableIncludedItem532")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem54?), TypeInfoPropertyName = "NullableIncludedItem542")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem55?), TypeInfoPropertyName = "NullableIncludedItem552")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaGroupType?), TypeInfoPropertyName = "NullableBetaGroupType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaGroupRelationshipsAppDataType?), TypeInfoPropertyName = "NullableBetaGroupRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaGroupRelationshipsBuildsDataItemType?), TypeInfoPropertyName = "NullableBetaGroupRelationshipsBuildsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaTestersDataItemType?), TypeInfoPropertyName = "NullableBetaGroupRelationshipsBetaTestersDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaRecruitmentCriteriaDataType?), TypeInfoPropertyName = "NullableBetaGroupRelationshipsBetaRecruitmentCriteriaDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem56?), TypeInfoPropertyName = "NullableIncludedItem562")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem57?), TypeInfoPropertyName = "NullableIncludedItem572")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaTesterType?), TypeInfoPropertyName = "NullableBetaTesterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaInviteType?), TypeInfoPropertyName = "NullableBetaInviteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaTesterState?), TypeInfoPropertyName = "NullableBetaTesterState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaTesterAttributesAppDevicePlatform?), TypeInfoPropertyName = "NullableBetaTesterAttributesAppDevicePlatform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaTesterRelationshipsAppsDataItemType?), TypeInfoPropertyName = "NullableBetaTesterRelationshipsAppsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaTesterRelationshipsBetaGroupsDataItemType?), TypeInfoPropertyName = "NullableBetaTesterRelationshipsBetaGroupsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaTesterRelationshipsBuildsDataItemType?), TypeInfoPropertyName = "NullableBetaTesterRelationshipsBuildsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem58?), TypeInfoPropertyName = "NullableIncludedItem582")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem59?), TypeInfoPropertyName = "NullableIncludedItem592")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBetaDetailType?), TypeInfoPropertyName = "NullableBuildBetaDetailType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InternalBetaState?), TypeInfoPropertyName = "NullableInternalBetaState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ExternalBetaState?), TypeInfoPropertyName = "NullableExternalBetaState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBetaDetailRelationshipsBuildDataType?), TypeInfoPropertyName = "NullableBuildBetaDetailRelationshipsBuildDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleType?), TypeInfoPropertyName = "NullableBuildBundleType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleType2?), TypeInfoPropertyName = "NullableBuildBundleType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleRelationshipsAppClipDomainCacheStatusDataType?), TypeInfoPropertyName = "NullableBuildBundleRelationshipsAppClipDomainCacheStatusDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleRelationshipsAppClipDomainDebugStatusDataType?), TypeInfoPropertyName = "NullableBuildBundleRelationshipsAppClipDomainDebugStatusDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleRelationshipsBetaAppClipInvocationsDataItemType?), TypeInfoPropertyName = "NullableBuildBundleRelationshipsBetaAppClipInvocationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleRelationshipsBuildBundleFileSizesDataItemType?), TypeInfoPropertyName = "NullableBuildBundleRelationshipsBuildBundleFileSizesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildIconType?), TypeInfoPropertyName = "NullableBuildIconType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IconAssetType?), TypeInfoPropertyName = "NullableIconAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadType?), TypeInfoPropertyName = "NullableBuildUploadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadState?), TypeInfoPropertyName = "NullableBuildUploadState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadRelationshipsBuildDataType?), TypeInfoPropertyName = "NullableBuildUploadRelationshipsBuildDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetFileDataType?), TypeInfoPropertyName = "NullableBuildUploadRelationshipsAssetFileDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetDescriptionFileDataType?), TypeInfoPropertyName = "NullableBuildUploadRelationshipsAssetDescriptionFileDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetSpiFileDataType?), TypeInfoPropertyName = "NullableBuildUploadRelationshipsAssetSpiFileDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem60?), TypeInfoPropertyName = "NullableIncludedItem602")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem61?), TypeInfoPropertyName = "NullableIncludedItem612")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildType?), TypeInfoPropertyName = "NullableBuildType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildAttributesProcessingState?), TypeInfoPropertyName = "NullableBuildAttributesProcessingState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildAudienceType?), TypeInfoPropertyName = "NullableBuildAudienceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsPreReleaseVersionDataType?), TypeInfoPropertyName = "NullableBuildRelationshipsPreReleaseVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItemType?), TypeInfoPropertyName = "NullableBuildRelationshipsIndividualTestersDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItemType?), TypeInfoPropertyName = "NullableBuildRelationshipsBetaGroupsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItemType?), TypeInfoPropertyName = "NullableBuildRelationshipsBetaBuildLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclarationDataType?), TypeInfoPropertyName = "NullableBuildRelationshipsAppEncryptionDeclarationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmissionDataType?), TypeInfoPropertyName = "NullableBuildRelationshipsBetaAppReviewSubmissionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsAppDataType?), TypeInfoPropertyName = "NullableBuildRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsBuildBetaDetailDataType?), TypeInfoPropertyName = "NullableBuildRelationshipsBuildBetaDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsAppStoreVersionDataType?), TypeInfoPropertyName = "NullableBuildRelationshipsAppStoreVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsIconsDataItemType?), TypeInfoPropertyName = "NullableBuildRelationshipsIconsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItemType?), TypeInfoPropertyName = "NullableBuildRelationshipsBuildBundlesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildRelationshipsBuildUploadDataType?), TypeInfoPropertyName = "NullableBuildRelationshipsBuildUploadDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem62?), TypeInfoPropertyName = "NullableIncludedItem622")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildsResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableBuildsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem63?), TypeInfoPropertyName = "NullableIncludedItem632")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem64?), TypeInfoPropertyName = "NullableIncludedItem642")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem65?), TypeInfoPropertyName = "NullableIncludedItem652")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionType?), TypeInfoPropertyName = "NullableCiBuildActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiActionType?), TypeInfoPropertyName = "NullableCiActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiExecutionProgress?), TypeInfoPropertyName = "NullableCiExecutionProgress2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiCompletionStatus?), TypeInfoPropertyName = "NullableCiCompletionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionRelationshipsBuildRunDataType?), TypeInfoPropertyName = "NullableCiBuildActionRelationshipsBuildRunDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunType?), TypeInfoPropertyName = "NullableCiBuildRunType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunAttributesStartReason?), TypeInfoPropertyName = "NullableCiBuildRunAttributesStartReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunAttributesCancelReason?), TypeInfoPropertyName = "NullableCiBuildRunAttributesCancelReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunRelationshipsBuildsDataItemType?), TypeInfoPropertyName = "NullableCiBuildRunRelationshipsBuildsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunRelationshipsWorkflowDataType?), TypeInfoPropertyName = "NullableCiBuildRunRelationshipsWorkflowDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunRelationshipsProductDataType?), TypeInfoPropertyName = "NullableCiBuildRunRelationshipsProductDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunRelationshipsSourceBranchOrTagDataType?), TypeInfoPropertyName = "NullableCiBuildRunRelationshipsSourceBranchOrTagDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunRelationshipsDestinationBranchDataType?), TypeInfoPropertyName = "NullableCiBuildRunRelationshipsDestinationBranchDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunRelationshipsPullRequestDataType?), TypeInfoPropertyName = "NullableCiBuildRunRelationshipsPullRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem66?), TypeInfoPropertyName = "NullableIncludedItem662")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem67?), TypeInfoPropertyName = "NullableIncludedItem672")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableCiBuildRunResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataType?), TypeInfoPropertyName = "NullableCiBuildRunCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsBuildRunDataType?), TypeInfoPropertyName = "NullableCiBuildRunCreateRequestDataRelationshipsBuildRunDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsWorkflowDataType?), TypeInfoPropertyName = "NullableCiBuildRunCreateRequestDataRelationshipsWorkflowDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagDataType?), TypeInfoPropertyName = "NullableCiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsPullRequestDataType?), TypeInfoPropertyName = "NullableCiBuildRunCreateRequestDataRelationshipsPullRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductType?), TypeInfoPropertyName = "NullableCiProductType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductAttributesProductType?), TypeInfoPropertyName = "NullableCiProductAttributesProductType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductRelationshipsAppDataType?), TypeInfoPropertyName = "NullableCiProductRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductRelationshipsBundleIdDataType?), TypeInfoPropertyName = "NullableCiProductRelationshipsBundleIdDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductRelationshipsPrimaryRepositoriesDataItemType?), TypeInfoPropertyName = "NullableCiProductRelationshipsPrimaryRepositoriesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem68?), TypeInfoPropertyName = "NullableIncludedItem682")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem69?), TypeInfoPropertyName = "NullableIncludedItem692")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowType?), TypeInfoPropertyName = "NullableCiWorkflowType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowRelationshipsProductDataType?), TypeInfoPropertyName = "NullableCiWorkflowRelationshipsProductDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowRelationshipsRepositoryDataType?), TypeInfoPropertyName = "NullableCiWorkflowRelationshipsRepositoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowRelationshipsXcodeVersionDataType?), TypeInfoPropertyName = "NullableCiWorkflowRelationshipsXcodeVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowRelationshipsMacOsVersionDataType?), TypeInfoPropertyName = "NullableCiWorkflowRelationshipsMacOsVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem70?), TypeInfoPropertyName = "NullableIncludedItem702")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem71?), TypeInfoPropertyName = "NullableIncludedItem712")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiTestDestinationKind?), TypeInfoPropertyName = "NullableCiTestDestinationKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem72?), TypeInfoPropertyName = "NullableIncludedItem722")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem73?), TypeInfoPropertyName = "NullableIncludedItem732")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem74?), TypeInfoPropertyName = "NullableIncludedItem742")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem75?), TypeInfoPropertyName = "NullableIncludedItem752")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem76?), TypeInfoPropertyName = "NullableIncludedItem762")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem77?), TypeInfoPropertyName = "NullableIncludedItem772")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem78?), TypeInfoPropertyName = "NullableIncludedItem782")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem79?), TypeInfoPropertyName = "NullableIncludedItem792")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem80?), TypeInfoPropertyName = "NullableIncludedItem802")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem83?), TypeInfoPropertyName = "NullableIncludedItem832")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem84?), TypeInfoPropertyName = "NullableIncludedItem842")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem85?), TypeInfoPropertyName = "NullableIncludedItem852")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem86?), TypeInfoPropertyName = "NullableIncludedItem862")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem87?), TypeInfoPropertyName = "NullableIncludedItem872")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem88?), TypeInfoPropertyName = "NullableIncludedItem882")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem89?), TypeInfoPropertyName = "NullableIncludedItem892")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem90?), TypeInfoPropertyName = "NullableIncludedItem902")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem91?), TypeInfoPropertyName = "NullableIncludedItem912")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem92?), TypeInfoPropertyName = "NullableIncludedItem922")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem93?), TypeInfoPropertyName = "NullableIncludedItem932")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem94?), TypeInfoPropertyName = "NullableIncludedItem942")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem95?), TypeInfoPropertyName = "NullableIncludedItem952")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem96?), TypeInfoPropertyName = "NullableIncludedItem962")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem97?), TypeInfoPropertyName = "NullableIncludedItem972")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem98?), TypeInfoPropertyName = "NullableIncludedItem982")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem99?), TypeInfoPropertyName = "NullableIncludedItem992")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem100?), TypeInfoPropertyName = "NullableIncludedItem1002")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem101?), TypeInfoPropertyName = "NullableIncludedItem1012")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem102?), TypeInfoPropertyName = "NullableIncludedItem1022")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem103?), TypeInfoPropertyName = "NullableIncludedItem1032")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem104?), TypeInfoPropertyName = "NullableIncludedItem1042")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem105?), TypeInfoPropertyName = "NullableIncludedItem1052")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem106?), TypeInfoPropertyName = "NullableIncludedItem1062")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem107?), TypeInfoPropertyName = "NullableIncludedItem1072")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem108?), TypeInfoPropertyName = "NullableIncludedItem1082")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem109?), TypeInfoPropertyName = "NullableIncludedItem1092")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem110?), TypeInfoPropertyName = "NullableIncludedItem1102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem111?), TypeInfoPropertyName = "NullableIncludedItem1112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem112?), TypeInfoPropertyName = "NullableIncludedItem1122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem113?), TypeInfoPropertyName = "NullableIncludedItem1132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem114?), TypeInfoPropertyName = "NullableIncludedItem1142")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem115?), TypeInfoPropertyName = "NullableIncludedItem1152")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem116?), TypeInfoPropertyName = "NullableIncludedItem1162")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem117?), TypeInfoPropertyName = "NullableIncludedItem1172")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem118?), TypeInfoPropertyName = "NullableIncludedItem1182")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem119?), TypeInfoPropertyName = "NullableIncludedItem1192")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem120?), TypeInfoPropertyName = "NullableIncludedItem1202")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem121?), TypeInfoPropertyName = "NullableIncludedItem1212")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem122?), TypeInfoPropertyName = "NullableIncludedItem1222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem123?), TypeInfoPropertyName = "NullableIncludedItem1232")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem124?), TypeInfoPropertyName = "NullableIncludedItem1242")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem125?), TypeInfoPropertyName = "NullableIncludedItem1252")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem126?), TypeInfoPropertyName = "NullableIncludedItem1262")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem127?), TypeInfoPropertyName = "NullableIncludedItem1272")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem128?), TypeInfoPropertyName = "NullableIncludedItem1282")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem129?), TypeInfoPropertyName = "NullableIncludedItem1292")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem130?), TypeInfoPropertyName = "NullableIncludedItem1302")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem131?), TypeInfoPropertyName = "NullableIncludedItem1312")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem138?), TypeInfoPropertyName = "NullableIncludedItem1382")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem139?), TypeInfoPropertyName = "NullableIncludedItem1392")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem141?), TypeInfoPropertyName = "NullableIncludedItem1412")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem142?), TypeInfoPropertyName = "NullableIncludedItem1422")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem143?), TypeInfoPropertyName = "NullableIncludedItem1432")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem144?), TypeInfoPropertyName = "NullableIncludedItem1442")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem145?), TypeInfoPropertyName = "NullableIncludedItem1452")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem146?), TypeInfoPropertyName = "NullableIncludedItem1462")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem147?), TypeInfoPropertyName = "NullableIncludedItem1472")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PrereleaseVersionType?), TypeInfoPropertyName = "NullablePrereleaseVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsBuildsDataItemType?), TypeInfoPropertyName = "NullablePrereleaseVersionRelationshipsBuildsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsAppDataType?), TypeInfoPropertyName = "NullablePrereleaseVersionRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem148?), TypeInfoPropertyName = "NullableIncludedItem1482")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem149?), TypeInfoPropertyName = "NullableIncludedItem1492")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem150?), TypeInfoPropertyName = "NullableIncludedItem1502")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem151?), TypeInfoPropertyName = "NullableIncludedItem1512")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem152?), TypeInfoPropertyName = "NullableIncludedItem1522")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem153?), TypeInfoPropertyName = "NullableIncludedItem1532")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem154?), TypeInfoPropertyName = "NullableIncludedItem1542")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem155?), TypeInfoPropertyName = "NullableIncludedItem1552")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem156?), TypeInfoPropertyName = "NullableIncludedItem1562")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem157?), TypeInfoPropertyName = "NullableIncludedItem1572")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmGitReferenceType?), TypeInfoPropertyName = "NullableScmGitReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiGitRefKind?), TypeInfoPropertyName = "NullableCiGitRefKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmGitReferenceRelationshipsRepositoryDataType?), TypeInfoPropertyName = "NullableScmGitReferenceRelationshipsRepositoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmPullRequestType?), TypeInfoPropertyName = "NullableScmPullRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmPullRequestRelationshipsRepositoryDataType?), TypeInfoPropertyName = "NullableScmPullRequestRelationshipsRepositoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem158?), TypeInfoPropertyName = "NullableIncludedItem1582")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem159?), TypeInfoPropertyName = "NullableIncludedItem1592")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem160?), TypeInfoPropertyName = "NullableIncludedItem1602")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem161?), TypeInfoPropertyName = "NullableIncludedItem1612")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem162?), TypeInfoPropertyName = "NullableIncludedItem1622")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem163?), TypeInfoPropertyName = "NullableIncludedItem1632")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem164?), TypeInfoPropertyName = "NullableIncludedItem1642")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem165?), TypeInfoPropertyName = "NullableIncludedItem1652")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem166?), TypeInfoPropertyName = "NullableIncludedItem1662")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem167?), TypeInfoPropertyName = "NullableIncludedItem1672")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem168?), TypeInfoPropertyName = "NullableIncludedItem1682")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem169?), TypeInfoPropertyName = "NullableIncludedItem1692")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem170?), TypeInfoPropertyName = "NullableIncludedItem1702")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem171?), TypeInfoPropertyName = "NullableIncludedItem1712")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem172?), TypeInfoPropertyName = "NullableIncludedItem1722")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem173?), TypeInfoPropertyName = "NullableIncludedItem1732")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem174?), TypeInfoPropertyName = "NullableIncludedItem1742")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem175?), TypeInfoPropertyName = "NullableIncludedItem1752")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem176?), TypeInfoPropertyName = "NullableIncludedItem1762")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem177?), TypeInfoPropertyName = "NullableIncludedItem1772")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem179?), TypeInfoPropertyName = "NullableIncludedItem1792")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunActionsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableCiBuildRunActionsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunBuildsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableCiBuildRunBuildsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>?), TypeInfoPropertyName = "NullableOneOfErrorSourcePointerErrorSourceParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<string, global::AppStoreConnect.ErrorLinksAssociated>?), TypeInfoPropertyName = "NullableOneOfStringErrorLinksAssociated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiActionDestination?), TypeInfoPropertyName = "NullableCiActionDestination2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiActionTestConfigurationKind?), TypeInfoPropertyName = "NullableCiActionTestConfigurationKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiActionPlatform?), TypeInfoPropertyName = "NullableCiActionPlatform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiFilesAndFoldersRuleMode?), TypeInfoPropertyName = "NullableCiFilesAndFoldersRuleMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleFrequency?), TypeInfoPropertyName = "NullableCiScheduledStartConditionScheduleFrequency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleDay?), TypeInfoPropertyName = "NullableCiScheduledStartConditionScheduleDay2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEncryptionDeclarationRelationshipsBuildsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsAppEncryptionDeclarationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsBetaGroupsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsAppStoreVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsPreReleaseVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsBetaAppLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsBuildsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsAppInfosDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsAppClipsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsInAppPurchasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsSubscriptionGroupsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsGameCenterEnabledVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsAppCustomProductPagesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsInAppPurchasesV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsPromotedPurchasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsAppEventsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsReviewSubmissionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsAppStoreVersionExperimentsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsAndroidToIosAppMappingDetailsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.StateDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.Build>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaGroupRelationshipsBuildsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaGroupRelationshipsBetaTestersDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaTesterAttributesAppDevice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaTesterRelationshipsAppsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaTesterRelationshipsBetaGroupsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaTesterRelationshipsBuildsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildBundleRelationshipsBetaAppClipInvocationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildBundleRelationshipsBuildBundleFileSizesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsIconsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem62>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunRelationshipsBuildsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem67>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductRelationshipsPrimaryRepositoriesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.PrereleaseVersionRelationshipsBuildsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunActionsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunBuildsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ErrorResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiTestDestination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBranchPatternsPattern>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiStartConditionFileMatcher>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiScheduledStartConditionScheduleDay>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiTagPatternsPattern>))]
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
    internal sealed partial class CiBuildRunsSourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CiBuildRunsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItemJsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem2JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem3JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem4JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem5JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem6JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem7JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem8JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem9JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem10JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem11JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem12JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem13JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem14JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem15JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem16JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem18JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem19JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem20JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem21JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem22JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem23JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem24JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem25JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem26JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem27JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem28JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem30JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem31JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem32JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem33JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem34JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem35JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem36JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem37JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem38JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem39JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem40JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem41JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem42JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem43JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem44JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem45JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem46JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem47JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem50JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem51JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem52JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem53JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem54JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem55JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem56JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem57JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem58JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem59JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem60JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem61JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem62JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem63JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem64JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem65JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem66JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem67JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem68JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem69JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem70JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem71JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem72JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem73JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem74JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem75JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem76JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem77JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem78JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem79JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem80JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem83JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem84JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem85JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem86JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem87JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem88JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem89JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem90JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem91JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem92JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem93JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem94JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem95JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem96JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem97JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem98JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem99JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem100JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem101JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem102JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem103JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem104JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem105JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem106JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem107JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem108JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem109JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem110JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem111JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem112JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem113JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem114JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem115JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem116JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem117JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem118JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem119JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem120JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem121JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem122JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem123JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem124JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem125JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem126JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem127JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem128JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem129JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem130JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem131JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem138JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem139JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem141JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem142JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem143JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem144JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem145JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem146JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem147JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem148JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem149JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem150JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem151JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem152JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem153JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem154JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem155JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem156JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem157JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem158JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem159JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem160JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem161JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem162JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem163JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem164JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem165JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem166JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem167JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem168JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem169JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem170JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem171JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem172JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem173JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem174JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem175JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem176JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem177JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem179JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.OneOfJsonConverter<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.OneOfJsonConverter<string, global::AppStoreConnect.ErrorLinksAssociated>());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsBuildsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsBuildsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAttributesReviewType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAttributesReviewType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAttributesReleaseType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAttributesReleaseType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsBuildDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsBuildDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionPhasedReleaseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionPhasedReleaseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsGameCenterAppVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsGameCenterAppVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsRoutingAppCoverageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsRoutingAppCoverageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreReviewDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreReviewDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionSubmissionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionSubmissionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppClipDefaultExperienceDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppClipDefaultExperienceDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAlternativeDistributionPackageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAlternativeDistributionPackageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAttributesContentRightsDeclaration)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAttributesContentRightsDeclaration?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppEncryptionDeclarationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppEncryptionDeclarationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreIconDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreIconDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsCiProductDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsCiProductDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaGroupsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaGroupsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsPreReleaseVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsPreReleaseVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaAppLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaAppLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBuildsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBuildsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaLicenseAgreementDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaLicenseAgreementDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaAppReviewDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaAppReviewDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppInfosDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppInfosDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppClipsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppClipsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsEndUserLicenseAgreementDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsEndUserLicenseAgreementDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGroupsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGroupsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsGameCenterEnabledVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsGameCenterEnabledVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppCustomProductPagesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppCustomProductPagesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesV2DataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesV2DataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsPromotedPurchasesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsPromotedPurchasesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppEventsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppEventsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsReviewSubmissionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsReviewSubmissionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGracePeriodDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGracePeriodDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionExperimentsV2DataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionExperimentsV2DataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAndroidToIosAppMappingDetailsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAndroidToIosAppMappingDetailsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppReviewSubmissionType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppReviewSubmissionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppReviewSubmissionRelationshipsBuildDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppReviewSubmissionRelationshipsBuildDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationRelationshipsBuildDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationRelationshipsBuildDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaGroupType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaGroupType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaGroupRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaGroupRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaGroupRelationshipsBuildsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaGroupRelationshipsBuildsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaTestersDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaTestersDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaRecruitmentCriteriaDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaRecruitmentCriteriaDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterAttributesAppDevicePlatform)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterAttributesAppDevicePlatform?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterRelationshipsAppsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterRelationshipsAppsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterRelationshipsBetaGroupsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterRelationshipsBetaGroupsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterRelationshipsBuildsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterRelationshipsBuildsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailRelationshipsBuildDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailRelationshipsBuildDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundleType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundleType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundleRelationshipsAppClipDomainCacheStatusDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundleRelationshipsAppClipDomainCacheStatusDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundleRelationshipsAppClipDomainDebugStatusDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundleRelationshipsAppClipDomainDebugStatusDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundleRelationshipsBetaAppClipInvocationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundleRelationshipsBetaAppClipInvocationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundleRelationshipsBuildBundleFileSizesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundleRelationshipsBuildBundleFileSizesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildIconType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildIconType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadRelationshipsBuildDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadRelationshipsBuildDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetFileDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetFileDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetDescriptionFileDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetDescriptionFileDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetSpiFileDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetSpiFileDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAttributesProcessingState)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAttributesProcessingState?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsPreReleaseVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsPreReleaseVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclarationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclarationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmissionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmissionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildBetaDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildBetaDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppStoreVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppStoreVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsIconsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsIconsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildUploadDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildUploadDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionRelationshipsBuildRunDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionRelationshipsBuildRunDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunAttributesStartReason)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunAttributesStartReason?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunAttributesCancelReason)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunAttributesCancelReason?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsBuildsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsBuildsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsWorkflowDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsWorkflowDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsProductDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsProductDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsSourceBranchOrTagDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsSourceBranchOrTagDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsDestinationBranchDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsDestinationBranchDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsPullRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsPullRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsBuildRunDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsBuildRunDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsWorkflowDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsWorkflowDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsPullRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunCreateRequestDataRelationshipsPullRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductAttributesProductType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductAttributesProductType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsBundleIdDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsBundleIdDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsPrimaryRepositoriesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsPrimaryRepositoriesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRelationshipsProductDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRelationshipsProductDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRelationshipsRepositoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRelationshipsRepositoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRelationshipsXcodeVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRelationshipsXcodeVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRelationshipsMacOsVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRelationshipsMacOsVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsBuildsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsBuildsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmGitReferenceType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmGitReferenceType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmGitReferenceRelationshipsRepositoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmGitReferenceRelationshipsRepositoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestRelationshipsRepositoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestRelationshipsRepositoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunActionsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunActionsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunBuildsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunBuildsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppVersionState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppVersionState?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaInviteType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaInviteType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaReviewState)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaReviewState?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterState)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaTesterState?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundleType2)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundleType2?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadState)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadState?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiActionDestination)

                    || typeToConvert == typeof(global::AppStoreConnect.CiActionDestination?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiActionTestConfigurationKind)

                    || typeToConvert == typeof(global::AppStoreConnect.CiActionTestConfigurationKind?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiActionPlatform)

                    || typeToConvert == typeof(global::AppStoreConnect.CiActionPlatform?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiActionType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiActionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiCompletionStatus)

                    || typeToConvert == typeof(global::AppStoreConnect.CiCompletionStatus?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiExecutionProgress)

                    || typeToConvert == typeof(global::AppStoreConnect.CiExecutionProgress?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiFilesAndFoldersRuleMode)

                    || typeToConvert == typeof(global::AppStoreConnect.CiFilesAndFoldersRuleMode?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiGitRefKind)

                    || typeToConvert == typeof(global::AppStoreConnect.CiGitRefKind?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleFrequency)

                    || typeToConvert == typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleFrequency?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleDay)

                    || typeToConvert == typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleDay?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiTestDestinationKind)

                    || typeToConvert == typeof(global::AppStoreConnect.CiTestDestinationKind?)

                    || typeToConvert == typeof(global::AppStoreConnect.ExternalBetaState)

                    || typeToConvert == typeof(global::AppStoreConnect.ExternalBetaState?)

                    || typeToConvert == typeof(global::AppStoreConnect.IconAssetType)

                    || typeToConvert == typeof(global::AppStoreConnect.IconAssetType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InternalBetaState)

                    || typeToConvert == typeof(global::AppStoreConnect.InternalBetaState?)

                    || typeToConvert == typeof(global::AppStoreConnect.Platform)

                    || typeToConvert == typeof(global::AppStoreConnect.Platform?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion?)

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
                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsBuildsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationRelationshipsBuildsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsBuildsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationRelationshipsBuildsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAttributesReviewType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionAttributesReviewTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAttributesReviewType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionAttributesReviewTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAttributesReleaseType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionAttributesReleaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAttributesReleaseType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionAttributesReleaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsBuildDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsBuildDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsBuildDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsBuildDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionPhasedReleaseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAppStoreVersionPhasedReleaseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionPhasedReleaseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAppStoreVersionPhasedReleaseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsGameCenterAppVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsGameCenterAppVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsGameCenterAppVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsGameCenterAppVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsRoutingAppCoverageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsRoutingAppCoverageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsRoutingAppCoverageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsRoutingAppCoverageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreReviewDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAppStoreReviewDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreReviewDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAppStoreReviewDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionSubmissionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAppStoreVersionSubmissionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionSubmissionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAppStoreVersionSubmissionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppClipDefaultExperienceDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAppClipDefaultExperienceDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppClipDefaultExperienceDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAppClipDefaultExperienceDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAppStoreVersionExperimentsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAppStoreVersionExperimentsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAlternativeDistributionPackageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAlternativeDistributionPackageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAlternativeDistributionPackageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAlternativeDistributionPackageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAttributesContentRightsDeclaration))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAttributesContentRightsDeclarationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAttributesContentRightsDeclaration?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAttributesContentRightsDeclarationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppEncryptionDeclarationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppEncryptionDeclarationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppEncryptionDeclarationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppEncryptionDeclarationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreIconDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppStoreIconDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreIconDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppStoreIconDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsCiProductDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsCiProductDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsCiProductDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsCiProductDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaGroupsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsBetaGroupsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaGroupsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsBetaGroupsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppStoreVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppStoreVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsPreReleaseVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsPreReleaseVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsPreReleaseVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsPreReleaseVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaAppLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsBetaAppLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaAppLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsBetaAppLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBuildsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsBuildsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBuildsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsBuildsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaLicenseAgreementDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsBetaLicenseAgreementDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaLicenseAgreementDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsBetaLicenseAgreementDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaAppReviewDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsBetaAppReviewDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaAppReviewDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsBetaAppReviewDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppInfosDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppInfosDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppInfosDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppInfosDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppClipsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppClipsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppClipsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppClipsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsEndUserLicenseAgreementDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsEndUserLicenseAgreementDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsEndUserLicenseAgreementDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsEndUserLicenseAgreementDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsInAppPurchasesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsInAppPurchasesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGroupsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsSubscriptionGroupsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGroupsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsSubscriptionGroupsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsGameCenterEnabledVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsGameCenterEnabledVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsGameCenterEnabledVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsGameCenterEnabledVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppCustomProductPagesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppCustomProductPagesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppCustomProductPagesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppCustomProductPagesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesV2DataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsInAppPurchasesV2DataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesV2DataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsInAppPurchasesV2DataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsPromotedPurchasesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsPromotedPurchasesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsPromotedPurchasesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsPromotedPurchasesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppEventsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppEventsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppEventsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppEventsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsReviewSubmissionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsReviewSubmissionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsReviewSubmissionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsReviewSubmissionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGracePeriodDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsSubscriptionGracePeriodDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGracePeriodDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsSubscriptionGracePeriodDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionExperimentsV2DataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppStoreVersionExperimentsV2DataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionExperimentsV2DataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppStoreVersionExperimentsV2DataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAndroidToIosAppMappingDetailsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAndroidToIosAppMappingDetailsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAndroidToIosAppMappingDetailsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAndroidToIosAppMappingDetailsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppReviewSubmissionType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppReviewSubmissionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppReviewSubmissionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppReviewSubmissionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppReviewSubmissionRelationshipsBuildDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppReviewSubmissionRelationshipsBuildDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppReviewSubmissionRelationshipsBuildDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppReviewSubmissionRelationshipsBuildDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaBuildLocalizationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaBuildLocalizationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationRelationshipsBuildDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaBuildLocalizationRelationshipsBuildDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaBuildLocalizationRelationshipsBuildDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaBuildLocalizationRelationshipsBuildDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaGroupType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaGroupTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaGroupType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaGroupTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaGroupRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaGroupRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaGroupRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaGroupRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaGroupRelationshipsBuildsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaGroupRelationshipsBuildsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaGroupRelationshipsBuildsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaGroupRelationshipsBuildsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaTestersDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaGroupRelationshipsBetaTestersDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaTestersDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaGroupRelationshipsBetaTestersDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaRecruitmentCriteriaDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaGroupRelationshipsBetaRecruitmentCriteriaDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaRecruitmentCriteriaDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaGroupRelationshipsBetaRecruitmentCriteriaDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaTesterType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTesterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaTesterType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTesterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaTesterAttributesAppDevicePlatform))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTesterAttributesAppDevicePlatformJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaTesterAttributesAppDevicePlatform?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTesterAttributesAppDevicePlatformNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaTesterRelationshipsAppsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTesterRelationshipsAppsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaTesterRelationshipsAppsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTesterRelationshipsAppsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaTesterRelationshipsBetaGroupsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTesterRelationshipsBetaGroupsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaTesterRelationshipsBetaGroupsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTesterRelationshipsBetaGroupsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaTesterRelationshipsBuildsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTesterRelationshipsBuildsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaTesterRelationshipsBuildsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTesterRelationshipsBuildsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaDetailTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaDetailTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailRelationshipsBuildDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaDetailRelationshipsBuildDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailRelationshipsBuildDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaDetailRelationshipsBuildDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundleType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundleType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundleTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundleRelationshipsAppClipDomainCacheStatusDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundleRelationshipsAppClipDomainCacheStatusDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundleRelationshipsAppClipDomainCacheStatusDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundleRelationshipsAppClipDomainCacheStatusDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundleRelationshipsAppClipDomainDebugStatusDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundleRelationshipsAppClipDomainDebugStatusDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundleRelationshipsAppClipDomainDebugStatusDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundleRelationshipsAppClipDomainDebugStatusDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundleRelationshipsBetaAppClipInvocationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundleRelationshipsBetaAppClipInvocationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundleRelationshipsBetaAppClipInvocationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundleRelationshipsBetaAppClipInvocationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundleRelationshipsBuildBundleFileSizesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundleRelationshipsBuildBundleFileSizesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundleRelationshipsBuildBundleFileSizesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundleRelationshipsBuildBundleFileSizesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildIconType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildIconTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildIconType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildIconTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadRelationshipsBuildDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadRelationshipsBuildDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadRelationshipsBuildDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadRelationshipsBuildDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetFileDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadRelationshipsAssetFileDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetFileDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadRelationshipsAssetFileDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetDescriptionFileDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadRelationshipsAssetDescriptionFileDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetDescriptionFileDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadRelationshipsAssetDescriptionFileDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetSpiFileDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadRelationshipsAssetSpiFileDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetSpiFileDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadRelationshipsAssetSpiFileDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAttributesProcessingState))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAttributesProcessingStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAttributesProcessingState?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAttributesProcessingStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsPreReleaseVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsPreReleaseVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsPreReleaseVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsPreReleaseVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsIndividualTestersDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsIndividualTestersDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBetaGroupsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBetaGroupsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBetaBuildLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBetaBuildLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclarationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsAppEncryptionDeclarationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclarationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsAppEncryptionDeclarationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmissionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBetaAppReviewSubmissionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmissionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBetaAppReviewSubmissionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildBetaDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBuildBetaDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildBetaDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBuildBetaDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppStoreVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsAppStoreVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppStoreVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsAppStoreVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsIconsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsIconsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsIconsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsIconsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBuildBundlesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBuildBundlesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildUploadDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBuildUploadDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildUploadDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBuildUploadDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionRelationshipsBuildRunDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionRelationshipsBuildRunDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionRelationshipsBuildRunDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionRelationshipsBuildRunDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunAttributesStartReason))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunAttributesStartReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunAttributesStartReason?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunAttributesStartReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunAttributesCancelReason))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunAttributesCancelReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunAttributesCancelReason?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunAttributesCancelReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsBuildsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunRelationshipsBuildsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsBuildsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunRelationshipsBuildsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsWorkflowDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunRelationshipsWorkflowDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsWorkflowDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunRelationshipsWorkflowDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsProductDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunRelationshipsProductDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsProductDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunRelationshipsProductDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsSourceBranchOrTagDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunRelationshipsSourceBranchOrTagDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsSourceBranchOrTagDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunRelationshipsSourceBranchOrTagDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsDestinationBranchDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunRelationshipsDestinationBranchDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsDestinationBranchDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunRelationshipsDestinationBranchDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsPullRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunRelationshipsPullRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunRelationshipsPullRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunRelationshipsPullRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductAttributesProductType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductAttributesProductTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductAttributesProductType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductAttributesProductTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsBundleIdDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductRelationshipsBundleIdDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsBundleIdDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductRelationshipsBundleIdDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsPrimaryRepositoriesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductRelationshipsPrimaryRepositoriesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsPrimaryRepositoriesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductRelationshipsPrimaryRepositoriesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRelationshipsProductDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowRelationshipsProductDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRelationshipsProductDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowRelationshipsProductDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRelationshipsRepositoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowRelationshipsRepositoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRelationshipsRepositoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowRelationshipsRepositoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRelationshipsXcodeVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowRelationshipsXcodeVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRelationshipsXcodeVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowRelationshipsXcodeVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRelationshipsMacOsVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowRelationshipsMacOsVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRelationshipsMacOsVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowRelationshipsMacOsVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionType))
                {
                    return new global::AppStoreConnect.JsonConverters.PrereleaseVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.PrereleaseVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsBuildsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.PrereleaseVersionRelationshipsBuildsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsBuildsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.PrereleaseVersionRelationshipsBuildsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.PrereleaseVersionRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.PrereleaseVersionRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmGitReferenceType))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmGitReferenceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmGitReferenceType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmGitReferenceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmGitReferenceRelationshipsRepositoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmGitReferenceRelationshipsRepositoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmGitReferenceRelationshipsRepositoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmGitReferenceRelationshipsRepositoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestType))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmPullRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmPullRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestRelationshipsRepositoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmPullRequestRelationshipsRepositoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestRelationshipsRepositoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmPullRequestRelationshipsRepositoryDataTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppVersionState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppVersionStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppVersionState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppVersionStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaInviteType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaInviteTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaInviteType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaInviteTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaReviewState))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaReviewStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaReviewState?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaReviewStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaTesterState))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTesterStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaTesterState?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaTesterStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAudienceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAudienceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundleType2))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundleType2JsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundleType2?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundleType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadState))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadState?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiActionDestination))
                {
                    return new global::AppStoreConnect.JsonConverters.CiActionDestinationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiActionDestination?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiActionDestinationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiActionTestConfigurationKind))
                {
                    return new global::AppStoreConnect.JsonConverters.CiActionTestConfigurationKindJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiActionTestConfigurationKind?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiActionTestConfigurationKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiActionPlatform))
                {
                    return new global::AppStoreConnect.JsonConverters.CiActionPlatformJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiActionPlatform?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiActionPlatformNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiActionType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiActionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiCompletionStatus))
                {
                    return new global::AppStoreConnect.JsonConverters.CiCompletionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiCompletionStatus?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiCompletionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiExecutionProgress))
                {
                    return new global::AppStoreConnect.JsonConverters.CiExecutionProgressJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiExecutionProgress?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiExecutionProgressNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiFilesAndFoldersRuleMode))
                {
                    return new global::AppStoreConnect.JsonConverters.CiFilesAndFoldersRuleModeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiFilesAndFoldersRuleMode?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiFilesAndFoldersRuleModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiGitRefKind))
                {
                    return new global::AppStoreConnect.JsonConverters.CiGitRefKindJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiGitRefKind?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiGitRefKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleFrequency))
                {
                    return new global::AppStoreConnect.JsonConverters.CiScheduledStartConditionScheduleFrequencyJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleFrequency?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiScheduledStartConditionScheduleFrequencyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleDay))
                {
                    return new global::AppStoreConnect.JsonConverters.CiScheduledStartConditionScheduleDayJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleDay?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiScheduledStartConditionScheduleDayNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiTestDestinationKind))
                {
                    return new global::AppStoreConnect.JsonConverters.CiTestDestinationKindJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiTestDestinationKind?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiTestDestinationKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ExternalBetaState))
                {
                    return new global::AppStoreConnect.JsonConverters.ExternalBetaStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ExternalBetaState?))
                {
                    return new global::AppStoreConnect.JsonConverters.ExternalBetaStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.IconAssetType))
                {
                    return new global::AppStoreConnect.JsonConverters.IconAssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.IconAssetType?))
                {
                    return new global::AppStoreConnect.JsonConverters.IconAssetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InternalBetaState))
                {
                    return new global::AppStoreConnect.JsonConverters.InternalBetaStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InternalBetaState?))
                {
                    return new global::AppStoreConnect.JsonConverters.InternalBetaStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.Platform))
                {
                    return new global::AppStoreConnect.JsonConverters.PlatformJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.Platform?))
                {
                    return new global::AppStoreConnect.JsonConverters.PlatformNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionStatusUrlVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionStatusUrlVersionNullableJsonConverter();
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
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[3];

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

                    1 => new CiBuildRunsSourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),

                    2 => new CiBuildRunsSourceGenerationContextChunk2(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}