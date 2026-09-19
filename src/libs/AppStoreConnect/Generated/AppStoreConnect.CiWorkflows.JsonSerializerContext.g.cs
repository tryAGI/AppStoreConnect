
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem44), TypeInfoPropertyName = "IncludedItem442")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterAppVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.RoutingAppCoverage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem45), TypeInfoPropertyName = "IncludedItem452")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem71>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem71), TypeInfoPropertyName = "IncludedItem712")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "CiWorkflowResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowCreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataType), TypeInfoPropertyName = "CiWorkflowCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsProduct))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsProductData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsProductDataType), TypeInfoPropertyName = "CiWorkflowCreateRequestDataRelationshipsProductDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsRepository))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsRepositoryData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsRepositoryDataType), TypeInfoPropertyName = "CiWorkflowCreateRequestDataRelationshipsRepositoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsXcodeVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsXcodeVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsXcodeVersionDataType), TypeInfoPropertyName = "CiWorkflowCreateRequestDataRelationshipsXcodeVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsMacOsVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsMacOsVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsMacOsVersionDataType), TypeInfoPropertyName = "CiWorkflowCreateRequestDataRelationshipsMacOsVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowUpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataType), TypeInfoPropertyName = "CiWorkflowUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsXcodeVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsXcodeVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsXcodeVersionDataType), TypeInfoPropertyName = "CiWorkflowUpdateRequestDataRelationshipsXcodeVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsMacOsVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsMacOsVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsMacOsVersionDataType), TypeInfoPropertyName = "CiWorkflowUpdateRequestDataRelationshipsMacOsVersionDataType2")]
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
    internal sealed partial class CiWorkflowsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem158), TypeInfoPropertyName = "IncludedItem1582")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmRepositoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem159>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem159), TypeInfoPropertyName = "IncludedItem1592")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmRepositoryResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmRepositoryResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "ScmRepositoryResponseIncludedItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowBuildRunsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowBuildRunsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowBuildRunsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowBuildRunsLinkagesResponseDataItemType), TypeInfoPropertyName = "CiWorkflowBuildRunsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowRepositoryLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowRepositoryLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowRepositoryLinkageResponseDataType), TypeInfoPropertyName = "CiWorkflowRepositoryLinkageResponseDataType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiWorkflow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiWorkflow), TypeInfoPropertyName = "CiWorkflowsGetInstanceFieldsCiWorkflow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiProduct), TypeInfoPropertyName = "CiWorkflowsGetInstanceFieldsCiProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsGetInstanceFieldsScmRepositorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsScmRepositorie), TypeInfoPropertyName = "CiWorkflowsGetInstanceFieldsScmRepositorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiXcodeVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiXcodeVersion), TypeInfoPropertyName = "CiWorkflowsGetInstanceFieldsCiXcodeVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiMacOsVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiMacOsVersion), TypeInfoPropertyName = "CiWorkflowsGetInstanceFieldsCiMacOsVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsGetInstanceIncludeItem), TypeInfoPropertyName = "CiWorkflowsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedSortItem), TypeInfoPropertyName = "CiWorkflowsBuildRunsGetToManyRelatedSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun), TypeInfoPropertyName = "CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild), TypeInfoPropertyName = "CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow), TypeInfoPropertyName = "CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct), TypeInfoPropertyName = "CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference), TypeInfoPropertyName = "CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest), TypeInfoPropertyName = "CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "CiWorkflowsBuildRunsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorie), TypeInfoPropertyName = "CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsRepositoryGetToOneRelatedFieldsScmProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsRepositoryGetToOneRelatedFieldsScmProvider), TypeInfoPropertyName = "CiWorkflowsRepositoryGetToOneRelatedFieldsScmProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsRepositoryGetToOneRelatedFieldsScmGitReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsRepositoryGetToOneRelatedFieldsScmGitReference), TypeInfoPropertyName = "CiWorkflowsRepositoryGetToOneRelatedFieldsScmGitReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsRepositoryGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsRepositoryGetToOneRelatedIncludeItem), TypeInfoPropertyName = "CiWorkflowsRepositoryGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem?), TypeInfoPropertyName = "NullableIncludedItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem2?), TypeInfoPropertyName = "NullableIncludedItem22_3")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem44?), TypeInfoPropertyName = "NullableIncludedItem442")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem45?), TypeInfoPropertyName = "NullableIncludedItem452")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem69?), TypeInfoPropertyName = "NullableIncludedItem692")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowType?), TypeInfoPropertyName = "NullableCiWorkflowType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowRelationshipsProductDataType?), TypeInfoPropertyName = "NullableCiWorkflowRelationshipsProductDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowRelationshipsRepositoryDataType?), TypeInfoPropertyName = "NullableCiWorkflowRelationshipsRepositoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowRelationshipsXcodeVersionDataType?), TypeInfoPropertyName = "NullableCiWorkflowRelationshipsXcodeVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowRelationshipsMacOsVersionDataType?), TypeInfoPropertyName = "NullableCiWorkflowRelationshipsMacOsVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem70?), TypeInfoPropertyName = "NullableIncludedItem702")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem71?), TypeInfoPropertyName = "NullableIncludedItem712")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableCiWorkflowResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataType?), TypeInfoPropertyName = "NullableCiWorkflowCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsProductDataType?), TypeInfoPropertyName = "NullableCiWorkflowCreateRequestDataRelationshipsProductDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsRepositoryDataType?), TypeInfoPropertyName = "NullableCiWorkflowCreateRequestDataRelationshipsRepositoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsXcodeVersionDataType?), TypeInfoPropertyName = "NullableCiWorkflowCreateRequestDataRelationshipsXcodeVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsMacOsVersionDataType?), TypeInfoPropertyName = "NullableCiWorkflowCreateRequestDataRelationshipsMacOsVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataType?), TypeInfoPropertyName = "NullableCiWorkflowUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsXcodeVersionDataType?), TypeInfoPropertyName = "NullableCiWorkflowUpdateRequestDataRelationshipsXcodeVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsMacOsVersionDataType?), TypeInfoPropertyName = "NullableCiWorkflowUpdateRequestDataRelationshipsMacOsVersionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiXcodeVersionType?), TypeInfoPropertyName = "NullableCiXcodeVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiTestDestinationKind?), TypeInfoPropertyName = "NullableCiTestDestinationKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersionsDataItemType?), TypeInfoPropertyName = "NullableCiXcodeVersionRelationshipsMacOsVersionsDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem159?), TypeInfoPropertyName = "NullableIncludedItem1592")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmRepositoryResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableScmRepositoryResponseIncludedItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowBuildRunsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableCiWorkflowBuildRunsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowRepositoryLinkageResponseDataType?), TypeInfoPropertyName = "NullableCiWorkflowRepositoryLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>?), TypeInfoPropertyName = "NullableOneOfErrorSourcePointerErrorSourceParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<string, global::AppStoreConnect.ErrorLinksAssociated>?), TypeInfoPropertyName = "NullableOneOfStringErrorLinksAssociated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiActionDestination?), TypeInfoPropertyName = "NullableCiActionDestination2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiActionTestConfigurationKind?), TypeInfoPropertyName = "NullableCiActionTestConfigurationKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiActionPlatform?), TypeInfoPropertyName = "NullableCiActionPlatform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiFilesAndFoldersRuleMode?), TypeInfoPropertyName = "NullableCiFilesAndFoldersRuleMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleFrequency?), TypeInfoPropertyName = "NullableCiScheduledStartConditionScheduleFrequency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleDay?), TypeInfoPropertyName = "NullableCiScheduledStartConditionScheduleDay2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ScmProviderTypeKind?), TypeInfoPropertyName = "NullableScmProviderTypeKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiWorkflow?), TypeInfoPropertyName = "NullableCiWorkflowsGetInstanceFieldsCiWorkflow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiProduct?), TypeInfoPropertyName = "NullableCiWorkflowsGetInstanceFieldsCiProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsScmRepositorie?), TypeInfoPropertyName = "NullableCiWorkflowsGetInstanceFieldsScmRepositorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiXcodeVersion?), TypeInfoPropertyName = "NullableCiWorkflowsGetInstanceFieldsCiXcodeVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiMacOsVersion?), TypeInfoPropertyName = "NullableCiWorkflowsGetInstanceFieldsCiMacOsVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableCiWorkflowsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedSortItem?), TypeInfoPropertyName = "NullableCiWorkflowsBuildRunsGetToManyRelatedSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun?), TypeInfoPropertyName = "NullableCiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild?), TypeInfoPropertyName = "NullableCiWorkflowsBuildRunsGetToManyRelatedFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow?), TypeInfoPropertyName = "NullableCiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct?), TypeInfoPropertyName = "NullableCiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference?), TypeInfoPropertyName = "NullableCiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest?), TypeInfoPropertyName = "NullableCiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableCiWorkflowsBuildRunsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorie?), TypeInfoPropertyName = "NullableCiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsRepositoryGetToOneRelatedFieldsScmProvider?), TypeInfoPropertyName = "NullableCiWorkflowsRepositoryGetToOneRelatedFieldsScmProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsRepositoryGetToOneRelatedFieldsScmGitReference?), TypeInfoPropertyName = "NullableCiWorkflowsRepositoryGetToOneRelatedFieldsScmGitReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiWorkflowsRepositoryGetToOneRelatedIncludeItem?), TypeInfoPropertyName = "NullableCiWorkflowsRepositoryGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsIconsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunRelationshipsBuildsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem66>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductRelationshipsPrimaryRepositoriesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem71>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiXcodeVersionAttributesTestDestination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiXcodeVersionAttributesTestDestinationAvailableRuntime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersionsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem159>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowBuildRunsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ErrorResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiTestDestination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBranchPatternsPattern>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiStartConditionFileMatcher>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiScheduledStartConditionScheduleDay>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiTagPatternsPattern>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiWorkflow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowsGetInstanceFieldsScmRepositorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiXcodeVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiMacOsVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowsRepositoryGetToOneRelatedFieldsScmProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowsRepositoryGetToOneRelatedFieldsScmGitReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiWorkflowsRepositoryGetToOneRelatedIncludeItem>))]
    internal sealed partial class CiWorkflowsSourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CiWorkflowsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static CiWorkflowsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private CiWorkflowsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.BuildType)

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

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsProductDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsProductDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsRepositoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsRepositoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsXcodeVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsXcodeVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsMacOsVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsMacOsVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsXcodeVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsXcodeVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsMacOsVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsMacOsVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiXcodeVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiXcodeVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiXcodeVersionRelationshipsMacOsVersionsDataItemType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowBuildRunsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowBuildRunsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRepositoryLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRepositoryLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.ScmProviderTypeKind)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmProviderTypeKind?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiWorkflow)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiWorkflow?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiProduct)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiProduct?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsScmRepositorie)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsScmRepositorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiXcodeVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiXcodeVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiMacOsVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiMacOsVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorie)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsRepositoryGetToOneRelatedFieldsScmProvider)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsRepositoryGetToOneRelatedFieldsScmProvider?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsRepositoryGetToOneRelatedFieldsScmGitReference)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsRepositoryGetToOneRelatedFieldsScmGitReference?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsRepositoryGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsRepositoryGetToOneRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsProductDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowCreateRequestDataRelationshipsProductDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsProductDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowCreateRequestDataRelationshipsProductDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsRepositoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowCreateRequestDataRelationshipsRepositoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsRepositoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowCreateRequestDataRelationshipsRepositoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsXcodeVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowCreateRequestDataRelationshipsXcodeVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsXcodeVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowCreateRequestDataRelationshipsXcodeVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsMacOsVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowCreateRequestDataRelationshipsMacOsVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowCreateRequestDataRelationshipsMacOsVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowCreateRequestDataRelationshipsMacOsVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowUpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsXcodeVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowUpdateRequestDataRelationshipsXcodeVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsXcodeVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowUpdateRequestDataRelationshipsXcodeVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsMacOsVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowUpdateRequestDataRelationshipsMacOsVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsMacOsVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowUpdateRequestDataRelationshipsMacOsVersionDataTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmRepositoryResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmRepositoryResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmRepositoryResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowBuildRunsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowBuildRunsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowBuildRunsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowBuildRunsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRepositoryLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowRepositoryLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowRepositoryLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowRepositoryLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAudienceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAudienceTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.ScmProviderTypeKind))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmProviderTypeKindJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmProviderTypeKind?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmProviderTypeKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiWorkflow))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsGetInstanceFieldsCiWorkflowJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiWorkflow?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsGetInstanceFieldsCiWorkflowNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiProduct))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsGetInstanceFieldsCiProductJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiProduct?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsGetInstanceFieldsCiProductNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsScmRepositorie))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsGetInstanceFieldsScmRepositorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsScmRepositorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsGetInstanceFieldsScmRepositorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiXcodeVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsGetInstanceFieldsCiXcodeVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiXcodeVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsGetInstanceFieldsCiXcodeVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiMacOsVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsGetInstanceFieldsCiMacOsVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiMacOsVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsGetInstanceFieldsCiMacOsVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsGetInstanceIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsBuildRunsGetToManyRelatedSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsBuildRunsGetToManyRelatedSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRunJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRunNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsBuildRunsGetToManyRelatedFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsBuildRunsGetToManyRelatedFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflowJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflowNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProductJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProductNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReferenceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReferenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequestJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequestNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsBuildRunsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsBuildRunsGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorie))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsRepositoryGetToOneRelatedFieldsScmRepositorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsRepositoryGetToOneRelatedFieldsScmProvider))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsRepositoryGetToOneRelatedFieldsScmProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsRepositoryGetToOneRelatedFieldsScmProvider?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsRepositoryGetToOneRelatedFieldsScmProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsRepositoryGetToOneRelatedFieldsScmGitReference))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsRepositoryGetToOneRelatedFieldsScmGitReferenceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsRepositoryGetToOneRelatedFieldsScmGitReference?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsRepositoryGetToOneRelatedFieldsScmGitReferenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsRepositoryGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsRepositoryGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowsRepositoryGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowsRepositoryGetToOneRelatedIncludeItemNullableJsonConverter();
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
                    0 => new CiWorkflowsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new CiWorkflowsSourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}