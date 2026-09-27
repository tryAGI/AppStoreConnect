
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationType), TypeInfoPropertyName = "AgeRatingDeclarationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferences), TypeInfoPropertyName = "AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferences2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesContests), TypeInfoPropertyName = "AgeRatingDeclarationAttributesContests2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesGamblingSimulated), TypeInfoPropertyName = "AgeRatingDeclarationAttributesGamblingSimulated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesGunsOrOtherWeapons), TypeInfoPropertyName = "AgeRatingDeclarationAttributesGunsOrOtherWeapons2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.KidsAgeBand), TypeInfoPropertyName = "KidsAgeBand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesMedicalOrTreatmentInformation), TypeInfoPropertyName = "AgeRatingDeclarationAttributesMedicalOrTreatmentInformation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesProfanityOrCrudeHumor), TypeInfoPropertyName = "AgeRatingDeclarationAttributesProfanityOrCrudeHumor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesSexualContentGraphicAndNudity), TypeInfoPropertyName = "AgeRatingDeclarationAttributesSexualContentGraphicAndNudity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesSexualContentOrNudity), TypeInfoPropertyName = "AgeRatingDeclarationAttributesSexualContentOrNudity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesHorrorOrFearThemes), TypeInfoPropertyName = "AgeRatingDeclarationAttributesHorrorOrFearThemes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesMatureOrSuggestiveThemes), TypeInfoPropertyName = "AgeRatingDeclarationAttributesMatureOrSuggestiveThemes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceCartoonOrFantasy), TypeInfoPropertyName = "AgeRatingDeclarationAttributesViolenceCartoonOrFantasy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadistic), TypeInfoPropertyName = "AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadistic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceRealistic), TypeInfoPropertyName = "AgeRatingDeclarationAttributesViolenceRealistic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAgeRatingOverride), TypeInfoPropertyName = "AgeRatingDeclarationAttributesAgeRatingOverride2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAgeRatingOverrideV2), TypeInfoPropertyName = "AgeRatingDeclarationAttributesAgeRatingOverrideV22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesKoreaAgeRatingOverride), TypeInfoPropertyName = "AgeRatingDeclarationAttributesKoreaAgeRatingOverride2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackageVariant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.RelationshipLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem), TypeInfoPropertyName = "IncludedItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AlternativeDistributionPackage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem2), TypeInfoPropertyName = "IncludedItem22_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AndroidToIosAppMappingDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoryType), TypeInfoPropertyName = "AppCategoryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoryAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.Platform>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Platform), TypeInfoPropertyName = "Platform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoryRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoryRelationshipsSubcategories))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCategoryRelationshipsSubcategoriesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoryRelationshipsSubcategoriesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoryRelationshipsSubcategoriesDataItemType), TypeInfoPropertyName = "AppCategoryRelationshipsSubcategoriesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoryRelationshipsParent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoryRelationshipsParentData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoryRelationshipsParentDataType), TypeInfoPropertyName = "AppCategoryRelationshipsParentDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoryResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoLocalizationType), TypeInfoPropertyName = "AppInfoLocalizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoLocalizationAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoLocalizationRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoLocalizationRelationshipsAppInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoLocalizationRelationshipsAppInfoData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoLocalizationRelationshipsAppInfoDataType), TypeInfoPropertyName = "AppInfoLocalizationRelationshipsAppInfoDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoLocalizationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfoLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfo>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem23>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem23), TypeInfoPropertyName = "IncludedItem232")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "AppInfoResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoUpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoUpdateRequestDataType), TypeInfoPropertyName = "AppInfoUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimaryCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimaryCategoryData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimaryCategoryDataType), TypeInfoPropertyName = "AppInfoUpdateRequestDataRelationshipsPrimaryCategoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOne))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataType), TypeInfoPropertyName = "AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwoData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwoDataType), TypeInfoPropertyName = "AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwoDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondaryCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondaryCategoryData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondaryCategoryDataType), TypeInfoPropertyName = "AppInfoUpdateRequestDataRelationshipsSecondaryCategoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOne))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOneData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOneDataType), TypeInfoPropertyName = "AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOneDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwoData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwoDataType), TypeInfoPropertyName = "AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwoDataType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem44), TypeInfoPropertyName = "IncludedItem442")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.RoutingAppCoverage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem45), TypeInfoPropertyName = "IncludedItem452")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.Territory>))]
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
    internal sealed partial class AppInfosSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.TerritoryType), TypeInfoPropertyName = "TerritoryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.TerritoryAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.TerritoryAgeRating))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.TerritoryAgeRatingType), TypeInfoPropertyName = "TerritoryAgeRatingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.TerritoryAgeRatingAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.TerritoryAgeRatingRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.TerritoryAgeRatingRelationshipsTerritory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.TerritoryAgeRatingRelationshipsTerritoryData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.TerritoryAgeRatingRelationshipsTerritoryDataType), TypeInfoPropertyName = "TerritoryAgeRatingRelationshipsTerritoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.TerritoryAgeRatingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.TerritoryAgeRating>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem179), TypeInfoPropertyName = "IncludedItem1792")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoAgeRatingDeclarationLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoAgeRatingDeclarationLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoAgeRatingDeclarationLinkageResponseDataType), TypeInfoPropertyName = "AppInfoAgeRatingDeclarationLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoAppInfoLocalizationsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfoAppInfoLocalizationsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoAppInfoLocalizationsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoAppInfoLocalizationsLinkagesResponseDataItemType), TypeInfoPropertyName = "AppInfoAppInfoLocalizationsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoPrimaryCategoryLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoPrimaryCategoryLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoPrimaryCategoryLinkageResponseDataType), TypeInfoPropertyName = "AppInfoPrimaryCategoryLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoPrimarySubcategoryOneLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoPrimarySubcategoryOneLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoPrimarySubcategoryOneLinkageResponseDataType), TypeInfoPropertyName = "AppInfoPrimarySubcategoryOneLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoPrimarySubcategoryTwoLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoPrimarySubcategoryTwoLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoPrimarySubcategoryTwoLinkageResponseDataType), TypeInfoPropertyName = "AppInfoPrimarySubcategoryTwoLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoSecondaryCategoryLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoSecondaryCategoryLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoSecondaryCategoryLinkageResponseDataType), TypeInfoPropertyName = "AppInfoSecondaryCategoryLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoSecondarySubcategoryOneLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoSecondarySubcategoryOneLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoSecondarySubcategoryOneLinkageResponseDataType), TypeInfoPropertyName = "AppInfoSecondarySubcategoryOneLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoSecondarySubcategoryTwoLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoSecondarySubcategoryTwoLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoSecondarySubcategoryTwoLinkageResponseDataType), TypeInfoPropertyName = "AppInfoSecondarySubcategoryTwoLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoTerritoryAgeRatingsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfoTerritoryAgeRatingsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoTerritoryAgeRatingsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoTerritoryAgeRatingsLinkagesResponseDataItemType), TypeInfoPropertyName = "AppInfoTerritoryAgeRatingsLinkagesResponseDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfo), TypeInfoPropertyName = "AppInfosGetInstanceFieldsAppInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosGetInstanceFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsApp), TypeInfoPropertyName = "AppInfosGetInstanceFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosGetInstanceFieldsAgeRatingDeclaration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAgeRatingDeclaration), TypeInfoPropertyName = "AppInfosGetInstanceFieldsAgeRatingDeclaration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfoLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfoLocalization), TypeInfoPropertyName = "AppInfosGetInstanceFieldsAppInfoLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosGetInstanceFieldsAppCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppCategorie), TypeInfoPropertyName = "AppInfosGetInstanceFieldsAppCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosGetInstanceIncludeItem), TypeInfoPropertyName = "AppInfosGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration), TypeInfoPropertyName = "AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization), TypeInfoPropertyName = "AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo), TypeInfoPropertyName = "AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "AppInfosAppInfoLocalizationsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosPrimaryCategoryGetToOneRelatedFieldsAppCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosPrimaryCategoryGetToOneRelatedFieldsAppCategorie), TypeInfoPropertyName = "AppInfosPrimaryCategoryGetToOneRelatedFieldsAppCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosPrimaryCategoryGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosPrimaryCategoryGetToOneRelatedIncludeItem), TypeInfoPropertyName = "AppInfosPrimaryCategoryGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosPrimarySubcategoryOneGetToOneRelatedFieldsAppCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosPrimarySubcategoryOneGetToOneRelatedFieldsAppCategorie), TypeInfoPropertyName = "AppInfosPrimarySubcategoryOneGetToOneRelatedFieldsAppCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosPrimarySubcategoryOneGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosPrimarySubcategoryOneGetToOneRelatedIncludeItem), TypeInfoPropertyName = "AppInfosPrimarySubcategoryOneGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosPrimarySubcategoryTwoGetToOneRelatedFieldsAppCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosPrimarySubcategoryTwoGetToOneRelatedFieldsAppCategorie), TypeInfoPropertyName = "AppInfosPrimarySubcategoryTwoGetToOneRelatedFieldsAppCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosPrimarySubcategoryTwoGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosPrimarySubcategoryTwoGetToOneRelatedIncludeItem), TypeInfoPropertyName = "AppInfosPrimarySubcategoryTwoGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosSecondaryCategoryGetToOneRelatedFieldsAppCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosSecondaryCategoryGetToOneRelatedFieldsAppCategorie), TypeInfoPropertyName = "AppInfosSecondaryCategoryGetToOneRelatedFieldsAppCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosSecondaryCategoryGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosSecondaryCategoryGetToOneRelatedIncludeItem), TypeInfoPropertyName = "AppInfosSecondaryCategoryGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosSecondarySubcategoryOneGetToOneRelatedFieldsAppCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosSecondarySubcategoryOneGetToOneRelatedFieldsAppCategorie), TypeInfoPropertyName = "AppInfosSecondarySubcategoryOneGetToOneRelatedFieldsAppCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosSecondarySubcategoryOneGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosSecondarySubcategoryOneGetToOneRelatedIncludeItem), TypeInfoPropertyName = "AppInfosSecondarySubcategoryOneGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosSecondarySubcategoryTwoGetToOneRelatedFieldsAppCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosSecondarySubcategoryTwoGetToOneRelatedFieldsAppCategorie), TypeInfoPropertyName = "AppInfosSecondarySubcategoryTwoGetToOneRelatedFieldsAppCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosSecondarySubcategoryTwoGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosSecondarySubcategoryTwoGetToOneRelatedIncludeItem), TypeInfoPropertyName = "AppInfosSecondarySubcategoryTwoGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritoryAgeRating>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritoryAgeRating), TypeInfoPropertyName = "AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritoryAgeRating2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritorie), TypeInfoPropertyName = "AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosTerritoryAgeRatingsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosTerritoryAgeRatingsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "AppInfosTerritoryAgeRatingsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationType?), TypeInfoPropertyName = "NullableAgeRatingDeclarationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferences?), TypeInfoPropertyName = "NullableAgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferences2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesContests?), TypeInfoPropertyName = "NullableAgeRatingDeclarationAttributesContests2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesGamblingSimulated?), TypeInfoPropertyName = "NullableAgeRatingDeclarationAttributesGamblingSimulated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesGunsOrOtherWeapons?), TypeInfoPropertyName = "NullableAgeRatingDeclarationAttributesGunsOrOtherWeapons2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.KidsAgeBand?), TypeInfoPropertyName = "NullableKidsAgeBand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesMedicalOrTreatmentInformation?), TypeInfoPropertyName = "NullableAgeRatingDeclarationAttributesMedicalOrTreatmentInformation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesProfanityOrCrudeHumor?), TypeInfoPropertyName = "NullableAgeRatingDeclarationAttributesProfanityOrCrudeHumor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesSexualContentGraphicAndNudity?), TypeInfoPropertyName = "NullableAgeRatingDeclarationAttributesSexualContentGraphicAndNudity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesSexualContentOrNudity?), TypeInfoPropertyName = "NullableAgeRatingDeclarationAttributesSexualContentOrNudity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesHorrorOrFearThemes?), TypeInfoPropertyName = "NullableAgeRatingDeclarationAttributesHorrorOrFearThemes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesMatureOrSuggestiveThemes?), TypeInfoPropertyName = "NullableAgeRatingDeclarationAttributesMatureOrSuggestiveThemes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceCartoonOrFantasy?), TypeInfoPropertyName = "NullableAgeRatingDeclarationAttributesViolenceCartoonOrFantasy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadistic?), TypeInfoPropertyName = "NullableAgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadistic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceRealistic?), TypeInfoPropertyName = "NullableAgeRatingDeclarationAttributesViolenceRealistic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAgeRatingOverride?), TypeInfoPropertyName = "NullableAgeRatingDeclarationAttributesAgeRatingOverride2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAgeRatingOverrideV2?), TypeInfoPropertyName = "NullableAgeRatingDeclarationAttributesAgeRatingOverrideV22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesKoreaAgeRatingOverride?), TypeInfoPropertyName = "NullableAgeRatingDeclarationAttributesKoreaAgeRatingOverride2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem?), TypeInfoPropertyName = "NullableIncludedItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem2?), TypeInfoPropertyName = "NullableIncludedItem22_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoryType?), TypeInfoPropertyName = "NullableAppCategoryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Platform?), TypeInfoPropertyName = "NullablePlatform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoryRelationshipsSubcategoriesDataItemType?), TypeInfoPropertyName = "NullableAppCategoryRelationshipsSubcategoriesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppCategoryRelationshipsParentDataType?), TypeInfoPropertyName = "NullableAppCategoryRelationshipsParentDataType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem18?), TypeInfoPropertyName = "NullableIncludedItem182")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem19?), TypeInfoPropertyName = "NullableIncludedItem192")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem20?), TypeInfoPropertyName = "NullableIncludedItem202")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem21?), TypeInfoPropertyName = "NullableIncludedItem212")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoLocalizationType?), TypeInfoPropertyName = "NullableAppInfoLocalizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoLocalizationRelationshipsAppInfoDataType?), TypeInfoPropertyName = "NullableAppInfoLocalizationRelationshipsAppInfoDataType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableAppInfoResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoUpdateRequestDataType?), TypeInfoPropertyName = "NullableAppInfoUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimaryCategoryDataType?), TypeInfoPropertyName = "NullableAppInfoUpdateRequestDataRelationshipsPrimaryCategoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataType?), TypeInfoPropertyName = "NullableAppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwoDataType?), TypeInfoPropertyName = "NullableAppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwoDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondaryCategoryDataType?), TypeInfoPropertyName = "NullableAppInfoUpdateRequestDataRelationshipsSecondaryCategoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOneDataType?), TypeInfoPropertyName = "NullableAppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOneDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwoDataType?), TypeInfoPropertyName = "NullableAppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwoDataType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.TerritoryType?), TypeInfoPropertyName = "NullableTerritoryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.TerritoryAgeRatingType?), TypeInfoPropertyName = "NullableTerritoryAgeRatingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.TerritoryAgeRatingRelationshipsTerritoryDataType?), TypeInfoPropertyName = "NullableTerritoryAgeRatingRelationshipsTerritoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem179?), TypeInfoPropertyName = "NullableIncludedItem1792")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoAgeRatingDeclarationLinkageResponseDataType?), TypeInfoPropertyName = "NullableAppInfoAgeRatingDeclarationLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoAppInfoLocalizationsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableAppInfoAppInfoLocalizationsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoPrimaryCategoryLinkageResponseDataType?), TypeInfoPropertyName = "NullableAppInfoPrimaryCategoryLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoPrimarySubcategoryOneLinkageResponseDataType?), TypeInfoPropertyName = "NullableAppInfoPrimarySubcategoryOneLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoPrimarySubcategoryTwoLinkageResponseDataType?), TypeInfoPropertyName = "NullableAppInfoPrimarySubcategoryTwoLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoSecondaryCategoryLinkageResponseDataType?), TypeInfoPropertyName = "NullableAppInfoSecondaryCategoryLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoSecondarySubcategoryOneLinkageResponseDataType?), TypeInfoPropertyName = "NullableAppInfoSecondarySubcategoryOneLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoSecondarySubcategoryTwoLinkageResponseDataType?), TypeInfoPropertyName = "NullableAppInfoSecondarySubcategoryTwoLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfoTerritoryAgeRatingsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableAppInfoTerritoryAgeRatingsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>?), TypeInfoPropertyName = "NullableOneOfErrorSourcePointerErrorSourceParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<string, global::AppStoreConnect.ErrorLinksAssociated>?), TypeInfoPropertyName = "NullableOneOfStringErrorLinksAssociated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfo?), TypeInfoPropertyName = "NullableAppInfosGetInstanceFieldsAppInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsApp?), TypeInfoPropertyName = "NullableAppInfosGetInstanceFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAgeRatingDeclaration?), TypeInfoPropertyName = "NullableAppInfosGetInstanceFieldsAgeRatingDeclaration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfoLocalization?), TypeInfoPropertyName = "NullableAppInfosGetInstanceFieldsAppInfoLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppCategorie?), TypeInfoPropertyName = "NullableAppInfosGetInstanceFieldsAppCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableAppInfosGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration?), TypeInfoPropertyName = "NullableAppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization?), TypeInfoPropertyName = "NullableAppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo?), TypeInfoPropertyName = "NullableAppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableAppInfosAppInfoLocalizationsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosPrimaryCategoryGetToOneRelatedFieldsAppCategorie?), TypeInfoPropertyName = "NullableAppInfosPrimaryCategoryGetToOneRelatedFieldsAppCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosPrimaryCategoryGetToOneRelatedIncludeItem?), TypeInfoPropertyName = "NullableAppInfosPrimaryCategoryGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosPrimarySubcategoryOneGetToOneRelatedFieldsAppCategorie?), TypeInfoPropertyName = "NullableAppInfosPrimarySubcategoryOneGetToOneRelatedFieldsAppCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosPrimarySubcategoryOneGetToOneRelatedIncludeItem?), TypeInfoPropertyName = "NullableAppInfosPrimarySubcategoryOneGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosPrimarySubcategoryTwoGetToOneRelatedFieldsAppCategorie?), TypeInfoPropertyName = "NullableAppInfosPrimarySubcategoryTwoGetToOneRelatedFieldsAppCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosPrimarySubcategoryTwoGetToOneRelatedIncludeItem?), TypeInfoPropertyName = "NullableAppInfosPrimarySubcategoryTwoGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosSecondaryCategoryGetToOneRelatedFieldsAppCategorie?), TypeInfoPropertyName = "NullableAppInfosSecondaryCategoryGetToOneRelatedFieldsAppCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosSecondaryCategoryGetToOneRelatedIncludeItem?), TypeInfoPropertyName = "NullableAppInfosSecondaryCategoryGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosSecondarySubcategoryOneGetToOneRelatedFieldsAppCategorie?), TypeInfoPropertyName = "NullableAppInfosSecondarySubcategoryOneGetToOneRelatedFieldsAppCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosSecondarySubcategoryOneGetToOneRelatedIncludeItem?), TypeInfoPropertyName = "NullableAppInfosSecondarySubcategoryOneGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosSecondarySubcategoryTwoGetToOneRelatedFieldsAppCategorie?), TypeInfoPropertyName = "NullableAppInfosSecondarySubcategoryTwoGetToOneRelatedFieldsAppCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosSecondarySubcategoryTwoGetToOneRelatedIncludeItem?), TypeInfoPropertyName = "NullableAppInfosSecondarySubcategoryTwoGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritoryAgeRating?), TypeInfoPropertyName = "NullableAppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritoryAgeRating2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritorie?), TypeInfoPropertyName = "NullableAppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppInfosTerritoryAgeRatingsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableAppInfosTerritoryAgeRatingsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.Platform>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCategoryRelationshipsSubcategoriesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfoLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem23>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.Territory>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.TerritoryAgeRating>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfoAppInfoLocalizationsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfoTerritoryAgeRatingsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ErrorResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosGetInstanceFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosGetInstanceFieldsAgeRatingDeclaration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfoLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosGetInstanceFieldsAppCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosPrimaryCategoryGetToOneRelatedFieldsAppCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosPrimaryCategoryGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosPrimarySubcategoryOneGetToOneRelatedFieldsAppCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosPrimarySubcategoryOneGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosPrimarySubcategoryTwoGetToOneRelatedFieldsAppCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosPrimarySubcategoryTwoGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosSecondaryCategoryGetToOneRelatedFieldsAppCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosSecondaryCategoryGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosSecondarySubcategoryOneGetToOneRelatedFieldsAppCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosSecondarySubcategoryOneGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosSecondarySubcategoryTwoGetToOneRelatedFieldsAppCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosSecondarySubcategoryTwoGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritoryAgeRating>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosTerritoryAgeRatingsGetToManyRelatedIncludeItem>))]
    internal sealed partial class AppInfosSourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppInfosSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AppInfosSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AppInfosSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationType)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferences)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferences?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesContests)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesContests?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesGamblingSimulated)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesGamblingSimulated?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesGunsOrOtherWeapons)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesGunsOrOtherWeapons?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesMedicalOrTreatmentInformation)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesMedicalOrTreatmentInformation?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesProfanityOrCrudeHumor)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesProfanityOrCrudeHumor?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesSexualContentGraphicAndNudity)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesSexualContentGraphicAndNudity?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesSexualContentOrNudity)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesSexualContentOrNudity?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesHorrorOrFearThemes)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesHorrorOrFearThemes?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesMatureOrSuggestiveThemes)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesMatureOrSuggestiveThemes?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceCartoonOrFantasy)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceCartoonOrFantasy?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadistic)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadistic?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceRealistic)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceRealistic?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAgeRatingOverride)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAgeRatingOverride?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAgeRatingOverrideV2)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAgeRatingOverrideV2?)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesKoreaAgeRatingOverride)

                    || typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesKoreaAgeRatingOverride?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategoryType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategoryType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategoryRelationshipsSubcategoriesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategoryRelationshipsSubcategoriesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategoryRelationshipsParentDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCategoryRelationshipsParentDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoLocalizationType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoLocalizationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoLocalizationRelationshipsAppInfoDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoLocalizationRelationshipsAppInfoDataType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimaryCategoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimaryCategoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwoDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwoDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondaryCategoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondaryCategoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOneDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOneDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwoDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwoDataType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryType)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryType?)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryAgeRatingType)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryAgeRatingType?)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryAgeRatingRelationshipsTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryAgeRatingRelationshipsTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAgeRatingDeclarationLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAgeRatingDeclarationLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAppInfoLocalizationsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAppInfoLocalizationsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoPrimaryCategoryLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoPrimaryCategoryLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoPrimarySubcategoryOneLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoPrimarySubcategoryOneLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoPrimarySubcategoryTwoLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoPrimarySubcategoryTwoLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoSecondaryCategoryLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoSecondaryCategoryLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoSecondarySubcategoryOneLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoSecondarySubcategoryOneLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoSecondarySubcategoryTwoLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoSecondarySubcategoryTwoLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoTerritoryAgeRatingsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoTerritoryAgeRatingsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreAgeRating)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreAgeRating?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionState?)

                    || typeToConvert == typeof(global::AppStoreConnect.BrazilAgeRating)

                    || typeToConvert == typeof(global::AppStoreConnect.BrazilAgeRating?)

                    || typeToConvert == typeof(global::AppStoreConnect.KidsAgeBand)

                    || typeToConvert == typeof(global::AppStoreConnect.KidsAgeBand?)

                    || typeToConvert == typeof(global::AppStoreConnect.Platform)

                    || typeToConvert == typeof(global::AppStoreConnect.Platform?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfo)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfo?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAgeRatingDeclaration)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAgeRatingDeclaration?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfoLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfoLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppCategorie)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppCategorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosPrimaryCategoryGetToOneRelatedFieldsAppCategorie)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosPrimaryCategoryGetToOneRelatedFieldsAppCategorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosPrimaryCategoryGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosPrimaryCategoryGetToOneRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosPrimarySubcategoryOneGetToOneRelatedFieldsAppCategorie)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosPrimarySubcategoryOneGetToOneRelatedFieldsAppCategorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosPrimarySubcategoryOneGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosPrimarySubcategoryOneGetToOneRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosPrimarySubcategoryTwoGetToOneRelatedFieldsAppCategorie)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosPrimarySubcategoryTwoGetToOneRelatedFieldsAppCategorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosPrimarySubcategoryTwoGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosPrimarySubcategoryTwoGetToOneRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosSecondaryCategoryGetToOneRelatedFieldsAppCategorie)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosSecondaryCategoryGetToOneRelatedFieldsAppCategorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosSecondaryCategoryGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosSecondaryCategoryGetToOneRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosSecondarySubcategoryOneGetToOneRelatedFieldsAppCategorie)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosSecondarySubcategoryOneGetToOneRelatedFieldsAppCategorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosSecondarySubcategoryOneGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosSecondarySubcategoryOneGetToOneRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosSecondarySubcategoryTwoGetToOneRelatedFieldsAppCategorie)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosSecondarySubcategoryTwoGetToOneRelatedFieldsAppCategorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosSecondarySubcategoryTwoGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosSecondarySubcategoryTwoGetToOneRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritoryAgeRating)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritoryAgeRating?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritorie)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosTerritoryAgeRatingsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosTerritoryAgeRatingsGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationType))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferences))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferencesJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferences?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesAlcoholTobaccoOrDrugUseOrReferencesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesContests))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesContestsJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesContests?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesContestsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesGamblingSimulated))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesGamblingSimulatedJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesGamblingSimulated?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesGamblingSimulatedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesGunsOrOtherWeapons))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesGunsOrOtherWeaponsJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesGunsOrOtherWeapons?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesGunsOrOtherWeaponsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesMedicalOrTreatmentInformation))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesMedicalOrTreatmentInformationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesMedicalOrTreatmentInformation?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesMedicalOrTreatmentInformationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesProfanityOrCrudeHumor))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesProfanityOrCrudeHumorJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesProfanityOrCrudeHumor?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesProfanityOrCrudeHumorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesSexualContentGraphicAndNudity))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesSexualContentGraphicAndNudityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesSexualContentGraphicAndNudity?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesSexualContentGraphicAndNudityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesSexualContentOrNudity))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesSexualContentOrNudityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesSexualContentOrNudity?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesSexualContentOrNudityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesHorrorOrFearThemes))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesHorrorOrFearThemesJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesHorrorOrFearThemes?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesHorrorOrFearThemesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesMatureOrSuggestiveThemes))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesMatureOrSuggestiveThemesJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesMatureOrSuggestiveThemes?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesMatureOrSuggestiveThemesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceCartoonOrFantasy))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesViolenceCartoonOrFantasyJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceCartoonOrFantasy?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesViolenceCartoonOrFantasyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadistic))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadisticJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadistic?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesViolenceRealisticProlongedGraphicOrSadisticNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceRealistic))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesViolenceRealisticJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesViolenceRealistic?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesViolenceRealisticNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAgeRatingOverride))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesAgeRatingOverrideJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAgeRatingOverride?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesAgeRatingOverrideNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAgeRatingOverrideV2))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesAgeRatingOverrideV2JsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesAgeRatingOverrideV2?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesAgeRatingOverrideV2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesKoreaAgeRatingOverride))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesKoreaAgeRatingOverrideJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributesKoreaAgeRatingOverride?))
                {
                    return new global::AppStoreConnect.JsonConverters.AgeRatingDeclarationAttributesKoreaAgeRatingOverrideNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCategoryType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCategoryTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCategoryType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCategoryTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCategoryRelationshipsSubcategoriesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCategoryRelationshipsSubcategoriesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCategoryRelationshipsSubcategoriesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCategoryRelationshipsSubcategoriesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCategoryRelationshipsParentDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCategoryRelationshipsParentDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCategoryRelationshipsParentDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCategoryRelationshipsParentDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoLocalizationType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoLocalizationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoLocalizationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoLocalizationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoLocalizationRelationshipsAppInfoDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoLocalizationRelationshipsAppInfoDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoLocalizationRelationshipsAppInfoDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoLocalizationRelationshipsAppInfoDataTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoUpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimaryCategoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoUpdateRequestDataRelationshipsPrimaryCategoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimaryCategoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoUpdateRequestDataRelationshipsPrimaryCategoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwoDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwoDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwoDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwoDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondaryCategoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoUpdateRequestDataRelationshipsSecondaryCategoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondaryCategoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoUpdateRequestDataRelationshipsSecondaryCategoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOneDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOneDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOneDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOneDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwoDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwoDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwoDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwoDataTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryType))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryType?))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryAgeRatingType))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryAgeRatingTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryAgeRatingType?))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryAgeRatingTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryAgeRatingRelationshipsTerritoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryAgeRatingRelationshipsTerritoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryAgeRatingRelationshipsTerritoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryAgeRatingRelationshipsTerritoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAgeRatingDeclarationLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAgeRatingDeclarationLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAgeRatingDeclarationLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAgeRatingDeclarationLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAppInfoLocalizationsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAppInfoLocalizationsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAppInfoLocalizationsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAppInfoLocalizationsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoPrimaryCategoryLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoPrimaryCategoryLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoPrimaryCategoryLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoPrimaryCategoryLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoPrimarySubcategoryOneLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoPrimarySubcategoryOneLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoPrimarySubcategoryOneLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoPrimarySubcategoryOneLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoPrimarySubcategoryTwoLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoPrimarySubcategoryTwoLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoPrimarySubcategoryTwoLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoPrimarySubcategoryTwoLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoSecondaryCategoryLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoSecondaryCategoryLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoSecondaryCategoryLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoSecondaryCategoryLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoSecondarySubcategoryOneLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoSecondarySubcategoryOneLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoSecondarySubcategoryOneLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoSecondarySubcategoryOneLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoSecondarySubcategoryTwoLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoSecondarySubcategoryTwoLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoSecondarySubcategoryTwoLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoSecondarySubcategoryTwoLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoTerritoryAgeRatingsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoTerritoryAgeRatingsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoTerritoryAgeRatingsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoTerritoryAgeRatingsLinkagesResponseDataItemTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.BrazilAgeRating))
                {
                    return new global::AppStoreConnect.JsonConverters.BrazilAgeRatingJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BrazilAgeRating?))
                {
                    return new global::AppStoreConnect.JsonConverters.BrazilAgeRatingNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionStatusUrlVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionStatusUrlVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfo))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosGetInstanceFieldsAppInfoJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfo?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosGetInstanceFieldsAppInfoNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosGetInstanceFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosGetInstanceFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAgeRatingDeclaration))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosGetInstanceFieldsAgeRatingDeclarationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAgeRatingDeclaration?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosGetInstanceFieldsAgeRatingDeclarationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfoLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosGetInstanceFieldsAppInfoLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfoLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosGetInstanceFieldsAppInfoLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppCategorie))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosGetInstanceFieldsAppCategorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceFieldsAppCategorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosGetInstanceFieldsAppCategorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosGetInstanceIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclarationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclarationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosAppInfoLocalizationsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosAppInfoLocalizationsGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosPrimaryCategoryGetToOneRelatedFieldsAppCategorie))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosPrimaryCategoryGetToOneRelatedFieldsAppCategorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosPrimaryCategoryGetToOneRelatedFieldsAppCategorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosPrimaryCategoryGetToOneRelatedFieldsAppCategorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosPrimaryCategoryGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosPrimaryCategoryGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosPrimaryCategoryGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosPrimaryCategoryGetToOneRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosPrimarySubcategoryOneGetToOneRelatedFieldsAppCategorie))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosPrimarySubcategoryOneGetToOneRelatedFieldsAppCategorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosPrimarySubcategoryOneGetToOneRelatedFieldsAppCategorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosPrimarySubcategoryOneGetToOneRelatedFieldsAppCategorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosPrimarySubcategoryOneGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosPrimarySubcategoryOneGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosPrimarySubcategoryOneGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosPrimarySubcategoryOneGetToOneRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosPrimarySubcategoryTwoGetToOneRelatedFieldsAppCategorie))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosPrimarySubcategoryTwoGetToOneRelatedFieldsAppCategorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosPrimarySubcategoryTwoGetToOneRelatedFieldsAppCategorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosPrimarySubcategoryTwoGetToOneRelatedFieldsAppCategorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosPrimarySubcategoryTwoGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosPrimarySubcategoryTwoGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosPrimarySubcategoryTwoGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosPrimarySubcategoryTwoGetToOneRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosSecondaryCategoryGetToOneRelatedFieldsAppCategorie))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosSecondaryCategoryGetToOneRelatedFieldsAppCategorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosSecondaryCategoryGetToOneRelatedFieldsAppCategorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosSecondaryCategoryGetToOneRelatedFieldsAppCategorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosSecondaryCategoryGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosSecondaryCategoryGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosSecondaryCategoryGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosSecondaryCategoryGetToOneRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosSecondarySubcategoryOneGetToOneRelatedFieldsAppCategorie))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosSecondarySubcategoryOneGetToOneRelatedFieldsAppCategorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosSecondarySubcategoryOneGetToOneRelatedFieldsAppCategorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosSecondarySubcategoryOneGetToOneRelatedFieldsAppCategorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosSecondarySubcategoryOneGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosSecondarySubcategoryOneGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosSecondarySubcategoryOneGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosSecondarySubcategoryOneGetToOneRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosSecondarySubcategoryTwoGetToOneRelatedFieldsAppCategorie))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosSecondarySubcategoryTwoGetToOneRelatedFieldsAppCategorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosSecondarySubcategoryTwoGetToOneRelatedFieldsAppCategorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosSecondarySubcategoryTwoGetToOneRelatedFieldsAppCategorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosSecondarySubcategoryTwoGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosSecondarySubcategoryTwoGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosSecondarySubcategoryTwoGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosSecondarySubcategoryTwoGetToOneRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritoryAgeRating))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritoryAgeRatingJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritoryAgeRating?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritoryAgeRatingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritorie))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosTerritoryAgeRatingsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosTerritoryAgeRatingsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosTerritoryAgeRatingsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosTerritoryAgeRatingsGetToManyRelatedIncludeItemNullableJsonConverter();
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
                    0 => new AppInfosSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new AppInfosSourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}