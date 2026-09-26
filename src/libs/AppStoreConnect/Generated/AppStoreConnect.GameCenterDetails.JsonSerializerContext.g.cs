
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppRelationshipsPerformanceOverviews))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem79>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem79), TypeInfoPropertyName = "IncludedItem792")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleasesResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleasesResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterAchievementReleasesResponseIncludedItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionReleasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityVersionRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityVersion>))]
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
    internal sealed partial class GameCenterDetailsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsCompatibilityVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionRelationshipsCompatibilityVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsCompatibilityVersionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsCompatibilityVersionsDataItemType), TypeInfoPropertyName = "GameCenterAppVersionRelationshipsCompatibilityVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsAppStoreVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsAppStoreVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsAppStoreVersionDataType), TypeInfoPropertyName = "GameCenterAppVersionRelationshipsAppStoreVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem93>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem93), TypeInfoPropertyName = "IncludedItem932")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionsResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionsResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterAppVersionsResponseIncludedItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionReleasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersionRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersion>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailPlayer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailPlayerType), TypeInfoPropertyName = "GameCenterDetailPlayerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailPlayerAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailPlayersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailPlayer>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsBlockedPlayers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemType), TypeInfoPropertyName = "GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem101), TypeInfoPropertyName = "IncludedItem1012")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem102>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem102), TypeInfoPropertyName = "IncludedItem1022")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterDetailResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailCreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailCreateRequestDataType), TypeInfoPropertyName = "GameCenterDetailCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailCreateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailCreateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailCreateRequestDataRelationshipsApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailCreateRequestDataRelationshipsAppData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailCreateRequestDataRelationshipsAppDataType), TypeInfoPropertyName = "GameCenterDetailCreateRequestDataRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataType), TypeInfoPropertyName = "GameCenterDetailUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsGameCenterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsGameCenterGroupData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsGameCenterGroupDataType), TypeInfoPropertyName = "GameCenterDetailUpdateRequestDataRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardDataType), TypeInfoPropertyName = "GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardV2Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardV2DataType), TypeInfoPropertyName = "GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardV2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardDataType), TypeInfoPropertyName = "GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardV2Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardV2DataType), TypeInfoPropertyName = "GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardV2DataType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem104), TypeInfoPropertyName = "IncludedItem1042")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem105>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem105), TypeInfoPropertyName = "IncludedItem1052")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterGroupResponseIncludedItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardReleasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem110>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem110), TypeInfoPropertyName = "IncludedItem1102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardReleasesResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardReleasesResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterLeaderboardReleasesResponseIncludedItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem118>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem118), TypeInfoPropertyName = "IncludedItem1182")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleasesResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleasesResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterLeaderboardSetReleasesResponseIncludedItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterScoreModerations))]
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
    internal sealed partial class GameCenterDetailsSourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailAchievementReleasesLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailAchievementReleasesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailAchievementReleasesLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailAchievementReleasesLinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterDetailAchievementReleasesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailActivityReleasesLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailActivityReleasesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailActivityReleasesLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailActivityReleasesLinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterDetailActivityReleasesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailBlockedPlayersLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailBlockedPlayersLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailBlockedPlayersLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailBlockedPlayersLinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterDetailBlockedPlayersLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailChallengeReleasesLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailChallengeReleasesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailChallengeReleasesLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailChallengeReleasesLinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterDetailChallengeReleasesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailChallengesMinimumPlatformVersionsLinkagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailChallengesMinimumPlatformVersionsLinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailChallengesMinimumPlatformVersionsLinkagesRequestDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailChallengesMinimumPlatformVersionsLinkagesRequestDataItemType), TypeInfoPropertyName = "GameCenterDetailChallengesMinimumPlatformVersionsLinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterAchievementsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailGameCenterAchievementsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterAchievementsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterAchievementsLinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterDetailGameCenterAchievementsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterAchievementsLinkagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailGameCenterAchievementsLinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterAchievementsLinkagesRequestDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterAchievementsLinkagesRequestDataItemType), TypeInfoPropertyName = "GameCenterDetailGameCenterAchievementsLinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterAchievementsV2LinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailGameCenterAchievementsV2LinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterAchievementsV2LinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterAchievementsV2LinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterDetailGameCenterAchievementsV2LinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterAchievementsV2LinkagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailGameCenterAchievementsV2LinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterAchievementsV2LinkagesRequestDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterAchievementsV2LinkagesRequestDataItemType), TypeInfoPropertyName = "GameCenterDetailGameCenterAchievementsV2LinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterActivitiesLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailGameCenterActivitiesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterActivitiesLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterActivitiesLinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterDetailGameCenterActivitiesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterAppVersionsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailGameCenterAppVersionsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterAppVersionsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterAppVersionsLinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterDetailGameCenterAppVersionsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterChallengesLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailGameCenterChallengesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterChallengesLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterChallengesLinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterDetailGameCenterChallengesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterGroupLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterGroupLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterGroupLinkageResponseDataType), TypeInfoPropertyName = "GameCenterDetailGameCenterGroupLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsLinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterDetailGameCenterLeaderboardSetsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsLinkagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsLinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsLinkagesRequestDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsLinkagesRequestDataItemType), TypeInfoPropertyName = "GameCenterDetailGameCenterLeaderboardSetsLinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsV2LinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsV2LinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsV2LinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsV2LinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterDetailGameCenterLeaderboardSetsV2LinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsV2LinkagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsV2LinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsV2LinkagesRequestDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsV2LinkagesRequestDataItemType), TypeInfoPropertyName = "GameCenterDetailGameCenterLeaderboardSetsV2LinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsLinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterDetailGameCenterLeaderboardsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsLinkagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsLinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsLinkagesRequestDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsLinkagesRequestDataItemType), TypeInfoPropertyName = "GameCenterDetailGameCenterLeaderboardsLinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsV2LinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsV2LinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsV2LinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsV2LinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterDetailGameCenterLeaderboardsV2LinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsV2LinkagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsV2LinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsV2LinkagesRequestDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsV2LinkagesRequestDataItemType), TypeInfoPropertyName = "GameCenterDetailGameCenterLeaderboardsV2LinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailLeaderboardReleasesLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailLeaderboardReleasesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailLeaderboardReleasesLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailLeaderboardReleasesLinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterDetailLeaderboardReleasesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailLeaderboardSetReleasesLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailLeaderboardSetReleasesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailLeaderboardSetReleasesLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailLeaderboardSetReleasesLinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterDetailLeaderboardSetReleasesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDataPointValues))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResultLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResultData), TypeInfoPropertyName = "GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResultData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemGranularity), TypeInfoPropertyName = "GameCenterMatchmakingAppRequestsV1MetricResponseDataItemGranularity2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterDetailsGetInstanceFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsApp), TypeInfoPropertyName = "GameCenterDetailsGetInstanceFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterAppVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterAppVersion), TypeInfoPropertyName = "GameCenterDetailsGetInstanceFieldsGameCenterAppVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterGroup), TypeInfoPropertyName = "GameCenterDetailsGetInstanceFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard), TypeInfoPropertyName = "GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet), TypeInfoPropertyName = "GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterAchievement), TypeInfoPropertyName = "GameCenterDetailsGetInstanceFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterActivitie), TypeInfoPropertyName = "GameCenterDetailsGetInstanceFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterChallenge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterChallenge), TypeInfoPropertyName = "GameCenterDetailsGetInstanceFieldsGameCenterChallenge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterAchievementRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterAchievementRelease), TypeInfoPropertyName = "GameCenterDetailsGetInstanceFieldsGameCenterAchievementRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterActivityVersionRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterActivityVersionRelease), TypeInfoPropertyName = "GameCenterDetailsGetInstanceFieldsGameCenterActivityVersionRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterChallengeVersionRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterChallengeVersionRelease), TypeInfoPropertyName = "GameCenterDetailsGetInstanceFieldsGameCenterChallengeVersionRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardRelease), TypeInfoPropertyName = "GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSetRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSetRelease), TypeInfoPropertyName = "GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSetRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsAppStoreVersion), TypeInfoPropertyName = "GameCenterDetailsGetInstanceFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceIncludeItem), TypeInfoPropertyName = "GameCenterDetailsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievementRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievementRelease), TypeInfoPropertyName = "GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievementRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement), TypeInfoPropertyName = "GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsAchievementReleasesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsAchievementReleasesGetToManyRelatedIncludeItem), TypeInfoPropertyName = "GameCenterDetailsAchievementReleasesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersionRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersionRelease), TypeInfoPropertyName = "GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersionRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersion), TypeInfoPropertyName = "GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsActivityReleasesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsActivityReleasesGetToManyRelatedIncludeItem), TypeInfoPropertyName = "GameCenterDetailsActivityReleasesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsBlockedPlayersGetToManyRelatedFieldsGameCenterDetailPlayer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsBlockedPlayersGetToManyRelatedFieldsGameCenterDetailPlayer), TypeInfoPropertyName = "GameCenterDetailsBlockedPlayersGetToManyRelatedFieldsGameCenterDetailPlayer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersionRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersionRelease), TypeInfoPropertyName = "GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersionRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersion), TypeInfoPropertyName = "GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsChallengeReleasesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsChallengeReleasesGetToManyRelatedIncludeItem), TypeInfoPropertyName = "GameCenterDetailsChallengeReleasesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement), TypeInfoPropertyName = "GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup), TypeInfoPropertyName = "GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization), TypeInfoPropertyName = "GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease), TypeInfoPropertyName = "GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie), TypeInfoPropertyName = "GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "GameCenterDetailsGameCenterAchievementsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement), TypeInfoPropertyName = "GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterGroup), TypeInfoPropertyName = "GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie), TypeInfoPropertyName = "GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion), TypeInfoPropertyName = "GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedIncludeItem), TypeInfoPropertyName = "GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie), TypeInfoPropertyName = "GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroup), TypeInfoPropertyName = "GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement), TypeInfoPropertyName = "GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard), TypeInfoPropertyName = "GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion), TypeInfoPropertyName = "GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedIncludeItem), TypeInfoPropertyName = "GameCenterDetailsGameCenterActivitiesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsGameCenterAppVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsGameCenterAppVersion), TypeInfoPropertyName = "GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsGameCenterAppVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion), TypeInfoPropertyName = "GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "GameCenterDetailsGameCenterAppVersionsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge), TypeInfoPropertyName = "GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup), TypeInfoPropertyName = "GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion), TypeInfoPropertyName = "GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard), TypeInfoPropertyName = "GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedIncludeItem), TypeInfoPropertyName = "GameCenterDetailsGameCenterChallengesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterGroup), TypeInfoPropertyName = "GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard), TypeInfoPropertyName = "GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSet), TypeInfoPropertyName = "GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement), TypeInfoPropertyName = "GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie), TypeInfoPropertyName = "GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge), TypeInfoPropertyName = "GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItem), TypeInfoPropertyName = "GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet), TypeInfoPropertyName = "GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterGroup), TypeInfoPropertyName = "GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization), TypeInfoPropertyName = "GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard), TypeInfoPropertyName = "GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease), TypeInfoPropertyName = "GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet), TypeInfoPropertyName = "GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterGroup), TypeInfoPropertyName = "GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard), TypeInfoPropertyName = "GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion), TypeInfoPropertyName = "GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem), TypeInfoPropertyName = "GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard), TypeInfoPropertyName = "GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup), TypeInfoPropertyName = "GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet), TypeInfoPropertyName = "GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization), TypeInfoPropertyName = "GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease), TypeInfoPropertyName = "GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie), TypeInfoPropertyName = "GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge), TypeInfoPropertyName = "GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard), TypeInfoPropertyName = "GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroup), TypeInfoPropertyName = "GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSet), TypeInfoPropertyName = "GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie), TypeInfoPropertyName = "GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge), TypeInfoPropertyName = "GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion), TypeInfoPropertyName = "GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem), TypeInfoPropertyName = "GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterLeaderboardRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterLeaderboardRelease), TypeInfoPropertyName = "GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterLeaderboardRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterLeaderboard), TypeInfoPropertyName = "GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsLeaderboardReleasesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardReleasesGetToManyRelatedIncludeItem), TypeInfoPropertyName = "GameCenterDetailsLeaderboardReleasesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease), TypeInfoPropertyName = "GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail), TypeInfoPropertyName = "GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSet), TypeInfoPropertyName = "GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedIncludeItem), TypeInfoPropertyName = "GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsClassicMatchmakingRequestsGetMetricsGranularity), TypeInfoPropertyName = "GameCenterDetailsClassicMatchmakingRequestsGetMetricsGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsClassicMatchmakingRequestsGetMetricsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsClassicMatchmakingRequestsGetMetricsGroupByItem), TypeInfoPropertyName = "GameCenterDetailsClassicMatchmakingRequestsGetMetricsGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsClassicMatchmakingRequestsGetMetricsFilterResult), TypeInfoPropertyName = "GameCenterDetailsClassicMatchmakingRequestsGetMetricsFilterResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsClassicMatchmakingRequestsGetMetricsSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsClassicMatchmakingRequestsGetMetricsSortItem), TypeInfoPropertyName = "GameCenterDetailsClassicMatchmakingRequestsGetMetricsSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGranularity), TypeInfoPropertyName = "GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGroupByItem), TypeInfoPropertyName = "GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsFilterResult), TypeInfoPropertyName = "GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsFilterResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsSortItem), TypeInfoPropertyName = "GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem?), TypeInfoPropertyName = "NullableIncludedItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem2?), TypeInfoPropertyName = "NullableIncludedItem22_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Platform?), TypeInfoPropertyName = "NullablePlatform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
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
    internal sealed partial class GameCenterDetailsSourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementReleasesResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterAchievementReleasesResponseIncludedItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionsResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterAppVersionsResponseIncludedItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailPlayerType?), TypeInfoPropertyName = "NullableGameCenterDetailPlayerType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem102?), TypeInfoPropertyName = "NullableIncludedItem1022")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterDetailResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailCreateRequestDataType?), TypeInfoPropertyName = "NullableGameCenterDetailCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailCreateRequestDataRelationshipsAppDataType?), TypeInfoPropertyName = "NullableGameCenterDetailCreateRequestDataRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataType?), TypeInfoPropertyName = "NullableGameCenterDetailUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsGameCenterGroupDataType?), TypeInfoPropertyName = "NullableGameCenterDetailUpdateRequestDataRelationshipsGameCenterGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardDataType?), TypeInfoPropertyName = "NullableGameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardV2DataType?), TypeInfoPropertyName = "NullableGameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardV2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardDataType?), TypeInfoPropertyName = "NullableGameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardV2DataType?), TypeInfoPropertyName = "NullableGameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardV2DataType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem105?), TypeInfoPropertyName = "NullableIncludedItem1052")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterGroupResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterGroupResponseIncludedItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardReleasesResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardReleasesResponseIncludedItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleasesResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetReleasesResponseIncludedItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailAchievementReleasesLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailAchievementReleasesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailActivityReleasesLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailActivityReleasesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailBlockedPlayersLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailBlockedPlayersLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailChallengeReleasesLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailChallengeReleasesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailChallengesMinimumPlatformVersionsLinkagesRequestDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailChallengesMinimumPlatformVersionsLinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterAchievementsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailGameCenterAchievementsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterAchievementsLinkagesRequestDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailGameCenterAchievementsLinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterAchievementsV2LinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailGameCenterAchievementsV2LinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterAchievementsV2LinkagesRequestDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailGameCenterAchievementsV2LinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterActivitiesLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailGameCenterActivitiesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterAppVersionsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailGameCenterAppVersionsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterChallengesLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailGameCenterChallengesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterGroupLinkageResponseDataType?), TypeInfoPropertyName = "NullableGameCenterDetailGameCenterGroupLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailGameCenterLeaderboardSetsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsLinkagesRequestDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailGameCenterLeaderboardSetsLinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsV2LinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailGameCenterLeaderboardSetsV2LinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsV2LinkagesRequestDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailGameCenterLeaderboardSetsV2LinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailGameCenterLeaderboardsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsLinkagesRequestDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailGameCenterLeaderboardsLinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsV2LinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailGameCenterLeaderboardsV2LinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsV2LinkagesRequestDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailGameCenterLeaderboardsV2LinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailLeaderboardReleasesLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailLeaderboardReleasesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailLeaderboardSetReleasesLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterDetailLeaderboardSetReleasesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResultData?), TypeInfoPropertyName = "NullableGameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResultData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemGranularity?), TypeInfoPropertyName = "NullableGameCenterMatchmakingAppRequestsV1MetricResponseDataItemGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>?), TypeInfoPropertyName = "NullableOneOfErrorSourcePointerErrorSourceParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<string, global::AppStoreConnect.ErrorLinksAssociated>?), TypeInfoPropertyName = "NullableOneOfStringErrorLinksAssociated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterDetailsGetInstanceFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsApp?), TypeInfoPropertyName = "NullableGameCenterDetailsGetInstanceFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterAppVersion?), TypeInfoPropertyName = "NullableGameCenterDetailsGetInstanceFieldsGameCenterAppVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterGroup?), TypeInfoPropertyName = "NullableGameCenterDetailsGetInstanceFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard?), TypeInfoPropertyName = "NullableGameCenterDetailsGetInstanceFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet?), TypeInfoPropertyName = "NullableGameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterAchievement?), TypeInfoPropertyName = "NullableGameCenterDetailsGetInstanceFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterActivitie?), TypeInfoPropertyName = "NullableGameCenterDetailsGetInstanceFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterChallenge?), TypeInfoPropertyName = "NullableGameCenterDetailsGetInstanceFieldsGameCenterChallenge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterAchievementRelease?), TypeInfoPropertyName = "NullableGameCenterDetailsGetInstanceFieldsGameCenterAchievementRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterActivityVersionRelease?), TypeInfoPropertyName = "NullableGameCenterDetailsGetInstanceFieldsGameCenterActivityVersionRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterChallengeVersionRelease?), TypeInfoPropertyName = "NullableGameCenterDetailsGetInstanceFieldsGameCenterChallengeVersionRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardRelease?), TypeInfoPropertyName = "NullableGameCenterDetailsGetInstanceFieldsGameCenterLeaderboardRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSetRelease?), TypeInfoPropertyName = "NullableGameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSetRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsAppStoreVersion?), TypeInfoPropertyName = "NullableGameCenterDetailsGetInstanceFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableGameCenterDetailsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievementRelease?), TypeInfoPropertyName = "NullableGameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievementRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement?), TypeInfoPropertyName = "NullableGameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsAchievementReleasesGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterDetailsAchievementReleasesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersionRelease?), TypeInfoPropertyName = "NullableGameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersionRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersion?), TypeInfoPropertyName = "NullableGameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsActivityReleasesGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterDetailsActivityReleasesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsBlockedPlayersGetToManyRelatedFieldsGameCenterDetailPlayer?), TypeInfoPropertyName = "NullableGameCenterDetailsBlockedPlayersGetToManyRelatedFieldsGameCenterDetailPlayer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersionRelease?), TypeInfoPropertyName = "NullableGameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersionRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersion?), TypeInfoPropertyName = "NullableGameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsChallengeReleasesGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterDetailsChallengeReleasesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterAchievementsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterGroup?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterAchievementsV2GetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroup?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterActivitiesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsGameCenterAppVersion?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsGameCenterAppVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterAppVersionsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterChallengesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterGroup?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSet?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterGroup?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterGroup?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterLeaderboardsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroup?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSet?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterLeaderboardRelease?), TypeInfoPropertyName = "NullableGameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterLeaderboardRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterLeaderboard?), TypeInfoPropertyName = "NullableGameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterLeaderboard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardReleasesGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterDetailsLeaderboardReleasesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease?), TypeInfoPropertyName = "NullableGameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableGameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSet?), TypeInfoPropertyName = "NullableGameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterDetailsLeaderboardSetReleasesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsClassicMatchmakingRequestsGetMetricsGranularity?), TypeInfoPropertyName = "NullableGameCenterDetailsClassicMatchmakingRequestsGetMetricsGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsClassicMatchmakingRequestsGetMetricsGroupByItem?), TypeInfoPropertyName = "NullableGameCenterDetailsClassicMatchmakingRequestsGetMetricsGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsClassicMatchmakingRequestsGetMetricsFilterResult?), TypeInfoPropertyName = "NullableGameCenterDetailsClassicMatchmakingRequestsGetMetricsFilterResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsClassicMatchmakingRequestsGetMetricsSortItem?), TypeInfoPropertyName = "NullableGameCenterDetailsClassicMatchmakingRequestsGetMetricsSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGranularity?), TypeInfoPropertyName = "NullableGameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGroupByItem?), TypeInfoPropertyName = "NullableGameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsFilterResult?), TypeInfoPropertyName = "NullableGameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsFilterResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsSortItem?), TypeInfoPropertyName = "NullableGameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsSortItem2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem79>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterActivityVersionRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterActivityVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterActivityVersionRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterActivityVersionRelationshipsReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAppVersionRelationshipsCompatibilityVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAppVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem93>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterChallengeVersionRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterChallengeVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterChallengeVersionRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterChallengeVersionRelationshipsReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterChallengeRelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterChallenge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem99>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailPlayer>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem102>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterDetailsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterActivitiesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterChallengesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem105>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem110>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem118>))]
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
    internal sealed partial class GameCenterDetailsSourceGenerationContextChunk3 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailAchievementReleasesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailActivityReleasesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailBlockedPlayersLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailChallengeReleasesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailChallengesMinimumPlatformVersionsLinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailGameCenterAchievementsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailGameCenterAchievementsLinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailGameCenterAchievementsV2LinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailGameCenterAchievementsV2LinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailGameCenterActivitiesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailGameCenterAppVersionsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailGameCenterChallengesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsLinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsV2LinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsV2LinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsLinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsV2LinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsV2LinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailLeaderboardReleasesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailLeaderboardSetReleasesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ErrorResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterAppVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterChallenge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterAchievementRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterActivityVersionRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterChallengeVersionRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSetRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievementRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsAchievementReleasesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersionRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsActivityReleasesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsBlockedPlayersGetToManyRelatedFieldsGameCenterDetailPlayer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersionRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsChallengeReleasesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsGameCenterAppVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterLeaderboardRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterLeaderboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsLeaderboardReleasesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsClassicMatchmakingRequestsGetMetricsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsClassicMatchmakingRequestsGetMetricsSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsSortItem>))]
    internal sealed partial class GameCenterDetailsSourceGenerationContextChunk4 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterDetailsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static GameCenterDetailsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private GameCenterDetailsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleasesResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleasesResponseIncludedItemDiscriminatorType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAppVersionsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAppVersionsResponseIncludedItemDiscriminatorType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailPlayerType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailPlayerType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailCreateRequestDataRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailCreateRequestDataRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsGameCenterGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsGameCenterGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardV2DataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardV2DataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardV2DataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardV2DataType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupResponseIncludedItemDiscriminatorType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardReleasesResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardReleasesResponseIncludedItemDiscriminatorType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleasesResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleasesResponseIncludedItemDiscriminatorType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailAchievementReleasesLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailAchievementReleasesLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailActivityReleasesLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailActivityReleasesLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailBlockedPlayersLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailBlockedPlayersLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailChallengeReleasesLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailChallengeReleasesLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailChallengesMinimumPlatformVersionsLinkagesRequestDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailChallengesMinimumPlatformVersionsLinkagesRequestDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterAchievementsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterAchievementsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterAchievementsLinkagesRequestDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterAchievementsLinkagesRequestDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterAchievementsV2LinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterAchievementsV2LinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterAchievementsV2LinkagesRequestDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterAchievementsV2LinkagesRequestDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterActivitiesLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterActivitiesLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterAppVersionsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterAppVersionsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterChallengesLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterChallengesLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterGroupLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterGroupLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsLinkagesRequestDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsLinkagesRequestDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsV2LinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsV2LinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsV2LinkagesRequestDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsV2LinkagesRequestDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsLinkagesRequestDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsLinkagesRequestDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsV2LinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsV2LinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsV2LinkagesRequestDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsV2LinkagesRequestDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailLeaderboardReleasesLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailLeaderboardReleasesLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailLeaderboardSetReleasesLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailLeaderboardSetReleasesLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResultData)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResultData?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemGranularity)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemGranularity?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterAppVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterAppVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterAchievement)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterAchievement?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterActivitie)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterActivitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterChallenge)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterChallenge?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterAchievementRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterAchievementRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterActivityVersionRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterActivityVersionRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterChallengeVersionRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterChallengeVersionRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSetRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSetRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievementRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievementRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsAchievementReleasesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsAchievementReleasesGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersionRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersionRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsActivityReleasesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsActivityReleasesGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsBlockedPlayersGetToManyRelatedFieldsGameCenterDetailPlayer)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsBlockedPlayersGetToManyRelatedFieldsGameCenterDetailPlayer?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersionRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersionRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsChallengeReleasesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsChallengeReleasesGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsGameCenterAppVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsGameCenterAppVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSet)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSet)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterLeaderboardRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterLeaderboardRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterLeaderboard)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterLeaderboard?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardReleasesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardReleasesGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSet)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsClassicMatchmakingRequestsGetMetricsGranularity)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsClassicMatchmakingRequestsGetMetricsGranularity?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsClassicMatchmakingRequestsGetMetricsGroupByItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsClassicMatchmakingRequestsGetMetricsGroupByItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsClassicMatchmakingRequestsGetMetricsFilterResult)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsClassicMatchmakingRequestsGetMetricsFilterResult?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsClassicMatchmakingRequestsGetMetricsSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsClassicMatchmakingRequestsGetMetricsSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGranularity)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGranularity?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGroupByItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGroupByItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsFilterResult)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsFilterResult?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsSortItem?);
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

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleasesResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleasesResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementReleasesResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementReleasesResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAppVersionsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAppVersionsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAppVersionsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAppVersionsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailPlayerType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailPlayerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailPlayerType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailPlayerTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailCreateRequestDataRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailCreateRequestDataRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailCreateRequestDataRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailCreateRequestDataRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailUpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsGameCenterGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailUpdateRequestDataRelationshipsGameCenterGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsGameCenterGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailUpdateRequestDataRelationshipsGameCenterGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardV2DataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardV2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardV2DataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardV2DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardV2DataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardV2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardV2DataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardV2DataTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterGroupResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterGroupResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardReleasesResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardReleasesResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardReleasesResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardReleasesResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleasesResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleasesResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetReleasesResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetReleasesResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailAchievementReleasesLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailAchievementReleasesLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailAchievementReleasesLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailAchievementReleasesLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailActivityReleasesLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailActivityReleasesLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailActivityReleasesLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailActivityReleasesLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailBlockedPlayersLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailBlockedPlayersLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailBlockedPlayersLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailBlockedPlayersLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailChallengeReleasesLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailChallengeReleasesLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailChallengeReleasesLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailChallengeReleasesLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailChallengesMinimumPlatformVersionsLinkagesRequestDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailChallengesMinimumPlatformVersionsLinkagesRequestDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailChallengesMinimumPlatformVersionsLinkagesRequestDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailChallengesMinimumPlatformVersionsLinkagesRequestDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterAchievementsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailGameCenterAchievementsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterAchievementsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailGameCenterAchievementsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterAchievementsLinkagesRequestDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailGameCenterAchievementsLinkagesRequestDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterAchievementsLinkagesRequestDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailGameCenterAchievementsLinkagesRequestDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterAchievementsV2LinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailGameCenterAchievementsV2LinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterAchievementsV2LinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailGameCenterAchievementsV2LinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterAchievementsV2LinkagesRequestDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailGameCenterAchievementsV2LinkagesRequestDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterAchievementsV2LinkagesRequestDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailGameCenterAchievementsV2LinkagesRequestDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterActivitiesLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailGameCenterActivitiesLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterActivitiesLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailGameCenterActivitiesLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterAppVersionsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailGameCenterAppVersionsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterAppVersionsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailGameCenterAppVersionsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterChallengesLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailGameCenterChallengesLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterChallengesLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailGameCenterChallengesLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterGroupLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailGameCenterGroupLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterGroupLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailGameCenterGroupLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailGameCenterLeaderboardSetsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailGameCenterLeaderboardSetsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsLinkagesRequestDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailGameCenterLeaderboardSetsLinkagesRequestDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsLinkagesRequestDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailGameCenterLeaderboardSetsLinkagesRequestDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsV2LinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailGameCenterLeaderboardSetsV2LinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsV2LinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailGameCenterLeaderboardSetsV2LinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsV2LinkagesRequestDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailGameCenterLeaderboardSetsV2LinkagesRequestDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardSetsV2LinkagesRequestDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailGameCenterLeaderboardSetsV2LinkagesRequestDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailGameCenterLeaderboardsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailGameCenterLeaderboardsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsLinkagesRequestDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailGameCenterLeaderboardsLinkagesRequestDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsLinkagesRequestDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailGameCenterLeaderboardsLinkagesRequestDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsV2LinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailGameCenterLeaderboardsV2LinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsV2LinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailGameCenterLeaderboardsV2LinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsV2LinkagesRequestDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailGameCenterLeaderboardsV2LinkagesRequestDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailGameCenterLeaderboardsV2LinkagesRequestDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailGameCenterLeaderboardsV2LinkagesRequestDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailLeaderboardReleasesLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailLeaderboardReleasesLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailLeaderboardReleasesLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailLeaderboardReleasesLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailLeaderboardSetReleasesLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailLeaderboardSetReleasesLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailLeaderboardSetReleasesLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailLeaderboardSetReleasesLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResultData))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResultDataJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResultData?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResultDataNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemGranularity))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemGranularityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemGranularity?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemGranularityNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGetInstanceFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGetInstanceFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGetInstanceFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGetInstanceFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterAppVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGetInstanceFieldsGameCenterAppVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterAppVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGetInstanceFieldsGameCenterAppVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGetInstanceFieldsGameCenterGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGetInstanceFieldsGameCenterGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterAchievement))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGetInstanceFieldsGameCenterAchievementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterAchievement?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGetInstanceFieldsGameCenterAchievementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterActivitie))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGetInstanceFieldsGameCenterActivitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterActivitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGetInstanceFieldsGameCenterActivitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterChallenge))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGetInstanceFieldsGameCenterChallengeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterChallenge?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGetInstanceFieldsGameCenterChallengeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterAchievementRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGetInstanceFieldsGameCenterAchievementReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterAchievementRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGetInstanceFieldsGameCenterAchievementReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterActivityVersionRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGetInstanceFieldsGameCenterActivityVersionReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterActivityVersionRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGetInstanceFieldsGameCenterActivityVersionReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterChallengeVersionRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGetInstanceFieldsGameCenterChallengeVersionReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterChallengeVersionRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGetInstanceFieldsGameCenterChallengeVersionReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSetRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSetReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSetRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSetReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGetInstanceFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGetInstanceFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGetInstanceIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievementRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievementReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievementRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievementReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievement?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsAchievementReleasesGetToManyRelatedFieldsGameCenterAchievementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsAchievementReleasesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsAchievementReleasesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsAchievementReleasesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsAchievementReleasesGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersionRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersionReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersionRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersionReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsActivityReleasesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsActivityReleasesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsActivityReleasesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsActivityReleasesGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsBlockedPlayersGetToManyRelatedFieldsGameCenterDetailPlayer))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsBlockedPlayersGetToManyRelatedFieldsGameCenterDetailPlayerJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsBlockedPlayersGetToManyRelatedFieldsGameCenterDetailPlayer?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsBlockedPlayersGetToManyRelatedFieldsGameCenterDetailPlayerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersionRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersionReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersionRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersionReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsChallengeReleasesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsChallengeReleasesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsChallengeReleasesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsChallengeReleasesGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievement?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterAchievementsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterAchievementsGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievement?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboardJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboardNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterActivitiesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterActivitiesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterActivitiesGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsGameCenterAppVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsGameCenterAppVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsGameCenterAppVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsGameCenterAppVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboardJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboardNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterChallengesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterChallengesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterChallengesGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSet))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievement?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterAchievementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallengeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallengeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallengeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallengeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSet))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallengeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallengeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterLeaderboardRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterLeaderboardReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterLeaderboardRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterLeaderboardReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterLeaderboard))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterLeaderboardJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterLeaderboard?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsLeaderboardReleasesGetToManyRelatedFieldsGameCenterLeaderboardNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardReleasesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsLeaderboardReleasesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardReleasesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsLeaderboardReleasesGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSet))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsClassicMatchmakingRequestsGetMetricsGranularity))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsClassicMatchmakingRequestsGetMetricsGranularityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsClassicMatchmakingRequestsGetMetricsGranularity?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsClassicMatchmakingRequestsGetMetricsGranularityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsClassicMatchmakingRequestsGetMetricsGroupByItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsClassicMatchmakingRequestsGetMetricsGroupByItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsClassicMatchmakingRequestsGetMetricsGroupByItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsClassicMatchmakingRequestsGetMetricsGroupByItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsClassicMatchmakingRequestsGetMetricsFilterResult))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsClassicMatchmakingRequestsGetMetricsFilterResultJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsClassicMatchmakingRequestsGetMetricsFilterResult?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsClassicMatchmakingRequestsGetMetricsFilterResultNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsClassicMatchmakingRequestsGetMetricsSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsClassicMatchmakingRequestsGetMetricsSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsClassicMatchmakingRequestsGetMetricsSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsClassicMatchmakingRequestsGetMetricsSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGranularity))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGranularityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGranularity?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGranularityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGroupByItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGroupByItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGroupByItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGroupByItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsFilterResult))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsFilterResultJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsFilterResult?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsFilterResultNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsSortItemNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[5];

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
                    0 => new GameCenterDetailsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new GameCenterDetailsSourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),

                    2 => new GameCenterDetailsSourceGenerationContextChunk2(new global::System.Text.Json.JsonSerializerOptions()),

                    3 => new GameCenterDetailsSourceGenerationContextChunk3(new global::System.Text.Json.JsonSerializerOptions()),

                    4 => new GameCenterDetailsSourceGenerationContextChunk4(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}