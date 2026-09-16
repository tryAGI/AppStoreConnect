
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionType), TypeInfoPropertyName = "AlternativeDistributionPackageVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionAttributesState), TypeInfoPropertyName = "AlternativeDistributionPackageVersionAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsVariants))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.RelationshipLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsVariantsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsVariantsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsVariantsDataItemType), TypeInfoPropertyName = "AlternativeDistributionPackageVersionRelationshipsVariantsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsDeltas))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsDeltasDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsDeltasDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsDeltasDataItemType), TypeInfoPropertyName = "AlternativeDistributionPackageVersionRelationshipsDeltasDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackageDataType), TypeInfoPropertyName = "AlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackageVersion>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem3), TypeInfoPropertyName = "IncludedItem32_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClip))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem4), TypeInfoPropertyName = "IncludedItem42_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipAppStoreReviewDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailType), TypeInfoPropertyName = "AppClipAppStoreReviewDetailType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperience))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperienceData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperienceDataType), TypeInfoPropertyName = "AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperienceDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperience))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationType), TypeInfoPropertyName = "AppClipDefaultExperienceLocalizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperience))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperienceData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperienceDataType), TypeInfoPropertyName = "AppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperienceDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImageDataType), TypeInfoPropertyName = "AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImageDataType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem8>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem8), TypeInfoPropertyName = "IncludedItem82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "AppClipDefaultExperienceResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipType), TypeInfoPropertyName = "AppClipType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipRelationshipsApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipRelationshipsAppData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipRelationshipsAppDataType), TypeInfoPropertyName = "AppClipRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiences))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiencesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiencesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiencesDataItemType), TypeInfoPropertyName = "AppClipRelationshipsAppClipDefaultExperiencesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipRelationshipsAppClipAdvancedExperiences))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppKeywordType), TypeInfoPropertyName = "AppKeywordType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetType), TypeInfoPropertyName = "AppPreviewSetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PreviewType), TypeInfoPropertyName = "PreviewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionLocalizationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionLocalizationDataType), TypeInfoPropertyName = "AppPreviewSetRelationshipsAppStoreVersionLocalizationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppCustomProductPageLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppCustomProductPageLocalizationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppCustomProductPageLocalizationDataType), TypeInfoPropertyName = "AppPreviewSetRelationshipsAppCustomProductPageLocalizationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType), TypeInfoPropertyName = "AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppPreviews))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetRelationshipsAppPreviewsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppPreviewsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppPreviewsDataItemType), TypeInfoPropertyName = "AppPreviewSetRelationshipsAppPreviewsDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotSetType), TypeInfoPropertyName = "AppScreenshotSetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotSetAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScreenshotDisplayType), TypeInfoPropertyName = "ScreenshotDisplayType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotSetRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionLocalizationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionLocalizationDataType), TypeInfoPropertyName = "AppScreenshotSetRelationshipsAppStoreVersionLocalizationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppCustomProductPageLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppCustomProductPageLocalizationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppCustomProductPageLocalizationDataType), TypeInfoPropertyName = "AppScreenshotSetRelationshipsAppCustomProductPageLocalizationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType), TypeInfoPropertyName = "AppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppScreenshots))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppScreenshotSetRelationshipsAppScreenshotsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppScreenshotsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppScreenshotsDataItemType), TypeInfoPropertyName = "AppScreenshotSetRelationshipsAppScreenshotsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem31), TypeInfoPropertyName = "IncludedItem312")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem32), TypeInfoPropertyName = "IncludedItem322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreReviewAttachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreReviewAttachmentType), TypeInfoPropertyName = "AppStoreReviewAttachmentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreReviewAttachmentAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreReviewAttachmentRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreReviewAttachmentRelationshipsAppStoreReviewDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreReviewAttachmentRelationshipsAppStoreReviewDetailData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreReviewAttachmentRelationshipsAppStoreReviewDetailDataType), TypeInfoPropertyName = "AppStoreReviewAttachmentRelationshipsAppStoreReviewDetailDataType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreReviewDetailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem33>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem33), TypeInfoPropertyName = "IncludedItem332")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreReviewDetailResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreReviewDetailResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "AppStoreReviewDetailResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem34), TypeInfoPropertyName = "IncludedItem342")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem35), TypeInfoPropertyName = "IncludedItem352")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentType), TypeInfoPropertyName = "AppStoreVersionExperimentTreatmentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentDataType), TypeInfoPropertyName = "AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2DataType), TypeInfoPropertyName = "AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItemType), TypeInfoPropertyName = "AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem36), TypeInfoPropertyName = "IncludedItem362")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem37), TypeInfoPropertyName = "IncludedItem372")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2Type), TypeInfoPropertyName = "AppStoreVersionExperimentV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2Attributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2AttributesState), TypeInfoPropertyName = "AppStoreVersionExperimentV2AttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2Relationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppDataType), TypeInfoPropertyName = "AppStoreVersionExperimentV2RelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsLatestControlVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsLatestControlVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsLatestControlVersionDataType), TypeInfoPropertyName = "AppStoreVersionExperimentV2RelationshipsLatestControlVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsControlVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsControlVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsControlVersionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsControlVersionsDataItemType), TypeInfoPropertyName = "AppStoreVersionExperimentV2RelationshipsControlVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatments))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItemType), TypeInfoPropertyName = "AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentsV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem38>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem38), TypeInfoPropertyName = "IncludedItem382")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentsV2ResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentsV2ResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "AppStoreVersionExperimentsV2ResponseIncludedItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem40>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem40), TypeInfoPropertyName = "IncludedItem402")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentsResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentsResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "AppStoreVersionExperimentsResponseIncludedItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionLocalizationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem42>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem42), TypeInfoPropertyName = "IncludedItem422")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionLocalizationsResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionLocalizationsResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "AppStoreVersionLocalizationsResponseIncludedItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionSubmissionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersion>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionCreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataType), TypeInfoPropertyName = "AppStoreVersionCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataAttributesReviewType), TypeInfoPropertyName = "AppStoreVersionCreateRequestDataAttributesReviewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataAttributesReleaseType), TypeInfoPropertyName = "AppStoreVersionCreateRequestDataAttributesReleaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationshipsApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationshipsAppData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationshipsAppDataType), TypeInfoPropertyName = "AppStoreVersionCreateRequestDataRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationshipsAppStoreVersionLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationshipsAppStoreVersionLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationshipsAppStoreVersionLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationshipsAppStoreVersionLocalizationsDataItemType), TypeInfoPropertyName = "AppStoreVersionCreateRequestDataRelationshipsAppStoreVersionLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationshipsBuild))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationshipsBuildData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationshipsBuildDataType), TypeInfoPropertyName = "AppStoreVersionCreateRequestDataRelationshipsBuildDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataType), TypeInfoPropertyName = "AppStoreVersionUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataAttributesReviewType), TypeInfoPropertyName = "AppStoreVersionUpdateRequestDataAttributesReviewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataAttributesReleaseType), TypeInfoPropertyName = "AppStoreVersionUpdateRequestDataAttributesReleaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataRelationshipsBuild))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataRelationshipsBuildData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataRelationshipsBuildDataType), TypeInfoPropertyName = "AppStoreVersionUpdateRequestDataRelationshipsBuildDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataRelationshipsAppClipDefaultExperience))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataRelationshipsAppClipDefaultExperienceData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataRelationshipsAppClipDefaultExperienceDataType), TypeInfoPropertyName = "AppStoreVersionUpdateRequestDataRelationshipsAppClipDefaultExperienceDataType2")]
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
    internal sealed partial class AppStoreVersionsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewResponseV1Type), TypeInfoPropertyName = "CustomerReviewResponseV1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewResponseV1Attributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewResponseV1AttributesState), TypeInfoPropertyName = "CustomerReviewResponseV1AttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewResponseV1Relationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewResponseV1RelationshipsReview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewResponseV1RelationshipsReviewData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewResponseV1RelationshipsReviewDataType), TypeInfoPropertyName = "CustomerReviewResponseV1RelationshipsReviewDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CustomerReview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewType), TypeInfoPropertyName = "CustomerReviewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.TerritoryCode), TypeInfoPropertyName = "TerritoryCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewRelationshipsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewRelationshipsResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewRelationshipsResponseDataType), TypeInfoPropertyName = "CustomerReviewRelationshipsResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewRelationshipsReviewTerritory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewRelationshipsReviewTerritoryData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewRelationshipsReviewTerritoryDataType), TypeInfoPropertyName = "CustomerReviewRelationshipsReviewTerritoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem72>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem72), TypeInfoPropertyName = "IncludedItem722")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewsResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewsResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "CustomerReviewsResponseIncludedItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem94>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem94), TypeInfoPropertyName = "IncludedItem942")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterAppVersionResponseIncludedItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.RoutingAppCoverageResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.TerritoryType), TypeInfoPropertyName = "TerritoryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.TerritoryAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem179), TypeInfoPropertyName = "IncludedItem1792")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAlternativeDistributionPackageLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAlternativeDistributionPackageLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAlternativeDistributionPackageLinkageResponseDataType), TypeInfoPropertyName = "AppStoreVersionAlternativeDistributionPackageLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAppClipDefaultExperienceLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAppClipDefaultExperienceLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAppClipDefaultExperienceLinkageResponseDataType), TypeInfoPropertyName = "AppStoreVersionAppClipDefaultExperienceLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAppClipDefaultExperienceLinkageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAppClipDefaultExperienceLinkageRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAppClipDefaultExperienceLinkageRequestDataType), TypeInfoPropertyName = "AppStoreVersionAppClipDefaultExperienceLinkageRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAppStoreReviewDetailLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAppStoreReviewDetailLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAppStoreReviewDetailLinkageResponseDataType), TypeInfoPropertyName = "AppStoreVersionAppStoreReviewDetailLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionExperimentsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionAppStoreVersionExperimentsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionExperimentsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionExperimentsLinkagesResponseDataItemType), TypeInfoPropertyName = "AppStoreVersionAppStoreVersionExperimentsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionExperimentsV2LinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionAppStoreVersionExperimentsV2LinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionExperimentsV2LinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionExperimentsV2LinkagesResponseDataItemType), TypeInfoPropertyName = "AppStoreVersionAppStoreVersionExperimentsV2LinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionLocalizationsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionAppStoreVersionLocalizationsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionLocalizationsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionLocalizationsLinkagesResponseDataItemType), TypeInfoPropertyName = "AppStoreVersionAppStoreVersionLocalizationsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionPhasedReleaseWithoutIncludesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionPhasedReleaseLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionPhasedReleaseLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionPhasedReleaseLinkageResponseDataType), TypeInfoPropertyName = "AppStoreVersionAppStoreVersionPhasedReleaseLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionSubmissionLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionSubmissionLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionSubmissionLinkageResponseDataType), TypeInfoPropertyName = "AppStoreVersionAppStoreVersionSubmissionLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildWithoutIncludesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionBuildLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionBuildLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionBuildLinkageResponseDataType), TypeInfoPropertyName = "AppStoreVersionBuildLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionBuildLinkageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionBuildLinkageRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionBuildLinkageRequestDataType), TypeInfoPropertyName = "AppStoreVersionBuildLinkageRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionCustomerReviewsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionCustomerReviewsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionCustomerReviewsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionCustomerReviewsLinkagesResponseDataItemType), TypeInfoPropertyName = "AppStoreVersionCustomerReviewsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionGameCenterAppVersionLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionGameCenterAppVersionLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionGameCenterAppVersionLinkageResponseDataType), TypeInfoPropertyName = "AppStoreVersionGameCenterAppVersionLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRoutingAppCoverageLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRoutingAppCoverageLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRoutingAppCoverageLinkageResponseDataType), TypeInfoPropertyName = "AppStoreVersionRoutingAppCoverageLinkageResponseDataType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersion), TypeInfoPropertyName = "AppStoreVersionsGetInstanceFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsApp), TypeInfoPropertyName = "AppStoreVersionsGetInstanceFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization), TypeInfoPropertyName = "AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsBuild), TypeInfoPropertyName = "AppStoreVersionsGetInstanceFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedRelease), TypeInfoPropertyName = "AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsGameCenterAppVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsGameCenterAppVersion), TypeInfoPropertyName = "AppStoreVersionsGetInstanceFieldsGameCenterAppVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsRoutingAppCoverage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsRoutingAppCoverage), TypeInfoPropertyName = "AppStoreVersionsGetInstanceFieldsRoutingAppCoverage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail), TypeInfoPropertyName = "AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionSubmission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionSubmission), TypeInfoPropertyName = "AppStoreVersionsGetInstanceFieldsAppStoreVersionSubmission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppClipDefaultExperience>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppClipDefaultExperience), TypeInfoPropertyName = "AppStoreVersionsGetInstanceFieldsAppClipDefaultExperience2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment), TypeInfoPropertyName = "AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAlternativeDistributionPackage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAlternativeDistributionPackage), TypeInfoPropertyName = "AppStoreVersionsGetInstanceFieldsAlternativeDistributionPackage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceIncludeItem), TypeInfoPropertyName = "AppStoreVersionsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackage), TypeInfoPropertyName = "AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageVersion), TypeInfoPropertyName = "AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedIncludeItem), TypeInfoPropertyName = "AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperience>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperience), TypeInfoPropertyName = "AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperience2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClip>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClip), TypeInfoPropertyName = "AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClip2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion), TypeInfoPropertyName = "AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperienceLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperienceLocalization), TypeInfoPropertyName = "AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperienceLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipAppStoreReviewDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipAppStoreReviewDetail), TypeInfoPropertyName = "AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipAppStoreReviewDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedIncludeItem), TypeInfoPropertyName = "AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail), TypeInfoPropertyName = "AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion), TypeInfoPropertyName = "AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewAttachment), TypeInfoPropertyName = "AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewAttachment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedIncludeItem), TypeInfoPropertyName = "AppStoreVersionsAppStoreReviewDetailGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItem), TypeInfoPropertyName = "AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperiment), TypeInfoPropertyName = "AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion), TypeInfoPropertyName = "AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment), TypeInfoPropertyName = "AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem), TypeInfoPropertyName = "AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment), TypeInfoPropertyName = "AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsApp), TypeInfoPropertyName = "AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion), TypeInfoPropertyName = "AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment), TypeInfoPropertyName = "AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem), TypeInfoPropertyName = "AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersionLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersionLocalization), TypeInfoPropertyName = "AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersionLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion), TypeInfoPropertyName = "AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppScreenshotSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppScreenshotSet), TypeInfoPropertyName = "AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppScreenshotSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppPreviewSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppPreviewSet), TypeInfoPropertyName = "AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppPreviewSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelatedFieldsAppStoreVersionPhasedRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelatedFieldsAppStoreVersionPhasedRelease), TypeInfoPropertyName = "AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelatedFieldsAppStoreVersionPhasedRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersionSubmission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersionSubmission), TypeInfoPropertyName = "AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersionSubmission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion), TypeInfoPropertyName = "AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedIncludeItem>))]
    internal sealed partial class AppStoreVersionsSourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedIncludeItem), TypeInfoPropertyName = "AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsBuildGetToOneRelatedFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsBuildGetToOneRelatedFieldsBuild), TypeInfoPropertyName = "AppStoreVersionsBuildGetToOneRelatedFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedFilterTerritoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedFilterTerritoryItem), TypeInfoPropertyName = "AppStoreVersionsCustomerReviewsGetToManyRelatedFilterTerritoryItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedSortItem), TypeInfoPropertyName = "AppStoreVersionsCustomerReviewsGetToManyRelatedSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReview), TypeInfoPropertyName = "AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReview2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse), TypeInfoPropertyName = "AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsTerritorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsTerritorie), TypeInfoPropertyName = "AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsTerritorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "AppStoreVersionsCustomerReviewsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsGameCenterAppVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsGameCenterAppVersion), TypeInfoPropertyName = "AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsGameCenterAppVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion), TypeInfoPropertyName = "AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsGameCenterAppVersionGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsGameCenterAppVersionGetToOneRelatedIncludeItem), TypeInfoPropertyName = "AppStoreVersionsGameCenterAppVersionGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsRoutingAppCoverage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsRoutingAppCoverage), TypeInfoPropertyName = "AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsRoutingAppCoverage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion), TypeInfoPropertyName = "AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsRoutingAppCoverageGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsRoutingAppCoverageGetToOneRelatedIncludeItem), TypeInfoPropertyName = "AppStoreVersionsRoutingAppCoverageGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionType?), TypeInfoPropertyName = "NullableAlternativeDistributionPackageVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionAttributesState?), TypeInfoPropertyName = "NullableAlternativeDistributionPackageVersionAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsVariantsDataItemType?), TypeInfoPropertyName = "NullableAlternativeDistributionPackageVersionRelationshipsVariantsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsDeltasDataItemType?), TypeInfoPropertyName = "NullableAlternativeDistributionPackageVersionRelationshipsDeltasDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackageDataType?), TypeInfoPropertyName = "NullableAlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem?), TypeInfoPropertyName = "NullableIncludedItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem2?), TypeInfoPropertyName = "NullableIncludedItem22_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageType?), TypeInfoPropertyName = "NullableAlternativeDistributionPackageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageRelationshipsVersionsDataItemType?), TypeInfoPropertyName = "NullableAlternativeDistributionPackageRelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Platform?), TypeInfoPropertyName = "NullablePlatform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipAction?), TypeInfoPropertyName = "NullableAppClipAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem3?), TypeInfoPropertyName = "NullableIncludedItem32_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem4?), TypeInfoPropertyName = "NullableIncludedItem42_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailType?), TypeInfoPropertyName = "NullableAppClipAppStoreReviewDetailType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperienceDataType?), TypeInfoPropertyName = "NullableAppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperienceDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationType?), TypeInfoPropertyName = "NullableAppClipDefaultExperienceLocalizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperienceDataType?), TypeInfoPropertyName = "NullableAppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperienceDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImageDataType?), TypeInfoPropertyName = "NullableAppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem5?), TypeInfoPropertyName = "NullableIncludedItem52_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem6?), TypeInfoPropertyName = "NullableIncludedItem62_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceType?), TypeInfoPropertyName = "NullableAppClipDefaultExperienceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDataType?), TypeInfoPropertyName = "NullableAppClipDefaultExperienceRelationshipsAppClipDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionDataType?), TypeInfoPropertyName = "NullableAppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemType?), TypeInfoPropertyName = "NullableAppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataType?), TypeInfoPropertyName = "NullableAppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem7?), TypeInfoPropertyName = "NullableIncludedItem72_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem8?), TypeInfoPropertyName = "NullableIncludedItem82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDefaultExperienceResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableAppClipDefaultExperienceResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipType?), TypeInfoPropertyName = "NullableAppClipType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipRelationshipsAppDataType?), TypeInfoPropertyName = "NullableAppClipRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiencesDataItemType?), TypeInfoPropertyName = "NullableAppClipRelationshipsAppClipDefaultExperiencesDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppKeywordType?), TypeInfoPropertyName = "NullableAppKeywordType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetType?), TypeInfoPropertyName = "NullableAppPreviewSetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PreviewType?), TypeInfoPropertyName = "NullablePreviewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionLocalizationDataType?), TypeInfoPropertyName = "NullableAppPreviewSetRelationshipsAppStoreVersionLocalizationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppCustomProductPageLocalizationDataType?), TypeInfoPropertyName = "NullableAppPreviewSetRelationshipsAppCustomProductPageLocalizationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType?), TypeInfoPropertyName = "NullableAppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppPreviewsDataItemType?), TypeInfoPropertyName = "NullableAppPreviewSetRelationshipsAppPreviewsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem24?), TypeInfoPropertyName = "NullableIncludedItem242")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem25?), TypeInfoPropertyName = "NullableIncludedItem252")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem26?), TypeInfoPropertyName = "NullableIncludedItem262")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem27?), TypeInfoPropertyName = "NullableIncludedItem272")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem28?), TypeInfoPropertyName = "NullableIncludedItem282")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem30?), TypeInfoPropertyName = "NullableIncludedItem302")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotSetType?), TypeInfoPropertyName = "NullableAppScreenshotSetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScreenshotDisplayType?), TypeInfoPropertyName = "NullableScreenshotDisplayType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionLocalizationDataType?), TypeInfoPropertyName = "NullableAppScreenshotSetRelationshipsAppStoreVersionLocalizationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppCustomProductPageLocalizationDataType?), TypeInfoPropertyName = "NullableAppScreenshotSetRelationshipsAppCustomProductPageLocalizationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType?), TypeInfoPropertyName = "NullableAppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppScreenshotsDataItemType?), TypeInfoPropertyName = "NullableAppScreenshotSetRelationshipsAppScreenshotsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem31?), TypeInfoPropertyName = "NullableIncludedItem312")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem32?), TypeInfoPropertyName = "NullableIncludedItem322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreReviewAttachmentType?), TypeInfoPropertyName = "NullableAppStoreReviewAttachmentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreReviewAttachmentRelationshipsAppStoreReviewDetailDataType?), TypeInfoPropertyName = "NullableAppStoreReviewAttachmentRelationshipsAppStoreReviewDetailDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreReviewDetailType?), TypeInfoPropertyName = "NullableAppStoreReviewDetailType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreReviewDetailRelationshipsAppStoreVersionDataType?), TypeInfoPropertyName = "NullableAppStoreReviewDetailRelationshipsAppStoreVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreReviewDetailRelationshipsAppStoreReviewAttachmentsDataItemType?), TypeInfoPropertyName = "NullableAppStoreReviewDetailRelationshipsAppStoreReviewAttachmentsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem33?), TypeInfoPropertyName = "NullableIncludedItem332")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreReviewDetailResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableAppStoreReviewDetailResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem34?), TypeInfoPropertyName = "NullableIncludedItem342")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem35?), TypeInfoPropertyName = "NullableIncludedItem352")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentType?), TypeInfoPropertyName = "NullableAppStoreVersionExperimentTreatmentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentDataType?), TypeInfoPropertyName = "NullableAppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2DataType?), TypeInfoPropertyName = "NullableAppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItemType?), TypeInfoPropertyName = "NullableAppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem36?), TypeInfoPropertyName = "NullableIncludedItem362")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem37?), TypeInfoPropertyName = "NullableIncludedItem372")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2Type?), TypeInfoPropertyName = "NullableAppStoreVersionExperimentV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2AttributesState?), TypeInfoPropertyName = "NullableAppStoreVersionExperimentV2AttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppDataType?), TypeInfoPropertyName = "NullableAppStoreVersionExperimentV2RelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsLatestControlVersionDataType?), TypeInfoPropertyName = "NullableAppStoreVersionExperimentV2RelationshipsLatestControlVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsControlVersionsDataItemType?), TypeInfoPropertyName = "NullableAppStoreVersionExperimentV2RelationshipsControlVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItemType?), TypeInfoPropertyName = "NullableAppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem38?), TypeInfoPropertyName = "NullableIncludedItem382")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentsV2ResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableAppStoreVersionExperimentsV2ResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem39?), TypeInfoPropertyName = "NullableIncludedItem392")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentType?), TypeInfoPropertyName = "NullableAppStoreVersionExperimentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentAttributesState?), TypeInfoPropertyName = "NullableAppStoreVersionExperimentAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionDataType?), TypeInfoPropertyName = "NullableAppStoreVersionExperimentRelationshipsAppStoreVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItemType?), TypeInfoPropertyName = "NullableAppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem40?), TypeInfoPropertyName = "NullableIncludedItem402")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentsResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableAppStoreVersionExperimentsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem41?), TypeInfoPropertyName = "NullableIncludedItem412")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionLocalizationType?), TypeInfoPropertyName = "NullableAppStoreVersionLocalizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppStoreVersionDataType?), TypeInfoPropertyName = "NullableAppStoreVersionLocalizationRelationshipsAppStoreVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItemType?), TypeInfoPropertyName = "NullableAppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItemType?), TypeInfoPropertyName = "NullableAppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItemType?), TypeInfoPropertyName = "NullableAppStoreVersionLocalizationRelationshipsSearchKeywordsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem42?), TypeInfoPropertyName = "NullableIncludedItem422")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionLocalizationsResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableAppStoreVersionLocalizationsResponseIncludedItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataType?), TypeInfoPropertyName = "NullableAppStoreVersionCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataAttributesReviewType?), TypeInfoPropertyName = "NullableAppStoreVersionCreateRequestDataAttributesReviewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataAttributesReleaseType?), TypeInfoPropertyName = "NullableAppStoreVersionCreateRequestDataAttributesReleaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationshipsAppDataType?), TypeInfoPropertyName = "NullableAppStoreVersionCreateRequestDataRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationshipsAppStoreVersionLocalizationsDataItemType?), TypeInfoPropertyName = "NullableAppStoreVersionCreateRequestDataRelationshipsAppStoreVersionLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationshipsBuildDataType?), TypeInfoPropertyName = "NullableAppStoreVersionCreateRequestDataRelationshipsBuildDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataType?), TypeInfoPropertyName = "NullableAppStoreVersionUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataAttributesReviewType?), TypeInfoPropertyName = "NullableAppStoreVersionUpdateRequestDataAttributesReviewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataAttributesReleaseType?), TypeInfoPropertyName = "NullableAppStoreVersionUpdateRequestDataAttributesReleaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataRelationshipsBuildDataType?), TypeInfoPropertyName = "NullableAppStoreVersionUpdateRequestDataRelationshipsBuildDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataRelationshipsAppClipDefaultExperienceDataType?), TypeInfoPropertyName = "NullableAppStoreVersionUpdateRequestDataRelationshipsAppClipDefaultExperienceDataType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem63?), TypeInfoPropertyName = "NullableIncludedItem632")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem64?), TypeInfoPropertyName = "NullableIncludedItem642")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem65?), TypeInfoPropertyName = "NullableIncludedItem652")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem66?), TypeInfoPropertyName = "NullableIncludedItem662")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem67?), TypeInfoPropertyName = "NullableIncludedItem672")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem68?), TypeInfoPropertyName = "NullableIncludedItem682")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem69?), TypeInfoPropertyName = "NullableIncludedItem692")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem70?), TypeInfoPropertyName = "NullableIncludedItem702")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem71?), TypeInfoPropertyName = "NullableIncludedItem712")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewResponseV1Type?), TypeInfoPropertyName = "NullableCustomerReviewResponseV1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewResponseV1AttributesState?), TypeInfoPropertyName = "NullableCustomerReviewResponseV1AttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewResponseV1RelationshipsReviewDataType?), TypeInfoPropertyName = "NullableCustomerReviewResponseV1RelationshipsReviewDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewType?), TypeInfoPropertyName = "NullableCustomerReviewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.TerritoryCode?), TypeInfoPropertyName = "NullableTerritoryCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewRelationshipsResponseDataType?), TypeInfoPropertyName = "NullableCustomerReviewRelationshipsResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewRelationshipsReviewTerritoryDataType?), TypeInfoPropertyName = "NullableCustomerReviewRelationshipsReviewTerritoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem72?), TypeInfoPropertyName = "NullableIncludedItem722")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewsResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableCustomerReviewsResponseIncludedItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionType?), TypeInfoPropertyName = "NullableGameCenterAppVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsCompatibilityVersionsDataItemType?), TypeInfoPropertyName = "NullableGameCenterAppVersionRelationshipsCompatibilityVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsAppStoreVersionDataType?), TypeInfoPropertyName = "NullableGameCenterAppVersionRelationshipsAppStoreVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem93?), TypeInfoPropertyName = "NullableIncludedItem932")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem94?), TypeInfoPropertyName = "NullableIncludedItem942")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersionResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterAppVersionResponseIncludedItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.TerritoryType?), TypeInfoPropertyName = "NullableTerritoryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem179?), TypeInfoPropertyName = "NullableIncludedItem1792")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAlternativeDistributionPackageLinkageResponseDataType?), TypeInfoPropertyName = "NullableAppStoreVersionAlternativeDistributionPackageLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAppClipDefaultExperienceLinkageResponseDataType?), TypeInfoPropertyName = "NullableAppStoreVersionAppClipDefaultExperienceLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAppClipDefaultExperienceLinkageRequestDataType?), TypeInfoPropertyName = "NullableAppStoreVersionAppClipDefaultExperienceLinkageRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAppStoreReviewDetailLinkageResponseDataType?), TypeInfoPropertyName = "NullableAppStoreVersionAppStoreReviewDetailLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionExperimentsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableAppStoreVersionAppStoreVersionExperimentsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionExperimentsV2LinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableAppStoreVersionAppStoreVersionExperimentsV2LinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionLocalizationsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableAppStoreVersionAppStoreVersionLocalizationsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionPhasedReleaseLinkageResponseDataType?), TypeInfoPropertyName = "NullableAppStoreVersionAppStoreVersionPhasedReleaseLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionSubmissionLinkageResponseDataType?), TypeInfoPropertyName = "NullableAppStoreVersionAppStoreVersionSubmissionLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionBuildLinkageResponseDataType?), TypeInfoPropertyName = "NullableAppStoreVersionBuildLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionBuildLinkageRequestDataType?), TypeInfoPropertyName = "NullableAppStoreVersionBuildLinkageRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionCustomerReviewsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableAppStoreVersionCustomerReviewsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionGameCenterAppVersionLinkageResponseDataType?), TypeInfoPropertyName = "NullableAppStoreVersionGameCenterAppVersionLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionRoutingAppCoverageLinkageResponseDataType?), TypeInfoPropertyName = "NullableAppStoreVersionRoutingAppCoverageLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>?), TypeInfoPropertyName = "NullableOneOfErrorSourcePointerErrorSourceParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<string, global::AppStoreConnect.ErrorLinksAssociated>?), TypeInfoPropertyName = "NullableOneOfStringErrorLinksAssociated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppMediaAssetStateState?), TypeInfoPropertyName = "NullableAppMediaAssetStateState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ChecksumAlgorithm?), TypeInfoPropertyName = "NullableChecksumAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ChecksumsCompositeAlgorithm?), TypeInfoPropertyName = "NullableChecksumsCompositeAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersion?), TypeInfoPropertyName = "NullableAppStoreVersionsGetInstanceFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsApp?), TypeInfoPropertyName = "NullableAppStoreVersionsGetInstanceFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization?), TypeInfoPropertyName = "NullableAppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsBuild?), TypeInfoPropertyName = "NullableAppStoreVersionsGetInstanceFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedRelease?), TypeInfoPropertyName = "NullableAppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsGameCenterAppVersion?), TypeInfoPropertyName = "NullableAppStoreVersionsGetInstanceFieldsGameCenterAppVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsRoutingAppCoverage?), TypeInfoPropertyName = "NullableAppStoreVersionsGetInstanceFieldsRoutingAppCoverage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail?), TypeInfoPropertyName = "NullableAppStoreVersionsGetInstanceFieldsAppStoreReviewDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionSubmission?), TypeInfoPropertyName = "NullableAppStoreVersionsGetInstanceFieldsAppStoreVersionSubmission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppClipDefaultExperience?), TypeInfoPropertyName = "NullableAppStoreVersionsGetInstanceFieldsAppClipDefaultExperience2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment?), TypeInfoPropertyName = "NullableAppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAlternativeDistributionPackage?), TypeInfoPropertyName = "NullableAppStoreVersionsGetInstanceFieldsAlternativeDistributionPackage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableAppStoreVersionsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackage?), TypeInfoPropertyName = "NullableAppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageVersion?), TypeInfoPropertyName = "NullableAppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedIncludeItem?), TypeInfoPropertyName = "NullableAppStoreVersionsAlternativeDistributionPackageGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperience?), TypeInfoPropertyName = "NullableAppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperience2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClip?), TypeInfoPropertyName = "NullableAppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClip2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion?), TypeInfoPropertyName = "NullableAppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperienceLocalization?), TypeInfoPropertyName = "NullableAppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperienceLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipAppStoreReviewDetail?), TypeInfoPropertyName = "NullableAppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipAppStoreReviewDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedIncludeItem?), TypeInfoPropertyName = "NullableAppStoreVersionsAppClipDefaultExperienceGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail?), TypeInfoPropertyName = "NullableAppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion?), TypeInfoPropertyName = "NullableAppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewAttachment?), TypeInfoPropertyName = "NullableAppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewAttachment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedIncludeItem?), TypeInfoPropertyName = "NullableAppStoreVersionsAppStoreReviewDetailGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItem?), TypeInfoPropertyName = "NullableAppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperiment?), TypeInfoPropertyName = "NullableAppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion?), TypeInfoPropertyName = "NullableAppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment?), TypeInfoPropertyName = "NullableAppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableAppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem?), TypeInfoPropertyName = "NullableAppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment?), TypeInfoPropertyName = "NullableAppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsApp?), TypeInfoPropertyName = "NullableAppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion?), TypeInfoPropertyName = "NullableAppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment?), TypeInfoPropertyName = "NullableAppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableAppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersionLocalization?), TypeInfoPropertyName = "NullableAppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersionLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion?), TypeInfoPropertyName = "NullableAppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppScreenshotSet?), TypeInfoPropertyName = "NullableAppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppScreenshotSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppPreviewSet?), TypeInfoPropertyName = "NullableAppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppPreviewSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableAppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelatedFieldsAppStoreVersionPhasedRelease?), TypeInfoPropertyName = "NullableAppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelatedFieldsAppStoreVersionPhasedRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersionSubmission?), TypeInfoPropertyName = "NullableAppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersionSubmission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion?), TypeInfoPropertyName = "NullableAppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedIncludeItem?), TypeInfoPropertyName = "NullableAppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsBuildGetToOneRelatedFieldsBuild?), TypeInfoPropertyName = "NullableAppStoreVersionsBuildGetToOneRelatedFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedFilterTerritoryItem?), TypeInfoPropertyName = "NullableAppStoreVersionsCustomerReviewsGetToManyRelatedFilterTerritoryItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedSortItem?), TypeInfoPropertyName = "NullableAppStoreVersionsCustomerReviewsGetToManyRelatedSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReview?), TypeInfoPropertyName = "NullableAppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReview2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse?), TypeInfoPropertyName = "NullableAppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsTerritorie?), TypeInfoPropertyName = "NullableAppStoreVersionsCustomerReviewsGetToManyRelatedFieldsTerritorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableAppStoreVersionsCustomerReviewsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsGameCenterAppVersion?), TypeInfoPropertyName = "NullableAppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsGameCenterAppVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion?), TypeInfoPropertyName = "NullableAppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsGameCenterAppVersionGetToOneRelatedIncludeItem?), TypeInfoPropertyName = "NullableAppStoreVersionsGameCenterAppVersionGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsRoutingAppCoverage?), TypeInfoPropertyName = "NullableAppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsRoutingAppCoverage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion?), TypeInfoPropertyName = "NullableAppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionsRoutingAppCoverageGetToOneRelatedIncludeItem?), TypeInfoPropertyName = "NullableAppStoreVersionsRoutingAppCoverageGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsVariantsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsDeltasDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AlternativeDistributionPackageVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AlternativeDistributionPackageRelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.UploadOperation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem8>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiencesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPreviewSetRelationshipsAppPreviewsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppScreenshotSetRelationshipsAppScreenshotsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreReviewDetailRelationshipsAppStoreReviewAttachmentsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem33>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsControlVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem38>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem40>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem42>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem45>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationshipsAppStoreVersionLocalizationsDataItem>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsIconsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CustomerReview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem72>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAppVersionRelationshipsCompatibilityVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem94>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionAppStoreVersionExperimentsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionAppStoreVersionExperimentsV2LinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionAppStoreVersionLocalizationsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionCustomerReviewsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ErrorResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppMediaStateError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.HttpHeader>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsGameCenterAppVersion>))]
    internal sealed partial class AppStoreVersionsSourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsRoutingAppCoverage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionSubmission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppClipDefaultExperience>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAlternativeDistributionPackage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperience>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClip>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperienceLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipAppStoreReviewDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersionLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppScreenshotSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppPreviewSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelatedFieldsAppStoreVersionPhasedRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersionSubmission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsBuildGetToOneRelatedFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedFilterTerritoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsTerritorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsGameCenterAppVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsGameCenterAppVersionGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsRoutingAppCoverage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsRoutingAppCoverageGetToOneRelatedIncludeItem>))]
    internal sealed partial class AppStoreVersionsSourceGenerationContextChunk3 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppStoreVersionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AppStoreVersionsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AppStoreVersionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsVariantsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsVariantsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsDeltasDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsDeltasDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageType)

                    || typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageRelationshipsVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageRelationshipsVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperienceDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperienceDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperienceDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperienceDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImageDataType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiencesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiencesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppKeywordType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppKeywordType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppCustomProductPageLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppCustomProductPageLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppPreviewsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppPreviewsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppCustomProductPageLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppCustomProductPageLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppScreenshotsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppScreenshotsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreReviewAttachmentType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreReviewAttachmentType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreReviewAttachmentRelationshipsAppStoreReviewDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreReviewAttachmentRelationshipsAppStoreReviewDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreReviewDetailType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreReviewDetailType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreReviewDetailRelationshipsAppStoreVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreReviewDetailRelationshipsAppStoreVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreReviewDetailRelationshipsAppStoreReviewAttachmentsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreReviewDetailRelationshipsAppStoreReviewAttachmentsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreReviewDetailResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreReviewDetailResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2DataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2DataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2AttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2AttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsLatestControlVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsLatestControlVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsControlVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsControlVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentsV2ResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentsV2ResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentRelationshipsAppStoreVersionExperimentTreatmentsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentsResponseIncludedItemDiscriminatorType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsResponseIncludedItemDiscriminatorType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataAttributesReviewType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataAttributesReviewType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataAttributesReleaseType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataAttributesReleaseType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationshipsAppStoreVersionLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationshipsAppStoreVersionLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationshipsBuildDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationshipsBuildDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataAttributesReviewType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataAttributesReviewType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataAttributesReleaseType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataAttributesReleaseType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataRelationshipsBuildDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataRelationshipsBuildDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataRelationshipsAppClipDefaultExperienceDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataRelationshipsAppClipDefaultExperienceDataType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseV1Type)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseV1Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseV1AttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseV1AttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseV1RelationshipsReviewDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseV1RelationshipsReviewDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewType)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewRelationshipsResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewRelationshipsResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewRelationshipsReviewTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewRelationshipsReviewTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAppVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAppVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsCompatibilityVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsCompatibilityVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsAppStoreVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAppVersionRelationshipsAppStoreVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAppVersionResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAppVersionResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.RoutingAppCoverageType)

                    || typeToConvert == typeof(global::AppStoreConnect.RoutingAppCoverageType?)

                    || typeToConvert == typeof(global::AppStoreConnect.RoutingAppCoverageRelationshipsAppStoreVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.RoutingAppCoverageRelationshipsAppStoreVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryType)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAlternativeDistributionPackageLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAlternativeDistributionPackageLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAppClipDefaultExperienceLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAppClipDefaultExperienceLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAppClipDefaultExperienceLinkageRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAppClipDefaultExperienceLinkageRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAppStoreReviewDetailLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAppStoreReviewDetailLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionExperimentsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionExperimentsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionExperimentsV2LinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionExperimentsV2LinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionLocalizationsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionLocalizationsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionPhasedReleaseLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionPhasedReleaseLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionSubmissionLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionSubmissionLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionBuildLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionBuildLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionBuildLinkageRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionBuildLinkageRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionCustomerReviewsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionCustomerReviewsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionGameCenterAppVersionLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionGameCenterAppVersionLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRoutingAppCoverageLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRoutingAppCoverageLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAction)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAction?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppVersionState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppVersionState?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ChecksumAlgorithm)

                    || typeToConvert == typeof(global::AppStoreConnect.ChecksumAlgorithm?)

                    || typeToConvert == typeof(global::AppStoreConnect.ChecksumsCompositeAlgorithm)

                    || typeToConvert == typeof(global::AppStoreConnect.ChecksumsCompositeAlgorithm?)

                    || typeToConvert == typeof(global::AppStoreConnect.PhasedReleaseState)

                    || typeToConvert == typeof(global::AppStoreConnect.PhasedReleaseState?)

                    || typeToConvert == typeof(global::AppStoreConnect.Platform)

                    || typeToConvert == typeof(global::AppStoreConnect.Platform?)

                    || typeToConvert == typeof(global::AppStoreConnect.PreviewType)

                    || typeToConvert == typeof(global::AppStoreConnect.PreviewType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScreenshotDisplayType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScreenshotDisplayType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryCode)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryCode?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsGameCenterAppVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsGameCenterAppVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsRoutingAppCoverage)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsRoutingAppCoverage?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionSubmission)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionSubmission?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppClipDefaultExperience)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppClipDefaultExperience?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAlternativeDistributionPackage)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAlternativeDistributionPackage?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackage)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackage?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperience)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperience?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClip)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClip?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperienceLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperienceLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipAppStoreReviewDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipAppStoreReviewDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewAttachment)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewAttachment?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperiment)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperiment?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersionLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersionLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppScreenshotSet)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppScreenshotSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppPreviewSet)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppPreviewSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelatedFieldsAppStoreVersionPhasedRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelatedFieldsAppStoreVersionPhasedRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersionSubmission)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersionSubmission?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsBuildGetToOneRelatedFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsBuildGetToOneRelatedFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedFilterTerritoryItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedFilterTerritoryItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReview)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReview?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsTerritorie)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsTerritorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsGameCenterAppVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsGameCenterAppVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGameCenterAppVersionGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGameCenterAppVersionGetToOneRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsRoutingAppCoverage)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsRoutingAppCoverage?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsRoutingAppCoverageGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsRoutingAppCoverageGetToOneRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionType))
                {
                    return new global::AppStoreConnect.JsonConverters.AlternativeDistributionPackageVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AlternativeDistributionPackageVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.AlternativeDistributionPackageVersionAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AlternativeDistributionPackageVersionAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsVariantsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AlternativeDistributionPackageVersionRelationshipsVariantsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsVariantsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AlternativeDistributionPackageVersionRelationshipsVariantsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsDeltasDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AlternativeDistributionPackageVersionRelationshipsDeltasDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsDeltasDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AlternativeDistributionPackageVersionRelationshipsDeltasDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackageDataTypeNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAppStoreReviewDetailTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAppStoreReviewDetailTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperienceDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperienceDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperienceDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperienceDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceLocalizationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceLocalizationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperienceDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperienceDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperienceDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperienceDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImageDataTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiencesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipRelationshipsAppClipDefaultExperiencesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiencesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipRelationshipsAppClipDefaultExperiencesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppKeywordType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppKeywordTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppKeywordType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppKeywordTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionLocalizationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetRelationshipsAppStoreVersionLocalizationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionLocalizationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetRelationshipsAppStoreVersionLocalizationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppCustomProductPageLocalizationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetRelationshipsAppCustomProductPageLocalizationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppCustomProductPageLocalizationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetRelationshipsAppCustomProductPageLocalizationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppPreviewsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetRelationshipsAppPreviewsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppPreviewsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetRelationshipsAppPreviewsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionLocalizationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetRelationshipsAppStoreVersionLocalizationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionLocalizationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetRelationshipsAppStoreVersionLocalizationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppCustomProductPageLocalizationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetRelationshipsAppCustomProductPageLocalizationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppCustomProductPageLocalizationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetRelationshipsAppCustomProductPageLocalizationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppScreenshotsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetRelationshipsAppScreenshotsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppScreenshotsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetRelationshipsAppScreenshotsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreReviewAttachmentType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreReviewAttachmentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreReviewAttachmentType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreReviewAttachmentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreReviewAttachmentRelationshipsAppStoreReviewDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreReviewAttachmentRelationshipsAppStoreReviewDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreReviewAttachmentRelationshipsAppStoreReviewDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreReviewAttachmentRelationshipsAppStoreReviewDetailDataTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreReviewDetailResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreReviewDetailResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreReviewDetailResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreReviewDetailResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2DataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2DataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2AttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentV2AttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2AttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentV2AttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentV2RelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentV2RelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsLatestControlVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentV2RelationshipsLatestControlVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsLatestControlVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentV2RelationshipsLatestControlVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsControlVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentV2RelationshipsControlVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsControlVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentV2RelationshipsControlVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentsV2ResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentsV2ResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentsV2ResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentsV2ResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataAttributesReviewType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionCreateRequestDataAttributesReviewTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataAttributesReviewType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionCreateRequestDataAttributesReviewTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataAttributesReleaseType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionCreateRequestDataAttributesReleaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataAttributesReleaseType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionCreateRequestDataAttributesReleaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionCreateRequestDataRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionCreateRequestDataRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationshipsAppStoreVersionLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionCreateRequestDataRelationshipsAppStoreVersionLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationshipsAppStoreVersionLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionCreateRequestDataRelationshipsAppStoreVersionLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationshipsBuildDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionCreateRequestDataRelationshipsBuildDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationshipsBuildDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionCreateRequestDataRelationshipsBuildDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionUpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataAttributesReviewType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionUpdateRequestDataAttributesReviewTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataAttributesReviewType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionUpdateRequestDataAttributesReviewTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataAttributesReleaseType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionUpdateRequestDataAttributesReleaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataAttributesReleaseType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionUpdateRequestDataAttributesReleaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataRelationshipsBuildDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionUpdateRequestDataRelationshipsBuildDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataRelationshipsBuildDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionUpdateRequestDataRelationshipsBuildDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataRelationshipsAppClipDefaultExperienceDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionUpdateRequestDataRelationshipsAppClipDefaultExperienceDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionUpdateRequestDataRelationshipsAppClipDefaultExperienceDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionUpdateRequestDataRelationshipsAppClipDefaultExperienceDataTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseV1Type))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewResponseV1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseV1Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewResponseV1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseV1AttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewResponseV1AttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseV1AttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewResponseV1AttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseV1RelationshipsReviewDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewResponseV1RelationshipsReviewDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseV1RelationshipsReviewDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewResponseV1RelationshipsReviewDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewType))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewRelationshipsResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewRelationshipsResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewRelationshipsResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewRelationshipsResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewRelationshipsReviewTerritoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewRelationshipsReviewTerritoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewRelationshipsReviewTerritoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewRelationshipsReviewTerritoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAppVersionResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAppVersionResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAppVersionResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAppVersionResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryType))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryType?))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAlternativeDistributionPackageLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionAlternativeDistributionPackageLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAlternativeDistributionPackageLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionAlternativeDistributionPackageLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAppClipDefaultExperienceLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionAppClipDefaultExperienceLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAppClipDefaultExperienceLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionAppClipDefaultExperienceLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAppClipDefaultExperienceLinkageRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionAppClipDefaultExperienceLinkageRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAppClipDefaultExperienceLinkageRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionAppClipDefaultExperienceLinkageRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAppStoreReviewDetailLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionAppStoreReviewDetailLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAppStoreReviewDetailLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionAppStoreReviewDetailLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionExperimentsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionAppStoreVersionExperimentsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionExperimentsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionAppStoreVersionExperimentsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionExperimentsV2LinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionAppStoreVersionExperimentsV2LinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionExperimentsV2LinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionAppStoreVersionExperimentsV2LinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionLocalizationsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionAppStoreVersionLocalizationsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionLocalizationsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionAppStoreVersionLocalizationsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionPhasedReleaseLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionAppStoreVersionPhasedReleaseLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionPhasedReleaseLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionAppStoreVersionPhasedReleaseLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionSubmissionLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionAppStoreVersionSubmissionLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAppStoreVersionSubmissionLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionAppStoreVersionSubmissionLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionBuildLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionBuildLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionBuildLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionBuildLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionBuildLinkageRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionBuildLinkageRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionBuildLinkageRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionBuildLinkageRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionCustomerReviewsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionCustomerReviewsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionCustomerReviewsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionCustomerReviewsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionGameCenterAppVersionLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionGameCenterAppVersionLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionGameCenterAppVersionLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionGameCenterAppVersionLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRoutingAppCoverageLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRoutingAppCoverageLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRoutingAppCoverageLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRoutingAppCoverageLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAction))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipActionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAction?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipActionNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAudienceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAudienceTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.PreviewType))
                {
                    return new global::AppStoreConnect.JsonConverters.PreviewTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PreviewType?))
                {
                    return new global::AppStoreConnect.JsonConverters.PreviewTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScreenshotDisplayType))
                {
                    return new global::AppStoreConnect.JsonConverters.ScreenshotDisplayTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScreenshotDisplayType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScreenshotDisplayTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionStatusUrlVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionStatusUrlVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryCode))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryCode?))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsGameCenterAppVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsGameCenterAppVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsGameCenterAppVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsGameCenterAppVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsRoutingAppCoverage))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsRoutingAppCoverageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsRoutingAppCoverage?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsRoutingAppCoverageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAppStoreReviewDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAppStoreReviewDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionSubmission))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAppStoreVersionSubmissionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionSubmission?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAppStoreVersionSubmissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppClipDefaultExperience))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAppClipDefaultExperienceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppClipDefaultExperience?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAppClipDefaultExperienceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAppStoreVersionExperimentJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAppStoreVersionExperimentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAlternativeDistributionPackage))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAlternativeDistributionPackageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAlternativeDistributionPackage?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAlternativeDistributionPackageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackage))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackage?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedFieldsAlternativeDistributionPackageVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperience))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperienceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperience?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperienceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClip))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClip?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperienceLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperienceLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperienceLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipDefaultExperienceLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipAppStoreReviewDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipAppStoreReviewDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipAppStoreReviewDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppClipAppStoreReviewDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewAttachment))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewAttachmentJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewAttachment?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewAttachmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFilterStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperiment))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperiment?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatmentJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersionLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersionLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersionLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersionLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppScreenshotSet))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppScreenshotSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppScreenshotSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppScreenshotSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppPreviewSet))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppPreviewSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppPreviewSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppPreviewSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelatedFieldsAppStoreVersionPhasedRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelatedFieldsAppStoreVersionPhasedReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelatedFieldsAppStoreVersionPhasedRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelatedFieldsAppStoreVersionPhasedReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersionSubmission))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersionSubmissionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersionSubmission?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersionSubmissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsBuildGetToOneRelatedFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsBuildGetToOneRelatedFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsBuildGetToOneRelatedFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsBuildGetToOneRelatedFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedFilterTerritoryItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsCustomerReviewsGetToManyRelatedFilterTerritoryItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedFilterTerritoryItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsCustomerReviewsGetToManyRelatedFilterTerritoryItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsCustomerReviewsGetToManyRelatedSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsCustomerReviewsGetToManyRelatedSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReview))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReviewJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReview?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReviewNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsTerritorie))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsTerritorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsTerritorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsTerritorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsCustomerReviewsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsCustomerReviewsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsCustomerReviewsGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsGameCenterAppVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsGameCenterAppVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsGameCenterAppVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsGameCenterAppVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGameCenterAppVersionGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGameCenterAppVersionGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGameCenterAppVersionGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGameCenterAppVersionGetToOneRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsRoutingAppCoverage))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsRoutingAppCoverageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsRoutingAppCoverage?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsRoutingAppCoverageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsRoutingAppCoverageGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsRoutingAppCoverageGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsRoutingAppCoverageGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsRoutingAppCoverageGetToOneRelatedIncludeItemNullableJsonConverter();
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
                    0 => new AppStoreVersionsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new AppStoreVersionsSourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),

                    2 => new AppStoreVersionsSourceGenerationContextChunk2(new global::System.Text.Json.JsonSerializerOptions()),

                    3 => new AppStoreVersionsSourceGenerationContextChunk3(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}