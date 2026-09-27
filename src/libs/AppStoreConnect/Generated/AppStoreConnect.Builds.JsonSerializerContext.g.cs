
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageType), TypeInfoPropertyName = "AlternativeDistributionPackageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Checksums))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageRelationshipsVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackageRelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageRelationshipsVersionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageRelationshipsVersionsDataItemType), TypeInfoPropertyName = "AlternativeDistributionPackageRelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AndroidToIosAppMappingDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Platform), TypeInfoPropertyName = "Platform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipAdvancedExperienceImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ImageAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.UploadOperation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UploadOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppMediaAssetState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipAdvancedExperienceLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipAction), TypeInfoPropertyName = "AppClipAction2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceType), TypeInfoPropertyName = "AppClipDefaultExperienceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClip))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDataType), TypeInfoPropertyName = "AppClipDefaultExperienceRelationshipsAppClipDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionDataType), TypeInfoPropertyName = "AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemType), TypeInfoPropertyName = "AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataType), TypeInfoPropertyName = "AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreReviewDetailType), TypeInfoPropertyName = "AppStoreReviewDetailType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreReviewDetailAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreReviewDetailRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreReviewDetailRelationshipsAppStoreVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreReviewDetailRelationshipsAppStoreVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreReviewDetailRelationshipsAppStoreVersionDataType), TypeInfoPropertyName = "AppStoreReviewDetailRelationshipsAppStoreVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreReviewDetailRelationshipsAppStoreReviewAttachments))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreReviewDetailRelationshipsAppStoreReviewAttachmentsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreReviewDetailRelationshipsAppStoreReviewAttachmentsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreReviewDetailRelationshipsAppStoreReviewAttachmentsDataItemType), TypeInfoPropertyName = "AppStoreReviewDetailRelationshipsAppStoreReviewAttachmentsDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionLocalizationType), TypeInfoPropertyName = "AppStoreVersionLocalizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionLocalizationAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppStoreVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppStoreVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppStoreVersionDataType), TypeInfoPropertyName = "AppStoreVersionLocalizationRelationshipsAppStoreVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppScreenshotSets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItemType), TypeInfoPropertyName = "AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppPreviewSets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItemType), TypeInfoPropertyName = "AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsSearchKeywords))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItemType), TypeInfoPropertyName = "AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem42), TypeInfoPropertyName = "IncludedItem422")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem43), TypeInfoPropertyName = "IncludedItem432")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionPhasedRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionPhasedReleaseType), TypeInfoPropertyName = "AppStoreVersionPhasedReleaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionPhasedReleaseAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PhasedReleaseState), TypeInfoPropertyName = "PhasedReleaseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionSubmission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionSubmissionType), TypeInfoPropertyName = "AppStoreVersionSubmissionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionSubmissionRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionSubmissionRelationshipsAppStoreVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionSubmissionRelationshipsAppStoreVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionSubmissionRelationshipsAppStoreVersionDataType), TypeInfoPropertyName = "AppStoreVersionSubmissionRelationshipsAppStoreVersionDataType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem45>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem45), TypeInfoPropertyName = "IncludedItem452")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "AppStoreVersionResponseIncludedItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaBuildLocalization>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTester>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBetaDetailResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildIcon>))]
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
    internal sealed partial class BuildsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem63>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem63), TypeInfoPropertyName = "IncludedItem632")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "BuildResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUpdateRequestDataType), TypeInfoPropertyName = "BuildUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUpdateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUpdateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUpdateRequestDataRelationshipsAppEncryptionDeclaration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUpdateRequestDataRelationshipsAppEncryptionDeclarationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUpdateRequestDataRelationshipsAppEncryptionDeclarationDataType), TypeInfoPropertyName = "BuildUpdateRequestDataRelationshipsAppEncryptionDeclarationDataType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DiagnosticSignature))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DiagnosticSignatureType), TypeInfoPropertyName = "DiagnosticSignatureType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DiagnosticSignatureAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DiagnosticSignatureAttributesDiagnosticType), TypeInfoPropertyName = "DiagnosticSignatureAttributesDiagnosticType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DiagnosticInsight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DiagnosticSignatureRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DiagnosticSignatureRelationshipsLogs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DiagnosticSignaturesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.DiagnosticSignature>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.RoutingAppCoverageType), TypeInfoPropertyName = "RoutingAppCoverageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.RoutingAppCoverageAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.RoutingAppCoverageRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.RoutingAppCoverageRelationshipsAppStoreVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.RoutingAppCoverageRelationshipsAppStoreVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.RoutingAppCoverageRelationshipsAppStoreVersionDataType), TypeInfoPropertyName = "RoutingAppCoverageRelationshipsAppStoreVersionDataType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppWithoutIncludesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaTestersWithoutIncludesResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildUsagesV1MetricResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaBuildUsagesV1MetricResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildUsagesV1MetricResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaBuildUsagesV1MetricResponseDataItemDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildUsagesV1MetricResponseDataItemDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildUsagesV1MetricResponseDataItemDataPointValues))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppMediaStateError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppMediaStateError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppMediaAssetStateState), TypeInfoPropertyName = "AppMediaAssetStateState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ChecksumAlgorithm), TypeInfoPropertyName = "ChecksumAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ChecksumsFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ChecksumsComposite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ChecksumsCompositeAlgorithm), TypeInfoPropertyName = "ChecksumsCompositeAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.HttpHeader>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.HttpHeader))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DiagnosticInsightType), TypeInfoPropertyName = "DiagnosticInsightType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DiagnosticInsightDirection), TypeInfoPropertyName = "DiagnosticInsightDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.DiagnosticInsightReferenceVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DiagnosticInsightReferenceVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MetricCategory), TypeInfoPropertyName = "MetricCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MetricsInsight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.MetricsInsightPopulation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MetricsInsightPopulation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.XcodeMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.XcodeMetricsInsights))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.MetricsInsight>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.XcodeMetricsProductDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.XcodeMetricsProductDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricGoalKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricGoalKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricUnit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricDataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricDataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricDatasetFilterCriteria))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricDatasetPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricDatasetPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricDatasetPointPercentageBreakdown))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricDatasetRecommendedMetricGoal))]
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
    internal sealed partial class BuildsSourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem?), TypeInfoPropertyName = "NullableIncludedItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem2?), TypeInfoPropertyName = "NullableIncludedItem22_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageType?), TypeInfoPropertyName = "NullableAlternativeDistributionPackageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageRelationshipsVersionsDataItemType?), TypeInfoPropertyName = "NullableAlternativeDistributionPackageRelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Platform?), TypeInfoPropertyName = "NullablePlatform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipAction?), TypeInfoPropertyName = "NullableAppClipAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem3?), TypeInfoPropertyName = "NullableIncludedItem32_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem4?), TypeInfoPropertyName = "NullableIncludedItem42_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem5?), TypeInfoPropertyName = "NullableIncludedItem52_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem6?), TypeInfoPropertyName = "NullableIncludedItem62_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceType?), TypeInfoPropertyName = "NullableAppClipDefaultExperienceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDataType?), TypeInfoPropertyName = "NullableAppClipDefaultExperienceRelationshipsAppClipDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionDataType?), TypeInfoPropertyName = "NullableAppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemType?), TypeInfoPropertyName = "NullableAppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataType?), TypeInfoPropertyName = "NullableAppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreReviewDetailType?), TypeInfoPropertyName = "NullableAppStoreReviewDetailType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreReviewDetailRelationshipsAppStoreVersionDataType?), TypeInfoPropertyName = "NullableAppStoreReviewDetailRelationshipsAppStoreVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreReviewDetailRelationshipsAppStoreReviewAttachmentsDataItemType?), TypeInfoPropertyName = "NullableAppStoreReviewDetailRelationshipsAppStoreReviewAttachmentsDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionLocalizationType?), TypeInfoPropertyName = "NullableAppStoreVersionLocalizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppStoreVersionDataType?), TypeInfoPropertyName = "NullableAppStoreVersionLocalizationRelationshipsAppStoreVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItemType?), TypeInfoPropertyName = "NullableAppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItemType?), TypeInfoPropertyName = "NullableAppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItemType?), TypeInfoPropertyName = "NullableAppStoreVersionLocalizationRelationshipsSearchKeywordsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem42?), TypeInfoPropertyName = "NullableIncludedItem422")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem43?), TypeInfoPropertyName = "NullableIncludedItem432")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionPhasedReleaseType?), TypeInfoPropertyName = "NullableAppStoreVersionPhasedReleaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PhasedReleaseState?), TypeInfoPropertyName = "NullablePhasedReleaseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionSubmissionType?), TypeInfoPropertyName = "NullableAppStoreVersionSubmissionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionSubmissionRelationshipsAppStoreVersionDataType?), TypeInfoPropertyName = "NullableAppStoreVersionSubmissionRelationshipsAppStoreVersionDataType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableAppStoreVersionResponseIncludedItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableBuildResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUpdateRequestDataType?), TypeInfoPropertyName = "NullableBuildUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildUpdateRequestDataRelationshipsAppEncryptionDeclarationDataType?), TypeInfoPropertyName = "NullableBuildUpdateRequestDataRelationshipsAppEncryptionDeclarationDataType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DiagnosticSignatureType?), TypeInfoPropertyName = "NullableDiagnosticSignatureType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DiagnosticSignatureAttributesDiagnosticType?), TypeInfoPropertyName = "NullableDiagnosticSignatureAttributesDiagnosticType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionType?), TypeInfoPropertyName = "NullableGameCenterAppVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsCompatibilityVersionsDataItemType?), TypeInfoPropertyName = "NullableGameCenterAppVersionRelationshipsCompatibilityVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsAppStoreVersionDataType?), TypeInfoPropertyName = "NullableGameCenterAppVersionRelationshipsAppStoreVersionDataType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.RoutingAppCoverageType?), TypeInfoPropertyName = "NullableRoutingAppCoverageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.RoutingAppCoverageRelationshipsAppStoreVersionDataType?), TypeInfoPropertyName = "NullableRoutingAppCoverageRelationshipsAppStoreVersionDataType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>?), TypeInfoPropertyName = "NullableOneOfErrorSourcePointerErrorSourceParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<string, global::AppStoreConnect.ErrorLinksAssociated>?), TypeInfoPropertyName = "NullableOneOfStringErrorLinksAssociated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppMediaAssetStateState?), TypeInfoPropertyName = "NullableAppMediaAssetStateState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ChecksumAlgorithm?), TypeInfoPropertyName = "NullableChecksumAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ChecksumsCompositeAlgorithm?), TypeInfoPropertyName = "NullableChecksumsCompositeAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DiagnosticInsightType?), TypeInfoPropertyName = "NullableDiagnosticInsightType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DiagnosticInsightDirection?), TypeInfoPropertyName = "NullableDiagnosticInsightDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MetricCategory?), TypeInfoPropertyName = "NullableMetricCategory2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AlternativeDistributionPackageRelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.UploadOperation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEncryptionDeclarationRelationshipsBuildsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreReviewDetailRelationshipsAppStoreReviewAttachmentsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem45>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaBuildLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaGroupRelationshipsBuildsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaGroupRelationshipsBetaTestersDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaTesterAttributesAppDevice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaTesterRelationshipsAppsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaTesterRelationshipsBetaGroupsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaTesterRelationshipsBuildsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaTester>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildBundleRelationshipsBetaAppClipInvocationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildBundleRelationshipsBuildBundleFileSizesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildIcon>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsIconsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem62>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem63>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.DiagnosticSignature>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAppVersionRelationshipsCompatibilityVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.PrereleaseVersionRelationshipsBuildsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildBetaBuildLocalizationsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildBetaGroupsLinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildDiagnosticSignaturesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildIconsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildIndividualTestersLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildIndividualTestersLinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaBuildUsagesV1MetricResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaBuildUsagesV1MetricResponseDataItemDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ErrorResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppMediaStateError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.HttpHeader>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.DiagnosticInsightReferenceVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.MetricsInsightPopulation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.MetricsInsight>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.XcodeMetricsProductDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricGoalKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricDataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.XcodeMetricsProductDataItemMetricCategorieMetricDatasetPoint>))]
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
    internal sealed partial class BuildsSourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    internal sealed partial class BuildsSourceGenerationContextChunk3 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BuildsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


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
                    typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageType)

                    || typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageRelationshipsVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageRelationshipsVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsBuildsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsBuildsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreReviewDetailType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreReviewDetailType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreReviewDetailRelationshipsAppStoreVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreReviewDetailRelationshipsAppStoreVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreReviewDetailRelationshipsAppStoreReviewAttachmentsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreReviewDetailRelationshipsAppStoreReviewAttachmentsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppStoreVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppStoreVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionPhasedReleaseType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionPhasedReleaseType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionSubmissionType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionSubmissionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionSubmissionRelationshipsAppStoreVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionSubmissionRelationshipsAppStoreVersionDataType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionResponseIncludedItemDiscriminatorType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.BuildResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUpdateRequestDataRelationshipsAppEncryptionDeclarationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUpdateRequestDataRelationshipsAppEncryptionDeclarationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.DiagnosticSignatureType)

                    || typeToConvert == typeof(global::AppStoreConnect.DiagnosticSignatureType?)

                    || typeToConvert == typeof(global::AppStoreConnect.DiagnosticSignatureAttributesDiagnosticType)

                    || typeToConvert == typeof(global::AppStoreConnect.DiagnosticSignatureAttributesDiagnosticType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAppVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAppVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsCompatibilityVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsCompatibilityVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsAppStoreVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsAppStoreVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsBuildsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsBuildsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.RoutingAppCoverageType)

                    || typeToConvert == typeof(global::AppStoreConnect.RoutingAppCoverageType?)

                    || typeToConvert == typeof(global::AppStoreConnect.RoutingAppCoverageRelationshipsAppStoreVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.RoutingAppCoverageRelationshipsAppStoreVersionDataType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAction)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAction?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.ChecksumAlgorithm)

                    || typeToConvert == typeof(global::AppStoreConnect.ChecksumAlgorithm?)

                    || typeToConvert == typeof(global::AppStoreConnect.ChecksumsCompositeAlgorithm)

                    || typeToConvert == typeof(global::AppStoreConnect.ChecksumsCompositeAlgorithm?)

                    || typeToConvert == typeof(global::AppStoreConnect.DiagnosticInsightDirection)

                    || typeToConvert == typeof(global::AppStoreConnect.DiagnosticInsightDirection?)

                    || typeToConvert == typeof(global::AppStoreConnect.DiagnosticInsightType)

                    || typeToConvert == typeof(global::AppStoreConnect.DiagnosticInsightType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ExternalBetaState)

                    || typeToConvert == typeof(global::AppStoreConnect.ExternalBetaState?)

                    || typeToConvert == typeof(global::AppStoreConnect.IconAssetType)

                    || typeToConvert == typeof(global::AppStoreConnect.IconAssetType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InternalBetaState)

                    || typeToConvert == typeof(global::AppStoreConnect.InternalBetaState?)

                    || typeToConvert == typeof(global::AppStoreConnect.MetricCategory)

                    || typeToConvert == typeof(global::AppStoreConnect.MetricCategory?)

                    || typeToConvert == typeof(global::AppStoreConnect.PhasedReleaseState)

                    || typeToConvert == typeof(global::AppStoreConnect.PhasedReleaseState?)

                    || typeToConvert == typeof(global::AppStoreConnect.Platform)

                    || typeToConvert == typeof(global::AppStoreConnect.Platform?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion?)

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
                if (typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageType))
                {
                    return new global::AppStoreConnect.JsonConverters.AlternativeDistributionPackageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AlternativeDistributionPackageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageRelationshipsVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AlternativeDistributionPackageRelationshipsVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageRelationshipsVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AlternativeDistributionPackageRelationshipsVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceRelationshipsAppClipDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceRelationshipsAppClipDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataTypeNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreReviewDetailType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreReviewDetailTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreReviewDetailType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreReviewDetailTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreReviewDetailRelationshipsAppStoreVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreReviewDetailRelationshipsAppStoreVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreReviewDetailRelationshipsAppStoreVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreReviewDetailRelationshipsAppStoreVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreReviewDetailRelationshipsAppStoreReviewAttachmentsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreReviewDetailRelationshipsAppStoreReviewAttachmentsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreReviewDetailRelationshipsAppStoreReviewAttachmentsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreReviewDetailRelationshipsAppStoreReviewAttachmentsDataItemTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppStoreVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationRelationshipsAppStoreVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppStoreVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationRelationshipsAppStoreVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionPhasedReleaseType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionPhasedReleaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionPhasedReleaseType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionPhasedReleaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionSubmissionType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionSubmissionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionSubmissionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionSubmissionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionSubmissionRelationshipsAppStoreVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionSubmissionRelationshipsAppStoreVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionSubmissionRelationshipsAppStoreVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionSubmissionRelationshipsAppStoreVersionDataTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.BuildResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::AppStoreConnect.RoutingAppCoverageType))
                {
                    return new global::AppStoreConnect.JsonConverters.RoutingAppCoverageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.RoutingAppCoverageType?))
                {
                    return new global::AppStoreConnect.JsonConverters.RoutingAppCoverageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.RoutingAppCoverageRelationshipsAppStoreVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.RoutingAppCoverageRelationshipsAppStoreVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.RoutingAppCoverageRelationshipsAppStoreVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.RoutingAppCoverageRelationshipsAppStoreVersionDataTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAction))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipActionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAction?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaAssetStateStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaAssetStateStateNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.ChecksumAlgorithm))
                {
                    return new global::AppStoreConnect.JsonConverters.ChecksumAlgorithmJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ChecksumAlgorithm?))
                {
                    return new global::AppStoreConnect.JsonConverters.ChecksumAlgorithmNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ChecksumsCompositeAlgorithm))
                {
                    return new global::AppStoreConnect.JsonConverters.ChecksumsCompositeAlgorithmJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ChecksumsCompositeAlgorithm?))
                {
                    return new global::AppStoreConnect.JsonConverters.ChecksumsCompositeAlgorithmNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DiagnosticInsightDirection))
                {
                    return new global::AppStoreConnect.JsonConverters.DiagnosticInsightDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DiagnosticInsightDirection?))
                {
                    return new global::AppStoreConnect.JsonConverters.DiagnosticInsightDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DiagnosticInsightType))
                {
                    return new global::AppStoreConnect.JsonConverters.DiagnosticInsightTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DiagnosticInsightType?))
                {
                    return new global::AppStoreConnect.JsonConverters.DiagnosticInsightTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.MetricCategory))
                {
                    return new global::AppStoreConnect.JsonConverters.MetricCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MetricCategory?))
                {
                    return new global::AppStoreConnect.JsonConverters.MetricCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PhasedReleaseState))
                {
                    return new global::AppStoreConnect.JsonConverters.PhasedReleaseStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PhasedReleaseState?))
                {
                    return new global::AppStoreConnect.JsonConverters.PhasedReleaseStateNullableJsonConverter();
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
                    0 => new BuildsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new BuildsSourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),

                    2 => new BuildsSourceGenerationContextChunk2(new global::System.Text.Json.JsonSerializerOptions()),

                    3 => new BuildsSourceGenerationContextChunk3(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}