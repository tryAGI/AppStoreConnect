
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.KidsAgeBand), TypeInfoPropertyName = "KidsAgeBand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageVariant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.RelationshipLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem), TypeInfoPropertyName = "IncludedItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem2), TypeInfoPropertyName = "IncludedItem22_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AndroidToIosAppMappingDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AndroidToIosAppMappingDetailType), TypeInfoPropertyName = "AndroidToIosAppMappingDetailType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AndroidToIosAppMappingDetailAttributes))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCustomProductPageType), TypeInfoPropertyName = "AppCustomProductPageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCustomProductPageAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCustomProductPageRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppDataType), TypeInfoPropertyName = "AppCustomProductPageRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppCustomProductPageVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemType), TypeInfoPropertyName = "AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoType), TypeInfoPropertyName = "AppInfoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionState), TypeInfoPropertyName = "AppStoreVersionState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoAttributesState), TypeInfoPropertyName = "AppInfoAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreAgeRating), TypeInfoPropertyName = "AppStoreAgeRating2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoAttributesAustraliaAgeRating), TypeInfoPropertyName = "AppInfoAttributesAustraliaAgeRating2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BrazilAgeRating), TypeInfoPropertyName = "BrazilAgeRating2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoAttributesBrazilAgeRatingV2), TypeInfoPropertyName = "AppInfoAttributesBrazilAgeRatingV22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoAttributesFranceAgeRating), TypeInfoPropertyName = "AppInfoAttributesFranceAgeRating2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoAttributesKoreaAgeRating), TypeInfoPropertyName = "AppInfoAttributesKoreaAgeRating2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsAppData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsAppDataType), TypeInfoPropertyName = "AppInfoRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsAgeRatingDeclaration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsAgeRatingDeclarationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsAgeRatingDeclarationDataType), TypeInfoPropertyName = "AppInfoRelationshipsAgeRatingDeclarationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizationsDataItemType), TypeInfoPropertyName = "AppInfoRelationshipsAppInfoLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsPrimaryCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsPrimaryCategoryData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsPrimaryCategoryDataType), TypeInfoPropertyName = "AppInfoRelationshipsPrimaryCategoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryOne))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryOneData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryOneDataType), TypeInfoPropertyName = "AppInfoRelationshipsPrimarySubcategoryOneDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryTwo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryTwoData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryTwoDataType), TypeInfoPropertyName = "AppInfoRelationshipsPrimarySubcategoryTwoDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsSecondaryCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsSecondaryCategoryData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsSecondaryCategoryDataType), TypeInfoPropertyName = "AppInfoRelationshipsSecondaryCategoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryOne))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryOneData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryOneDataType), TypeInfoPropertyName = "AppInfoRelationshipsSecondarySubcategoryOneDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryTwo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryTwoData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryTwoDataType), TypeInfoPropertyName = "AppInfoRelationshipsSecondarySubcategoryTwoDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsTerritoryAgeRatings))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem47>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem47), TypeInfoPropertyName = "IncludedItem472")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "AppResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem50), TypeInfoPropertyName = "IncludedItem502")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem51), TypeInfoPropertyName = "IncludedItem512")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationType), TypeInfoPropertyName = "BetaAppLocalizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationRelationshipsApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationRelationshipsAppData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationRelationshipsAppDataType), TypeInfoPropertyName = "BetaAppLocalizationRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppReviewDetailType), TypeInfoPropertyName = "BetaAppReviewDetailType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppReviewDetailAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppReviewDetailRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppReviewDetailRelationshipsApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppReviewDetailRelationshipsAppData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppReviewDetailRelationshipsAppDataType), TypeInfoPropertyName = "BetaAppReviewDetailRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppReviewSubmission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaBuildLocalization))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaLicenseAgreementType), TypeInfoPropertyName = "BetaLicenseAgreementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaLicenseAgreementAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaLicenseAgreementRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaLicenseAgreementRelationshipsApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaLicenseAgreementRelationshipsAppData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaLicenseAgreementRelationshipsAppDataType), TypeInfoPropertyName = "BetaLicenseAgreementRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem58), TypeInfoPropertyName = "IncludedItem582")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem59), TypeInfoPropertyName = "IncludedItem592")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBetaDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildIconType), TypeInfoPropertyName = "BuildIconType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildIconAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IconAssetType), TypeInfoPropertyName = "IconAssetType2")]
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
    internal sealed partial class CiProductsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BundleIdType), TypeInfoPropertyName = "BundleIdType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BundleIdAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BundleIdPlatform), TypeInfoPropertyName = "BundleIdPlatform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BundleIdRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BundleIdRelationshipsProfiles))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdRelationshipsProfilesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BundleIdRelationshipsProfilesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BundleIdRelationshipsProfilesDataItemType), TypeInfoPropertyName = "BundleIdRelationshipsProfilesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BundleIdRelationshipsBundleIdCapabilities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdRelationshipsBundleIdCapabilitiesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BundleIdRelationshipsBundleIdCapabilitiesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BundleIdRelationshipsBundleIdCapabilitiesDataItemType), TypeInfoPropertyName = "BundleIdRelationshipsBundleIdCapabilitiesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BundleIdRelationshipsApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BundleIdRelationshipsAppData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BundleIdRelationshipsAppDataType), TypeInfoPropertyName = "BundleIdRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem64), TypeInfoPropertyName = "IncludedItem642")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Profile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem65), TypeInfoPropertyName = "IncludedItem652")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Certificate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiActionType), TypeInfoPropertyName = "CiActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiIssueCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiExecutionProgress), TypeInfoPropertyName = "CiExecutionProgress2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiCompletionStatus), TypeInfoPropertyName = "CiCompletionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRun))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem66>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem66), TypeInfoPropertyName = "IncludedItem662")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmGitReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmPullRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "CiBuildRunsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem67), TypeInfoPropertyName = "IncludedItem672")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiMacOsVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiMacOsVersionType), TypeInfoPropertyName = "CiMacOsVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiMacOsVersionAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiMacOsVersionRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersionsDataItemType), TypeInfoPropertyName = "CiMacOsVersionRelationshipsXcodeVersionsDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem68>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem68), TypeInfoPropertyName = "IncludedItem682")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmRepository))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "CiProductsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem69>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem69), TypeInfoPropertyName = "IncludedItem692")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "CiProductResponseIncludedItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem70>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem70), TypeInfoPropertyName = "IncludedItem702")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "CiWorkflowsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem71), TypeInfoPropertyName = "IncludedItem712")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiXcodeVersionType), TypeInfoPropertyName = "CiXcodeVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiXcodeVersionAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiXcodeVersionAttributesTestDestination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiXcodeVersionAttributesTestDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiXcodeVersionAttributesTestDestinationAvailableRuntime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiXcodeVersionAttributesTestDestinationAvailableRuntime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiTestDestinationKind), TypeInfoPropertyName = "CiTestDestinationKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiXcodeVersionRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersionsDataItemType), TypeInfoPropertyName = "CiXcodeVersionRelationshipsMacOsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CustomerReviewResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem72), TypeInfoPropertyName = "IncludedItem722")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem73), TypeInfoPropertyName = "IncludedItem732")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Device))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.EndUserLicenseAgreementType), TypeInfoPropertyName = "EndUserLicenseAgreementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.EndUserLicenseAgreementAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsAppData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsAppDataType), TypeInfoPropertyName = "EndUserLicenseAgreementRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsTerritories))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.EndUserLicenseAgreementRelationshipsTerritoriesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsTerritoriesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsTerritoriesDataItemType), TypeInfoPropertyName = "EndUserLicenseAgreementRelationshipsTerritoriesDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem101), TypeInfoPropertyName = "IncludedItem1012")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterLeaderboardSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem102), TypeInfoPropertyName = "IncludedItem1022")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterEnabledVersionType), TypeInfoPropertyName = "GameCenterEnabledVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterEnabledVersionAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationshipsCompatibleVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterEnabledVersionRelationshipsCompatibleVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationshipsCompatibleVersionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationshipsCompatibleVersionsDataItemType), TypeInfoPropertyName = "GameCenterEnabledVersionRelationshipsCompatibleVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationshipsApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationshipsAppData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationshipsAppDataType), TypeInfoPropertyName = "GameCenterEnabledVersionRelationshipsAppDataType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseType), TypeInfoPropertyName = "InAppPurchaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseAttributesInAppPurchaseType), TypeInfoPropertyName = "InAppPurchaseAttributesInAppPurchaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseAttributesState), TypeInfoPropertyName = "InAppPurchaseAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseRelationshipsApps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseRelationshipsAppsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseRelationshipsAppsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseRelationshipsAppsDataItemType), TypeInfoPropertyName = "InAppPurchaseRelationshipsAppsDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseType), TypeInfoPropertyName = "PromotedPurchaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseAttributesState), TypeInfoPropertyName = "PromotedPurchaseAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataType), TypeInfoPropertyName = "PromotedPurchaseRelationshipsInAppPurchaseV2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscriptionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscriptionDataType), TypeInfoPropertyName = "PromotedPurchaseRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem152), TypeInfoPropertyName = "IncludedItem1522")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Subscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem153), TypeInfoPropertyName = "IncludedItem1532")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem154), TypeInfoPropertyName = "IncludedItem1542")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionVersion))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem156), TypeInfoPropertyName = "IncludedItem1562")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem157), TypeInfoPropertyName = "IncludedItem1572")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmGitReferenceType), TypeInfoPropertyName = "ScmGitReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmGitReferenceAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiGitRefKind), TypeInfoPropertyName = "CiGitRefKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmGitReferenceRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmGitReferenceRelationshipsRepository))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmGitReferenceRelationshipsRepositoryData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmGitReferenceRelationshipsRepositoryDataType), TypeInfoPropertyName = "ScmGitReferenceRelationshipsRepositoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ScmRepository>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmProviderType), TypeInfoPropertyName = "ScmProviderType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmProviderAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmProviderType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmProviderRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmProviderRelationshipsRepositories))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmPullRequestType), TypeInfoPropertyName = "ScmPullRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmPullRequestAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmPullRequestRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmPullRequestRelationshipsRepository))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmPullRequestRelationshipsRepositoryData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmPullRequestRelationshipsRepositoryDataType), TypeInfoPropertyName = "ScmPullRequestRelationshipsRepositoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmRepositoryType), TypeInfoPropertyName = "ScmRepositoryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmRepositoryAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmRepositoryRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmRepositoryRelationshipsScmProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmRepositoryRelationshipsScmProviderData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmRepositoryRelationshipsScmProviderDataType), TypeInfoPropertyName = "ScmRepositoryRelationshipsScmProviderDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmRepositoryRelationshipsDefaultBranch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmRepositoryRelationshipsDefaultBranchData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmRepositoryRelationshipsDefaultBranchDataType), TypeInfoPropertyName = "ScmRepositoryRelationshipsDefaultBranchDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmRepositoryRelationshipsGitReferences))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmRepositoryRelationshipsPullRequests))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmRepositoriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem158>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem158), TypeInfoPropertyName = "IncludedItem1582")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmRepositoriesResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmRepositoriesResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "ScmRepositoriesResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem159), TypeInfoPropertyName = "IncludedItem1592")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionAvailability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGracePeriodType), TypeInfoPropertyName = "SubscriptionGracePeriodType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGracePeriodAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGracePeriodDuration), TypeInfoPropertyName = "SubscriptionGracePeriodDuration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGracePeriodAttributesRenewalType), TypeInfoPropertyName = "SubscriptionGracePeriodAttributesRenewalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupLocalizationV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem160), TypeInfoPropertyName = "IncludedItem1602")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem161), TypeInfoPropertyName = "IncludedItem1612")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupType), TypeInfoPropertyName = "SubscriptionGroupType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionsDataItemType), TypeInfoPropertyName = "SubscriptionGroupRelationshipsSubscriptionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType), TypeInfoPropertyName = "SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupRelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsVersionsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsVersionsDataItemType), TypeInfoPropertyName = "SubscriptionGroupRelationshipsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem162), TypeInfoPropertyName = "IncludedItem1622")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem163), TypeInfoPropertyName = "IncludedItem1632")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionImageV2))]
    internal sealed partial class CiProductsSourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductAdditionalRepositoriesLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductAdditionalRepositoriesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductAdditionalRepositoriesLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductAdditionalRepositoriesLinkagesResponseDataItemType), TypeInfoPropertyName = "CiProductAdditionalRepositoriesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductAppLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductAppLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductAppLinkageResponseDataType), TypeInfoPropertyName = "CiProductAppLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductBuildRunsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductBuildRunsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductBuildRunsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductBuildRunsLinkagesResponseDataItemType), TypeInfoPropertyName = "CiProductBuildRunsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductPrimaryRepositoriesLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductPrimaryRepositoriesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductPrimaryRepositoriesLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductPrimaryRepositoriesLinkagesResponseDataItemType), TypeInfoPropertyName = "CiProductPrimaryRepositoriesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductWorkflowsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductWorkflowsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductWorkflowsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductWorkflowsLinkagesResponseDataItemType), TypeInfoPropertyName = "CiProductWorkflowsLinkagesResponseDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmProviderTypeKind), TypeInfoPropertyName = "ScmProviderTypeKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetCollectionFilterProductTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetCollectionFilterProductTypeItem), TypeInfoPropertyName = "CiProductsGetCollectionFilterProductTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetCollectionFieldsCiProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsCiProduct), TypeInfoPropertyName = "CiProductsGetCollectionFieldsCiProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetCollectionFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsApp), TypeInfoPropertyName = "CiProductsGetCollectionFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetCollectionFieldsBundleId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsBundleId), TypeInfoPropertyName = "CiProductsGetCollectionFieldsBundleId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetCollectionFieldsScmRepositorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsScmRepositorie), TypeInfoPropertyName = "CiProductsGetCollectionFieldsScmRepositorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetCollectionIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetCollectionIncludeItem), TypeInfoPropertyName = "CiProductsGetCollectionIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetInstanceFieldsCiProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsCiProduct), TypeInfoPropertyName = "CiProductsGetInstanceFieldsCiProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetInstanceFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsApp), TypeInfoPropertyName = "CiProductsGetInstanceFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetInstanceFieldsBundleId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsBundleId), TypeInfoPropertyName = "CiProductsGetInstanceFieldsBundleId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetInstanceFieldsScmRepositorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsScmRepositorie), TypeInfoPropertyName = "CiProductsGetInstanceFieldsScmRepositorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetInstanceIncludeItem), TypeInfoPropertyName = "CiProductsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie), TypeInfoPropertyName = "CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProvider), TypeInfoPropertyName = "CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference), TypeInfoPropertyName = "CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedIncludeItem), TypeInfoPropertyName = "CiProductsAdditionalRepositoriesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsApp), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuildIcon>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuildIcon), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsBuildIcon2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsCiProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsCiProduct), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsCiProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaGroup), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsBetaGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersion), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPreReleaseVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPreReleaseVersion), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsPreReleaseVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppLocalization), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsBetaAppLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuild), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppInfo), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsAppInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppClip>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppClip), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsAppClip2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsInAppPurchase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsInAppPurchase), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsInAppPurchase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGroup), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsSubscriptionGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppCustomProductPage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppCustomProductPage), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsAppCustomProductPage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPromotedPurchase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPromotedPurchase), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsPromotedPurchase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEvent), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsAppEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsReviewSubmission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsReviewSubmission), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsReviewSubmission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterDetail), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedIncludeItem), TypeInfoPropertyName = "CiProductsAppGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedSortItem), TypeInfoPropertyName = "CiProductsBuildRunsGetToManyRelatedSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun), TypeInfoPropertyName = "CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsBuild), TypeInfoPropertyName = "CiProductsBuildRunsGetToManyRelatedFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow), TypeInfoPropertyName = "CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiProduct), TypeInfoPropertyName = "CiProductsBuildRunsGetToManyRelatedFieldsCiProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference), TypeInfoPropertyName = "CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest), TypeInfoPropertyName = "CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "CiProductsBuildRunsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie), TypeInfoPropertyName = "CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider), TypeInfoPropertyName = "CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference), TypeInfoPropertyName = "CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedIncludeItem), TypeInfoPropertyName = "CiProductsPrimaryRepositoriesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow), TypeInfoPropertyName = "CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiProduct), TypeInfoPropertyName = "CiProductsWorkflowsGetToManyRelatedFieldsCiProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie), TypeInfoPropertyName = "CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion), TypeInfoPropertyName = "CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersion), TypeInfoPropertyName = "CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "CiProductsWorkflowsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.KidsAgeBand?), TypeInfoPropertyName = "NullableKidsAgeBand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem?), TypeInfoPropertyName = "NullableIncludedItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem2?), TypeInfoPropertyName = "NullableIncludedItem22_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AndroidToIosAppMappingDetailType?), TypeInfoPropertyName = "NullableAndroidToIosAppMappingDetailType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Platform?), TypeInfoPropertyName = "NullablePlatform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem3?), TypeInfoPropertyName = "NullableIncludedItem32_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem4?), TypeInfoPropertyName = "NullableIncludedItem42_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem5?), TypeInfoPropertyName = "NullableIncludedItem52_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem6?), TypeInfoPropertyName = "NullableIncludedItem62_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem7?), TypeInfoPropertyName = "NullableIncludedItem72_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem8?), TypeInfoPropertyName = "NullableIncludedItem82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipType?), TypeInfoPropertyName = "NullableAppClipType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipRelationshipsAppDataType?), TypeInfoPropertyName = "NullableAppClipRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiencesDataItemType?), TypeInfoPropertyName = "NullableAppClipRelationshipsAppClipDefaultExperiencesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem9?), TypeInfoPropertyName = "NullableIncludedItem92_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem10?), TypeInfoPropertyName = "NullableIncludedItem102_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem11?), TypeInfoPropertyName = "NullableIncludedItem112_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem12?), TypeInfoPropertyName = "NullableIncludedItem122_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem13?), TypeInfoPropertyName = "NullableIncludedItem132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem14?), TypeInfoPropertyName = "NullableIncludedItem142_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCustomProductPageType?), TypeInfoPropertyName = "NullableAppCustomProductPageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppDataType?), TypeInfoPropertyName = "NullableAppCustomProductPageRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemType?), TypeInfoPropertyName = "NullableAppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventType?), TypeInfoPropertyName = "NullableAppEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventAttributesBadge?), TypeInfoPropertyName = "NullableAppEventAttributesBadge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventAttributesEventState?), TypeInfoPropertyName = "NullableAppEventAttributesEventState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventAttributesPriority?), TypeInfoPropertyName = "NullableAppEventAttributesPriority2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventAttributesPurpose?), TypeInfoPropertyName = "NullableAppEventAttributesPurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppEventRelationshipsLocalizationsDataItemType?), TypeInfoPropertyName = "NullableAppEventRelationshipsLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoType?), TypeInfoPropertyName = "NullableAppInfoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionState?), TypeInfoPropertyName = "NullableAppStoreVersionState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoAttributesState?), TypeInfoPropertyName = "NullableAppInfoAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreAgeRating?), TypeInfoPropertyName = "NullableAppStoreAgeRating2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoAttributesAustraliaAgeRating?), TypeInfoPropertyName = "NullableAppInfoAttributesAustraliaAgeRating2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BrazilAgeRating?), TypeInfoPropertyName = "NullableBrazilAgeRating2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoAttributesBrazilAgeRatingV2?), TypeInfoPropertyName = "NullableAppInfoAttributesBrazilAgeRatingV22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoAttributesFranceAgeRating?), TypeInfoPropertyName = "NullableAppInfoAttributesFranceAgeRating2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoAttributesKoreaAgeRating?), TypeInfoPropertyName = "NullableAppInfoAttributesKoreaAgeRating2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsAppDataType?), TypeInfoPropertyName = "NullableAppInfoRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsAgeRatingDeclarationDataType?), TypeInfoPropertyName = "NullableAppInfoRelationshipsAgeRatingDeclarationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizationsDataItemType?), TypeInfoPropertyName = "NullableAppInfoRelationshipsAppInfoLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsPrimaryCategoryDataType?), TypeInfoPropertyName = "NullableAppInfoRelationshipsPrimaryCategoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryOneDataType?), TypeInfoPropertyName = "NullableAppInfoRelationshipsPrimarySubcategoryOneDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryTwoDataType?), TypeInfoPropertyName = "NullableAppInfoRelationshipsPrimarySubcategoryTwoDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsSecondaryCategoryDataType?), TypeInfoPropertyName = "NullableAppInfoRelationshipsSecondaryCategoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryOneDataType?), TypeInfoPropertyName = "NullableAppInfoRelationshipsSecondarySubcategoryOneDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryTwoDataType?), TypeInfoPropertyName = "NullableAppInfoRelationshipsSecondarySubcategoryTwoDataType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2Type?), TypeInfoPropertyName = "NullableAppStoreVersionExperimentV2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2AttributesState?), TypeInfoPropertyName = "NullableAppStoreVersionExperimentV2AttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppDataType?), TypeInfoPropertyName = "NullableAppStoreVersionExperimentV2RelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsLatestControlVersionDataType?), TypeInfoPropertyName = "NullableAppStoreVersionExperimentV2RelationshipsLatestControlVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsControlVersionsDataItemType?), TypeInfoPropertyName = "NullableAppStoreVersionExperimentV2RelationshipsControlVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItemType?), TypeInfoPropertyName = "NullableAppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableAppResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem50?), TypeInfoPropertyName = "NullableIncludedItem502")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem51?), TypeInfoPropertyName = "NullableIncludedItem512")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationType?), TypeInfoPropertyName = "NullableBetaAppLocalizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppLocalizationRelationshipsAppDataType?), TypeInfoPropertyName = "NullableBetaAppLocalizationRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppReviewDetailType?), TypeInfoPropertyName = "NullableBetaAppReviewDetailType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppReviewDetailRelationshipsAppDataType?), TypeInfoPropertyName = "NullableBetaAppReviewDetailRelationshipsAppDataType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaLicenseAgreementType?), TypeInfoPropertyName = "NullableBetaLicenseAgreementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaLicenseAgreementRelationshipsAppDataType?), TypeInfoPropertyName = "NullableBetaLicenseAgreementRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem58?), TypeInfoPropertyName = "NullableIncludedItem582")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem59?), TypeInfoPropertyName = "NullableIncludedItem592")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildIconType?), TypeInfoPropertyName = "NullableBuildIconType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IconAssetType?), TypeInfoPropertyName = "NullableIconAssetType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BundleIdType?), TypeInfoPropertyName = "NullableBundleIdType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BundleIdPlatform?), TypeInfoPropertyName = "NullableBundleIdPlatform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BundleIdRelationshipsProfilesDataItemType?), TypeInfoPropertyName = "NullableBundleIdRelationshipsProfilesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BundleIdRelationshipsBundleIdCapabilitiesDataItemType?), TypeInfoPropertyName = "NullableBundleIdRelationshipsBundleIdCapabilitiesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BundleIdRelationshipsAppDataType?), TypeInfoPropertyName = "NullableBundleIdRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem64?), TypeInfoPropertyName = "NullableIncludedItem642")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem65?), TypeInfoPropertyName = "NullableIncludedItem652")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiActionType?), TypeInfoPropertyName = "NullableCiActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiExecutionProgress?), TypeInfoPropertyName = "NullableCiExecutionProgress2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiCompletionStatus?), TypeInfoPropertyName = "NullableCiCompletionStatus2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildRunsResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableCiBuildRunsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem67?), TypeInfoPropertyName = "NullableIncludedItem672")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiMacOsVersionType?), TypeInfoPropertyName = "NullableCiMacOsVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersionsDataItemType?), TypeInfoPropertyName = "NullableCiMacOsVersionRelationshipsXcodeVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductType?), TypeInfoPropertyName = "NullableCiProductType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductAttributesProductType?), TypeInfoPropertyName = "NullableCiProductAttributesProductType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductRelationshipsAppDataType?), TypeInfoPropertyName = "NullableCiProductRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductRelationshipsBundleIdDataType?), TypeInfoPropertyName = "NullableCiProductRelationshipsBundleIdDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductRelationshipsPrimaryRepositoriesDataItemType?), TypeInfoPropertyName = "NullableCiProductRelationshipsPrimaryRepositoriesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem68?), TypeInfoPropertyName = "NullableIncludedItem682")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableCiProductsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem69?), TypeInfoPropertyName = "NullableIncludedItem692")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableCiProductResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowType?), TypeInfoPropertyName = "NullableCiWorkflowType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowRelationshipsProductDataType?), TypeInfoPropertyName = "NullableCiWorkflowRelationshipsProductDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowRelationshipsRepositoryDataType?), TypeInfoPropertyName = "NullableCiWorkflowRelationshipsRepositoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowRelationshipsXcodeVersionDataType?), TypeInfoPropertyName = "NullableCiWorkflowRelationshipsXcodeVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowRelationshipsMacOsVersionDataType?), TypeInfoPropertyName = "NullableCiWorkflowRelationshipsMacOsVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem70?), TypeInfoPropertyName = "NullableIncludedItem702")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableCiWorkflowsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem71?), TypeInfoPropertyName = "NullableIncludedItem712")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiXcodeVersionType?), TypeInfoPropertyName = "NullableCiXcodeVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiTestDestinationKind?), TypeInfoPropertyName = "NullableCiTestDestinationKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersionsDataItemType?), TypeInfoPropertyName = "NullableCiXcodeVersionRelationshipsMacOsVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem72?), TypeInfoPropertyName = "NullableIncludedItem722")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem73?), TypeInfoPropertyName = "NullableIncludedItem732")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.EndUserLicenseAgreementType?), TypeInfoPropertyName = "NullableEndUserLicenseAgreementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsAppDataType?), TypeInfoPropertyName = "NullableEndUserLicenseAgreementRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsTerritoriesDataItemType?), TypeInfoPropertyName = "NullableEndUserLicenseAgreementRelationshipsTerritoriesDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterEnabledVersionType?), TypeInfoPropertyName = "NullableGameCenterEnabledVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationshipsCompatibleVersionsDataItemType?), TypeInfoPropertyName = "NullableGameCenterEnabledVersionRelationshipsCompatibleVersionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationshipsAppDataType?), TypeInfoPropertyName = "NullableGameCenterEnabledVersionRelationshipsAppDataType2")]
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
    internal sealed partial class CiProductsSourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseType?), TypeInfoPropertyName = "NullableInAppPurchaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseAttributesInAppPurchaseType?), TypeInfoPropertyName = "NullableInAppPurchaseAttributesInAppPurchaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseAttributesState?), TypeInfoPropertyName = "NullableInAppPurchaseAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.InAppPurchaseRelationshipsAppsDataItemType?), TypeInfoPropertyName = "NullableInAppPurchaseRelationshipsAppsDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseType?), TypeInfoPropertyName = "NullablePromotedPurchaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseAttributesState?), TypeInfoPropertyName = "NullablePromotedPurchaseAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataType?), TypeInfoPropertyName = "NullablePromotedPurchaseRelationshipsInAppPurchaseV2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscriptionDataType?), TypeInfoPropertyName = "NullablePromotedPurchaseRelationshipsSubscriptionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem152?), TypeInfoPropertyName = "NullableIncludedItem1522")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem153?), TypeInfoPropertyName = "NullableIncludedItem1532")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem154?), TypeInfoPropertyName = "NullableIncludedItem1542")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem155?), TypeInfoPropertyName = "NullableIncludedItem1552")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionType?), TypeInfoPropertyName = "NullableReviewSubmissionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionAttributesState?), TypeInfoPropertyName = "NullableReviewSubmissionAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsAppDataType?), TypeInfoPropertyName = "NullableReviewSubmissionRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsItemsDataItemType?), TypeInfoPropertyName = "NullableReviewSubmissionRelationshipsItemsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsAppStoreVersionForReviewDataType?), TypeInfoPropertyName = "NullableReviewSubmissionRelationshipsAppStoreVersionForReviewDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsSubmittedByActorDataType?), TypeInfoPropertyName = "NullableReviewSubmissionRelationshipsSubmittedByActorDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsLastUpdatedByActorDataType?), TypeInfoPropertyName = "NullableReviewSubmissionRelationshipsLastUpdatedByActorDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem156?), TypeInfoPropertyName = "NullableIncludedItem1562")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem157?), TypeInfoPropertyName = "NullableIncludedItem1572")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmGitReferenceType?), TypeInfoPropertyName = "NullableScmGitReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiGitRefKind?), TypeInfoPropertyName = "NullableCiGitRefKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmGitReferenceRelationshipsRepositoryDataType?), TypeInfoPropertyName = "NullableScmGitReferenceRelationshipsRepositoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmProviderType?), TypeInfoPropertyName = "NullableScmProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmPullRequestType?), TypeInfoPropertyName = "NullableScmPullRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmPullRequestRelationshipsRepositoryDataType?), TypeInfoPropertyName = "NullableScmPullRequestRelationshipsRepositoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmRepositoryType?), TypeInfoPropertyName = "NullableScmRepositoryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmRepositoryRelationshipsScmProviderDataType?), TypeInfoPropertyName = "NullableScmRepositoryRelationshipsScmProviderDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmRepositoryRelationshipsDefaultBranchDataType?), TypeInfoPropertyName = "NullableScmRepositoryRelationshipsDefaultBranchDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem158?), TypeInfoPropertyName = "NullableIncludedItem1582")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmRepositoriesResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableScmRepositoriesResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem159?), TypeInfoPropertyName = "NullableIncludedItem1592")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGracePeriodType?), TypeInfoPropertyName = "NullableSubscriptionGracePeriodType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGracePeriodDuration?), TypeInfoPropertyName = "NullableSubscriptionGracePeriodDuration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGracePeriodAttributesRenewalType?), TypeInfoPropertyName = "NullableSubscriptionGracePeriodAttributesRenewalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem160?), TypeInfoPropertyName = "NullableIncludedItem1602")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem161?), TypeInfoPropertyName = "NullableIncludedItem1612")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupType?), TypeInfoPropertyName = "NullableSubscriptionGroupType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionsDataItemType?), TypeInfoPropertyName = "NullableSubscriptionGroupRelationshipsSubscriptionsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType?), TypeInfoPropertyName = "NullableSubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsVersionsDataItemType?), TypeInfoPropertyName = "NullableSubscriptionGroupRelationshipsVersionsDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductAdditionalRepositoriesLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableCiProductAdditionalRepositoriesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductAppLinkageResponseDataType?), TypeInfoPropertyName = "NullableCiProductAppLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductBuildRunsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableCiProductBuildRunsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductPrimaryRepositoriesLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableCiProductPrimaryRepositoriesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductWorkflowsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableCiProductWorkflowsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>?), TypeInfoPropertyName = "NullableOneOfErrorSourcePointerErrorSourceParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<string, global::AppStoreConnect.ErrorLinksAssociated>?), TypeInfoPropertyName = "NullableOneOfStringErrorLinksAssociated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiActionDestination?), TypeInfoPropertyName = "NullableCiActionDestination2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiActionTestConfigurationKind?), TypeInfoPropertyName = "NullableCiActionTestConfigurationKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiActionPlatform?), TypeInfoPropertyName = "NullableCiActionPlatform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiFilesAndFoldersRuleMode?), TypeInfoPropertyName = "NullableCiFilesAndFoldersRuleMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleFrequency?), TypeInfoPropertyName = "NullableCiScheduledStartConditionScheduleFrequency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleDay?), TypeInfoPropertyName = "NullableCiScheduledStartConditionScheduleDay2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmProviderTypeKind?), TypeInfoPropertyName = "NullableScmProviderTypeKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetCollectionFilterProductTypeItem?), TypeInfoPropertyName = "NullableCiProductsGetCollectionFilterProductTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsCiProduct?), TypeInfoPropertyName = "NullableCiProductsGetCollectionFieldsCiProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsApp?), TypeInfoPropertyName = "NullableCiProductsGetCollectionFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsBundleId?), TypeInfoPropertyName = "NullableCiProductsGetCollectionFieldsBundleId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsScmRepositorie?), TypeInfoPropertyName = "NullableCiProductsGetCollectionFieldsScmRepositorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetCollectionIncludeItem?), TypeInfoPropertyName = "NullableCiProductsGetCollectionIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsCiProduct?), TypeInfoPropertyName = "NullableCiProductsGetInstanceFieldsCiProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsApp?), TypeInfoPropertyName = "NullableCiProductsGetInstanceFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsBundleId?), TypeInfoPropertyName = "NullableCiProductsGetInstanceFieldsBundleId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsScmRepositorie?), TypeInfoPropertyName = "NullableCiProductsGetInstanceFieldsScmRepositorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableCiProductsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie?), TypeInfoPropertyName = "NullableCiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProvider?), TypeInfoPropertyName = "NullableCiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference?), TypeInfoPropertyName = "NullableCiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableCiProductsAdditionalRepositoriesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsApp?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuildIcon?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsBuildIcon2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsCiProduct?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsCiProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaGroup?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsBetaGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersion?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsAppStoreVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPreReleaseVersion?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsPreReleaseVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppLocalization?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsBetaAppLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuild?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppInfo?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsAppInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppClip?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsAppClip2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsInAppPurchase?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsInAppPurchase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGroup?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsSubscriptionGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppCustomProductPage?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsAppCustomProductPage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPromotedPurchase?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsPromotedPurchase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEvent?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsAppEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsReviewSubmission?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsReviewSubmission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterDetail?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsGameCenterDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedIncludeItem?), TypeInfoPropertyName = "NullableCiProductsAppGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedSortItem?), TypeInfoPropertyName = "NullableCiProductsBuildRunsGetToManyRelatedSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun?), TypeInfoPropertyName = "NullableCiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsBuild?), TypeInfoPropertyName = "NullableCiProductsBuildRunsGetToManyRelatedFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow?), TypeInfoPropertyName = "NullableCiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiProduct?), TypeInfoPropertyName = "NullableCiProductsBuildRunsGetToManyRelatedFieldsCiProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference?), TypeInfoPropertyName = "NullableCiProductsBuildRunsGetToManyRelatedFieldsScmGitReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest?), TypeInfoPropertyName = "NullableCiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableCiProductsBuildRunsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie?), TypeInfoPropertyName = "NullableCiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider?), TypeInfoPropertyName = "NullableCiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference?), TypeInfoPropertyName = "NullableCiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableCiProductsPrimaryRepositoriesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow?), TypeInfoPropertyName = "NullableCiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiProduct?), TypeInfoPropertyName = "NullableCiProductsWorkflowsGetToManyRelatedFieldsCiProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie?), TypeInfoPropertyName = "NullableCiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion?), TypeInfoPropertyName = "NullableCiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersion?), TypeInfoPropertyName = "NullableCiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableCiProductsWorkflowsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiencesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEncryptionDeclarationRelationshipsBuildsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEventAttributesTerritorySchedule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEventAttributesArchivedTerritorySchedule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEventRelationshipsLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsControlVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItem>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem47>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaGroupRelationshipsBuildsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaGroupRelationshipsBetaTestersDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsIconsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BundleIdRelationshipsProfilesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BundleIdRelationshipsBundleIdCapabilitiesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunRelationshipsBuildsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem66>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductRelationshipsPrimaryRepositoriesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem68>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem69>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem70>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiXcodeVersionAttributesTestDestination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiXcodeVersionAttributesTestDestinationAvailableRuntime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.EndUserLicenseAgreementRelationshipsTerritoriesDataItem>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterEnabledVersionRelationshipsCompatibleVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseRelationshipsAppsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.PrereleaseVersionRelationshipsBuildsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionRelationshipsItemsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ScmRepository>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem158>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupRelationshipsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductAdditionalRepositoriesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductBuildRunsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductPrimaryRepositoriesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductWorkflowsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ErrorResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiTestDestination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBranchPatternsPattern>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiStartConditionFileMatcher>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiScheduledStartConditionScheduleDay>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiTagPatternsPattern>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsGetCollectionFilterProductTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsGetCollectionFieldsCiProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsGetCollectionFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsGetCollectionFieldsBundleId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsGetCollectionFieldsScmRepositorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsGetCollectionIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsGetInstanceFieldsCiProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsGetInstanceFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsGetInstanceFieldsBundleId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsGetInstanceFieldsScmRepositorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuildIcon>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsCiProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPreReleaseVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppClip>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsInAppPurchase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppCustomProductPage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPromotedPurchase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsReviewSubmission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedIncludeItem>))]
    internal sealed partial class CiProductsSourceGenerationContextChunk3 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CiProductsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static CiProductsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private CiProductsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AndroidToIosAppMappingDetailType)

                    || typeToConvert == typeof(global::AppStoreConnect.AndroidToIosAppMappingDetailType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiencesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiencesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsBuildsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsBuildsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentDataType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesAustraliaAgeRating)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesAustraliaAgeRating?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesBrazilAgeRatingV2)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesBrazilAgeRatingV2?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesFranceAgeRating)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesFranceAgeRating?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesKoreaAgeRating)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesKoreaAgeRating?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAgeRatingDeclarationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAgeRatingDeclarationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimaryCategoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimaryCategoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryOneDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryOneDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryTwoDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryTwoDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondaryCategoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondaryCategoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryOneDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryOneDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryTwoDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryTwoDataType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.AppResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppReviewDetailType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppReviewDetailType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppReviewDetailRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppReviewDetailRelationshipsAppDataType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.BetaLicenseAgreementType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaLicenseAgreementType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaLicenseAgreementRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaLicenseAgreementRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildIconType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildIconType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdType)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdRelationshipsProfilesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdRelationshipsProfilesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdRelationshipsBundleIdCapabilitiesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdRelationshipsBundleIdCapabilitiesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdRelationshipsAppDataType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiMacOsVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiMacOsVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersionsDataItemType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductResponseIncludedItemDiscriminatorType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiXcodeVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiXcodeVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementType)

                    || typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementType?)

                    || typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsTerritoriesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsTerritoriesDataItemType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterEnabledVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterEnabledVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationshipsCompatibleVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationshipsCompatibleVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseAttributesInAppPurchaseType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseAttributesInAppPurchaseType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseRelationshipsAppsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseRelationshipsAppsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsBuildsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsBuildsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseType)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseType?)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataType)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscriptionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscriptionDataType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.ScmGitReferenceType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmGitReferenceType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmGitReferenceRelationshipsRepositoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmGitReferenceRelationshipsRepositoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmProviderType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmProviderType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestRelationshipsRepositoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmPullRequestRelationshipsRepositoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsScmProviderDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsScmProviderDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsDefaultBranchDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsDefaultBranchDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmRepositoriesResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmRepositoriesResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGracePeriodType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGracePeriodType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGracePeriodAttributesRenewalType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGracePeriodAttributesRenewalType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductAdditionalRepositoriesLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductAdditionalRepositoriesLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductAppLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductAppLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductBuildRunsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductBuildRunsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductPrimaryRepositoriesLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductPrimaryRepositoriesLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductWorkflowsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductWorkflowsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreAgeRating)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreAgeRating?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppVersionState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppVersionState?)

                    || typeToConvert == typeof(global::AppStoreConnect.BrazilAgeRating)

                    || typeToConvert == typeof(global::AppStoreConnect.BrazilAgeRating?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdPlatform)

                    || typeToConvert == typeof(global::AppStoreConnect.BundleIdPlatform?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.IconAssetType)

                    || typeToConvert == typeof(global::AppStoreConnect.IconAssetType?)

                    || typeToConvert == typeof(global::AppStoreConnect.KidsAgeBand)

                    || typeToConvert == typeof(global::AppStoreConnect.KidsAgeBand?)

                    || typeToConvert == typeof(global::AppStoreConnect.Platform)

                    || typeToConvert == typeof(global::AppStoreConnect.Platform?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmProviderTypeKind)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmProviderTypeKind?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGracePeriodDuration)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGracePeriodDuration?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFilterProductTypeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFilterProductTypeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsCiProduct)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsCiProduct?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsBundleId)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsBundleId?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsScmRepositorie)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsScmRepositorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsCiProduct)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsCiProduct?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsBundleId)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsBundleId?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsScmRepositorie)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsScmRepositorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProvider)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProvider?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuildIcon)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuildIcon?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsCiProduct)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsCiProduct?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPreReleaseVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPreReleaseVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppInfo)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppInfo?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppClip)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppClip?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsInAppPurchase)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsInAppPurchase?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppCustomProductPage)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppCustomProductPage?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPromotedPurchase)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPromotedPurchase?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEvent)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEvent?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsReviewSubmission)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsReviewSubmission?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiProduct)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiProduct?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiProduct)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiProduct?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AndroidToIosAppMappingDetailType))
                {
                    return new global::AppStoreConnect.JsonConverters.AndroidToIosAppMappingDetailTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AndroidToIosAppMappingDetailType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AndroidToIosAppMappingDetailTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesAustraliaAgeRating))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAttributesAustraliaAgeRatingJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesAustraliaAgeRating?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAttributesAustraliaAgeRatingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesBrazilAgeRatingV2))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAttributesBrazilAgeRatingV2JsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesBrazilAgeRatingV2?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAttributesBrazilAgeRatingV2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesFranceAgeRating))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAttributesFranceAgeRatingJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesFranceAgeRating?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAttributesFranceAgeRatingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesKoreaAgeRating))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAttributesKoreaAgeRatingJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesKoreaAgeRating?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAttributesKoreaAgeRatingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAgeRatingDeclarationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsAgeRatingDeclarationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAgeRatingDeclarationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsAgeRatingDeclarationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsAppInfoLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsAppInfoLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimaryCategoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsPrimaryCategoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimaryCategoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsPrimaryCategoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryOneDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsPrimarySubcategoryOneDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryOneDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsPrimarySubcategoryOneDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryTwoDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsPrimarySubcategoryTwoDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryTwoDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsPrimarySubcategoryTwoDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondaryCategoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsSecondaryCategoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondaryCategoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsSecondaryCategoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryOneDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsSecondarySubcategoryOneDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryOneDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsSecondarySubcategoryOneDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryTwoDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsSecondarySubcategoryTwoDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryTwoDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsSecondarySubcategoryTwoDataTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.AppResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppLocalizationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppLocalizationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppLocalizationRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppLocalizationRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppReviewDetailType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppReviewDetailTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppReviewDetailType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppReviewDetailTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppReviewDetailRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppReviewDetailRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppReviewDetailRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppReviewDetailRelationshipsAppDataTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.BetaLicenseAgreementType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaLicenseAgreementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaLicenseAgreementType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaLicenseAgreementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaLicenseAgreementRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaLicenseAgreementRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaLicenseAgreementRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaLicenseAgreementRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildIconType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildIconTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildIconType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildIconTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdType))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdRelationshipsProfilesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdRelationshipsProfilesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdRelationshipsProfilesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdRelationshipsProfilesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdRelationshipsBundleIdCapabilitiesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdRelationshipsBundleIdCapabilitiesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdRelationshipsBundleIdCapabilitiesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdRelationshipsBundleIdCapabilitiesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdRelationshipsAppDataTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiMacOsVersionType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiMacOsVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiMacOsVersionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiMacOsVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiMacOsVersionRelationshipsXcodeVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiMacOsVersionRelationshipsXcodeVersionsDataItemTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiXcodeVersionType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiXcodeVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiXcodeVersionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiXcodeVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiXcodeVersionRelationshipsMacOsVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiXcodeVersionRelationshipsMacOsVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementType))
                {
                    return new global::AppStoreConnect.JsonConverters.EndUserLicenseAgreementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementType?))
                {
                    return new global::AppStoreConnect.JsonConverters.EndUserLicenseAgreementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.EndUserLicenseAgreementRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.EndUserLicenseAgreementRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsTerritoriesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.EndUserLicenseAgreementRelationshipsTerritoriesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsTerritoriesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.EndUserLicenseAgreementRelationshipsTerritoriesDataItemTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterEnabledVersionType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterEnabledVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterEnabledVersionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterEnabledVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationshipsCompatibleVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterEnabledVersionRelationshipsCompatibleVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationshipsCompatibleVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterEnabledVersionRelationshipsCompatibleVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterEnabledVersionRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterEnabledVersionRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseAttributesInAppPurchaseType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseAttributesInAppPurchaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseAttributesInAppPurchaseType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseAttributesInAppPurchaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseRelationshipsAppsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseRelationshipsAppsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseRelationshipsAppsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseRelationshipsAppsDataItemTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseType))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseType?))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataType))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseRelationshipsInAppPurchaseV2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseRelationshipsInAppPurchaseV2DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscriptionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseRelationshipsSubscriptionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscriptionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseRelationshipsSubscriptionDataTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.ScmProviderType))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmProviderTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmProviderType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmProviderTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryType))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmRepositoryTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmRepositoryTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsScmProviderDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmRepositoryRelationshipsScmProviderDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsScmProviderDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmRepositoryRelationshipsScmProviderDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsDefaultBranchDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmRepositoryRelationshipsDefaultBranchDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryRelationshipsDefaultBranchDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmRepositoryRelationshipsDefaultBranchDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmRepositoriesResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmRepositoriesResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmRepositoriesResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmRepositoriesResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGracePeriodType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGracePeriodTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGracePeriodType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGracePeriodTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGracePeriodAttributesRenewalType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGracePeriodAttributesRenewalTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGracePeriodAttributesRenewalType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGracePeriodAttributesRenewalTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupRelationshipsSubscriptionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupRelationshipsSubscriptionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupRelationshipsVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupRelationshipsVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductAdditionalRepositoriesLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductAdditionalRepositoriesLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductAdditionalRepositoriesLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductAdditionalRepositoriesLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductAppLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductAppLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductAppLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductAppLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductBuildRunsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductBuildRunsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductBuildRunsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductBuildRunsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductPrimaryRepositoriesLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductPrimaryRepositoriesLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductPrimaryRepositoriesLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductPrimaryRepositoriesLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductWorkflowsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductWorkflowsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductWorkflowsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductWorkflowsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreAgeRating))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreAgeRatingJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreAgeRating?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreAgeRatingNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.BrazilAgeRating))
                {
                    return new global::AppStoreConnect.JsonConverters.BrazilAgeRatingJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BrazilAgeRating?))
                {
                    return new global::AppStoreConnect.JsonConverters.BrazilAgeRatingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAudienceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAudienceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdPlatform))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdPlatformJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BundleIdPlatform?))
                {
                    return new global::AppStoreConnect.JsonConverters.BundleIdPlatformNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.IconAssetType))
                {
                    return new global::AppStoreConnect.JsonConverters.IconAssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.IconAssetType?))
                {
                    return new global::AppStoreConnect.JsonConverters.IconAssetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.KidsAgeBand))
                {
                    return new global::AppStoreConnect.JsonConverters.KidsAgeBandJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.KidsAgeBand?))
                {
                    return new global::AppStoreConnect.JsonConverters.KidsAgeBandNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.Platform))
                {
                    return new global::AppStoreConnect.JsonConverters.PlatformJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.Platform?))
                {
                    return new global::AppStoreConnect.JsonConverters.PlatformNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmProviderTypeKind))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmProviderTypeKindJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmProviderTypeKind?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmProviderTypeKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGracePeriodDuration))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGracePeriodDurationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGracePeriodDuration?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGracePeriodDurationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionStatusUrlVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionStatusUrlVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFilterProductTypeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetCollectionFilterProductTypeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFilterProductTypeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetCollectionFilterProductTypeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsCiProduct))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetCollectionFieldsCiProductJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsCiProduct?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetCollectionFieldsCiProductNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetCollectionFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetCollectionFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsBundleId))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetCollectionFieldsBundleIdJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsBundleId?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetCollectionFieldsBundleIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsScmRepositorie))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetCollectionFieldsScmRepositorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionFieldsScmRepositorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetCollectionFieldsScmRepositorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetCollectionIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetCollectionIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetCollectionIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsCiProduct))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetInstanceFieldsCiProductJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsCiProduct?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetInstanceFieldsCiProductNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetInstanceFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetInstanceFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsBundleId))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetInstanceFieldsBundleIdJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsBundleId?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetInstanceFieldsBundleIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsScmRepositorie))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetInstanceFieldsScmRepositorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceFieldsScmRepositorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetInstanceFieldsScmRepositorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsGetInstanceIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmRepositorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProvider))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProvider?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReferenceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReference?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAdditionalRepositoriesGetToManyRelatedFieldsScmGitReferenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAdditionalRepositoriesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAdditionalRepositoriesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAdditionalRepositoriesGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclarationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclarationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuildIcon))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBuildIconJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuildIcon?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBuildIconNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsCiProduct))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsCiProductJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsCiProduct?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsCiProductNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBetaGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBetaGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPreReleaseVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsPreReleaseVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPreReleaseVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsPreReleaseVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBetaAppLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBetaAppLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppInfo))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppInfoJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppInfo?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppInfoNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppClip))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppClipJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppClip?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppClipNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsInAppPurchase))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsInAppPurchaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsInAppPurchase?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsInAppPurchaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsSubscriptionGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsSubscriptionGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppCustomProductPage))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppCustomProductPageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppCustomProductPage?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppCustomProductPageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPromotedPurchase))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsPromotedPurchaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPromotedPurchase?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsPromotedPurchaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEvent))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppEventJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEvent?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsReviewSubmission))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsReviewSubmissionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsReviewSubmission?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsReviewSubmissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriodJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperimentJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperimentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRunJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRunNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflowJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflowNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiProduct))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsCiProductJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiProduct?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsCiProductNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsScmGitReferenceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsScmGitReferenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequestJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequestNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsBuildRunsGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmRepositorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProvider?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReferenceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReference?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsPrimaryRepositoriesGetToManyRelatedFieldsScmGitReferenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsPrimaryRepositoriesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsPrimaryRepositoriesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsPrimaryRepositoriesGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflowJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflowNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiProduct))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsWorkflowsGetToManyRelatedFieldsCiProductJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiProduct?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsWorkflowsGetToManyRelatedFieldsCiProductNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsWorkflowsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsWorkflowsGetToManyRelatedIncludeItemNullableJsonConverter();
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
                    0 => new CiProductsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new CiProductsSourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),

                    2 => new CiProductsSourceGenerationContextChunk2(new global::System.Text.Json.JsonSerializerOptions()),

                    3 => new CiProductsSourceGenerationContextChunk3(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}