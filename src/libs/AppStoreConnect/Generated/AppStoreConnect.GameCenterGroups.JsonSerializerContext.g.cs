
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem8), TypeInfoPropertyName = "IncludedItem82_3")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem50), TypeInfoPropertyName = "IncludedItem502")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem51), TypeInfoPropertyName = "IncludedItem512")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppReviewSubmission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem52), TypeInfoPropertyName = "IncludedItem522")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaTester))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem53), TypeInfoPropertyName = "IncludedItem532")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem54), TypeInfoPropertyName = "IncludedItem542")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem55), TypeInfoPropertyName = "IncludedItem552")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem56), TypeInfoPropertyName = "IncludedItem562")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaRecruitmentCriterion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem57), TypeInfoPropertyName = "IncludedItem572")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem58), TypeInfoPropertyName = "IncludedItem582")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem59), TypeInfoPropertyName = "IncludedItem592")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBetaDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUploadFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUpload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem60), TypeInfoPropertyName = "IncludedItem602")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem61), TypeInfoPropertyName = "IncludedItem612")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem62), TypeInfoPropertyName = "IncludedItem622")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem63), TypeInfoPropertyName = "IncludedItem632")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BundleIdCapability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BundleId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem64), TypeInfoPropertyName = "IncludedItem642")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Profile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem65), TypeInfoPropertyName = "IncludedItem652")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Certificate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem66), TypeInfoPropertyName = "IncludedItem662")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmGitReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmPullRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem67), TypeInfoPropertyName = "IncludedItem672")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiMacOsVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiXcodeVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem68), TypeInfoPropertyName = "IncludedItem682")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmRepository))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem69), TypeInfoPropertyName = "IncludedItem692")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem70), TypeInfoPropertyName = "IncludedItem702")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem71), TypeInfoPropertyName = "IncludedItem712")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem72), TypeInfoPropertyName = "IncludedItem722")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem73), TypeInfoPropertyName = "IncludedItem732")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Device))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem74), TypeInfoPropertyName = "IncludedItem742")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementImageV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem75), TypeInfoPropertyName = "IncludedItem752")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem76), TypeInfoPropertyName = "IncludedItem762")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationType), TypeInfoPropertyName = "GameCenterAchievementLocalizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementDataType), TypeInfoPropertyName = "GameCenterAchievementLocalizationRelationshipsGameCenterAchievementDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementImageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementImageDataType), TypeInfoPropertyName = "GameCenterAchievementLocalizationRelationshipsGameCenterAchievementImageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem77), TypeInfoPropertyName = "IncludedItem772")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem78), TypeInfoPropertyName = "IncludedItem782")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleaseType), TypeInfoPropertyName = "GameCenterAchievementReleaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleaseAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterDetailData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterDetailDataType), TypeInfoPropertyName = "GameCenterAchievementReleaseRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterAchievement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterAchievementData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterAchievementDataType), TypeInfoPropertyName = "GameCenterAchievementReleaseRelationshipsGameCenterAchievementDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem79), TypeInfoPropertyName = "IncludedItem792")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem80), TypeInfoPropertyName = "IncludedItem802")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2Type), TypeInfoPropertyName = "GameCenterAchievementVersionV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2Attributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterVersionState), TypeInfoPropertyName = "GameCenterVersionState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2Relationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsAchievement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsAchievementData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsAchievementDataType), TypeInfoPropertyName = "GameCenterAchievementVersionV2RelationshipsAchievementDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItemType), TypeInfoPropertyName = "GameCenterAchievementVersionV2RelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem81), TypeInfoPropertyName = "IncludedItem812")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem82), TypeInfoPropertyName = "IncludedItem822")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2Type), TypeInfoPropertyName = "GameCenterAchievementV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2Attributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2Relationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterDetailData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterDetailDataType), TypeInfoPropertyName = "GameCenterAchievementV2RelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterGroupData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterGroupDataType), TypeInfoPropertyName = "GameCenterAchievementV2RelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsActivity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsActivityData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsActivityDataType), TypeInfoPropertyName = "GameCenterAchievementV2RelationshipsActivityDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementV2RelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsVersionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsVersionsDataItemType), TypeInfoPropertyName = "GameCenterAchievementV2RelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem83>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem83), TypeInfoPropertyName = "IncludedItem832")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsV2ResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsV2ResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterAchievementsV2ResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem84), TypeInfoPropertyName = "IncludedItem842")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementType), TypeInfoPropertyName = "GameCenterAchievementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterDetailData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterDetailDataType), TypeInfoPropertyName = "GameCenterAchievementRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterGroupData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterGroupDataType), TypeInfoPropertyName = "GameCenterAchievementRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGroupAchievement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGroupAchievementData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGroupAchievementDataType), TypeInfoPropertyName = "GameCenterAchievementRelationshipsGroupAchievementDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsLocalizationsDataItemType), TypeInfoPropertyName = "GameCenterAchievementRelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsReleases))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementRelationshipsReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsReleasesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsReleasesDataItemType), TypeInfoPropertyName = "GameCenterAchievementRelationshipsReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsActivity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsActivityData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsActivityDataType), TypeInfoPropertyName = "GameCenterAchievementRelationshipsActivityDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem85>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem85), TypeInfoPropertyName = "IncludedItem852")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterAchievementsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem86), TypeInfoPropertyName = "IncludedItem862")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityType), TypeInfoPropertyName = "GameCenterActivityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityAttributesPlayStyle), TypeInfoPropertyName = "GameCenterActivityAttributesPlayStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterDetailData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterDetailDataType), TypeInfoPropertyName = "GameCenterActivityRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterGroupData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterGroupDataType), TypeInfoPropertyName = "GameCenterActivityRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievements))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsDataItemType), TypeInfoPropertyName = "GameCenterActivityRelationshipsAchievementsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsV2DataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsV2DataItemType), TypeInfoPropertyName = "GameCenterActivityRelationshipsAchievementsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboards))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsDataItemType), TypeInfoPropertyName = "GameCenterActivityRelationshipsLeaderboardsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsV2DataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsV2DataItemType), TypeInfoPropertyName = "GameCenterActivityRelationshipsLeaderboardsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityRelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsVersionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsVersionsDataItemType), TypeInfoPropertyName = "GameCenterActivityRelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivitiesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem87>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem87), TypeInfoPropertyName = "IncludedItem872")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivitiesResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivitiesResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterActivitiesResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem88), TypeInfoPropertyName = "IncludedItem882")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem89), TypeInfoPropertyName = "IncludedItem892")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem90), TypeInfoPropertyName = "IncludedItem902")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionReleaseType), TypeInfoPropertyName = "GameCenterActivityVersionReleaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionReleaseRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionReleaseRelationshipsVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionReleaseRelationshipsVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionReleaseRelationshipsVersionDataType), TypeInfoPropertyName = "GameCenterActivityVersionReleaseRelationshipsVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionType), TypeInfoPropertyName = "GameCenterActivityVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsActivity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsActivityData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsActivityDataType), TypeInfoPropertyName = "GameCenterActivityVersionRelationshipsActivityDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityVersionRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsLocalizationsDataItemType), TypeInfoPropertyName = "GameCenterActivityVersionRelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsDefaultImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsDefaultImageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsDefaultImageDataType), TypeInfoPropertyName = "GameCenterActivityVersionRelationshipsDefaultImageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsReleases))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityVersionRelationshipsReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsReleasesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsReleasesDataItemType), TypeInfoPropertyName = "GameCenterActivityVersionRelationshipsReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem91), TypeInfoPropertyName = "IncludedItem912")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem92), TypeInfoPropertyName = "IncludedItem922")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionType), TypeInfoPropertyName = "GameCenterAppVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionAttributes))]
    internal sealed partial class GameCenterGroupsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsCompatibilityVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionRelationshipsCompatibilityVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsCompatibilityVersionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsCompatibilityVersionsDataItemType), TypeInfoPropertyName = "GameCenterAppVersionRelationshipsCompatibilityVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsAppStoreVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsAppStoreVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsAppStoreVersionDataType), TypeInfoPropertyName = "GameCenterAppVersionRelationshipsAppStoreVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem93), TypeInfoPropertyName = "IncludedItem932")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem94), TypeInfoPropertyName = "IncludedItem942")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem95), TypeInfoPropertyName = "IncludedItem952")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem96), TypeInfoPropertyName = "IncludedItem962")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseType), TypeInfoPropertyName = "GameCenterChallengeVersionReleaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseRelationshipsVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseRelationshipsVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseRelationshipsVersionDataType), TypeInfoPropertyName = "GameCenterChallengeVersionReleaseRelationshipsVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionType), TypeInfoPropertyName = "GameCenterChallengeVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsChallenge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsChallengeData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsChallengeDataType), TypeInfoPropertyName = "GameCenterChallengeVersionRelationshipsChallengeDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersionRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsLocalizationsDataItemType), TypeInfoPropertyName = "GameCenterChallengeVersionRelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsReleases))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersionRelationshipsReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsReleasesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsReleasesDataItemType), TypeInfoPropertyName = "GameCenterChallengeVersionRelationshipsReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsDefaultImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsDefaultImageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsDefaultImageDataType), TypeInfoPropertyName = "GameCenterChallengeVersionRelationshipsDefaultImageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem97), TypeInfoPropertyName = "IncludedItem972")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallenge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem98), TypeInfoPropertyName = "IncludedItem982")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeType), TypeInfoPropertyName = "GameCenterChallengeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeAttributesChallengeType), TypeInfoPropertyName = "GameCenterChallengeAttributesChallengeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterDetailData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterDetailDataType), TypeInfoPropertyName = "GameCenterChallengeRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterGroupData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterGroupDataType), TypeInfoPropertyName = "GameCenterChallengeRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeRelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsVersionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsVersionsDataItemType), TypeInfoPropertyName = "GameCenterChallengeRelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardDataType), TypeInfoPropertyName = "GameCenterChallengeRelationshipsLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardV2Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardV2DataType), TypeInfoPropertyName = "GameCenterChallengeRelationshipsLeaderboardV2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallenge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem99>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem99), TypeInfoPropertyName = "IncludedItem992")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengesResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengesResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterChallengesResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem100), TypeInfoPropertyName = "IncludedItem1002")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailType), TypeInfoPropertyName = "GameCenterDetailType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAppData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAppDataType), TypeInfoPropertyName = "GameCenterDetailRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAppVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAppVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAppVersionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAppVersionsDataItemType), TypeInfoPropertyName = "GameCenterDetailRelationshipsGameCenterAppVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterGroupData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterGroupDataType), TypeInfoPropertyName = "GameCenterDetailRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboards))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItemType), TypeInfoPropertyName = "GameCenterDetailRelationshipsGameCenterLeaderboardsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItemType), TypeInfoPropertyName = "GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItemType), TypeInfoPropertyName = "GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItemType), TypeInfoPropertyName = "GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievements))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsDataItemType), TypeInfoPropertyName = "GameCenterDetailRelationshipsGameCenterAchievementsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItemType), TypeInfoPropertyName = "GameCenterDetailRelationshipsGameCenterAchievementsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterActivities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterActivitiesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterActivitiesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterActivitiesDataItemType), TypeInfoPropertyName = "GameCenterDetailRelationshipsGameCenterActivitiesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterChallenges))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterChallengesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterChallengesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterChallengesDataItemType), TypeInfoPropertyName = "GameCenterDetailRelationshipsGameCenterChallengesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardDataType), TypeInfoPropertyName = "GameCenterDetailRelationshipsDefaultLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardV2Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardV2DataType), TypeInfoPropertyName = "GameCenterDetailRelationshipsDefaultLeaderboardV2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardDataType), TypeInfoPropertyName = "GameCenterDetailRelationshipsDefaultGroupLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardV2Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardV2DataType), TypeInfoPropertyName = "GameCenterDetailRelationshipsDefaultGroupLeaderboardV2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAchievementReleases))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsAchievementReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAchievementReleasesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAchievementReleasesDataItemType), TypeInfoPropertyName = "GameCenterDetailRelationshipsAchievementReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsActivityReleases))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsActivityReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsActivityReleasesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsActivityReleasesDataItemType), TypeInfoPropertyName = "GameCenterDetailRelationshipsActivityReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengeReleases))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsChallengeReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengeReleasesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengeReleasesDataItemType), TypeInfoPropertyName = "GameCenterDetailRelationshipsChallengeReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardReleases))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardReleasesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardReleasesDataItemType), TypeInfoPropertyName = "GameCenterDetailRelationshipsLeaderboardReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardSetReleases))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemType), TypeInfoPropertyName = "GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemType), TypeInfoPropertyName = "GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem101>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem101), TypeInfoPropertyName = "IncludedItem1012")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterDetailsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem102), TypeInfoPropertyName = "IncludedItem1022")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem103), TypeInfoPropertyName = "IncludedItem1032")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupType), TypeInfoPropertyName = "GameCenterGroupType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterDetailsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterDetailsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterDetailsDataItemType), TypeInfoPropertyName = "GameCenterGroupRelationshipsGameCenterDetailsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboards))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsDataItemType), TypeInfoPropertyName = "GameCenterGroupRelationshipsGameCenterLeaderboardsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItemType), TypeInfoPropertyName = "GameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsDataItemType), TypeInfoPropertyName = "GameCenterGroupRelationshipsGameCenterLeaderboardSetsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsV2DataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsV2DataItemType), TypeInfoPropertyName = "GameCenterGroupRelationshipsGameCenterLeaderboardSetsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievements))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsDataItemType), TypeInfoPropertyName = "GameCenterGroupRelationshipsGameCenterAchievementsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsV2DataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsV2DataItemType), TypeInfoPropertyName = "GameCenterGroupRelationshipsGameCenterAchievementsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterActivities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterActivitiesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterActivitiesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterActivitiesDataItemType), TypeInfoPropertyName = "GameCenterGroupRelationshipsGameCenterActivitiesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterChallenges))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterChallengesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterChallengesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterChallengesDataItemType), TypeInfoPropertyName = "GameCenterGroupRelationshipsGameCenterChallengesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem104>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem104), TypeInfoPropertyName = "IncludedItem1042")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterGroupsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem105>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem105), TypeInfoPropertyName = "IncludedItem1052")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterGroupResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupCreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupCreateRequestDataType), TypeInfoPropertyName = "GameCenterGroupCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupCreateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupUpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupUpdateRequestDataType), TypeInfoPropertyName = "GameCenterGroupUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupUpdateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardImageV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationType), TypeInfoPropertyName = "GameCenterLeaderboardLocalizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardFormatter), TypeInfoPropertyName = "GameCenterLeaderboardFormatter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardDataType), TypeInfoPropertyName = "GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardImageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardImageDataType), TypeInfoPropertyName = "GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardImageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem106), TypeInfoPropertyName = "IncludedItem1062")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem107), TypeInfoPropertyName = "IncludedItem1072")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem108), TypeInfoPropertyName = "IncludedItem1082")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem109), TypeInfoPropertyName = "IncludedItem1092")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseType), TypeInfoPropertyName = "GameCenterLeaderboardReleaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterDetailData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterDetailDataType), TypeInfoPropertyName = "GameCenterLeaderboardReleaseRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterLeaderboard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterLeaderboardData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterLeaderboardDataType), TypeInfoPropertyName = "GameCenterLeaderboardReleaseRelationshipsGameCenterLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem110), TypeInfoPropertyName = "IncludedItem1102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem111), TypeInfoPropertyName = "IncludedItem1112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetImageV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationType), TypeInfoPropertyName = "GameCenterLeaderboardSetLocalizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetImageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetImageDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetImageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem112), TypeInfoPropertyName = "IncludedItem1122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem113), TypeInfoPropertyName = "IncludedItem1132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem114), TypeInfoPropertyName = "IncludedItem1142")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem115), TypeInfoPropertyName = "IncludedItem1152")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem116), TypeInfoPropertyName = "IncludedItem1162")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem117), TypeInfoPropertyName = "IncludedItem1172")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseType), TypeInfoPropertyName = "GameCenterLeaderboardSetReleaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationshipsGameCenterDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationshipsGameCenterDetailData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationshipsGameCenterDetailDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetReleaseRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationshipsGameCenterLeaderboardSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationshipsGameCenterLeaderboardSetData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationshipsGameCenterLeaderboardSetDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetReleaseRelationshipsGameCenterLeaderboardSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem118), TypeInfoPropertyName = "IncludedItem1182")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem119), TypeInfoPropertyName = "IncludedItem1192")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2Type), TypeInfoPropertyName = "GameCenterLeaderboardSetVersionV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2Attributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2Relationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLeaderboardSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLeaderboardSetData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLeaderboardSetDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetVersionV2RelationshipsLeaderboardSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem120), TypeInfoPropertyName = "IncludedItem1202")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem121), TypeInfoPropertyName = "IncludedItem1212")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2Type), TypeInfoPropertyName = "GameCenterLeaderboardSetV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2Attributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2Relationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterDetailData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterDetailDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetV2RelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterGroupData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterGroupDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetV2RelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterLeaderboards))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterLeaderboardsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterLeaderboardsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterLeaderboardsDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardSetV2RelationshipsGameCenterLeaderboardsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsVersionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsVersionsDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardSetV2RelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem122>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem122), TypeInfoPropertyName = "IncludedItem1222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2ResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2ResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterLeaderboardSetsV2ResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem123), TypeInfoPropertyName = "IncludedItem1232")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetType), TypeInfoPropertyName = "GameCenterLeaderboardSetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterDetailData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterDetailDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterGroupData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterGroupDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGroupLeaderboardSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGroupLeaderboardSetData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGroupLeaderboardSetDataType), TypeInfoPropertyName = "GameCenterLeaderboardSetRelationshipsGroupLeaderboardSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsLocalizationsDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardSetRelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterLeaderboards))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterLeaderboardsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterLeaderboardsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterLeaderboardsDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardSetRelationshipsGameCenterLeaderboardsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsReleases))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsReleasesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsReleasesDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardSetRelationshipsReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem124>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem124), TypeInfoPropertyName = "IncludedItem1242")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterLeaderboardSetsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem125), TypeInfoPropertyName = "IncludedItem1252")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2Type), TypeInfoPropertyName = "GameCenterLeaderboardVersionV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2Attributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2Relationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLeaderboard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLeaderboardData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLeaderboardDataType), TypeInfoPropertyName = "GameCenterLeaderboardVersionV2RelationshipsLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem126), TypeInfoPropertyName = "IncludedItem1262")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem127), TypeInfoPropertyName = "IncludedItem1272")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardType), TypeInfoPropertyName = "GameCenterLeaderboardType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesSubmissionType), TypeInfoPropertyName = "GameCenterLeaderboardAttributesSubmissionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesScoreSortType), TypeInfoPropertyName = "GameCenterLeaderboardAttributesScoreSortType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesVisibility), TypeInfoPropertyName = "GameCenterLeaderboardAttributesVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterDetailData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterDetailDataType), TypeInfoPropertyName = "GameCenterLeaderboardRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterGroupData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterGroupDataType), TypeInfoPropertyName = "GameCenterLeaderboardRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGroupLeaderboard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGroupLeaderboardData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGroupLeaderboardDataType), TypeInfoPropertyName = "GameCenterLeaderboardRelationshipsGroupLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterLeaderboardSets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterLeaderboardSetsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterLeaderboardSetsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterLeaderboardSetsDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardRelationshipsGameCenterLeaderboardSetsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsLocalizationsDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardRelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsReleases))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardRelationshipsReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsReleasesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsReleasesDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardRelationshipsReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsActivity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsActivityData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsActivityDataType), TypeInfoPropertyName = "GameCenterLeaderboardRelationshipsActivityDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsChallenge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsChallengeData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsChallengeDataType), TypeInfoPropertyName = "GameCenterLeaderboardRelationshipsChallengeDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem128>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem128), TypeInfoPropertyName = "IncludedItem1282")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardsResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardsResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterLeaderboardsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem129), TypeInfoPropertyName = "IncludedItem1292")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2Type), TypeInfoPropertyName = "GameCenterLeaderboardV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2Attributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesSubmissionType), TypeInfoPropertyName = "GameCenterLeaderboardV2AttributesSubmissionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesScoreSortType), TypeInfoPropertyName = "GameCenterLeaderboardV2AttributesScoreSortType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesVisibility), TypeInfoPropertyName = "GameCenterLeaderboardV2AttributesVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2Relationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterDetailData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterDetailDataType), TypeInfoPropertyName = "GameCenterLeaderboardV2RelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterGroupData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterGroupDataType), TypeInfoPropertyName = "GameCenterLeaderboardV2RelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsActivity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsActivityData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsActivityDataType), TypeInfoPropertyName = "GameCenterLeaderboardV2RelationshipsActivityDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsChallenge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsChallengeData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsChallengeDataType), TypeInfoPropertyName = "GameCenterLeaderboardV2RelationshipsChallengeDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsVersionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsVersionsDataItemType), TypeInfoPropertyName = "GameCenterLeaderboardV2RelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardsV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem130>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem130), TypeInfoPropertyName = "IncludedItem1302")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardsV2ResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardsV2ResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterLeaderboardsV2ResponseIncludedItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmProvider))]
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
    internal sealed partial class GameCenterGroupsSourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterAchievementsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupGameCenterAchievementsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterAchievementsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterAchievementsLinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterGroupGameCenterAchievementsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterAchievementsLinkagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupGameCenterAchievementsLinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterAchievementsLinkagesRequestDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterAchievementsLinkagesRequestDataItemType), TypeInfoPropertyName = "GameCenterGroupGameCenterAchievementsLinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterAchievementsV2LinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupGameCenterAchievementsV2LinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterAchievementsV2LinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterAchievementsV2LinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterGroupGameCenterAchievementsV2LinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterAchievementsV2LinkagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupGameCenterAchievementsV2LinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterAchievementsV2LinkagesRequestDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterAchievementsV2LinkagesRequestDataItemType), TypeInfoPropertyName = "GameCenterGroupGameCenterAchievementsV2LinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterActivitiesLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupGameCenterActivitiesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterActivitiesLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterActivitiesLinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterGroupGameCenterActivitiesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterChallengesLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupGameCenterChallengesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterChallengesLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterChallengesLinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterGroupGameCenterChallengesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterDetailsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupGameCenterDetailsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterDetailsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterDetailsLinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterGroupGameCenterDetailsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsLinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterGroupGameCenterLeaderboardSetsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsLinkagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsLinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsLinkagesRequestDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsLinkagesRequestDataItemType), TypeInfoPropertyName = "GameCenterGroupGameCenterLeaderboardSetsLinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsV2LinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsV2LinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsV2LinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsV2LinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterGroupGameCenterLeaderboardSetsV2LinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsV2LinkagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsV2LinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsV2LinkagesRequestDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsV2LinkagesRequestDataItemType), TypeInfoPropertyName = "GameCenterGroupGameCenterLeaderboardSetsV2LinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsLinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterGroupGameCenterLeaderboardsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsLinkagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsLinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsLinkagesRequestDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsLinkagesRequestDataItemType), TypeInfoPropertyName = "GameCenterGroupGameCenterLeaderboardsLinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsV2LinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsV2LinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsV2LinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsV2LinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterGroupGameCenterLeaderboardsV2LinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsV2LinkagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsV2LinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsV2LinkagesRequestDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsV2LinkagesRequestDataItemType), TypeInfoPropertyName = "GameCenterGroupGameCenterLeaderboardsV2LinkagesRequestDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterGroup), TypeInfoPropertyName = "GameCenterGroupsGetCollectionFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterGroupsGetCollectionFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard), TypeInfoPropertyName = "GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSet), TypeInfoPropertyName = "GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterAchievement), TypeInfoPropertyName = "GameCenterGroupsGetCollectionFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterActivitie), TypeInfoPropertyName = "GameCenterGroupsGetCollectionFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterChallenge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterChallenge), TypeInfoPropertyName = "GameCenterGroupsGetCollectionFieldsGameCenterChallenge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGetCollectionIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionIncludeItem), TypeInfoPropertyName = "GameCenterGroupsGetCollectionIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterGroup), TypeInfoPropertyName = "GameCenterGroupsGetInstanceFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterGroupsGetInstanceFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard), TypeInfoPropertyName = "GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet), TypeInfoPropertyName = "GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterAchievement), TypeInfoPropertyName = "GameCenterGroupsGetInstanceFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterActivitie), TypeInfoPropertyName = "GameCenterGroupsGetInstanceFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterChallenge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterChallenge), TypeInfoPropertyName = "GameCenterGroupsGetInstanceFieldsGameCenterChallenge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceIncludeItem), TypeInfoPropertyName = "GameCenterGroupsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement), TypeInfoPropertyName = "GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup), TypeInfoPropertyName = "GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization), TypeInfoPropertyName = "GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease), TypeInfoPropertyName = "GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie), TypeInfoPropertyName = "GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "GameCenterGroupsGameCenterAchievementsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement), TypeInfoPropertyName = "GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterGroup), TypeInfoPropertyName = "GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie), TypeInfoPropertyName = "GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion), TypeInfoPropertyName = "GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedIncludeItem), TypeInfoPropertyName = "GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie), TypeInfoPropertyName = "GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroup), TypeInfoPropertyName = "GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement), TypeInfoPropertyName = "GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard), TypeInfoPropertyName = "GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion), TypeInfoPropertyName = "GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem), TypeInfoPropertyName = "GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge), TypeInfoPropertyName = "GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup), TypeInfoPropertyName = "GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion), TypeInfoPropertyName = "GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard), TypeInfoPropertyName = "GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedIncludeItem), TypeInfoPropertyName = "GameCenterGroupsGameCenterChallengesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsApp), TypeInfoPropertyName = "GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAppVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAppVersion), TypeInfoPropertyName = "GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAppVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup), TypeInfoPropertyName = "GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboard), TypeInfoPropertyName = "GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet), TypeInfoPropertyName = "GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement), TypeInfoPropertyName = "GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie), TypeInfoPropertyName = "GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge), TypeInfoPropertyName = "GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievementRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievementRelease), TypeInfoPropertyName = "GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievementRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivityVersionRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivityVersionRelease), TypeInfoPropertyName = "GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivityVersionRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallengeVersionRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallengeVersionRelease), TypeInfoPropertyName = "GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallengeVersionRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardRelease), TypeInfoPropertyName = "GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease), TypeInfoPropertyName = "GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion), TypeInfoPropertyName = "GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet), TypeInfoPropertyName = "GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterGroup), TypeInfoPropertyName = "GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization), TypeInfoPropertyName = "GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard), TypeInfoPropertyName = "GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease), TypeInfoPropertyName = "GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet), TypeInfoPropertyName = "GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterGroup), TypeInfoPropertyName = "GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard), TypeInfoPropertyName = "GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion), TypeInfoPropertyName = "GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem), TypeInfoPropertyName = "GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard), TypeInfoPropertyName = "GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup), TypeInfoPropertyName = "GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet), TypeInfoPropertyName = "GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization), TypeInfoPropertyName = "GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease), TypeInfoPropertyName = "GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie), TypeInfoPropertyName = "GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge), TypeInfoPropertyName = "GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard), TypeInfoPropertyName = "GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroup), TypeInfoPropertyName = "GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSet), TypeInfoPropertyName = "GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie), TypeInfoPropertyName = "GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge), TypeInfoPropertyName = "GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion), TypeInfoPropertyName = "GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem), TypeInfoPropertyName = "GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem8?), TypeInfoPropertyName = "NullableIncludedItem82_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem9?), TypeInfoPropertyName = "NullableIncludedItem92_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem10?), TypeInfoPropertyName = "NullableIncludedItem102_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem11?), TypeInfoPropertyName = "NullableIncludedItem112_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem12?), TypeInfoPropertyName = "NullableIncludedItem122_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem13?), TypeInfoPropertyName = "NullableIncludedItem132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem14?), TypeInfoPropertyName = "NullableIncludedItem142_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem15?), TypeInfoPropertyName = "NullableIncludedItem152_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem16?), TypeInfoPropertyName = "NullableIncludedItem162_3")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem52?), TypeInfoPropertyName = "NullableIncludedItem522")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem53?), TypeInfoPropertyName = "NullableIncludedItem532")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem54?), TypeInfoPropertyName = "NullableIncludedItem542")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem55?), TypeInfoPropertyName = "NullableIncludedItem552")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem56?), TypeInfoPropertyName = "NullableIncludedItem562")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem57?), TypeInfoPropertyName = "NullableIncludedItem572")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem58?), TypeInfoPropertyName = "NullableIncludedItem582")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem59?), TypeInfoPropertyName = "NullableIncludedItem592")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem60?), TypeInfoPropertyName = "NullableIncludedItem602")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem61?), TypeInfoPropertyName = "NullableIncludedItem612")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem62?), TypeInfoPropertyName = "NullableIncludedItem622")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem63?), TypeInfoPropertyName = "NullableIncludedItem632")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem64?), TypeInfoPropertyName = "NullableIncludedItem642")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem65?), TypeInfoPropertyName = "NullableIncludedItem652")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem66?), TypeInfoPropertyName = "NullableIncludedItem662")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem67?), TypeInfoPropertyName = "NullableIncludedItem672")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem68?), TypeInfoPropertyName = "NullableIncludedItem682")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem69?), TypeInfoPropertyName = "NullableIncludedItem692")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem70?), TypeInfoPropertyName = "NullableIncludedItem702")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem71?), TypeInfoPropertyName = "NullableIncludedItem712")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem72?), TypeInfoPropertyName = "NullableIncludedItem722")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem73?), TypeInfoPropertyName = "NullableIncludedItem732")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem74?), TypeInfoPropertyName = "NullableIncludedItem742")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem75?), TypeInfoPropertyName = "NullableIncludedItem752")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem76?), TypeInfoPropertyName = "NullableIncludedItem762")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationType?), TypeInfoPropertyName = "NullableGameCenterAchievementLocalizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementLocalizationRelationshipsGameCenterAchievementDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementImageDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementLocalizationRelationshipsGameCenterAchievementImageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem77?), TypeInfoPropertyName = "NullableIncludedItem772")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem78?), TypeInfoPropertyName = "NullableIncludedItem782")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleaseType?), TypeInfoPropertyName = "NullableGameCenterAchievementReleaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterDetailDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementReleaseRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterAchievementDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementReleaseRelationshipsGameCenterAchievementDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem79?), TypeInfoPropertyName = "NullableIncludedItem792")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem80?), TypeInfoPropertyName = "NullableIncludedItem802")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2Type?), TypeInfoPropertyName = "NullableGameCenterAchievementVersionV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterVersionState?), TypeInfoPropertyName = "NullableGameCenterVersionState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsAchievementDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementVersionV2RelationshipsAchievementDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItemType?), TypeInfoPropertyName = "NullableGameCenterAchievementVersionV2RelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem81?), TypeInfoPropertyName = "NullableIncludedItem812")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem82?), TypeInfoPropertyName = "NullableIncludedItem822")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2Type?), TypeInfoPropertyName = "NullableGameCenterAchievementV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterDetailDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementV2RelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterGroupDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementV2RelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsActivityDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementV2RelationshipsActivityDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsVersionsDataItemType?), TypeInfoPropertyName = "NullableGameCenterAchievementV2RelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem83?), TypeInfoPropertyName = "NullableIncludedItem832")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsV2ResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterAchievementsV2ResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem84?), TypeInfoPropertyName = "NullableIncludedItem842")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementType?), TypeInfoPropertyName = "NullableGameCenterAchievementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterDetailDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterGroupDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGroupAchievementDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementRelationshipsGroupAchievementDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsLocalizationsDataItemType?), TypeInfoPropertyName = "NullableGameCenterAchievementRelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsReleasesDataItemType?), TypeInfoPropertyName = "NullableGameCenterAchievementRelationshipsReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsActivityDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementRelationshipsActivityDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem85?), TypeInfoPropertyName = "NullableIncludedItem852")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementsResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterAchievementsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem86?), TypeInfoPropertyName = "NullableIncludedItem862")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityType?), TypeInfoPropertyName = "NullableGameCenterActivityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityAttributesPlayStyle?), TypeInfoPropertyName = "NullableGameCenterActivityAttributesPlayStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterDetailDataType?), TypeInfoPropertyName = "NullableGameCenterActivityRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterGroupDataType?), TypeInfoPropertyName = "NullableGameCenterActivityRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsDataItemType?), TypeInfoPropertyName = "NullableGameCenterActivityRelationshipsAchievementsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsV2DataItemType?), TypeInfoPropertyName = "NullableGameCenterActivityRelationshipsAchievementsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsDataItemType?), TypeInfoPropertyName = "NullableGameCenterActivityRelationshipsLeaderboardsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsV2DataItemType?), TypeInfoPropertyName = "NullableGameCenterActivityRelationshipsLeaderboardsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityRelationshipsVersionsDataItemType?), TypeInfoPropertyName = "NullableGameCenterActivityRelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem87?), TypeInfoPropertyName = "NullableIncludedItem872")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivitiesResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterActivitiesResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem88?), TypeInfoPropertyName = "NullableIncludedItem882")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem89?), TypeInfoPropertyName = "NullableIncludedItem892")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem90?), TypeInfoPropertyName = "NullableIncludedItem902")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionReleaseType?), TypeInfoPropertyName = "NullableGameCenterActivityVersionReleaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionReleaseRelationshipsVersionDataType?), TypeInfoPropertyName = "NullableGameCenterActivityVersionReleaseRelationshipsVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionType?), TypeInfoPropertyName = "NullableGameCenterActivityVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsActivityDataType?), TypeInfoPropertyName = "NullableGameCenterActivityVersionRelationshipsActivityDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsLocalizationsDataItemType?), TypeInfoPropertyName = "NullableGameCenterActivityVersionRelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsDefaultImageDataType?), TypeInfoPropertyName = "NullableGameCenterActivityVersionRelationshipsDefaultImageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsReleasesDataItemType?), TypeInfoPropertyName = "NullableGameCenterActivityVersionRelationshipsReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem91?), TypeInfoPropertyName = "NullableIncludedItem912")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem92?), TypeInfoPropertyName = "NullableIncludedItem922")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionType?), TypeInfoPropertyName = "NullableGameCenterAppVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsCompatibilityVersionsDataItemType?), TypeInfoPropertyName = "NullableGameCenterAppVersionRelationshipsCompatibilityVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsAppStoreVersionDataType?), TypeInfoPropertyName = "NullableGameCenterAppVersionRelationshipsAppStoreVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem93?), TypeInfoPropertyName = "NullableIncludedItem932")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem94?), TypeInfoPropertyName = "NullableIncludedItem942")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem95?), TypeInfoPropertyName = "NullableIncludedItem952")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem96?), TypeInfoPropertyName = "NullableIncludedItem962")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseType?), TypeInfoPropertyName = "NullableGameCenterChallengeVersionReleaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseRelationshipsVersionDataType?), TypeInfoPropertyName = "NullableGameCenterChallengeVersionReleaseRelationshipsVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionType?), TypeInfoPropertyName = "NullableGameCenterChallengeVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsChallengeDataType?), TypeInfoPropertyName = "NullableGameCenterChallengeVersionRelationshipsChallengeDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsLocalizationsDataItemType?), TypeInfoPropertyName = "NullableGameCenterChallengeVersionRelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsReleasesDataItemType?), TypeInfoPropertyName = "NullableGameCenterChallengeVersionRelationshipsReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsDefaultImageDataType?), TypeInfoPropertyName = "NullableGameCenterChallengeVersionRelationshipsDefaultImageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem97?), TypeInfoPropertyName = "NullableIncludedItem972")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem98?), TypeInfoPropertyName = "NullableIncludedItem982")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeType?), TypeInfoPropertyName = "NullableGameCenterChallengeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeAttributesChallengeType?), TypeInfoPropertyName = "NullableGameCenterChallengeAttributesChallengeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterDetailDataType?), TypeInfoPropertyName = "NullableGameCenterChallengeRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterGroupDataType?), TypeInfoPropertyName = "NullableGameCenterChallengeRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsVersionsDataItemType?), TypeInfoPropertyName = "NullableGameCenterChallengeRelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardDataType?), TypeInfoPropertyName = "NullableGameCenterChallengeRelationshipsLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardV2DataType?), TypeInfoPropertyName = "NullableGameCenterChallengeRelationshipsLeaderboardV2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem99?), TypeInfoPropertyName = "NullableIncludedItem992")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengesResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterChallengesResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem100?), TypeInfoPropertyName = "NullableIncludedItem1002")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailType?), TypeInfoPropertyName = "NullableGameCenterDetailType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAppDataType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAppVersionsDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsGameCenterAppVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterGroupDataType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsGameCenterLeaderboardsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsGameCenterAchievementsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsGameCenterAchievementsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterActivitiesDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsGameCenterActivitiesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterChallengesDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsGameCenterChallengesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardDataType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsDefaultLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardV2DataType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsDefaultLeaderboardV2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardDataType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsDefaultGroupLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardV2DataType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsDefaultGroupLeaderboardV2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAchievementReleasesDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsAchievementReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsActivityReleasesDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsActivityReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengeReleasesDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsChallengeReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardReleasesDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsLeaderboardReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsLeaderboardSetReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem101?), TypeInfoPropertyName = "NullableIncludedItem1012")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterDetailsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem102?), TypeInfoPropertyName = "NullableIncludedItem1022")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem103?), TypeInfoPropertyName = "NullableIncludedItem1032")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupType?), TypeInfoPropertyName = "NullableGameCenterGroupType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterDetailsDataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupRelationshipsGameCenterDetailsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsDataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupRelationshipsGameCenterLeaderboardsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsDataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupRelationshipsGameCenterLeaderboardSetsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsV2DataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupRelationshipsGameCenterLeaderboardSetsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsDataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupRelationshipsGameCenterAchievementsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsV2DataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupRelationshipsGameCenterAchievementsV2DataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterActivitiesDataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupRelationshipsGameCenterActivitiesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterChallengesDataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupRelationshipsGameCenterChallengesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem104?), TypeInfoPropertyName = "NullableIncludedItem1042")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterGroupsResponseIncludedItemDiscriminatorType2")]
    internal sealed partial class GameCenterGroupsSourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem105?), TypeInfoPropertyName = "NullableIncludedItem1052")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterGroupResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupCreateRequestDataType?), TypeInfoPropertyName = "NullableGameCenterGroupCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupUpdateRequestDataType?), TypeInfoPropertyName = "NullableGameCenterGroupUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardLocalizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardFormatter?), TypeInfoPropertyName = "NullableGameCenterLeaderboardFormatter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardImageDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardImageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem106?), TypeInfoPropertyName = "NullableIncludedItem1062")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem107?), TypeInfoPropertyName = "NullableIncludedItem1072")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem108?), TypeInfoPropertyName = "NullableIncludedItem1082")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem109?), TypeInfoPropertyName = "NullableIncludedItem1092")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardReleaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterDetailDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardReleaseRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterLeaderboardDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardReleaseRelationshipsGameCenterLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem110?), TypeInfoPropertyName = "NullableIncludedItem1102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem111?), TypeInfoPropertyName = "NullableIncludedItem1112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetLocalizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetImageDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetImageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem112?), TypeInfoPropertyName = "NullableIncludedItem1122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem113?), TypeInfoPropertyName = "NullableIncludedItem1132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem114?), TypeInfoPropertyName = "NullableIncludedItem1142")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem115?), TypeInfoPropertyName = "NullableIncludedItem1152")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem116?), TypeInfoPropertyName = "NullableIncludedItem1162")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem117?), TypeInfoPropertyName = "NullableIncludedItem1172")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetReleaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationshipsGameCenterDetailDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetReleaseRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationshipsGameCenterLeaderboardSetDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetReleaseRelationshipsGameCenterLeaderboardSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem118?), TypeInfoPropertyName = "NullableIncludedItem1182")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem119?), TypeInfoPropertyName = "NullableIncludedItem1192")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2Type?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetVersionV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLeaderboardSetDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetVersionV2RelationshipsLeaderboardSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem120?), TypeInfoPropertyName = "NullableIncludedItem1202")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem121?), TypeInfoPropertyName = "NullableIncludedItem1212")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2Type?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterDetailDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetV2RelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterGroupDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetV2RelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterLeaderboardsDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetV2RelationshipsGameCenterLeaderboardsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsVersionsDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetV2RelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem122?), TypeInfoPropertyName = "NullableIncludedItem1222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2ResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsV2ResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem123?), TypeInfoPropertyName = "NullableIncludedItem1232")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterDetailDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterGroupDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGroupLeaderboardSetDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetRelationshipsGroupLeaderboardSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsLocalizationsDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetRelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterLeaderboardsDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetRelationshipsGameCenterLeaderboardsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsReleasesDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetRelationshipsReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem124?), TypeInfoPropertyName = "NullableIncludedItem1242")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetsResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem125?), TypeInfoPropertyName = "NullableIncludedItem1252")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2Type?), TypeInfoPropertyName = "NullableGameCenterLeaderboardVersionV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLeaderboardDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardVersionV2RelationshipsLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem126?), TypeInfoPropertyName = "NullableIncludedItem1262")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem127?), TypeInfoPropertyName = "NullableIncludedItem1272")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesSubmissionType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardAttributesSubmissionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesScoreSortType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardAttributesScoreSortType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesVisibility?), TypeInfoPropertyName = "NullableGameCenterLeaderboardAttributesVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterDetailDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardRelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterGroupDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGroupLeaderboardDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardRelationshipsGroupLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterLeaderboardSetsDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardRelationshipsGameCenterLeaderboardSetsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsLocalizationsDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardRelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsReleasesDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardRelationshipsReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsActivityDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardRelationshipsActivityDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsChallengeDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardRelationshipsChallengeDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem128?), TypeInfoPropertyName = "NullableIncludedItem1282")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardsResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem129?), TypeInfoPropertyName = "NullableIncludedItem1292")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2Type?), TypeInfoPropertyName = "NullableGameCenterLeaderboardV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesSubmissionType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardV2AttributesSubmissionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesScoreSortType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardV2AttributesScoreSortType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesVisibility?), TypeInfoPropertyName = "NullableGameCenterLeaderboardV2AttributesVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterDetailDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardV2RelationshipsGameCenterDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterGroupDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardV2RelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsActivityDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardV2RelationshipsActivityDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsChallengeDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardV2RelationshipsChallengeDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsVersionsDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardV2RelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem130?), TypeInfoPropertyName = "NullableIncludedItem1302")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardsV2ResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardsV2ResponseIncludedItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterAchievementsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupGameCenterAchievementsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterAchievementsLinkagesRequestDataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupGameCenterAchievementsLinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterAchievementsV2LinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupGameCenterAchievementsV2LinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterAchievementsV2LinkagesRequestDataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupGameCenterAchievementsV2LinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterActivitiesLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupGameCenterActivitiesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterChallengesLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupGameCenterChallengesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterDetailsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupGameCenterDetailsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupGameCenterLeaderboardSetsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsLinkagesRequestDataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupGameCenterLeaderboardSetsLinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsV2LinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupGameCenterLeaderboardSetsV2LinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsV2LinkagesRequestDataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupGameCenterLeaderboardSetsV2LinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupGameCenterLeaderboardsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsLinkagesRequestDataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupGameCenterLeaderboardsLinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsV2LinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupGameCenterLeaderboardsV2LinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsV2LinkagesRequestDataItemType?), TypeInfoPropertyName = "NullableGameCenterGroupGameCenterLeaderboardsV2LinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>?), TypeInfoPropertyName = "NullableOneOfErrorSourcePointerErrorSourceParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<string, global::AppStoreConnect.ErrorLinksAssociated>?), TypeInfoPropertyName = "NullableOneOfStringErrorLinksAssociated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterGroup?), TypeInfoPropertyName = "NullableGameCenterGroupsGetCollectionFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterGroupsGetCollectionFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard?), TypeInfoPropertyName = "NullableGameCenterGroupsGetCollectionFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSet?), TypeInfoPropertyName = "NullableGameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterAchievement?), TypeInfoPropertyName = "NullableGameCenterGroupsGetCollectionFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterActivitie?), TypeInfoPropertyName = "NullableGameCenterGroupsGetCollectionFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterChallenge?), TypeInfoPropertyName = "NullableGameCenterGroupsGetCollectionFieldsGameCenterChallenge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionIncludeItem?), TypeInfoPropertyName = "NullableGameCenterGroupsGetCollectionIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterGroup?), TypeInfoPropertyName = "NullableGameCenterGroupsGetInstanceFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterGroupsGetInstanceFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard?), TypeInfoPropertyName = "NullableGameCenterGroupsGetInstanceFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet?), TypeInfoPropertyName = "NullableGameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterAchievement?), TypeInfoPropertyName = "NullableGameCenterGroupsGetInstanceFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterActivitie?), TypeInfoPropertyName = "NullableGameCenterGroupsGetInstanceFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterChallenge?), TypeInfoPropertyName = "NullableGameCenterGroupsGetInstanceFieldsGameCenterChallenge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableGameCenterGroupsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterAchievementsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterGroup?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterAchievementsV2GetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroup?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterChallengesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsApp?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAppVersion?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAppVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboard?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievementRelease?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievementRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivityVersionRelease?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivityVersionRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallengeVersionRelease?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallengeVersionRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardRelease?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterGroup?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterGroup?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterLeaderboardsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroup?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSet?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementV2RelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem83>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementRelationshipsReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem85>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterActivityRelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterActivity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem87>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterActivityVersionRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterActivityVersionRelationshipsReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAppVersionRelationshipsCompatibilityVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterChallengeVersionRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterChallengeVersionRelationshipsReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterChallengeRelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterChallenge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem99>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAppVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterActivitiesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterChallengesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsAchievementReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsActivityReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsChallengeReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem101>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterDetailsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterActivitiesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterChallengesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem104>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem105>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterLeaderboardsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem122>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterLeaderboardsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem124>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterLeaderboardSetsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardRelationshipsReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem128>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem130>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupGameCenterAchievementsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupGameCenterAchievementsLinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupGameCenterAchievementsV2LinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupGameCenterAchievementsV2LinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupGameCenterActivitiesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupGameCenterChallengesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupGameCenterDetailsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsLinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsV2LinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsV2LinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsLinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsV2LinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsV2LinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ErrorResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterChallenge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGetCollectionIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterChallenge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAppVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievementRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivityVersionRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallengeVersionRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem>))]
    internal sealed partial class GameCenterGroupsSourceGenerationContextChunk3 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterGroupsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static GameCenterGroupsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private GameCenterGroupsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem81JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem82JsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionType)

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

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementImageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementImageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleaseType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleaseType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterAchievementDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterAchievementDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsAchievementDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsAchievementDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsActivityDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsActivityDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2ResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2ResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGroupAchievementDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGroupAchievementDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsReleasesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsReleasesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsActivityDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsActivityDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityAttributesPlayStyle)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityAttributesPlayStyle?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsV2DataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsV2DataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsV2DataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsV2DataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivitiesResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivitiesResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionReleaseType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionReleaseType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionReleaseRelationshipsVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionReleaseRelationshipsVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsActivityDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsActivityDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsDefaultImageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsDefaultImageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsReleasesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsReleasesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAppVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAppVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsCompatibilityVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsCompatibilityVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsAppStoreVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsAppStoreVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseRelationshipsVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseRelationshipsVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsChallengeDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsChallengeDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsReleasesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsReleasesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsDefaultImageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsDefaultImageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeAttributesChallengeType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeAttributesChallengeType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardV2DataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardV2DataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengesResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengesResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAppVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAppVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterActivitiesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterActivitiesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterChallengesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterChallengesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardV2DataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardV2DataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardV2DataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardV2DataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAchievementReleasesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAchievementReleasesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsActivityReleasesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsActivityReleasesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengeReleasesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengeReleasesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardReleasesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardReleasesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterDetailsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterDetailsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsV2DataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsV2DataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsV2DataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsV2DataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterActivitiesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterActivitiesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterChallengesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterChallengesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardImageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardImageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterLeaderboardDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterLeaderboardDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetImageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetImageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationshipsGameCenterLeaderboardSetDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationshipsGameCenterLeaderboardSetDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLeaderboardSetDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLeaderboardSetDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterLeaderboardsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterLeaderboardsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2ResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2ResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGroupLeaderboardSetDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGroupLeaderboardSetDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterLeaderboardsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterLeaderboardsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsReleasesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsReleasesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLeaderboardDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLeaderboardDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesSubmissionType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesSubmissionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesScoreSortType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesScoreSortType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesVisibility)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesVisibility?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGroupLeaderboardDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGroupLeaderboardDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterLeaderboardSetsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterLeaderboardSetsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsReleasesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsReleasesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsActivityDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsActivityDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsChallengeDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsChallengeDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesSubmissionType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesSubmissionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesScoreSortType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesScoreSortType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesVisibility)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesVisibility?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsActivityDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsActivityDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsChallengeDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsChallengeDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardsV2ResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardsV2ResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterAchievementsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterAchievementsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterAchievementsLinkagesRequestDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterAchievementsLinkagesRequestDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterAchievementsV2LinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterAchievementsV2LinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterAchievementsV2LinkagesRequestDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterAchievementsV2LinkagesRequestDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterActivitiesLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterActivitiesLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterChallengesLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterChallengesLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterDetailsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterDetailsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsLinkagesRequestDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsLinkagesRequestDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsV2LinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsV2LinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsV2LinkagesRequestDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsV2LinkagesRequestDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsLinkagesRequestDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsLinkagesRequestDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsV2LinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsV2LinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsV2LinkagesRequestDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsV2LinkagesRequestDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppVersionState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppVersionState?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardFormatter)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardFormatter?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterVersionState)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterVersionState?)

                    || typeToConvert == typeof(global::AppStoreConnect.Platform)

                    || typeToConvert == typeof(global::AppStoreConnect.Platform?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSet)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterAchievement)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterAchievement?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterActivitie)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterActivitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterChallenge)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterChallenge?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterAchievement)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterAchievement?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterActivitie)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterActivitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterChallenge)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterChallenge?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAppVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAppVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboard)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboard?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievementRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievementRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivityVersionRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivityVersionRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallengeVersionRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallengeVersionRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSet)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementLocalizationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementLocalizationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementImageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementImageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementImageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementImageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleaseType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleaseType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleaseRelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleaseRelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterAchievementDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleaseRelationshipsGameCenterAchievementDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterAchievementDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleaseRelationshipsGameCenterAchievementDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementVersionV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementVersionV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsAchievementDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementVersionV2RelationshipsAchievementDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsAchievementDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementVersionV2RelationshipsAchievementDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2RelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2RelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2RelationshipsGameCenterGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2RelationshipsGameCenterGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsActivityDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2RelationshipsActivityDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsActivityDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2RelationshipsActivityDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2RelationshipsVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2RelationshipsVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2ResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsV2ResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2ResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsV2ResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementRelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementRelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementRelationshipsGameCenterGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementRelationshipsGameCenterGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGroupAchievementDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementRelationshipsGroupAchievementDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsGroupAchievementDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementRelationshipsGroupAchievementDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementRelationshipsLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementRelationshipsLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsReleasesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementRelationshipsReleasesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsReleasesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementRelationshipsReleasesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsActivityDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementRelationshipsActivityDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementRelationshipsActivityDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementRelationshipsActivityDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityAttributesPlayStyle))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityAttributesPlayStyleJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityAttributesPlayStyle?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityAttributesPlayStyleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityRelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityRelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityRelationshipsGameCenterGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityRelationshipsGameCenterGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityRelationshipsAchievementsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityRelationshipsAchievementsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsV2DataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityRelationshipsAchievementsV2DataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsV2DataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityRelationshipsAchievementsV2DataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityRelationshipsLeaderboardsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityRelationshipsLeaderboardsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsV2DataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityRelationshipsLeaderboardsV2DataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsV2DataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityRelationshipsLeaderboardsV2DataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityRelationshipsVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityRelationshipsVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityRelationshipsVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivitiesResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivitiesResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivitiesResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivitiesResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionReleaseType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityVersionReleaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionReleaseType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityVersionReleaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionReleaseRelationshipsVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityVersionReleaseRelationshipsVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionReleaseRelationshipsVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityVersionReleaseRelationshipsVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsActivityDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityVersionRelationshipsActivityDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsActivityDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityVersionRelationshipsActivityDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityVersionRelationshipsLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityVersionRelationshipsLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsDefaultImageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityVersionRelationshipsDefaultImageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsDefaultImageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityVersionRelationshipsDefaultImageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsReleasesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityVersionRelationshipsReleasesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsReleasesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterActivityVersionRelationshipsReleasesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAppVersionType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAppVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAppVersionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAppVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsCompatibilityVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAppVersionRelationshipsCompatibilityVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsCompatibilityVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAppVersionRelationshipsCompatibilityVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsAppStoreVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAppVersionRelationshipsAppStoreVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsAppStoreVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAppVersionRelationshipsAppStoreVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionReleaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionReleaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseRelationshipsVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionReleaseRelationshipsVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseRelationshipsVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionReleaseRelationshipsVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsChallengeDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionRelationshipsChallengeDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsChallengeDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionRelationshipsChallengeDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionRelationshipsLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionRelationshipsLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsReleasesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionRelationshipsReleasesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsReleasesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionRelationshipsReleasesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsDefaultImageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionRelationshipsDefaultImageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsDefaultImageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionRelationshipsDefaultImageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeAttributesChallengeType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeAttributesChallengeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeAttributesChallengeType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeAttributesChallengeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeRelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeRelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeRelationshipsGameCenterGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeRelationshipsGameCenterGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeRelationshipsVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeRelationshipsVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeRelationshipsLeaderboardDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeRelationshipsLeaderboardDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardV2DataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeRelationshipsLeaderboardV2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardV2DataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeRelationshipsLeaderboardV2DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengesResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengesResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengesResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengesResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAppVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterAppVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAppVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterAppVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterAchievementsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterAchievementsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterActivitiesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterActivitiesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterActivitiesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterActivitiesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterChallengesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterChallengesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterChallengesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterChallengesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsDefaultLeaderboardDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsDefaultLeaderboardDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardV2DataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsDefaultLeaderboardV2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardV2DataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsDefaultLeaderboardV2DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsDefaultGroupLeaderboardDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsDefaultGroupLeaderboardDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardV2DataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsDefaultGroupLeaderboardV2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardV2DataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsDefaultGroupLeaderboardV2DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAchievementReleasesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsAchievementReleasesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAchievementReleasesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsAchievementReleasesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsActivityReleasesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsActivityReleasesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsActivityReleasesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsActivityReleasesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengeReleasesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsChallengeReleasesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengeReleasesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsChallengeReleasesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardReleasesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsLeaderboardReleasesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardReleasesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsLeaderboardReleasesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterDetailsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterDetailsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterDetailsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterDetailsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterLeaderboardsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterLeaderboardsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterLeaderboardSetsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterLeaderboardSetsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsV2DataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterLeaderboardSetsV2DataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsV2DataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterLeaderboardSetsV2DataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterAchievementsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterAchievementsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsV2DataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterAchievementsV2DataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsV2DataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterAchievementsV2DataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterActivitiesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterActivitiesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterActivitiesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterActivitiesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterChallengesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterChallengesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterChallengesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupRelationshipsGameCenterChallengesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupUpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardLocalizationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardLocalizationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardImageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardImageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardImageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardImageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardReleaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardReleaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardReleaseRelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardReleaseRelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterLeaderboardDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardReleaseRelationshipsGameCenterLeaderboardDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterLeaderboardDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardReleaseRelationshipsGameCenterLeaderboardDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetLocalizationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetLocalizationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetImageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetImageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetImageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetLocalizationRelationshipsGameCenterLeaderboardSetImageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleaseRelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleaseRelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationshipsGameCenterLeaderboardSetDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleaseRelationshipsGameCenterLeaderboardSetDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleaseRelationshipsGameCenterLeaderboardSetDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleaseRelationshipsGameCenterLeaderboardSetDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetVersionV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetVersionV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLeaderboardSetDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetVersionV2RelationshipsLeaderboardSetDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLeaderboardSetDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetVersionV2RelationshipsLeaderboardSetDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2RelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2RelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2RelationshipsGameCenterGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2RelationshipsGameCenterGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterLeaderboardsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2RelationshipsGameCenterLeaderboardsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsGameCenterLeaderboardsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2RelationshipsGameCenterLeaderboardsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2RelationshipsVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2RelationshipsVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetV2RelationshipsVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2ResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2ResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsV2ResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsV2ResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetRelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetRelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetRelationshipsGameCenterGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetRelationshipsGameCenterGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGroupLeaderboardSetDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetRelationshipsGroupLeaderboardSetDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGroupLeaderboardSetDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetRelationshipsGroupLeaderboardSetDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetRelationshipsLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetRelationshipsLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterLeaderboardsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetRelationshipsGameCenterLeaderboardsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterLeaderboardsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetRelationshipsGameCenterLeaderboardsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsReleasesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetRelationshipsReleasesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsReleasesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetRelationshipsReleasesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardVersionV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardVersionV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLeaderboardDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardVersionV2RelationshipsLeaderboardDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLeaderboardDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardVersionV2RelationshipsLeaderboardDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesSubmissionType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardAttributesSubmissionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesSubmissionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardAttributesSubmissionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesScoreSortType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardAttributesScoreSortTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesScoreSortType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardAttributesScoreSortTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesVisibility))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardAttributesVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardAttributesVisibility?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardAttributesVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardRelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardRelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardRelationshipsGameCenterGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardRelationshipsGameCenterGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGroupLeaderboardDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardRelationshipsGroupLeaderboardDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGroupLeaderboardDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardRelationshipsGroupLeaderboardDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterLeaderboardSetsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardRelationshipsGameCenterLeaderboardSetsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterLeaderboardSetsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardRelationshipsGameCenterLeaderboardSetsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardRelationshipsLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardRelationshipsLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsReleasesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardRelationshipsReleasesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsReleasesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardRelationshipsReleasesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsActivityDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardRelationshipsActivityDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsActivityDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardRelationshipsActivityDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsChallengeDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardRelationshipsChallengeDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardRelationshipsChallengeDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardRelationshipsChallengeDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesSubmissionType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2AttributesSubmissionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesSubmissionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2AttributesSubmissionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesScoreSortType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2AttributesScoreSortTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesScoreSortType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2AttributesScoreSortTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesVisibility))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2AttributesVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesVisibility?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2AttributesVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsGameCenterGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsGameCenterGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsActivityDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsActivityDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsActivityDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsActivityDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsChallengeDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsChallengeDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsChallengeDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsChallengeDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardsV2ResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardsV2ResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardsV2ResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardsV2ResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterAchievementsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupGameCenterAchievementsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterAchievementsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupGameCenterAchievementsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterAchievementsLinkagesRequestDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupGameCenterAchievementsLinkagesRequestDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterAchievementsLinkagesRequestDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupGameCenterAchievementsLinkagesRequestDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterAchievementsV2LinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupGameCenterAchievementsV2LinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterAchievementsV2LinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupGameCenterAchievementsV2LinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterAchievementsV2LinkagesRequestDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupGameCenterAchievementsV2LinkagesRequestDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterAchievementsV2LinkagesRequestDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupGameCenterAchievementsV2LinkagesRequestDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterActivitiesLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupGameCenterActivitiesLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterActivitiesLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupGameCenterActivitiesLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterChallengesLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupGameCenterChallengesLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterChallengesLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupGameCenterChallengesLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterDetailsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupGameCenterDetailsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterDetailsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupGameCenterDetailsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupGameCenterLeaderboardSetsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupGameCenterLeaderboardSetsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsLinkagesRequestDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupGameCenterLeaderboardSetsLinkagesRequestDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsLinkagesRequestDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupGameCenterLeaderboardSetsLinkagesRequestDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsV2LinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupGameCenterLeaderboardSetsV2LinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsV2LinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupGameCenterLeaderboardSetsV2LinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsV2LinkagesRequestDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupGameCenterLeaderboardSetsV2LinkagesRequestDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardSetsV2LinkagesRequestDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupGameCenterLeaderboardSetsV2LinkagesRequestDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupGameCenterLeaderboardsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupGameCenterLeaderboardsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsLinkagesRequestDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupGameCenterLeaderboardsLinkagesRequestDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsLinkagesRequestDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupGameCenterLeaderboardsLinkagesRequestDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsV2LinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupGameCenterLeaderboardsV2LinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsV2LinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupGameCenterLeaderboardsV2LinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsV2LinkagesRequestDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupGameCenterLeaderboardsV2LinkagesRequestDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupGameCenterLeaderboardsV2LinkagesRequestDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupGameCenterLeaderboardsV2LinkagesRequestDataItemTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardFormatter))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardFormatterJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardFormatter?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardFormatterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterVersionState))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterVersionStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterVersionState?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterVersionStateNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGetCollectionFieldsGameCenterGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGetCollectionFieldsGameCenterGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGetCollectionFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGetCollectionFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSet))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterAchievement))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGetCollectionFieldsGameCenterAchievementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterAchievement?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGetCollectionFieldsGameCenterAchievementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterActivitie))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGetCollectionFieldsGameCenterActivitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterActivitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGetCollectionFieldsGameCenterActivitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterChallenge))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGetCollectionFieldsGameCenterChallengeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionFieldsGameCenterChallenge?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGetCollectionFieldsGameCenterChallengeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGetCollectionIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetCollectionIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGetCollectionIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGetInstanceFieldsGameCenterGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGetInstanceFieldsGameCenterGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGetInstanceFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGetInstanceFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterAchievement))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGetInstanceFieldsGameCenterAchievementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterAchievement?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGetInstanceFieldsGameCenterAchievementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterActivitie))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGetInstanceFieldsGameCenterActivitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterActivitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGetInstanceFieldsGameCenterActivitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterChallenge))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGetInstanceFieldsGameCenterChallengeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterChallenge?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGetInstanceFieldsGameCenterChallengeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGetInstanceIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterAchievementsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterAchievementsGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboardJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboardNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboardJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboardNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterChallengesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterChallengesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterChallengesGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAppVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAppVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAppVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAppVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboard))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboard?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallengeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallengeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievementRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievementReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievementRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievementReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivityVersionRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivityVersionReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivityVersionRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivityVersionReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallengeVersionRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallengeVersionReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallengeVersionRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallengeVersionReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSetReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSetReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallengeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallengeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSet))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallengeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallengeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItemNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[4];

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
                    0 => new GameCenterGroupsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new GameCenterGroupsSourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),

                    2 => new GameCenterGroupsSourceGenerationContextChunk2(new global::System.Text.Json.JsonSerializerOptions()),

                    3 => new GameCenterGroupsSourceGenerationContextChunk3(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}