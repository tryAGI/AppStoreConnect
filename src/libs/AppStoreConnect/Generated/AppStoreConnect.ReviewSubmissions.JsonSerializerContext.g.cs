
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ActorType), TypeInfoPropertyName = "ActorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ActorAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ActorAttributesActorType), TypeInfoPropertyName = "ActorAttributesActorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.Platform>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCustomProductPageVersionType), TypeInfoPropertyName = "AppCustomProductPageVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCustomProductPageVersionAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCustomProductPageVersionAttributesState), TypeInfoPropertyName = "AppCustomProductPageVersionAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageDataType), TypeInfoPropertyName = "AppCustomProductPageVersionRelationshipsAppCustomProductPageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItemType), TypeInfoPropertyName = "AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventType), TypeInfoPropertyName = "AppEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventAttributesBadge), TypeInfoPropertyName = "AppEventAttributesBadge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventAttributesEventState), TypeInfoPropertyName = "AppEventAttributesEventState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventAttributesPriority), TypeInfoPropertyName = "AppEventAttributesPriority2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventAttributesPurpose), TypeInfoPropertyName = "AppEventAttributesPurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventAttributesTerritorySchedule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventAttributesTerritorySchedule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventAttributesArchivedTerritorySchedule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventAttributesArchivedTerritorySchedule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventRelationshipsLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventRelationshipsLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventRelationshipsLocalizationsDataItemType), TypeInfoPropertyName = "AppEventRelationshipsLocalizationsDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentType), TypeInfoPropertyName = "AppStoreVersionExperimentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentAttributesState), TypeInfoPropertyName = "AppStoreVersionExperimentAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionDataType), TypeInfoPropertyName = "AppStoreVersionExperimentRelationshipsAppStoreVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatments))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItemType), TypeInfoPropertyName = "AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionType), TypeInfoPropertyName = "BackgroundAssetVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionState), TypeInfoPropertyName = "BackgroundAssetVersionState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionAttributesStateDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.StateDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.StateDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsBackgroundAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsBackgroundAssetData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsBackgroundAssetDataType), TypeInfoPropertyName = "BackgroundAssetVersionRelationshipsBackgroundAssetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsInternalBetaRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsInternalBetaReleaseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsInternalBetaReleaseDataType), TypeInfoPropertyName = "BackgroundAssetVersionRelationshipsInternalBetaReleaseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsExternalBetaRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsExternalBetaReleaseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsExternalBetaReleaseDataType), TypeInfoPropertyName = "BackgroundAssetVersionRelationshipsExternalBetaReleaseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsAppStoreRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsAppStoreReleaseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsAppStoreReleaseDataType), TypeInfoPropertyName = "BackgroundAssetVersionRelationshipsAppStoreReleaseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsAssetFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsAssetFileData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsAssetFileDataType), TypeInfoPropertyName = "BackgroundAssetVersionRelationshipsAssetFileDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsManifestFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsManifestFileData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsManifestFileDataType), TypeInfoPropertyName = "BackgroundAssetVersionRelationshipsManifestFileDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsBackgroundAssetUploadFiles))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem75), TypeInfoPropertyName = "IncludedItem752")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem76), TypeInfoPropertyName = "IncludedItem762")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem77), TypeInfoPropertyName = "IncludedItem772")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem78), TypeInfoPropertyName = "IncludedItem782")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementRelease))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem93), TypeInfoPropertyName = "IncludedItem932")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem94), TypeInfoPropertyName = "IncludedItem942")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem95), TypeInfoPropertyName = "IncludedItem952")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem96), TypeInfoPropertyName = "IncludedItem962")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionRelease))]
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
    internal sealed partial class ReviewSubmissionsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem122), TypeInfoPropertyName = "IncludedItem1222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem123), TypeInfoPropertyName = "IncludedItem1232")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem124), TypeInfoPropertyName = "IncludedItem1242")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseVersionType), TypeInfoPropertyName = "InAppPurchaseVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseVersionAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseVersionAttributesState), TypeInfoPropertyName = "InAppPurchaseVersionAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseVersionRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsInAppPurchase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsInAppPurchaseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsInAppPurchaseDataType), TypeInfoPropertyName = "InAppPurchaseVersionRelationshipsInAppPurchaseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImageDataType), TypeInfoPropertyName = "InAppPurchaseVersionRelationshipsImageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseVersionRelationshipsImagesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImagesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImagesDataItemType), TypeInfoPropertyName = "InAppPurchaseVersionRelationshipsImagesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseVersionRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsLocalizationsDataItemType), TypeInfoPropertyName = "InAppPurchaseVersionRelationshipsLocalizationsDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemType), TypeInfoPropertyName = "ReviewSubmissionItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemAttributesState), TypeInfoPropertyName = "ReviewSubmissionItemAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppStoreVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppStoreVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppStoreVersionDataType), TypeInfoPropertyName = "ReviewSubmissionItemRelationshipsAppStoreVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppCustomProductPageVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppCustomProductPageVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppCustomProductPageVersionDataType), TypeInfoPropertyName = "ReviewSubmissionItemRelationshipsAppCustomProductPageVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppStoreVersionExperiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppStoreVersionExperimentData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppStoreVersionExperimentDataType), TypeInfoPropertyName = "ReviewSubmissionItemRelationshipsAppStoreVersionExperimentDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppStoreVersionExperimentV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppStoreVersionExperimentV2Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppStoreVersionExperimentV2DataType), TypeInfoPropertyName = "ReviewSubmissionItemRelationshipsAppStoreVersionExperimentV2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppEventDataType), TypeInfoPropertyName = "ReviewSubmissionItemRelationshipsAppEventDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsBackgroundAssetVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsBackgroundAssetVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsBackgroundAssetVersionDataType), TypeInfoPropertyName = "ReviewSubmissionItemRelationshipsBackgroundAssetVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterAchievementVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterAchievementVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterAchievementVersionDataType), TypeInfoPropertyName = "ReviewSubmissionItemRelationshipsGameCenterAchievementVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterActivityVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterActivityVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterActivityVersionDataType), TypeInfoPropertyName = "ReviewSubmissionItemRelationshipsGameCenterActivityVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterChallengeVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterChallengeVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterChallengeVersionDataType), TypeInfoPropertyName = "ReviewSubmissionItemRelationshipsGameCenterChallengeVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterLeaderboardSetVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterLeaderboardSetVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterLeaderboardSetVersionDataType), TypeInfoPropertyName = "ReviewSubmissionItemRelationshipsGameCenterLeaderboardSetVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterLeaderboardVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterLeaderboardVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterLeaderboardVersionDataType), TypeInfoPropertyName = "ReviewSubmissionItemRelationshipsGameCenterLeaderboardVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsInAppPurchaseVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsInAppPurchaseVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsInAppPurchaseVersionDataType), TypeInfoPropertyName = "ReviewSubmissionItemRelationshipsInAppPurchaseVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsSubscriptionVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsSubscriptionVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsSubscriptionVersionDataType), TypeInfoPropertyName = "ReviewSubmissionItemRelationshipsSubscriptionVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsSubscriptionGroupVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsSubscriptionGroupVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsSubscriptionGroupVersionDataType), TypeInfoPropertyName = "ReviewSubmissionItemRelationshipsSubscriptionGroupVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem154>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem154), TypeInfoPropertyName = "IncludedItem1542")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemsResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemsResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "ReviewSubmissionItemsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem155), TypeInfoPropertyName = "IncludedItem1552")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionType), TypeInfoPropertyName = "ReviewSubmissionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionAttributesState), TypeInfoPropertyName = "ReviewSubmissionAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsAppData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsAppDataType), TypeInfoPropertyName = "ReviewSubmissionRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionRelationshipsItemsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsItemsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsItemsDataItemType), TypeInfoPropertyName = "ReviewSubmissionRelationshipsItemsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsAppStoreVersionForReview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsAppStoreVersionForReviewData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsAppStoreVersionForReviewDataType), TypeInfoPropertyName = "ReviewSubmissionRelationshipsAppStoreVersionForReviewDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsSubmittedByActor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsSubmittedByActorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsSubmittedByActorDataType), TypeInfoPropertyName = "ReviewSubmissionRelationshipsSubmittedByActorDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsLastUpdatedByActor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsLastUpdatedByActorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsLastUpdatedByActorDataType), TypeInfoPropertyName = "ReviewSubmissionRelationshipsLastUpdatedByActorDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem156>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem156), TypeInfoPropertyName = "IncludedItem1562")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "ReviewSubmissionsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem157>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem157), TypeInfoPropertyName = "IncludedItem1572")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "ReviewSubmissionResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionCreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionCreateRequestDataType), TypeInfoPropertyName = "ReviewSubmissionCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionCreateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionCreateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionCreateRequestDataRelationshipsApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionCreateRequestDataRelationshipsAppData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionCreateRequestDataRelationshipsAppDataType), TypeInfoPropertyName = "ReviewSubmissionCreateRequestDataRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionUpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionUpdateRequestDataType), TypeInfoPropertyName = "ReviewSubmissionUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionUpdateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem158), TypeInfoPropertyName = "IncludedItem1582")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem159), TypeInfoPropertyName = "IncludedItem1592")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAvailability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupLocalizationV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionType), TypeInfoPropertyName = "SubscriptionGroupVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionAttributesState), TypeInfoPropertyName = "SubscriptionGroupVersionAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationshipsSubscriptionGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationshipsSubscriptionGroupData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationshipsSubscriptionGroupDataType), TypeInfoPropertyName = "SubscriptionGroupVersionRelationshipsSubscriptionGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationshipsLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupVersionRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationshipsLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationshipsLocalizationsDataItemType), TypeInfoPropertyName = "SubscriptionGroupVersionRelationshipsLocalizationsDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionType), TypeInfoPropertyName = "SubscriptionVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionAttributesState), TypeInfoPropertyName = "SubscriptionVersionAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsSubscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsSubscriptionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsSubscriptionDataType), TypeInfoPropertyName = "SubscriptionVersionRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImageDataType), TypeInfoPropertyName = "SubscriptionVersionRelationshipsImageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionVersionRelationshipsImagesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImagesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImagesDataItemType), TypeInfoPropertyName = "SubscriptionVersionRelationshipsImagesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizationsDataItemType), TypeInfoPropertyName = "SubscriptionVersionRelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem174), TypeInfoPropertyName = "IncludedItem1742")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem175), TypeInfoPropertyName = "IncludedItem1752")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem176), TypeInfoPropertyName = "IncludedItem1762")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.WinBackOffer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem177), TypeInfoPropertyName = "IncludedItem1772")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem179), TypeInfoPropertyName = "IncludedItem1792")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionItemsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemsLinkagesResponseDataItemType), TypeInfoPropertyName = "ReviewSubmissionItemsLinkagesResponseDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterPlatformItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterPlatformItem), TypeInfoPropertyName = "ReviewSubmissionsGetCollectionFilterPlatformItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterStateItem), TypeInfoPropertyName = "ReviewSubmissionsGetCollectionFilterStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmission), TypeInfoPropertyName = "ReviewSubmissionsGetCollectionFieldsReviewSubmission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsApp), TypeInfoPropertyName = "ReviewSubmissionsGetCollectionFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem), TypeInfoPropertyName = "ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsAppStoreVersion), TypeInfoPropertyName = "ReviewSubmissionsGetCollectionFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsActor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsActor), TypeInfoPropertyName = "ReviewSubmissionsGetCollectionFieldsActor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetCollectionIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionIncludeItem), TypeInfoPropertyName = "ReviewSubmissionsGetCollectionIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmission), TypeInfoPropertyName = "ReviewSubmissionsGetInstanceFieldsReviewSubmission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsApp), TypeInfoPropertyName = "ReviewSubmissionsGetInstanceFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem), TypeInfoPropertyName = "ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsAppStoreVersion), TypeInfoPropertyName = "ReviewSubmissionsGetInstanceFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsActor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsActor), TypeInfoPropertyName = "ReviewSubmissionsGetInstanceFieldsActor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceIncludeItem), TypeInfoPropertyName = "ReviewSubmissionsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem), TypeInfoPropertyName = "ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion), TypeInfoPropertyName = "ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppCustomProductPageVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppCustomProductPageVersion), TypeInfoPropertyName = "ReviewSubmissionsItemsGetToManyRelatedFieldsAppCustomProductPageVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment), TypeInfoPropertyName = "ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent), TypeInfoPropertyName = "ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion), TypeInfoPropertyName = "ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterAchievementVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterAchievementVersion), TypeInfoPropertyName = "ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterAchievementVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterActivityVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterActivityVersion), TypeInfoPropertyName = "ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterActivityVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterChallengeVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterChallengeVersion), TypeInfoPropertyName = "ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterChallengeVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion), TypeInfoPropertyName = "ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardVersion), TypeInfoPropertyName = "ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsInAppPurchaseVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsInAppPurchaseVersion), TypeInfoPropertyName = "ReviewSubmissionsItemsGetToManyRelatedFieldsInAppPurchaseVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionVersion), TypeInfoPropertyName = "ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionGroupVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionGroupVersion), TypeInfoPropertyName = "ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionGroupVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "ReviewSubmissionsItemsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ActorType?), TypeInfoPropertyName = "NullableActorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ActorAttributesActorType?), TypeInfoPropertyName = "NullableActorAttributesActorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCustomProductPageVersionType?), TypeInfoPropertyName = "NullableAppCustomProductPageVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCustomProductPageVersionAttributesState?), TypeInfoPropertyName = "NullableAppCustomProductPageVersionAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageDataType?), TypeInfoPropertyName = "NullableAppCustomProductPageVersionRelationshipsAppCustomProductPageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItemType?), TypeInfoPropertyName = "NullableAppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem13?), TypeInfoPropertyName = "NullableIncludedItem132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem14?), TypeInfoPropertyName = "NullableIncludedItem142_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem15?), TypeInfoPropertyName = "NullableIncludedItem152_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem16?), TypeInfoPropertyName = "NullableIncludedItem162_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem18?), TypeInfoPropertyName = "NullableIncludedItem182")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem19?), TypeInfoPropertyName = "NullableIncludedItem192")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem20?), TypeInfoPropertyName = "NullableIncludedItem202")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem21?), TypeInfoPropertyName = "NullableIncludedItem212")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventType?), TypeInfoPropertyName = "NullableAppEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventAttributesBadge?), TypeInfoPropertyName = "NullableAppEventAttributesBadge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventAttributesEventState?), TypeInfoPropertyName = "NullableAppEventAttributesEventState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventAttributesPriority?), TypeInfoPropertyName = "NullableAppEventAttributesPriority2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventAttributesPurpose?), TypeInfoPropertyName = "NullableAppEventAttributesPurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventRelationshipsLocalizationsDataItemType?), TypeInfoPropertyName = "NullableAppEventRelationshipsLocalizationsDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentType?), TypeInfoPropertyName = "NullableAppStoreVersionExperimentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentAttributesState?), TypeInfoPropertyName = "NullableAppStoreVersionExperimentAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionDataType?), TypeInfoPropertyName = "NullableAppStoreVersionExperimentRelationshipsAppStoreVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItemType?), TypeInfoPropertyName = "NullableAppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionType?), TypeInfoPropertyName = "NullableBackgroundAssetVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionState?), TypeInfoPropertyName = "NullableBackgroundAssetVersionState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsBackgroundAssetDataType?), TypeInfoPropertyName = "NullableBackgroundAssetVersionRelationshipsBackgroundAssetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsInternalBetaReleaseDataType?), TypeInfoPropertyName = "NullableBackgroundAssetVersionRelationshipsInternalBetaReleaseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsExternalBetaReleaseDataType?), TypeInfoPropertyName = "NullableBackgroundAssetVersionRelationshipsExternalBetaReleaseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsAppStoreReleaseDataType?), TypeInfoPropertyName = "NullableBackgroundAssetVersionRelationshipsAppStoreReleaseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsAssetFileDataType?), TypeInfoPropertyName = "NullableBackgroundAssetVersionRelationshipsAssetFileDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsManifestFileDataType?), TypeInfoPropertyName = "NullableBackgroundAssetVersionRelationshipsManifestFileDataType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem77?), TypeInfoPropertyName = "NullableIncludedItem772")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem78?), TypeInfoPropertyName = "NullableIncludedItem782")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem79?), TypeInfoPropertyName = "NullableIncludedItem792")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem80?), TypeInfoPropertyName = "NullableIncludedItem802")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2Type?), TypeInfoPropertyName = "NullableGameCenterAchievementVersionV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterVersionState?), TypeInfoPropertyName = "NullableGameCenterVersionState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsAchievementDataType?), TypeInfoPropertyName = "NullableGameCenterAchievementVersionV2RelationshipsAchievementDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItemType?), TypeInfoPropertyName = "NullableGameCenterAchievementVersionV2RelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem83?), TypeInfoPropertyName = "NullableIncludedItem832")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem84?), TypeInfoPropertyName = "NullableIncludedItem842")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem85?), TypeInfoPropertyName = "NullableIncludedItem852")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem86?), TypeInfoPropertyName = "NullableIncludedItem862")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem87?), TypeInfoPropertyName = "NullableIncludedItem872")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem88?), TypeInfoPropertyName = "NullableIncludedItem882")]
    internal sealed partial class ReviewSubmissionsSourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem89?), TypeInfoPropertyName = "NullableIncludedItem892")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem90?), TypeInfoPropertyName = "NullableIncludedItem902")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionType?), TypeInfoPropertyName = "NullableGameCenterActivityVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsActivityDataType?), TypeInfoPropertyName = "NullableGameCenterActivityVersionRelationshipsActivityDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsLocalizationsDataItemType?), TypeInfoPropertyName = "NullableGameCenterActivityVersionRelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsDefaultImageDataType?), TypeInfoPropertyName = "NullableGameCenterActivityVersionRelationshipsDefaultImageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterActivityVersionRelationshipsReleasesDataItemType?), TypeInfoPropertyName = "NullableGameCenterActivityVersionRelationshipsReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem91?), TypeInfoPropertyName = "NullableIncludedItem912")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem92?), TypeInfoPropertyName = "NullableIncludedItem922")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem93?), TypeInfoPropertyName = "NullableIncludedItem932")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem94?), TypeInfoPropertyName = "NullableIncludedItem942")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem95?), TypeInfoPropertyName = "NullableIncludedItem952")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem96?), TypeInfoPropertyName = "NullableIncludedItem962")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionType?), TypeInfoPropertyName = "NullableGameCenterChallengeVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsChallengeDataType?), TypeInfoPropertyName = "NullableGameCenterChallengeVersionRelationshipsChallengeDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsLocalizationsDataItemType?), TypeInfoPropertyName = "NullableGameCenterChallengeVersionRelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsReleasesDataItemType?), TypeInfoPropertyName = "NullableGameCenterChallengeVersionRelationshipsReleasesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsDefaultImageDataType?), TypeInfoPropertyName = "NullableGameCenterChallengeVersionRelationshipsDefaultImageDataType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2Type?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetVersionV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLeaderboardSetDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetVersionV2RelationshipsLeaderboardSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem120?), TypeInfoPropertyName = "NullableIncludedItem1202")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem121?), TypeInfoPropertyName = "NullableIncludedItem1212")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem122?), TypeInfoPropertyName = "NullableIncludedItem1222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem123?), TypeInfoPropertyName = "NullableIncludedItem1232")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem124?), TypeInfoPropertyName = "NullableIncludedItem1242")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem125?), TypeInfoPropertyName = "NullableIncludedItem1252")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2Type?), TypeInfoPropertyName = "NullableGameCenterLeaderboardVersionV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLeaderboardDataType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardVersionV2RelationshipsLeaderboardDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemType?), TypeInfoPropertyName = "NullableGameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem126?), TypeInfoPropertyName = "NullableIncludedItem1262")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem127?), TypeInfoPropertyName = "NullableIncludedItem1272")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem128?), TypeInfoPropertyName = "NullableIncludedItem1282")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem129?), TypeInfoPropertyName = "NullableIncludedItem1292")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem130?), TypeInfoPropertyName = "NullableIncludedItem1302")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem131?), TypeInfoPropertyName = "NullableIncludedItem1312")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem138?), TypeInfoPropertyName = "NullableIncludedItem1382")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem139?), TypeInfoPropertyName = "NullableIncludedItem1392")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem141?), TypeInfoPropertyName = "NullableIncludedItem1412")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseVersionType?), TypeInfoPropertyName = "NullableInAppPurchaseVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseVersionAttributesState?), TypeInfoPropertyName = "NullableInAppPurchaseVersionAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsInAppPurchaseDataType?), TypeInfoPropertyName = "NullableInAppPurchaseVersionRelationshipsInAppPurchaseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImageDataType?), TypeInfoPropertyName = "NullableInAppPurchaseVersionRelationshipsImageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImagesDataItemType?), TypeInfoPropertyName = "NullableInAppPurchaseVersionRelationshipsImagesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsLocalizationsDataItemType?), TypeInfoPropertyName = "NullableInAppPurchaseVersionRelationshipsLocalizationsDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemType?), TypeInfoPropertyName = "NullableReviewSubmissionItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemAttributesState?), TypeInfoPropertyName = "NullableReviewSubmissionItemAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppStoreVersionDataType?), TypeInfoPropertyName = "NullableReviewSubmissionItemRelationshipsAppStoreVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppCustomProductPageVersionDataType?), TypeInfoPropertyName = "NullableReviewSubmissionItemRelationshipsAppCustomProductPageVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppStoreVersionExperimentDataType?), TypeInfoPropertyName = "NullableReviewSubmissionItemRelationshipsAppStoreVersionExperimentDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppStoreVersionExperimentV2DataType?), TypeInfoPropertyName = "NullableReviewSubmissionItemRelationshipsAppStoreVersionExperimentV2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppEventDataType?), TypeInfoPropertyName = "NullableReviewSubmissionItemRelationshipsAppEventDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsBackgroundAssetVersionDataType?), TypeInfoPropertyName = "NullableReviewSubmissionItemRelationshipsBackgroundAssetVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterAchievementVersionDataType?), TypeInfoPropertyName = "NullableReviewSubmissionItemRelationshipsGameCenterAchievementVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterActivityVersionDataType?), TypeInfoPropertyName = "NullableReviewSubmissionItemRelationshipsGameCenterActivityVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterChallengeVersionDataType?), TypeInfoPropertyName = "NullableReviewSubmissionItemRelationshipsGameCenterChallengeVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterLeaderboardSetVersionDataType?), TypeInfoPropertyName = "NullableReviewSubmissionItemRelationshipsGameCenterLeaderboardSetVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterLeaderboardVersionDataType?), TypeInfoPropertyName = "NullableReviewSubmissionItemRelationshipsGameCenterLeaderboardVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsInAppPurchaseVersionDataType?), TypeInfoPropertyName = "NullableReviewSubmissionItemRelationshipsInAppPurchaseVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsSubscriptionVersionDataType?), TypeInfoPropertyName = "NullableReviewSubmissionItemRelationshipsSubscriptionVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsSubscriptionGroupVersionDataType?), TypeInfoPropertyName = "NullableReviewSubmissionItemRelationshipsSubscriptionGroupVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem154?), TypeInfoPropertyName = "NullableIncludedItem1542")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemsResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableReviewSubmissionItemsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem155?), TypeInfoPropertyName = "NullableIncludedItem1552")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionType?), TypeInfoPropertyName = "NullableReviewSubmissionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionAttributesState?), TypeInfoPropertyName = "NullableReviewSubmissionAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsAppDataType?), TypeInfoPropertyName = "NullableReviewSubmissionRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsItemsDataItemType?), TypeInfoPropertyName = "NullableReviewSubmissionRelationshipsItemsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsAppStoreVersionForReviewDataType?), TypeInfoPropertyName = "NullableReviewSubmissionRelationshipsAppStoreVersionForReviewDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsSubmittedByActorDataType?), TypeInfoPropertyName = "NullableReviewSubmissionRelationshipsSubmittedByActorDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsLastUpdatedByActorDataType?), TypeInfoPropertyName = "NullableReviewSubmissionRelationshipsLastUpdatedByActorDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem156?), TypeInfoPropertyName = "NullableIncludedItem1562")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableReviewSubmissionsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem157?), TypeInfoPropertyName = "NullableIncludedItem1572")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableReviewSubmissionResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionCreateRequestDataType?), TypeInfoPropertyName = "NullableReviewSubmissionCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionCreateRequestDataRelationshipsAppDataType?), TypeInfoPropertyName = "NullableReviewSubmissionCreateRequestDataRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionUpdateRequestDataType?), TypeInfoPropertyName = "NullableReviewSubmissionUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem158?), TypeInfoPropertyName = "NullableIncludedItem1582")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem159?), TypeInfoPropertyName = "NullableIncludedItem1592")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionType?), TypeInfoPropertyName = "NullableSubscriptionGroupVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionAttributesState?), TypeInfoPropertyName = "NullableSubscriptionGroupVersionAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationshipsSubscriptionGroupDataType?), TypeInfoPropertyName = "NullableSubscriptionGroupVersionRelationshipsSubscriptionGroupDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationshipsLocalizationsDataItemType?), TypeInfoPropertyName = "NullableSubscriptionGroupVersionRelationshipsLocalizationsDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionType?), TypeInfoPropertyName = "NullableSubscriptionVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionAttributesState?), TypeInfoPropertyName = "NullableSubscriptionVersionAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsSubscriptionDataType?), TypeInfoPropertyName = "NullableSubscriptionVersionRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImageDataType?), TypeInfoPropertyName = "NullableSubscriptionVersionRelationshipsImageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImagesDataItemType?), TypeInfoPropertyName = "NullableSubscriptionVersionRelationshipsImagesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizationsDataItemType?), TypeInfoPropertyName = "NullableSubscriptionVersionRelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem174?), TypeInfoPropertyName = "NullableIncludedItem1742")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem175?), TypeInfoPropertyName = "NullableIncludedItem1752")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem176?), TypeInfoPropertyName = "NullableIncludedItem1762")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem177?), TypeInfoPropertyName = "NullableIncludedItem1772")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem179?), TypeInfoPropertyName = "NullableIncludedItem1792")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItemsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableReviewSubmissionItemsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>?), TypeInfoPropertyName = "NullableOneOfErrorSourcePointerErrorSourceParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<string, global::AppStoreConnect.ErrorLinksAssociated>?), TypeInfoPropertyName = "NullableOneOfStringErrorLinksAssociated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterPlatformItem?), TypeInfoPropertyName = "NullableReviewSubmissionsGetCollectionFilterPlatformItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterStateItem?), TypeInfoPropertyName = "NullableReviewSubmissionsGetCollectionFilterStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmission?), TypeInfoPropertyName = "NullableReviewSubmissionsGetCollectionFieldsReviewSubmission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsApp?), TypeInfoPropertyName = "NullableReviewSubmissionsGetCollectionFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem?), TypeInfoPropertyName = "NullableReviewSubmissionsGetCollectionFieldsReviewSubmissionItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsAppStoreVersion?), TypeInfoPropertyName = "NullableReviewSubmissionsGetCollectionFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsActor?), TypeInfoPropertyName = "NullableReviewSubmissionsGetCollectionFieldsActor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionIncludeItem?), TypeInfoPropertyName = "NullableReviewSubmissionsGetCollectionIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmission?), TypeInfoPropertyName = "NullableReviewSubmissionsGetInstanceFieldsReviewSubmission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsApp?), TypeInfoPropertyName = "NullableReviewSubmissionsGetInstanceFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem?), TypeInfoPropertyName = "NullableReviewSubmissionsGetInstanceFieldsReviewSubmissionItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsAppStoreVersion?), TypeInfoPropertyName = "NullableReviewSubmissionsGetInstanceFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsActor?), TypeInfoPropertyName = "NullableReviewSubmissionsGetInstanceFieldsActor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableReviewSubmissionsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem?), TypeInfoPropertyName = "NullableReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion?), TypeInfoPropertyName = "NullableReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppCustomProductPageVersion?), TypeInfoPropertyName = "NullableReviewSubmissionsItemsGetToManyRelatedFieldsAppCustomProductPageVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment?), TypeInfoPropertyName = "NullableReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent?), TypeInfoPropertyName = "NullableReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion?), TypeInfoPropertyName = "NullableReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterAchievementVersion?), TypeInfoPropertyName = "NullableReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterAchievementVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterActivityVersion?), TypeInfoPropertyName = "NullableReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterActivityVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterChallengeVersion?), TypeInfoPropertyName = "NullableReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterChallengeVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion?), TypeInfoPropertyName = "NullableReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardVersion?), TypeInfoPropertyName = "NullableReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsInAppPurchaseVersion?), TypeInfoPropertyName = "NullableReviewSubmissionsItemsGetToManyRelatedFieldsInAppPurchaseVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionVersion?), TypeInfoPropertyName = "NullableReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionGroupVersion?), TypeInfoPropertyName = "NullableReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionGroupVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableReviewSubmissionsItemsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.Platform>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEventAttributesTerritorySchedule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEventAttributesArchivedTerritorySchedule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEventRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItem>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterActivityVersionRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterActivityVersionRelationshipsReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterChallengeVersionRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterChallengeVersionRelationshipsReleasesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseVersionRelationshipsImagesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseVersionRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem154>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionRelationshipsItemsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem156>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem157>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupVersionRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionVersionRelationshipsImagesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionItemsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ErrorResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterPlatformItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsActor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsGetCollectionIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsActor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppCustomProductPageVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterAchievementVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterActivityVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterChallengeVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsInAppPurchaseVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionGroupVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedIncludeItem>))]
    internal sealed partial class ReviewSubmissionsSourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReviewSubmissionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ReviewSubmissionsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ReviewSubmissionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.ActorType)

                    || typeToConvert == typeof(global::AppStoreConnect.ActorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ActorAttributesActorType)

                    || typeToConvert == typeof(global::AppStoreConnect.ActorAttributesActorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesBadge)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesBadge?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesEventState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesEventState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesPriority)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesPriority?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesPurpose)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesPurpose?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventRelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventRelationshipsLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItemType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsBackgroundAssetDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsBackgroundAssetDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsInternalBetaReleaseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsInternalBetaReleaseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsExternalBetaReleaseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsExternalBetaReleaseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsAppStoreReleaseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsAppStoreReleaseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsAssetFileDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsAssetFileDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsManifestFileDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsManifestFileDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsAchievementDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsAchievementDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItemType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLeaderboardSetDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLeaderboardSetDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLeaderboardDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLeaderboardDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsInAppPurchaseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsInAppPurchaseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImagesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImagesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppStoreVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppStoreVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppCustomProductPageVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppCustomProductPageVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppStoreVersionExperimentDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppStoreVersionExperimentDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppStoreVersionExperimentV2DataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppStoreVersionExperimentV2DataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppEventDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppEventDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsBackgroundAssetVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsBackgroundAssetVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterAchievementVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterAchievementVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterActivityVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterActivityVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterChallengeVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterChallengeVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterLeaderboardSetVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterLeaderboardSetVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterLeaderboardVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterLeaderboardVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsInAppPurchaseVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsInAppPurchaseVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsSubscriptionVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsSubscriptionVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsSubscriptionGroupVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsSubscriptionGroupVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsItemsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsItemsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsAppStoreVersionForReviewDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsAppStoreVersionForReviewDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsSubmittedByActorDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsSubmittedByActorDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsLastUpdatedByActorDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsLastUpdatedByActorDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionCreateRequestDataRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionCreateRequestDataRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationshipsSubscriptionGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationshipsSubscriptionGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationshipsLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsSubscriptionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsSubscriptionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImagesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImagesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppVersionState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppVersionState?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionState)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionState?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterVersionState)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterVersionState?)

                    || typeToConvert == typeof(global::AppStoreConnect.Platform)

                    || typeToConvert == typeof(global::AppStoreConnect.Platform?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterPlatformItem)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterPlatformItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmission)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmission?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsActor)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsActor?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmission)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmission?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsActor)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsActor?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppCustomProductPageVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppCustomProductPageVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterAchievementVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterAchievementVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterActivityVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterActivityVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterChallengeVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterChallengeVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsInAppPurchaseVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsInAppPurchaseVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionGroupVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionGroupVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.ActorType))
                {
                    return new global::AppStoreConnect.JsonConverters.ActorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ActorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ActorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ActorAttributesActorType))
                {
                    return new global::AppStoreConnect.JsonConverters.ActorAttributesActorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ActorAttributesActorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ActorAttributesActorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageVersionAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageVersionAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageVersionRelationshipsAppCustomProductPageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageVersionRelationshipsAppCustomProductPageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesBadge))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventAttributesBadgeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesBadge?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventAttributesBadgeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesEventState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventAttributesEventStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesEventState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventAttributesEventStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesPriority))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventAttributesPriorityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesPriority?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventAttributesPriorityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesPurpose))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventAttributesPurposeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesPurpose?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventAttributesPurposeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventRelationshipsLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventRelationshipsLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventRelationshipsLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventRelationshipsLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentRelationshipsAppStoreVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentRelationshipsAppStoreVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItemTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsBackgroundAssetDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionRelationshipsBackgroundAssetDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsBackgroundAssetDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionRelationshipsBackgroundAssetDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsInternalBetaReleaseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionRelationshipsInternalBetaReleaseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsInternalBetaReleaseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionRelationshipsInternalBetaReleaseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsExternalBetaReleaseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionRelationshipsExternalBetaReleaseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsExternalBetaReleaseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionRelationshipsExternalBetaReleaseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsAppStoreReleaseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionRelationshipsAppStoreReleaseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsAppStoreReleaseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionRelationshipsAppStoreReleaseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsAssetFileDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionRelationshipsAssetFileDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsAssetFileDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionRelationshipsAssetFileDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsManifestFileDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionRelationshipsManifestFileDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsManifestFileDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionRelationshipsManifestFileDataTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsInAppPurchaseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionRelationshipsInAppPurchaseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsInAppPurchaseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionRelationshipsInAppPurchaseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionRelationshipsImageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionRelationshipsImageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImagesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionRelationshipsImagesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImagesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionRelationshipsImagesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionRelationshipsLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionRelationshipsLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppStoreVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemRelationshipsAppStoreVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppStoreVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemRelationshipsAppStoreVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppCustomProductPageVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemRelationshipsAppCustomProductPageVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppCustomProductPageVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemRelationshipsAppCustomProductPageVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppStoreVersionExperimentDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemRelationshipsAppStoreVersionExperimentDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppStoreVersionExperimentDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemRelationshipsAppStoreVersionExperimentDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppStoreVersionExperimentV2DataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemRelationshipsAppStoreVersionExperimentV2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppStoreVersionExperimentV2DataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemRelationshipsAppStoreVersionExperimentV2DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppEventDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemRelationshipsAppEventDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppEventDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemRelationshipsAppEventDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsBackgroundAssetVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemRelationshipsBackgroundAssetVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsBackgroundAssetVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemRelationshipsBackgroundAssetVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterAchievementVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemRelationshipsGameCenterAchievementVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterAchievementVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemRelationshipsGameCenterAchievementVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterActivityVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemRelationshipsGameCenterActivityVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterActivityVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemRelationshipsGameCenterActivityVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterChallengeVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemRelationshipsGameCenterChallengeVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterChallengeVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemRelationshipsGameCenterChallengeVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterLeaderboardSetVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemRelationshipsGameCenterLeaderboardSetVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterLeaderboardSetVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemRelationshipsGameCenterLeaderboardSetVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterLeaderboardVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemRelationshipsGameCenterLeaderboardVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterLeaderboardVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemRelationshipsGameCenterLeaderboardVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsInAppPurchaseVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemRelationshipsInAppPurchaseVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsInAppPurchaseVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemRelationshipsInAppPurchaseVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsSubscriptionVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemRelationshipsSubscriptionVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsSubscriptionVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemRelationshipsSubscriptionVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsSubscriptionGroupVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemRelationshipsSubscriptionGroupVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationshipsSubscriptionGroupVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemRelationshipsSubscriptionGroupVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsItemsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionRelationshipsItemsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsItemsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionRelationshipsItemsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsAppStoreVersionForReviewDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionRelationshipsAppStoreVersionForReviewDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsAppStoreVersionForReviewDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionRelationshipsAppStoreVersionForReviewDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsSubmittedByActorDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionRelationshipsSubmittedByActorDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsSubmittedByActorDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionRelationshipsSubmittedByActorDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsLastUpdatedByActorDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionRelationshipsLastUpdatedByActorDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsLastUpdatedByActorDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionRelationshipsLastUpdatedByActorDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionCreateRequestDataRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionCreateRequestDataRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionCreateRequestDataRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionCreateRequestDataRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionUpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupVersionAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupVersionAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationshipsSubscriptionGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupVersionRelationshipsSubscriptionGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationshipsSubscriptionGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupVersionRelationshipsSubscriptionGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationshipsLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupVersionRelationshipsLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupVersionRelationshipsLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupVersionRelationshipsLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsSubscriptionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionRelationshipsSubscriptionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsSubscriptionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionRelationshipsSubscriptionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionRelationshipsImageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionRelationshipsImageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImagesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionRelationshipsImagesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImagesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionRelationshipsImagesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionRelationshipsLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionRelationshipsLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemsLinkagesResponseDataItemTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionState))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionState?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionStateNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterPlatformItem))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetCollectionFilterPlatformItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterPlatformItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetCollectionFilterPlatformItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetCollectionFilterStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetCollectionFilterStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmission))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetCollectionFieldsReviewSubmissionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmission?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetCollectionFieldsReviewSubmissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetCollectionFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetCollectionFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetCollectionFieldsReviewSubmissionItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetCollectionFieldsReviewSubmissionItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetCollectionFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetCollectionFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsActor))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetCollectionFieldsActorJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsActor?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetCollectionFieldsActorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetCollectionIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetCollectionIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmission))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetInstanceFieldsReviewSubmissionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmission?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetInstanceFieldsReviewSubmissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetInstanceFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetInstanceFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetInstanceFieldsReviewSubmissionItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetInstanceFieldsReviewSubmissionItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetInstanceFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetInstanceFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsActor))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetInstanceFieldsActorJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsActor?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetInstanceFieldsActorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetInstanceIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppCustomProductPageVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsItemsGetToManyRelatedFieldsAppCustomProductPageVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppCustomProductPageVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsItemsGetToManyRelatedFieldsAppCustomProductPageVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperimentJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperimentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsItemsGetToManyRelatedFieldsAppEventJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsItemsGetToManyRelatedFieldsAppEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterAchievementVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterAchievementVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterAchievementVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterAchievementVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterActivityVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterActivityVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterActivityVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterActivityVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterChallengeVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterChallengeVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterChallengeVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterChallengeVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardSetVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardSetVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsInAppPurchaseVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsItemsGetToManyRelatedFieldsInAppPurchaseVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsInAppPurchaseVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsItemsGetToManyRelatedFieldsInAppPurchaseVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionGroupVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionGroupVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionGroupVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionGroupVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsItemsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsItemsGetToManyRelatedIncludeItemNullableJsonConverter();
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
                    0 => new ReviewSubmissionsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new ReviewSubmissionsSourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),

                    2 => new ReviewSubmissionsSourceGenerationContextChunk2(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}